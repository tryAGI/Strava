
#nullable enable

namespace Strava
{
    /// <summary>
    /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
    /// </summary>
    public sealed partial class ActivityTotal
    {
        /// <summary>
        /// The number of activities considered in this total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// The total distance covered by the considered activities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public float? Distance { get; set; }

        /// <summary>
        /// The total moving time of the considered activities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moving_time")]
        public int? MovingTime { get; set; }

        /// <summary>
        /// The total elapsed time of the considered activities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elapsed_time")]
        public int? ElapsedTime { get; set; }

        /// <summary>
        /// The total elevation gain of the considered activities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elevation_gain")]
        public float? ElevationGain { get; set; }

        /// <summary>
        /// The total number of achievements of the considered activities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("achievement_count")]
        public int? AchievementCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityTotal" /> class.
        /// </summary>
        /// <param name="count">
        /// The number of activities considered in this total.
        /// </param>
        /// <param name="distance">
        /// The total distance covered by the considered activities.
        /// </param>
        /// <param name="movingTime">
        /// The total moving time of the considered activities.
        /// </param>
        /// <param name="elapsedTime">
        /// The total elapsed time of the considered activities.
        /// </param>
        /// <param name="elevationGain">
        /// The total elevation gain of the considered activities.
        /// </param>
        /// <param name="achievementCount">
        /// The total number of achievements of the considered activities.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityTotal(
            int? count,
            float? distance,
            int? movingTime,
            int? elapsedTime,
            float? elevationGain,
            int? achievementCount)
        {
            this.Count = count;
            this.Distance = distance;
            this.MovingTime = movingTime;
            this.ElapsedTime = elapsedTime;
            this.ElevationGain = elevationGain;
            this.AchievementCount = achievementCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityTotal" /> class.
        /// </summary>
        public ActivityTotal()
        {
        }

    }
}