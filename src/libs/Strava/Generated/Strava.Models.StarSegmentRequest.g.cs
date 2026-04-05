
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StarSegmentRequest
    {
        /// <summary>
        /// If true, star the segment; if false, unstar the segment.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starred")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Starred { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StarSegmentRequest" /> class.
        /// </summary>
        /// <param name="starred">
        /// If true, star the segment; if false, unstar the segment.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StarSegmentRequest(
            bool starred)
        {
            this.Starred = starred;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StarSegmentRequest" /> class.
        /// </summary>
        public StarSegmentRequest()
        {
        }
    }
}