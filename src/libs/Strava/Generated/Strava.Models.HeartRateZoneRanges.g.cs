
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeartRateZoneRanges
    {
        /// <summary>
        /// Whether the athlete has set their own custom heart rate zones
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_zones")]
        public bool? CustomZones { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zones")]
        public global::System.Collections.Generic.IList<global::Strava.ZoneRange>? Zones { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartRateZoneRanges" /> class.
        /// </summary>
        /// <param name="customZones">
        /// Whether the athlete has set their own custom heart rate zones
        /// </param>
        /// <param name="zones"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeartRateZoneRanges(
            bool? customZones,
            global::System.Collections.Generic.IList<global::Strava.ZoneRange>? zones)
        {
            this.CustomZones = customZones;
            this.Zones = zones;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartRateZoneRanges" /> class.
        /// </summary>
        public HeartRateZoneRanges()
        {
        }
    }
}