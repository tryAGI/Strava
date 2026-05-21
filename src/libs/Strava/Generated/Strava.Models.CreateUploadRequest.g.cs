
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateUploadRequest
    {
        /// <summary>
        /// The uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// The uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The desired name of the resulting activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The desired description of the resulting activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the resulting activity should be marked as having been performed on a trainer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainer")]
        public string? Trainer { get; set; }

        /// <summary>
        /// Whether the resulting activity should be tagged as a commute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commute")]
        public string? Commute { get; set; }

        /// <summary>
        /// The format of the uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.CreateUploadRequestDataTypeJsonConverter))]
        public global::Strava.CreateUploadRequestDataType? DataType { get; set; }

        /// <summary>
        /// The desired external identifier of the resulting activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUploadRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// The uploaded file.
        /// </param>
        /// <param name="filename">
        /// The uploaded file.
        /// </param>
        /// <param name="name">
        /// The desired name of the resulting activity.
        /// </param>
        /// <param name="description">
        /// The desired description of the resulting activity.
        /// </param>
        /// <param name="trainer">
        /// Whether the resulting activity should be marked as having been performed on a trainer.
        /// </param>
        /// <param name="commute">
        /// Whether the resulting activity should be tagged as a commute.
        /// </param>
        /// <param name="dataType">
        /// The format of the uploaded file.
        /// </param>
        /// <param name="externalId">
        /// The desired external identifier of the resulting activity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateUploadRequest(
            byte[]? file,
            string? filename,
            string? name,
            string? description,
            string? trainer,
            string? commute,
            global::Strava.CreateUploadRequestDataType? dataType,
            string? externalId)
        {
            this.File = file;
            this.Filename = filename;
            this.Name = name;
            this.Description = description;
            this.Trainer = trainer;
            this.Commute = commute;
            this.DataType = dataType;
            this.ExternalId = externalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUploadRequest" /> class.
        /// </summary>
        public CreateUploadRequest()
        {
        }

    }
}