#nullable enable

namespace Strava
{
    public partial interface ISegmentsClient
    {
        /// <summary>
        /// Star Segment<br/>
        /// Stars/Unstars the given segment for the authenticated athlete. Requires profile:write scope.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.DetailedSegment> StarSegmentAsync(
            long id,

            global::Strava.StarSegmentRequest request,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Star Segment<br/>
        /// Stars/Unstars the given segment for the authenticated athlete. Requires profile:write scope.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.AutoSDKHttpResponse<global::Strava.DetailedSegment>> StarSegmentAsResponseAsync(
            long id,

            global::Strava.StarSegmentRequest request,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Star Segment<br/>
        /// Stars/Unstars the given segment for the authenticated athlete. Requires profile:write scope.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="starred">
        /// If true, star the segment; if false, unstar the segment.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.DetailedSegment> StarSegmentAsync(
            long id,
            bool starred,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}