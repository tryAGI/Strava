
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummarySegmentEffort
    {
        /// <summary>
        /// The unique identifier of this effort
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// The unique identifier of the activity related to this effort
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public long? ActivityId { get; set; }

        /// <summary>
        /// The effort's elapsed time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elapsed_time")]
        public int? ElapsedTime { get; set; }

        /// <summary>
        /// The time at which the effort was started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// The time at which the effort was started in the local timezone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date_local")]
        public global::System.DateTime? StartDateLocal { get; set; }

        /// <summary>
        /// The effort's distance in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public float? Distance { get; set; }

        /// <summary>
        /// Whether this effort is the current best on the leaderboard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_kom")]
        public bool? IsKom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarySegmentEffort" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of this effort
        /// </param>
        /// <param name="activityId">
        /// The unique identifier of the activity related to this effort
        /// </param>
        /// <param name="elapsedTime">
        /// The effort's elapsed time
        /// </param>
        /// <param name="startDate">
        /// The time at which the effort was started.
        /// </param>
        /// <param name="startDateLocal">
        /// The time at which the effort was started in the local timezone.
        /// </param>
        /// <param name="distance">
        /// The effort's distance in meters
        /// </param>
        /// <param name="isKom">
        /// Whether this effort is the current best on the leaderboard
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummarySegmentEffort(
            long? id,
            long? activityId,
            int? elapsedTime,
            global::System.DateTime? startDate,
            global::System.DateTime? startDateLocal,
            float? distance,
            bool? isKom)
        {
            this.Id = id;
            this.ActivityId = activityId;
            this.ElapsedTime = elapsedTime;
            this.StartDate = startDate;
            this.StartDateLocal = startDateLocal;
            this.Distance = distance;
            this.IsKom = isKom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarySegmentEffort" /> class.
        /// </summary>
        public SummarySegmentEffort()
        {
        }
    }
}