#nullable enable

namespace Strava
{
    public partial interface IActivitiesClient
    {
        /// <summary>
        /// List Athlete Activities<br/>
        /// Returns the activities of an athlete for a specific identifier. Requires activity:read. Only Me activities will be filtered out unless requested by a token with activity:read_all.
        /// </summary>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="page"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Strava.SummaryActivity>> GetLoggedInAthleteActivitiesAsync(
            int? before = default,
            int? after = default,
            int? page = default,
            int? perPage = default,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}