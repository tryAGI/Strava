#nullable enable

namespace Strava
{
    public partial interface IUploadsClient
    {
        /// <summary>
        /// Upload Activity<br/>
        /// Uploads a new data file to create an activity from. Requires activity:write scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.Upload> CreateUploadAsync(

            global::Strava.CreateUploadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Activity<br/>
        /// Uploads a new data file to create an activity from. Requires activity:write scope.
        /// </summary>
        /// <param name="file">
        /// The uploaded file.
        /// </param>
        /// <param name="filename">
        /// The uploaded file.
        /// </param>
        /// <param name="name">
        /// The desired name of the resulting activity.
        /// </param>
        /// <param name="description">
        /// The desired description of the resulting activity.
        /// </param>
        /// <param name="trainer">
        /// Whether the resulting activity should be marked as having been performed on a trainer.
        /// </param>
        /// <param name="commute">
        /// Whether the resulting activity should be tagged as a commute.
        /// </param>
        /// <param name="dataType">
        /// The format of the uploaded file.
        /// </param>
        /// <param name="externalId">
        /// The desired external identifier of the resulting activity.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.Upload> CreateUploadAsync(
            byte[]? file = default,
            string? filename = default,
            string? name = default,
            string? description = default,
            string? trainer = default,
            string? commute = default,
            global::Strava.CreateUploadRequestDataType? dataType = default,
            string? externalId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}