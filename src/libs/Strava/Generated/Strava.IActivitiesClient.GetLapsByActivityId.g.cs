#nullable enable

namespace Strava
{
    public partial interface IActivitiesClient
    {
        /// <summary>
        /// List Activity Laps<br/>
        /// Returns the laps of an activity identified by an identifier. Requires activity:read for Everyone and Followers activities. Requires activity:read_all for Only Me activities.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Strava.Lap>> GetLapsByActivityIdAsync(
            long id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}