
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetailedActivityVariant2
    {
        /// <summary>
        /// The description of the activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photos")]
        public global::Strava.PhotosSummary? Photos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gear")]
        public global::Strava.SummaryGear? Gear { get; set; }

        /// <summary>
        /// The number of kilocalories consumed during this activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calories")]
        public float? Calories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_efforts")]
        public global::System.Collections.Generic.IList<global::Strava.DetailedSegmentEffort>? SegmentEfforts { get; set; }

        /// <summary>
        /// The name of the device used to record the activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_name")]
        public string? DeviceName { get; set; }

        /// <summary>
        /// The token used to embed a Strava activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_token")]
        public string? EmbedToken { get; set; }

        /// <summary>
        /// The splits of this activity in metric units (for runs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("splits_metric")]
        public global::System.Collections.Generic.IList<global::Strava.Split>? SplitsMetric { get; set; }

        /// <summary>
        /// The splits of this activity in imperial units (for runs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("splits_standard")]
        public global::System.Collections.Generic.IList<global::Strava.Split>? SplitsStandard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("laps")]
        public global::System.Collections.Generic.IList<global::Strava.Lap>? Laps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("best_efforts")]
        public global::System.Collections.Generic.IList<global::Strava.DetailedSegmentEffort>? BestEfforts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedActivityVariant2" /> class.
        /// </summary>
        /// <param name="description">
        /// The description of the activity
        /// </param>
        /// <param name="photos"></param>
        /// <param name="gear"></param>
        /// <param name="calories">
        /// The number of kilocalories consumed during this activity
        /// </param>
        /// <param name="segmentEfforts"></param>
        /// <param name="deviceName">
        /// The name of the device used to record the activity
        /// </param>
        /// <param name="embedToken">
        /// The token used to embed a Strava activity
        /// </param>
        /// <param name="splitsMetric">
        /// The splits of this activity in metric units (for runs)
        /// </param>
        /// <param name="splitsStandard">
        /// The splits of this activity in imperial units (for runs)
        /// </param>
        /// <param name="laps"></param>
        /// <param name="bestEfforts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetailedActivityVariant2(
            string? description,
            global::Strava.PhotosSummary? photos,
            global::Strava.SummaryGear? gear,
            float? calories,
            global::System.Collections.Generic.IList<global::Strava.DetailedSegmentEffort>? segmentEfforts,
            string? deviceName,
            string? embedToken,
            global::System.Collections.Generic.IList<global::Strava.Split>? splitsMetric,
            global::System.Collections.Generic.IList<global::Strava.Split>? splitsStandard,
            global::System.Collections.Generic.IList<global::Strava.Lap>? laps,
            global::System.Collections.Generic.IList<global::Strava.DetailedSegmentEffort>? bestEfforts)
        {
            this.Description = description;
            this.Photos = photos;
            this.Gear = gear;
            this.Calories = calories;
            this.SegmentEfforts = segmentEfforts;
            this.DeviceName = deviceName;
            this.EmbedToken = embedToken;
            this.SplitsMetric = splitsMetric;
            this.SplitsStandard = splitsStandard;
            this.Laps = laps;
            this.BestEfforts = bestEfforts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedActivityVariant2" /> class.
        /// </summary>
        public DetailedActivityVariant2()
        {
        }

    }
}