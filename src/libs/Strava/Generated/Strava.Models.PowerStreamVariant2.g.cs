
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PowerStreamVariant2
    {
        /// <summary>
        /// The sequence of power values for this stream, in watts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<int>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerStreamVariant2" /> class.
        /// </summary>
        /// <param name="data">
        /// The sequence of power values for this stream, in watts
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PowerStreamVariant2(
            global::System.Collections.Generic.IList<int>? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerStreamVariant2" /> class.
        /// </summary>
        public PowerStreamVariant2()
        {
        }

    }
}