
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Route
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("athlete")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.SummaryAthleteJsonConverter))]
        public global::Strava.SummaryAthlete? Athlete { get; set; }

        /// <summary>
        /// The description of the route
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The route's distance, in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public float? Distance { get; set; }

        /// <summary>
        /// The route's elevation gain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elevation_gain")]
        public float? ElevationGain { get; set; }

        /// <summary>
        /// The unique identifier of this route
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// The unique identifier of the route in string format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_str")]
        public string? IdStr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("map")]
        public global::Strava.PolylineMap? Map { get; set; }

        /// <summary>
        /// The name of this route
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether this route is private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// Whether this route is starred by the logged-in athlete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starred")]
        public bool? Starred { get; set; }

        /// <summary>
        /// An epoch timestamp of when the route was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public int? Timestamp { get; set; }

        /// <summary>
        /// This route's type (1 for ride, 2 for runs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// This route's sub-type (1 for road, 2 for mountain bike, 3 for cross, 4 for trail, 5 for mixed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_type")]
        public int? SubType { get; set; }

        /// <summary>
        /// The time at which the route was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The time at which the route was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Estimated time in seconds for the authenticated athlete to complete route
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_moving_time")]
        public int? EstimatedMovingTime { get; set; }

        /// <summary>
        /// The segments traversed by this route
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::Strava.SummarySegment>? Segments { get; set; }

        /// <summary>
        /// The custom waypoints along this route
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("waypoints")]
        public global::System.Collections.Generic.IList<global::Strava.Waypoint>? Waypoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Route" /> class.
        /// </summary>
        /// <param name="athlete"></param>
        /// <param name="description">
        /// The description of the route
        /// </param>
        /// <param name="distance">
        /// The route's distance, in meters
        /// </param>
        /// <param name="elevationGain">
        /// The route's elevation gain.
        /// </param>
        /// <param name="id">
        /// The unique identifier of this route
        /// </param>
        /// <param name="idStr">
        /// The unique identifier of the route in string format
        /// </param>
        /// <param name="map"></param>
        /// <param name="name">
        /// The name of this route
        /// </param>
        /// <param name="private">
        /// Whether this route is private
        /// </param>
        /// <param name="starred">
        /// Whether this route is starred by the logged-in athlete
        /// </param>
        /// <param name="timestamp">
        /// An epoch timestamp of when the route was created
        /// </param>
        /// <param name="type">
        /// This route's type (1 for ride, 2 for runs)
        /// </param>
        /// <param name="subType">
        /// This route's sub-type (1 for road, 2 for mountain bike, 3 for cross, 4 for trail, 5 for mixed)
        /// </param>
        /// <param name="createdAt">
        /// The time at which the route was created
        /// </param>
        /// <param name="updatedAt">
        /// The time at which the route was last updated
        /// </param>
        /// <param name="estimatedMovingTime">
        /// Estimated time in seconds for the authenticated athlete to complete route
        /// </param>
        /// <param name="segments">
        /// The segments traversed by this route
        /// </param>
        /// <param name="waypoints">
        /// The custom waypoints along this route
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Route(
            global::Strava.SummaryAthlete? athlete,
            string? description,
            float? distance,
            float? elevationGain,
            long? id,
            string? idStr,
            global::Strava.PolylineMap? map,
            string? name,
            bool? @private,
            bool? starred,
            int? timestamp,
            int? type,
            int? subType,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            int? estimatedMovingTime,
            global::System.Collections.Generic.IList<global::Strava.SummarySegment>? segments,
            global::System.Collections.Generic.IList<global::Strava.Waypoint>? waypoints)
        {
            this.Athlete = athlete;
            this.Description = description;
            this.Distance = distance;
            this.ElevationGain = elevationGain;
            this.Id = id;
            this.IdStr = idStr;
            this.Map = map;
            this.Name = name;
            this.Private = @private;
            this.Starred = starred;
            this.Timestamp = timestamp;
            this.Type = type;
            this.SubType = subType;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.EstimatedMovingTime = estimatedMovingTime;
            this.Segments = segments;
            this.Waypoints = waypoints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Route" /> class.
        /// </summary>
        public Route()
        {
        }

    }
}