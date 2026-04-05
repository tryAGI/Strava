
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Upload
    {
        /// <summary>
        /// The unique identifier of the upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// The unique identifier of the upload in string format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_str")]
        public string? IdStr { get; set; }

        /// <summary>
        /// The external identifier of the upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// The error associated with this upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The status of this upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The identifier of the activity this upload resulted into
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public long? ActivityId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Upload" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the upload
        /// </param>
        /// <param name="idStr">
        /// The unique identifier of the upload in string format
        /// </param>
        /// <param name="externalId">
        /// The external identifier of the upload
        /// </param>
        /// <param name="error">
        /// The error associated with this upload
        /// </param>
        /// <param name="status">
        /// The status of this upload
        /// </param>
        /// <param name="activityId">
        /// The identifier of the activity this upload resulted into
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Upload(
            long? id,
            string? idStr,
            string? externalId,
            string? error,
            string? status,
            long? activityId)
        {
            this.Id = id;
            this.IdStr = idStr;
            this.ExternalId = externalId;
            this.Error = error;
            this.Status = status;
            this.ActivityId = activityId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Upload" /> class.
        /// </summary>
        public Upload()
        {
        }
    }
}