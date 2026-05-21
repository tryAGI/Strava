
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Zones
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate")]
        public global::Strava.HeartRateZoneRanges? HeartRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("power")]
        public global::Strava.PowerZoneRanges? Power { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Zones" /> class.
        /// </summary>
        /// <param name="heartRate"></param>
        /// <param name="power"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Zones(
            global::Strava.HeartRateZoneRanges? heartRate,
            global::Strava.PowerZoneRanges? power)
        {
            this.HeartRate = heartRate;
            this.Power = power;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zones" /> class.
        /// </summary>
        public Zones()
        {
        }

    }
}