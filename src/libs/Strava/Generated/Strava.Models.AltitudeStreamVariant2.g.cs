
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AltitudeStreamVariant2
    {
        /// <summary>
        /// The sequence of altitude values for this stream, in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<float>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AltitudeStreamVariant2" /> class.
        /// </summary>
        /// <param name="data">
        /// The sequence of altitude values for this stream, in meters
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AltitudeStreamVariant2(
            global::System.Collections.Generic.IList<float>? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AltitudeStreamVariant2" /> class.
        /// </summary>
        public AltitudeStreamVariant2()
        {
        }
    }
}