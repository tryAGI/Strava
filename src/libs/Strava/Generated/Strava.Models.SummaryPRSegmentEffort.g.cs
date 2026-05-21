
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummaryPRSegmentEffort
    {
        /// <summary>
        /// The unique identifier of the activity related to the PR effort.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pr_activity_id")]
        public long? PrActivityId { get; set; }

        /// <summary>
        /// The elapsed time ot the PR effort.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pr_elapsed_time")]
        public int? PrElapsedTime { get; set; }

        /// <summary>
        /// The time at which the PR effort was started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pr_date")]
        public global::System.DateTime? PrDate { get; set; }

        /// <summary>
        /// Number of efforts by the authenticated athlete on this segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort_count")]
        public int? EffortCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryPRSegmentEffort" /> class.
        /// </summary>
        /// <param name="prActivityId">
        /// The unique identifier of the activity related to the PR effort.
        /// </param>
        /// <param name="prElapsedTime">
        /// The elapsed time ot the PR effort.
        /// </param>
        /// <param name="prDate">
        /// The time at which the PR effort was started.
        /// </param>
        /// <param name="effortCount">
        /// Number of efforts by the authenticated athlete on this segment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummaryPRSegmentEffort(
            long? prActivityId,
            int? prElapsedTime,
            global::System.DateTime? prDate,
            int? effortCount)
        {
            this.PrActivityId = prActivityId;
            this.PrElapsedTime = prElapsedTime;
            this.PrDate = prDate;
            this.EffortCount = effortCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryPRSegmentEffort" /> class.
        /// </summary>
        public SummaryPRSegmentEffort()
        {
        }

    }
}