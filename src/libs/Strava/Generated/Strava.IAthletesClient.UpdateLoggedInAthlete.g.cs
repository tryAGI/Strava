#nullable enable

namespace Strava
{
    public partial interface IAthletesClient
    {
        /// <summary>
        /// Update Athlete<br/>
        /// Update the currently authenticated athlete. Requires profile:write scope.
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.DetailedAthlete> UpdateLoggedInAthleteAsync(
            float weight,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}