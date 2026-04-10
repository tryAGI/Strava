#nullable enable

namespace Strava
{
    public partial interface IActivitiesClient
    {
        /// <summary>
        /// List Activity Kudoers<br/>
        /// Returns the athletes who kudoed an activity identified by an identifier. Requires activity:read for Everyone and Followers activities. Requires activity:read_all for Only Me activities.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Strava.SummaryAthlete>> GetKudoersByActivityIdAsync(
            long id,
            int? page = default,
            int? perPage = default,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}