#nullable enable

namespace Strava
{
    public partial interface IAthletesClient
    {
        /// <summary>
        /// Get Authenticated Athlete<br/>
        /// Returns the currently authenticated athlete. Tokens with profile:read_all scope will receive a detailed athlete representation; all others will receive a summary representation.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.DetailedAthlete> GetLoggedInAthleteAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}