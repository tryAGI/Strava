#nullable enable

namespace Strava
{
    public partial interface IAthletesClient
    {
        /// <summary>
        /// Get Zones<br/>
        /// Returns the the authenticated athlete's heart rate and power zones. Requires profile:read_all.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.Zones> GetLoggedInAthleteZonesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}