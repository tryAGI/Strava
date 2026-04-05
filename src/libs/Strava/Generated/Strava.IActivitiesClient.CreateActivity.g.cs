#nullable enable

namespace Strava
{
    public partial interface IActivitiesClient
    {
        /// <summary>
        /// Create an Activity<br/>
        /// Creates a manual activity for an athlete, requires activity:write scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.DetailedActivity> CreateActivityAsync(

            global::Strava.CreateActivityRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Activity<br/>
        /// Creates a manual activity for an athlete, requires activity:write scope.
        /// </summary>
        /// <param name="name">
        /// The name of the activity.
        /// </param>
        /// <param name="type">
        /// Type of activity. For example - Run, Ride etc.
        /// </param>
        /// <param name="sportType">
        /// Sport type of activity. For example - Run, MountainBikeRide, Ride, etc.
        /// </param>
        /// <param name="startDateLocal">
        /// ISO 8601 formatted date time.
        /// </param>
        /// <param name="elapsedTime">
        /// In seconds.
        /// </param>
        /// <param name="description">
        /// Description of the activity.
        /// </param>
        /// <param name="distance">
        /// In meters.
        /// </param>
        /// <param name="trainer">
        /// Set to 1 to mark as a trainer activity.
        /// </param>
        /// <param name="commute">
        /// Set to 1 to mark as commute.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.DetailedActivity> CreateActivityAsync(
            string name,
            string sportType,
            global::System.DateTime startDateLocal,
            int elapsedTime,
            string? type = default,
            string? description = default,
            float? distance = default,
            int? trainer = default,
            int? commute = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}