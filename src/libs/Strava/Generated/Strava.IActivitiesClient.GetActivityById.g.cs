#nullable enable

namespace Strava
{
    public partial interface IActivitiesClient
    {
        /// <summary>
        /// Get Activity<br/>
        /// Returns the given activity that is owned by the authenticated athlete. Requires activity:read for Everyone and Followers activities. Requires activity:read_all for Only Me activities.<br/>
        /// We strongly encourage you to display the appropriate attribution that identifies Garmin as the data source and the device name in your application. Please see example below from VeloViewer (that provides an attribution for a Garmin Forerunner device).<br/>
        /// ![Attribution](/images/device-attribution-image.png)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="includeAllEfforts"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.DetailedActivity> GetActivityByIdAsync(
            long id,
            bool? includeAllEfforts = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}