#nullable enable

namespace Strava
{
    public partial interface IActivitiesClient
    {
        /// <summary>
        /// Update Activity<br/>
        /// Updates the given activity that is owned by the authenticated athlete. Requires activity:write. Also requires activity:read_all in order to update Only Me activities
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.DetailedActivity> UpdateActivityByIdAsync(
            long id,

            global::Strava.UpdatableActivity request,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Activity<br/>
        /// Updates the given activity that is owned by the authenticated athlete. Requires activity:write. Also requires activity:read_all in order to update Only Me activities
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.AutoSDKHttpResponse<global::Strava.DetailedActivity>> UpdateActivityByIdAsResponseAsync(
            long id,

            global::Strava.UpdatableActivity request,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Activity<br/>
        /// Updates the given activity that is owned by the authenticated athlete. Requires activity:write. Also requires activity:read_all in order to update Only Me activities
        /// </summary>
        /// <param name="id"></param>
        /// <param name="commute">
        /// Whether this activity is a commute
        /// </param>
        /// <param name="trainer">
        /// Whether this activity was recorded on a training machine
        /// </param>
        /// <param name="hideFromHome">
        /// Whether this activity is muted
        /// </param>
        /// <param name="description">
        /// The description of the activity
        /// </param>
        /// <param name="name">
        /// The name of the activity
        /// </param>
        /// <param name="type">
        /// An enumeration of the types an activity may have. Note that this enumeration does not include new sport types (e.g. MountainBikeRide, EMountainBikeRide), activities with these sport types will have the corresponding activity type (e.g. Ride for MountainBikeRide, EBikeRide for EMountainBikeRide)
        /// </param>
        /// <param name="sportType">
        /// An enumeration of the sport types an activity may have. Distinct from ActivityType in that it has new types (e.g. MountainBikeRide)
        /// </param>
        /// <param name="gearId">
        /// Identifier for the gear associated with the activity. ‘none’ clears gear from activity
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.DetailedActivity> UpdateActivityByIdAsync(
            long id,
            bool? commute = default,
            bool? trainer = default,
            bool? hideFromHome = default,
            string? description = default,
            string? name = default,
            global::Strava.ActivityType? type = default,
            global::Strava.SportType? sportType = default,
            string? gearId = default,
            global::Strava.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}