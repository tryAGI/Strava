#nullable enable

namespace Strava
{
    public partial interface IUploadsClient
    {
        /// <summary>
        /// Get Upload<br/>
        /// Returns an upload for a given identifier. Requires activity:write scope.
        /// </summary>
        /// <param name="uploadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.Upload> GetUploadByIdAsync(
            long uploadId,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Upload<br/>
        /// Returns an upload for a given identifier. Requires activity:write scope.
        /// </summary>
        /// <param name="uploadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.AutoSDKHttpResponse<global::Strava.Upload>> GetUploadByIdAsResponseAsync(
            long uploadId,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}