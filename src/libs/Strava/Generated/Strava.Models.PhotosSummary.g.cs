
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhotosSummary
    {
        /// <summary>
        /// The number of photos
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        public global::Strava.PhotosSummaryPrimary? Primary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhotosSummary" /> class.
        /// </summary>
        /// <param name="count">
        /// The number of photos
        /// </param>
        /// <param name="primary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhotosSummary(
            int? count,
            global::Strava.PhotosSummaryPrimary? primary)
        {
            this.Count = count;
            this.Primary = primary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhotosSummary" /> class.
        /// </summary>
        public PhotosSummary()
        {
        }

    }
}