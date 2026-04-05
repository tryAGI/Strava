
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClubAnnouncement
    {
        /// <summary>
        /// The unique identifier of this announcement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// The unique identifier of the club this announcements was made in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("club_id")]
        public long? ClubId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("athlete")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.SummaryAthleteJsonConverter))]
        public global::Strava.SummaryAthlete? Athlete { get; set; }

        /// <summary>
        /// The time at which this announcement was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The content of this announcement
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClubAnnouncement" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of this announcement.
        /// </param>
        /// <param name="clubId">
        /// The unique identifier of the club this announcements was made in.
        /// </param>
        /// <param name="athlete"></param>
        /// <param name="createdAt">
        /// The time at which this announcement was created.
        /// </param>
        /// <param name="message">
        /// The content of this announcement
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClubAnnouncement(
            long? id,
            long? clubId,
            global::Strava.SummaryAthlete? athlete,
            global::System.DateTime? createdAt,
            string? message)
        {
            this.Id = id;
            this.ClubId = clubId;
            this.Athlete = athlete;
            this.CreatedAt = createdAt;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClubAnnouncement" /> class.
        /// </summary>
        public ClubAnnouncement()
        {
        }
    }
}