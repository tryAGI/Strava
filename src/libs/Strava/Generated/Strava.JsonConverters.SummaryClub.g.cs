#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Strava.JsonConverters
{
    /// <inheritdoc />
    public class SummaryClubJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Strava.SummaryClub>
    {
        /// <inheritdoc />
        public override global::Strava.SummaryClub Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("resource_state")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("activity_types")) __score1++;
            if (__jsonProps.Contains("city")) __score1++;
            if (__jsonProps.Contains("country")) __score1++;
            if (__jsonProps.Contains("cover_photo")) __score1++;
            if (__jsonProps.Contains("cover_photo_small")) __score1++;
            if (__jsonProps.Contains("featured")) __score1++;
            if (__jsonProps.Contains("member_count")) __score1++;
            if (__jsonProps.Contains("private")) __score1++;
            if (__jsonProps.Contains("profile_medium")) __score1++;
            if (__jsonProps.Contains("sport_type")) __score1++;
            if (__jsonProps.Contains("state")) __score1++;
            if (__jsonProps.Contains("url")) __score1++;
            if (__jsonProps.Contains("verified")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Strava.MetaClub? meta = default;
            global::Strava.SummaryClubVariant2? summaryClubVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.MetaClub), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.MetaClub> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.MetaClub).Name}");
                        meta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummaryClubVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummaryClubVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummaryClubVariant2).Name}");
                        summaryClubVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (meta == null && summaryClubVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.MetaClub), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.MetaClub> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.MetaClub).Name}");
                    meta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummaryClubVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummaryClubVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummaryClubVariant2).Name}");
                    summaryClubVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Strava.SummaryClub(
                meta,

                summaryClubVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Strava.SummaryClub value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMeta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.MetaClub), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.MetaClub?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.MetaClub).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Meta!, typeInfo);
            }
            else if (value.IsSummaryClubVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummaryClubVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummaryClubVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummaryClubVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SummaryClubVariant2!, typeInfo);
            }
        }
    }
}