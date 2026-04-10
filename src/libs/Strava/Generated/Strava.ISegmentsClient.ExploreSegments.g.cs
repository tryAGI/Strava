#nullable enable

namespace Strava
{
    public partial interface ISegmentsClient
    {
        /// <summary>
        /// Explore segments<br/>
        /// Returns the top 10 segments matching a specified query.
        /// </summary>
        /// <param name="bounds"></param>
        /// <param name="activityType"></param>
        /// <param name="minCat"></param>
        /// <param name="maxCat"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.ExplorerResponse> ExploreSegmentsAsync(
            global::System.Collections.Generic.IList<float> bounds,
            global::Strava.ExploreSegmentsActivityType? activityType = default,
            int? minCat = default,
            int? maxCat = default,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}