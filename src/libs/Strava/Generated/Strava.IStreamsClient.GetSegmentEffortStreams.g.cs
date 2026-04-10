#nullable enable

namespace Strava
{
    public partial interface IStreamsClient
    {
        /// <summary>
        /// Get Segment Effort Streams<br/>
        /// Returns a set of streams for a segment effort completed by the authenticated athlete. Requires read_all scope.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="keys"></param>
        /// <param name="keyByType">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.StreamSet> GetSegmentEffortStreamsAsync(
            long id,
            global::System.Collections.Generic.IList<global::Strava.GetSegmentEffortStreamsKey> keys,
            bool keyByType,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}