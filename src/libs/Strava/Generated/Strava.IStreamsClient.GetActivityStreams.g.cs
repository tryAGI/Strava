#nullable enable

namespace Strava
{
    public partial interface IStreamsClient
    {
        /// <summary>
        /// Get Activity Streams<br/>
        /// Returns the given activity's streams. Requires activity:read scope. Requires activity:read_all scope for Only Me activities.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="keys"></param>
        /// <param name="keyByType">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.StreamSet> GetActivityStreamsAsync(
            long id,
            global::System.Collections.Generic.IList<global::Strava.GetActivityStreamsKey> keys,
            bool keyByType,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Activity Streams<br/>
        /// Returns the given activity's streams. Requires activity:read scope. Requires activity:read_all scope for Only Me activities.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="keys"></param>
        /// <param name="keyByType">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.AutoSDKHttpResponse<global::Strava.StreamSet>> GetActivityStreamsAsResponseAsync(
            long id,
            global::System.Collections.Generic.IList<global::Strava.GetActivityStreamsKey> keys,
            bool keyByType,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}