
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CadenceStreamVariant2
    {
        /// <summary>
        /// The sequence of cadence values for this stream, in rotations per minute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<int>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CadenceStreamVariant2" /> class.
        /// </summary>
        /// <param name="data">
        /// The sequence of cadence values for this stream, in rotations per minute
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CadenceStreamVariant2(
            global::System.Collections.Generic.IList<int>? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CadenceStreamVariant2" /> class.
        /// </summary>
        public CadenceStreamVariant2()
        {
        }

    }
}