
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateActivityRequest
    {
        /// <summary>
        /// The name of the activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Type of activity. For example - Run, Ride etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Sport type of activity. For example - Run, MountainBikeRide, Ride, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sport_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SportType { get; set; }

        /// <summary>
        /// ISO 8601 formatted date time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date_local")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartDateLocal { get; set; }

        /// <summary>
        /// In seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elapsed_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ElapsedTime { get; set; }

        /// <summary>
        /// Description of the activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// In meters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public float? Distance { get; set; }

        /// <summary>
        /// Set to 1 to mark as a trainer activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainer")]
        public int? Trainer { get; set; }

        /// <summary>
        /// Set to 1 to mark as commute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commute")]
        public int? Commute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateActivityRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the activity.
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
        /// <param name="type">
        /// Type of activity. For example - Run, Ride etc.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateActivityRequest(
            string name,
            string sportType,
            global::System.DateTime startDateLocal,
            int elapsedTime,
            string? type,
            string? description,
            float? distance,
            int? trainer,
            int? commute)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.SportType = sportType ?? throw new global::System.ArgumentNullException(nameof(sportType));
            this.StartDateLocal = startDateLocal;
            this.ElapsedTime = elapsedTime;
            this.Description = description;
            this.Distance = distance;
            this.Trainer = trainer;
            this.Commute = commute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateActivityRequest" /> class.
        /// </summary>
        public CreateActivityRequest()
        {
        }

    }
}