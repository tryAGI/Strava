
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummaryActivityVariant2
    {
        /// <summary>
        /// The identifier provided at upload time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// The identifier of the upload that resulted in this activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_id")]
        public long? UploadId { get; set; }

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
        /// The activity's highest elevation, in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elev_high")]
        public float? ElevHigh { get; set; }

        /// <summary>
        /// The activity's lowest elevation, in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elev_low")]
        public float? ElevLow { get; set; }

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
        /// The time at which the activity was started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// The time at which the activity was started in the local timezone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date_local")]
        public global::System.DateTime? StartDateLocal { get; set; }

        /// <summary>
        /// The timezone of the activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// A pair of latitude/longitude coordinates, represented as an array of 2 floating point numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_latlng")]
        public global::System.Collections.Generic.IList<float>? StartLatlng { get; set; }

        /// <summary>
        /// A pair of latitude/longitude coordinates, represented as an array of 2 floating point numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_latlng")]
        public global::System.Collections.Generic.IList<float>? EndLatlng { get; set; }

        /// <summary>
        /// The number of achievements gained during this activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("achievement_count")]
        public int? AchievementCount { get; set; }

        /// <summary>
        /// The number of kudos given for this activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kudos_count")]
        public int? KudosCount { get; set; }

        /// <summary>
        /// The number of comments for this activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment_count")]
        public int? CommentCount { get; set; }

        /// <summary>
        /// The number of athletes for taking part in a group activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("athlete_count")]
        public int? AthleteCount { get; set; }

        /// <summary>
        /// The number of Instagram photos for this activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photo_count")]
        public int? PhotoCount { get; set; }

        /// <summary>
        /// The number of Instagram and Strava photos for this activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_photo_count")]
        public int? TotalPhotoCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("map")]
        public global::Strava.PolylineMap? Map { get; set; }

        /// <summary>
        /// The name of the device used to record the activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_name")]
        public string? DeviceName { get; set; }

        /// <summary>
        /// Whether this activity was recorded on a training machine
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainer")]
        public bool? Trainer { get; set; }

        /// <summary>
        /// Whether this activity is a commute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commute")]
        public bool? Commute { get; set; }

        /// <summary>
        /// Whether this activity was created manually
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manual")]
        public bool? Manual { get; set; }

        /// <summary>
        /// Whether this activity is private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// Whether this activity is flagged
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        public bool? Flagged { get; set; }

        /// <summary>
        /// The activity's workout type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workout_type")]
        public int? WorkoutType { get; set; }

        /// <summary>
        /// The unique identifier of the upload in string format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_id_str")]
        public string? UploadIdStr { get; set; }

        /// <summary>
        /// The activity's average speed, in meters per second
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_speed")]
        public float? AverageSpeed { get; set; }

        /// <summary>
        /// The activity's max speed, in meters per second
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_speed")]
        public float? MaxSpeed { get; set; }

        /// <summary>
        /// Whether the logged-in athlete has kudoed this activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_kudoed")]
        public bool? HasKudoed { get; set; }

        /// <summary>
        /// Whether the activity is muted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hide_from_home")]
        public bool? HideFromHome { get; set; }

        /// <summary>
        /// The id of the gear for the activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gear_id")]
        public string? GearId { get; set; }

        /// <summary>
        /// The total work done in kilojoules during this activity. Rides only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kilojoules")]
        public float? Kilojoules { get; set; }

        /// <summary>
        /// Average power output in watts during this activity. Rides only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_watts")]
        public float? AverageWatts { get; set; }

        /// <summary>
        /// Whether the watts are from a power meter, false if estimated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_watts")]
        public bool? DeviceWatts { get; set; }

        /// <summary>
        /// Rides with power meter data only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_watts")]
        public int? MaxWatts { get; set; }

        /// <summary>
        /// Similar to Normalized Power. Rides with power meter data only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weighted_average_watts")]
        public int? WeightedAverageWatts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryActivityVariant2" /> class.
        /// </summary>
        /// <param name="externalId">
        /// The identifier provided at upload time
        /// </param>
        /// <param name="uploadId">
        /// The identifier of the upload that resulted in this activity
        /// </param>
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
        /// <param name="elevHigh">
        /// The activity's highest elevation, in meters
        /// </param>
        /// <param name="elevLow">
        /// The activity's lowest elevation, in meters
        /// </param>
        /// <param name="type">
        /// An enumeration of the types an activity may have. Note that this enumeration does not include new sport types (e.g. MountainBikeRide, EMountainBikeRide), activities with these sport types will have the corresponding activity type (e.g. Ride for MountainBikeRide, EBikeRide for EMountainBikeRide)
        /// </param>
        /// <param name="sportType">
        /// An enumeration of the sport types an activity may have. Distinct from ActivityType in that it has new types (e.g. MountainBikeRide)
        /// </param>
        /// <param name="startDate">
        /// The time at which the activity was started.
        /// </param>
        /// <param name="startDateLocal">
        /// The time at which the activity was started in the local timezone.
        /// </param>
        /// <param name="timezone">
        /// The timezone of the activity
        /// </param>
        /// <param name="startLatlng">
        /// A pair of latitude/longitude coordinates, represented as an array of 2 floating point numbers.
        /// </param>
        /// <param name="endLatlng">
        /// A pair of latitude/longitude coordinates, represented as an array of 2 floating point numbers.
        /// </param>
        /// <param name="achievementCount">
        /// The number of achievements gained during this activity
        /// </param>
        /// <param name="kudosCount">
        /// The number of kudos given for this activity
        /// </param>
        /// <param name="commentCount">
        /// The number of comments for this activity
        /// </param>
        /// <param name="athleteCount">
        /// The number of athletes for taking part in a group activity
        /// </param>
        /// <param name="photoCount">
        /// The number of Instagram photos for this activity
        /// </param>
        /// <param name="totalPhotoCount">
        /// The number of Instagram and Strava photos for this activity
        /// </param>
        /// <param name="map"></param>
        /// <param name="deviceName">
        /// The name of the device used to record the activity
        /// </param>
        /// <param name="trainer">
        /// Whether this activity was recorded on a training machine
        /// </param>
        /// <param name="commute">
        /// Whether this activity is a commute
        /// </param>
        /// <param name="manual">
        /// Whether this activity was created manually
        /// </param>
        /// <param name="private">
        /// Whether this activity is private
        /// </param>
        /// <param name="flagged">
        /// Whether this activity is flagged
        /// </param>
        /// <param name="workoutType">
        /// The activity's workout type
        /// </param>
        /// <param name="uploadIdStr">
        /// The unique identifier of the upload in string format
        /// </param>
        /// <param name="averageSpeed">
        /// The activity's average speed, in meters per second
        /// </param>
        /// <param name="maxSpeed">
        /// The activity's max speed, in meters per second
        /// </param>
        /// <param name="hasKudoed">
        /// Whether the logged-in athlete has kudoed this activity
        /// </param>
        /// <param name="hideFromHome">
        /// Whether the activity is muted
        /// </param>
        /// <param name="gearId">
        /// The id of the gear for the activity
        /// </param>
        /// <param name="kilojoules">
        /// The total work done in kilojoules during this activity. Rides only
        /// </param>
        /// <param name="averageWatts">
        /// Average power output in watts during this activity. Rides only
        /// </param>
        /// <param name="deviceWatts">
        /// Whether the watts are from a power meter, false if estimated
        /// </param>
        /// <param name="maxWatts">
        /// Rides with power meter data only
        /// </param>
        /// <param name="weightedAverageWatts">
        /// Similar to Normalized Power. Rides with power meter data only
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummaryActivityVariant2(
            string? externalId,
            long? uploadId,
            global::Strava.MetaAthlete? athlete,
            string? name,
            float? distance,
            int? movingTime,
            int? elapsedTime,
            float? totalElevationGain,
            float? elevHigh,
            float? elevLow,
            global::Strava.ActivityType? type,
            global::Strava.SportType? sportType,
            global::System.DateTime? startDate,
            global::System.DateTime? startDateLocal,
            string? timezone,
            global::System.Collections.Generic.IList<float>? startLatlng,
            global::System.Collections.Generic.IList<float>? endLatlng,
            int? achievementCount,
            int? kudosCount,
            int? commentCount,
            int? athleteCount,
            int? photoCount,
            int? totalPhotoCount,
            global::Strava.PolylineMap? map,
            string? deviceName,
            bool? trainer,
            bool? commute,
            bool? manual,
            bool? @private,
            bool? flagged,
            int? workoutType,
            string? uploadIdStr,
            float? averageSpeed,
            float? maxSpeed,
            bool? hasKudoed,
            bool? hideFromHome,
            string? gearId,
            float? kilojoules,
            float? averageWatts,
            bool? deviceWatts,
            int? maxWatts,
            int? weightedAverageWatts)
        {
            this.ExternalId = externalId;
            this.UploadId = uploadId;
            this.Athlete = athlete;
            this.Name = name;
            this.Distance = distance;
            this.MovingTime = movingTime;
            this.ElapsedTime = elapsedTime;
            this.TotalElevationGain = totalElevationGain;
            this.ElevHigh = elevHigh;
            this.ElevLow = elevLow;
            this.Type = type;
            this.SportType = sportType;
            this.StartDate = startDate;
            this.StartDateLocal = startDateLocal;
            this.Timezone = timezone;
            this.StartLatlng = startLatlng;
            this.EndLatlng = endLatlng;
            this.AchievementCount = achievementCount;
            this.KudosCount = kudosCount;
            this.CommentCount = commentCount;
            this.AthleteCount = athleteCount;
            this.PhotoCount = photoCount;
            this.TotalPhotoCount = totalPhotoCount;
            this.Map = map;
            this.DeviceName = deviceName;
            this.Trainer = trainer;
            this.Commute = commute;
            this.Manual = manual;
            this.Private = @private;
            this.Flagged = flagged;
            this.WorkoutType = workoutType;
            this.UploadIdStr = uploadIdStr;
            this.AverageSpeed = averageSpeed;
            this.MaxSpeed = maxSpeed;
            this.HasKudoed = hasKudoed;
            this.HideFromHome = hideFromHome;
            this.GearId = gearId;
            this.Kilojoules = kilojoules;
            this.AverageWatts = averageWatts;
            this.DeviceWatts = deviceWatts;
            this.MaxWatts = maxWatts;
            this.WeightedAverageWatts = weightedAverageWatts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryActivityVariant2" /> class.
        /// </summary>
        public SummaryActivityVariant2()
        {
        }
    }
}