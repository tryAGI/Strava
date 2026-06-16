install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated
fetch_spec -o openapi.yaml https://developers.strava.com/swagger/swagger.json

# Strava spec uses external $ref to separate JSON files.
# Bundle all external references into a single spec.
python3 << 'PYEOF'
import json, urllib.request, sys

with open('openapi.yaml') as f:
    spec = json.load(f)

fragment_urls = [
    'https://developers.strava.com/swagger/activity.json',
    'https://developers.strava.com/swagger/activity_stats.json',
    'https://developers.strava.com/swagger/activity_total.json',
    'https://developers.strava.com/swagger/activity_type.json',
    'https://developers.strava.com/swagger/athlete.json',
    'https://developers.strava.com/swagger/club.json',
    'https://developers.strava.com/swagger/comment.json',
    'https://developers.strava.com/swagger/fault.json',
    'https://developers.strava.com/swagger/gear.json',
    'https://developers.strava.com/swagger/lap.json',
    'https://developers.strava.com/swagger/latlng.json',
    'https://developers.strava.com/swagger/map.json',
    'https://developers.strava.com/swagger/photo.json',
    'https://developers.strava.com/swagger/route.json',
    'https://developers.strava.com/swagger/segment.json',
    'https://developers.strava.com/swagger/segment_effort.json',
    'https://developers.strava.com/swagger/split.json',
    'https://developers.strava.com/swagger/sport_type.json',
    'https://developers.strava.com/swagger/stream.json',
    'https://developers.strava.com/swagger/upload.json',
    'https://developers.strava.com/swagger/waypoint.json',
    'https://developers.strava.com/swagger/zones.json',
]

defs = {}
for url in fragment_urls:
    req = urllib.request.Request(url, headers={'User-Agent': 'Mozilla/5.0'})
    with urllib.request.urlopen(req) as resp:
        data = json.loads(resp.read())
        for key, value in data.items():
            if isinstance(value, dict) and not key.startswith(('swagger', 'info')):
                defs[key] = value

spec['definitions'] = defs

def rewrite_refs(obj):
    if isinstance(obj, dict):
        if '$ref' in obj:
            ref = obj['$ref']
            if ref.startswith('https://'):
                obj['$ref'] = '#/definitions/' + (ref.split('#/')[-1] if '#/' in ref else ref.split('#')[-1])
        for v in obj.values():
            rewrite_refs(v)
    elif isinstance(obj, list):
        for item in obj:
            rewrite_refs(item)

rewrite_refs(spec)

with open('openapi.yaml', 'w') as f:
    json.dump(spec, f, indent=2)
print(f'Bundled {len(defs)} definitions')
PYEOF

autosdk generate openapi.yaml \
  --namespace Strava \
  --clientClassName StravaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
