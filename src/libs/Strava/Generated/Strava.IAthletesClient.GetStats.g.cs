#nullable enable

namespace Strava
{
    public partial interface IAthletesClient
    {
        /// <summary>
        /// Get Athlete Stats<br/>
        /// Returns the activity stats of an athlete. Only includes data from activities set to Everyone visibilty.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.ActivityStats> GetStatsAsync(
            long id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}