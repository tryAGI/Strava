#nullable enable

namespace Strava
{
    public partial interface ISegmentEffortsClient
    {
        /// <summary>
        /// Get Segment Effort<br/>
        /// Returns a segment effort from an activity that is owned by the authenticated athlete. Requires subscription.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.DetailedSegmentEffort> GetSegmentEffortByIdAsync(
            long id,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}