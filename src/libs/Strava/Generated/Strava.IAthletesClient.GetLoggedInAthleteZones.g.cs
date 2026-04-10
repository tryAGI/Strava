#nullable enable

namespace Strava
{
    public partial interface IAthletesClient
    {
        /// <summary>
        /// Get Zones<br/>
        /// Returns the the authenticated athlete's heart rate and power zones. Requires profile:read_all.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.Zones> GetLoggedInAthleteZonesAsync(
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}