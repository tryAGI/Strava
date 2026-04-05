
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Comment
    {
        /// <summary>
        /// The unique identifier of this comment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// The identifier of the activity this comment is related to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public long? ActivityId { get; set; }

        /// <summary>
        /// The content of the comment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("athlete")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.SummaryAthleteJsonConverter))]
        public global::Strava.SummaryAthlete? Athlete { get; set; }

        /// <summary>
        /// The time at which this comment was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Comment" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of this comment
        /// </param>
        /// <param name="activityId">
        /// The identifier of the activity this comment is related to
        /// </param>
        /// <param name="text">
        /// The content of the comment
        /// </param>
        /// <param name="athlete"></param>
        /// <param name="createdAt">
        /// The time at which this comment was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Comment(
            long? id,
            long? activityId,
            string? text,
            global::Strava.SummaryAthlete? athlete,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.ActivityId = activityId;
            this.Text = text;
            this.Athlete = athlete;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Comment" /> class.
        /// </summary>
        public Comment()
        {
        }
    }
}