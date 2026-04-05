
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatableActivity
    {
        /// <summary>
        /// Whether this activity is a commute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commute")]
        public bool? Commute { get; set; }

        /// <summary>
        /// Whether this activity was recorded on a training machine
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainer")]
        public bool? Trainer { get; set; }

        /// <summary>
        /// Whether this activity is muted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hide_from_home")]
        public bool? HideFromHome { get; set; }

        /// <summary>
        /// The description of the activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The name of the activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        /// Identifier for the gear associated with the activity. ‘none’ clears gear from activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gear_id")]
        public string? GearId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatableActivity" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatableActivity(
            bool? commute,
            bool? trainer,
            bool? hideFromHome,
            string? description,
            string? name,
            global::Strava.ActivityType? type,
            global::Strava.SportType? sportType,
            string? gearId)
        {
            this.Commute = commute;
            this.Trainer = trainer;
            this.HideFromHome = hideFromHome;
            this.Description = description;
            this.Name = name;
            this.Type = type;
            this.SportType = sportType;
            this.GearId = gearId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatableActivity" /> class.
        /// </summary>
        public UpdatableActivity()
        {
        }
    }
}