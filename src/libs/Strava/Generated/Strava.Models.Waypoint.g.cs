
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Waypoint
    {
        /// <summary>
        /// A pair of latitude/longitude coordinates, represented as an array of 2 floating point numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latlng")]
        public global::System.Collections.Generic.IList<float>? Latlng { get; set; }

        /// <summary>
        /// A pair of latitude/longitude coordinates, represented as an array of 2 floating point numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_latlng")]
        public global::System.Collections.Generic.IList<float>? TargetLatlng { get; set; }

        /// <summary>
        /// Categories that the waypoint belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// A title for the waypoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// A description of the waypoint (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The number meters along the route that the waypoint is located
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_into_route")]
        public float? DistanceIntoRoute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Waypoint" /> class.
        /// </summary>
        /// <param name="latlng">
        /// A pair of latitude/longitude coordinates, represented as an array of 2 floating point numbers.
        /// </param>
        /// <param name="targetLatlng">
        /// A pair of latitude/longitude coordinates, represented as an array of 2 floating point numbers.
        /// </param>
        /// <param name="categories">
        /// Categories that the waypoint belongs to
        /// </param>
        /// <param name="title">
        /// A title for the waypoint
        /// </param>
        /// <param name="description">
        /// A description of the waypoint (optional)
        /// </param>
        /// <param name="distanceIntoRoute">
        /// The number meters along the route that the waypoint is located
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Waypoint(
            global::System.Collections.Generic.IList<float>? latlng,
            global::System.Collections.Generic.IList<float>? targetLatlng,
            global::System.Collections.Generic.IList<string>? categories,
            string? title,
            string? description,
            float? distanceIntoRoute)
        {
            this.Latlng = latlng;
            this.TargetLatlng = targetLatlng;
            this.Categories = categories;
            this.Title = title;
            this.Description = description;
            this.DistanceIntoRoute = distanceIntoRoute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Waypoint" /> class.
        /// </summary>
        public Waypoint()
        {
        }
    }
}