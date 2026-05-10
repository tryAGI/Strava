
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MovingStreamVariant2
    {
        /// <summary>
        /// The sequence of moving values for this stream, as boolean values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<bool>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MovingStreamVariant2" /> class.
        /// </summary>
        /// <param name="data">
        /// The sequence of moving values for this stream, as boolean values
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MovingStreamVariant2(
            global::System.Collections.Generic.IList<bool>? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MovingStreamVariant2" /> class.
        /// </summary>
        public MovingStreamVariant2()
        {
        }

    }
}