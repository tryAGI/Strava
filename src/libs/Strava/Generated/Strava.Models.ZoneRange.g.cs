
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ZoneRange
    {
        /// <summary>
        /// The minimum value in the range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public int? Min { get; set; }

        /// <summary>
        /// The maximum value in the range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public int? Max { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneRange" /> class.
        /// </summary>
        /// <param name="min">
        /// The minimum value in the range.
        /// </param>
        /// <param name="max">
        /// The maximum value in the range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ZoneRange(
            int? min,
            int? max)
        {
            this.Min = min;
            this.Max = max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneRange" /> class.
        /// </summary>
        public ZoneRange()
        {
        }

    }
}