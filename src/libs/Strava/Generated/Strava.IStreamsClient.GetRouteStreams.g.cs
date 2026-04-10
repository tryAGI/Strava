#nullable enable

namespace Strava
{
    public partial interface IStreamsClient
    {
        /// <summary>
        /// Get Route Streams<br/>
        /// Returns the given route's streams. Requires read_all scope for private routes.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.StreamSet> GetRouteStreamsAsync(
            long id,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}