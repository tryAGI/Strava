
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExplorerResponse
    {
        /// <summary>
        /// The set of segments matching an explorer request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::Strava.ExplorerSegment>? Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExplorerResponse" /> class.
        /// </summary>
        /// <param name="segments">
        /// The set of segments matching an explorer request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExplorerResponse(
            global::System.Collections.Generic.IList<global::Strava.ExplorerSegment>? segments)
        {
            this.Segments = segments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExplorerResponse" /> class.
        /// </summary>
        public ExplorerResponse()
        {
        }

    }
}