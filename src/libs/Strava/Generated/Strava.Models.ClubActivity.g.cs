
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClubActivity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("athlete")]
        public global::Strava.MetaAthlete? Athlete { get; set; }

        /// <summary>
        /// The name of the activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The activity's distance, in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public float? Distance { get; set; }

        /// <summary>
        /// The activity's moving time, in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moving_time")]
        public int? MovingTime { get; set; }

        /// <summary>
        /// The activity's elapsed time, in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elapsed_time")]
        public int? ElapsedTime { get; set; }

        /// <summary>
        /// The activity's total elevation gain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_elevation_gain")]
        public float? TotalElevationGain { get; set; }

        /// <summary>
        /// An enumeration of the types an activity may have. Note that this enumeration does not include new sport types (e.g. MountainBikeRide, EMountainBikeRide), activities with these sport types will have the corresponding activity type (e.g. Ride for MountainBikeRide, EBikeRide for EMountainBikeRide)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.ActivityTypeJsonConverter))]
        public global::Strava.ActivityType? Type { get; set; }

        /// <summary>
        /// An enumeration of the sport types an activity may have. Distinct from ActivityType in that it has new types (e.g. MountainBikeRide)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sport_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.SportTypeJsonConverter))]
        public global::Strava.SportType? SportType { get; set; }

        /// <summary>
        /// The activity's workout type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workout_type")]
        public int? WorkoutType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClubActivity" /> class.
        /// </summary>
        /// <param name="athlete"></param>
        /// <param name="name">
        /// The name of the activity
        /// </param>
        /// <param name="distance">
        /// The activity's distance, in meters
        /// </param>
        /// <param name="movingTime">
        /// The activity's moving time, in seconds
        /// </param>
        /// <param name="elapsedTime">
        /// The activity's elapsed time, in seconds
        /// </param>
        /// <param name="totalElevationGain">
        /// The activity's total elevation gain.
        /// </param>
        /// <param name="type">
        /// An enumeration of the types an activity may have. Note that this enumeration does not include new sport types (e.g. MountainBikeRide, EMountainBikeRide), activities with these sport types will have the corresponding activity type (e.g. Ride for MountainBikeRide, EBikeRide for EMountainBikeRide)
        /// </param>
        /// <param name="sportType">
        /// An enumeration of the sport types an activity may have. Distinct from ActivityType in that it has new types (e.g. MountainBikeRide)
        /// </param>
        /// <param name="workoutType">
        /// The activity's workout type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClubActivity(
            global::Strava.MetaAthlete? athlete,
            string? name,
            float? distance,
            int? movingTime,
            int? elapsedTime,
            float? totalElevationGain,
            global::Strava.ActivityType? type,
            global::Strava.SportType? sportType,
            int? workoutType)
        {
            this.Athlete = athlete;
            this.Name = name;
            this.Distance = distance;
            this.MovingTime = movingTime;
            this.ElapsedTime = elapsedTime;
            this.TotalElevationGain = totalElevationGain;
            this.Type = type;
            this.SportType = sportType;
            this.WorkoutType = workoutType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClubActivity" /> class.
        /// </summary>
        public ClubActivity()
        {
        }

    }
}