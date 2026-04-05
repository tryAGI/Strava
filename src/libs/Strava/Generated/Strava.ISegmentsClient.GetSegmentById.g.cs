#nullable enable

namespace Strava
{
    public partial interface ISegmentsClient
    {
        /// <summary>
        /// Get Segment<br/>
        /// Returns the specified segment. read_all scope required in order to retrieve athlete-specific segment information, or to retrieve private segments.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.DetailedSegment> GetSegmentByIdAsync(
            long id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}