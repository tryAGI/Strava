#nullable enable

namespace Strava
{
    public partial interface ISegmentsClient
    {
        /// <summary>
        /// List Starred Segments<br/>
        /// List of the authenticated athlete's starred segments. Private segments are filtered out unless requested by a token with read_all scope.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Strava.SummarySegment>> GetLoggedInAthleteStarredSegmentsAsync(
            int? page = default,
            int? perPage = default,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}