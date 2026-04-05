
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PowerZoneRanges
    {
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
        /// Initializes a new instance of the <see cref="PowerZoneRanges" /> class.
        /// </summary>
        /// <param name="zones"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PowerZoneRanges(
            global::System.Collections.Generic.IList<global::Strava.ZoneRange>? zones)
        {
            this.Zones = zones;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerZoneRanges" /> class.
        /// </summary>
        public PowerZoneRanges()
        {
        }
    }
}