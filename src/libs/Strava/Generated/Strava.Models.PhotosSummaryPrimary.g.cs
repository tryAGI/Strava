
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhotosSummaryPrimary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public int? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_id")]
        public string? UniqueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::System.Collections.Generic.Dictionary<string, string>? Urls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhotosSummaryPrimary" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="source"></param>
        /// <param name="uniqueId"></param>
        /// <param name="urls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhotosSummaryPrimary(
            long? id,
            int? source,
            string? uniqueId,
            global::System.Collections.Generic.Dictionary<string, string>? urls)
        {
            this.Id = id;
            this.Source = source;
            this.UniqueId = uniqueId;
            this.Urls = urls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhotosSummaryPrimary" /> class.
        /// </summary>
        public PhotosSummaryPrimary()
        {
        }
    }
}