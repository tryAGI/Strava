
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PolylineMap
    {
        /// <summary>
        /// The identifier of the map
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The polyline of the map, only returned on detailed representation of an object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("polyline")]
        public string? Polyline { get; set; }

        /// <summary>
        /// The summary polyline of the map
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_polyline")]
        public string? SummaryPolyline { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolylineMap" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier of the map
        /// </param>
        /// <param name="polyline">
        /// The polyline of the map, only returned on detailed representation of an object
        /// </param>
        /// <param name="summaryPolyline">
        /// The summary polyline of the map
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolylineMap(
            string? id,
            string? polyline,
            string? summaryPolyline)
        {
            this.Id = id;
            this.Polyline = polyline;
            this.SummaryPolyline = summaryPolyline;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolylineMap" /> class.
        /// </summary>
        public PolylineMap()
        {
        }

    }
}