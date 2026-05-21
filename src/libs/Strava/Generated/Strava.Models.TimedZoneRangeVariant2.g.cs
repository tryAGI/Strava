
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimedZoneRangeVariant2
    {
        /// <summary>
        /// The number of seconds spent in this zone
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public int? Time { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimedZoneRangeVariant2" /> class.
        /// </summary>
        /// <param name="time">
        /// The number of seconds spent in this zone
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimedZoneRangeVariant2(
            int? time)
        {
            this.Time = time;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimedZoneRangeVariant2" /> class.
        /// </summary>
        public TimedZoneRangeVariant2()
        {
        }

    }
}