
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeartrateStreamVariant2
    {
        /// <summary>
        /// The sequence of heart rate values for this stream, in beats per minute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<int>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartrateStreamVariant2" /> class.
        /// </summary>
        /// <param name="data">
        /// The sequence of heart rate values for this stream, in beats per minute
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeartrateStreamVariant2(
            global::System.Collections.Generic.IList<int>? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartrateStreamVariant2" /> class.
        /// </summary>
        public HeartrateStreamVariant2()
        {
        }

    }
}