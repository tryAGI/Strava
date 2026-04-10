#nullable enable

namespace Strava
{
    public partial interface IStreamsClient
    {
        /// <summary>
        /// Get Segment Streams<br/>
        /// Returns the given segment's streams. Requires read_all scope for private segments.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="keys"></param>
        /// <param name="keyByType">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.StreamSet> GetSegmentStreamsAsync(
            long id,
            global::System.Collections.Generic.IList<global::Strava.GetSegmentStreamsKey> keys,
            bool keyByType,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}