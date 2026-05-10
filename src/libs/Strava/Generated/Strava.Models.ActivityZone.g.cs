
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityZone
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public int? Score { get; set; }

        /// <summary>
        /// Stores the exclusive ranges representing zones and the time spent in each.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distribution_buckets")]
        public global::System.Collections.Generic.IList<global::Strava.TimedZoneRange>? DistributionBuckets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.ActivityZoneTypeJsonConverter))]
        public global::Strava.ActivityZoneType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sensor_based")]
        public bool? SensorBased { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        public int? Points { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_zones")]
        public bool? CustomZones { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public int? Max { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityZone" /> class.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="distributionBuckets">
        /// Stores the exclusive ranges representing zones and the time spent in each.
        /// </param>
        /// <param name="type"></param>
        /// <param name="sensorBased"></param>
        /// <param name="points"></param>
        /// <param name="customZones"></param>
        /// <param name="max"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityZone(
            int? score,
            global::System.Collections.Generic.IList<global::Strava.TimedZoneRange>? distributionBuckets,
            global::Strava.ActivityZoneType? type,
            bool? sensorBased,
            int? points,
            bool? customZones,
            int? max)
        {
            this.Score = score;
            this.DistributionBuckets = distributionBuckets;
            this.Type = type;
            this.SensorBased = sensorBased;
            this.Points = points;
            this.CustomZones = customZones;
            this.Max = max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityZone" /> class.
        /// </summary>
        public ActivityZone()
        {
        }

    }
}