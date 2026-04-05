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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.Upload> GetUploadByIdAsync(
            long uploadId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}