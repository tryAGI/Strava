#nullable enable

namespace Strava
{
    public partial interface ISegmentEffortsClient
    {
        /// <summary>
        /// List Segment Efforts<br/>
        /// Returns a set of the authenticated athlete's segment efforts for a given segment.  Requires subscription.
        /// </summary>
        /// <param name="segmentId"></param>
        /// <param name="startDateLocal"></param>
        /// <param name="endDateLocal"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Strava.DetailedSegmentEffort>> GetEffortsBySegmentIdAsync(
            int segmentId,
            global::System.DateTime? startDateLocal = default,
            global::System.DateTime? endDateLocal = default,
            int? perPage = default,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Segment Efforts<br/>
        /// Returns a set of the authenticated athlete's segment efforts for a given segment.  Requires subscription.
        /// </summary>
        /// <param name="segmentId"></param>
        /// <param name="startDateLocal"></param>
        /// <param name="endDateLocal"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Strava.DetailedSegmentEffort>>> GetEffortsBySegmentIdAsResponseAsync(
            int segmentId,
            global::System.DateTime? startDateLocal = default,
            global::System.DateTime? endDateLocal = default,
            int? perPage = default,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}