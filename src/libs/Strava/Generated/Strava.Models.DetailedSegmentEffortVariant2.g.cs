
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetailedSegmentEffortVariant2
    {
        /// <summary>
        /// The name of the segment on which this effort was performed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity")]
        public global::Strava.MetaActivity? Activity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("athlete")]
        public global::Strava.MetaAthlete? Athlete { get; set; }

        /// <summary>
        /// The effort's moving time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moving_time")]
        public int? MovingTime { get; set; }

        /// <summary>
        /// The start index of this effort in its activity's stream
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// The end index of this effort in its activity's stream
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// The effort's average cadence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_cadence")]
        public float? AverageCadence { get; set; }

        /// <summary>
        /// The average wattage of this effort
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_watts")]
        public float? AverageWatts { get; set; }

        /// <summary>
        /// For riding efforts, whether the wattage was reported by a dedicated recording device
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_watts")]
        public bool? DeviceWatts { get; set; }

        /// <summary>
        /// The heart heart rate of the athlete during this effort
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_heartrate")]
        public float? AverageHeartrate { get; set; }

        /// <summary>
        /// The maximum heart rate of the athlete during this effort
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_heartrate")]
        public float? MaxHeartrate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment")]
        public global::Strava.SummarySegment? Segment { get; set; }

        /// <summary>
        /// The rank of the effort on the global leaderboard if it belongs in the top 10 at the time of upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kom_rank")]
        public int? KomRank { get; set; }

        /// <summary>
        /// The rank of the effort on the athlete's leaderboard if it belongs in the top 3 at the time of upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pr_rank")]
        public int? PrRank { get; set; }

        /// <summary>
        /// Whether this effort should be hidden when viewed within an activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedSegmentEffortVariant2" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the segment on which this effort was performed
        /// </param>
        /// <param name="activity"></param>
        /// <param name="athlete"></param>
        /// <param name="movingTime">
        /// The effort's moving time
        /// </param>
        /// <param name="startIndex">
        /// The start index of this effort in its activity's stream
        /// </param>
        /// <param name="endIndex">
        /// The end index of this effort in its activity's stream
        /// </param>
        /// <param name="averageCadence">
        /// The effort's average cadence
        /// </param>
        /// <param name="averageWatts">
        /// The average wattage of this effort
        /// </param>
        /// <param name="deviceWatts">
        /// For riding efforts, whether the wattage was reported by a dedicated recording device
        /// </param>
        /// <param name="averageHeartrate">
        /// The heart heart rate of the athlete during this effort
        /// </param>
        /// <param name="maxHeartrate">
        /// The maximum heart rate of the athlete during this effort
        /// </param>
        /// <param name="segment"></param>
        /// <param name="komRank">
        /// The rank of the effort on the global leaderboard if it belongs in the top 10 at the time of upload
        /// </param>
        /// <param name="prRank">
        /// The rank of the effort on the athlete's leaderboard if it belongs in the top 3 at the time of upload
        /// </param>
        /// <param name="hidden">
        /// Whether this effort should be hidden when viewed within an activity
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetailedSegmentEffortVariant2(
            string? name,
            global::Strava.MetaActivity? activity,
            global::Strava.MetaAthlete? athlete,
            int? movingTime,
            int? startIndex,
            int? endIndex,
            float? averageCadence,
            float? averageWatts,
            bool? deviceWatts,
            float? averageHeartrate,
            float? maxHeartrate,
            global::Strava.SummarySegment? segment,
            int? komRank,
            int? prRank,
            bool? hidden)
        {
            this.Name = name;
            this.Activity = activity;
            this.Athlete = athlete;
            this.MovingTime = movingTime;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.AverageCadence = averageCadence;
            this.AverageWatts = averageWatts;
            this.DeviceWatts = deviceWatts;
            this.AverageHeartrate = averageHeartrate;
            this.MaxHeartrate = maxHeartrate;
            this.Segment = segment;
            this.KomRank = komRank;
            this.PrRank = prRank;
            this.Hidden = hidden;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedSegmentEffortVariant2" /> class.
        /// </summary>
        public DetailedSegmentEffortVariant2()
        {
        }
    }
}