
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummarySegment
    {
        /// <summary>
        /// The unique identifier of this segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// The name of this segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.SummarySegmentActivityTypeJsonConverter))]
        public global::Strava.SummarySegmentActivityType? ActivityType { get; set; }

        /// <summary>
        /// The segment's distance, in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public float? Distance { get; set; }

        /// <summary>
        /// The segment's average grade, in percents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_grade")]
        public float? AverageGrade { get; set; }

        /// <summary>
        /// The segments's maximum grade, in percents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum_grade")]
        public float? MaximumGrade { get; set; }

        /// <summary>
        /// The segments's highest elevation, in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elevation_high")]
        public float? ElevationHigh { get; set; }

        /// <summary>
        /// The segments's lowest elevation, in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elevation_low")]
        public float? ElevationLow { get; set; }

        /// <summary>
        /// A pair of latitude/longitude coordinates, represented as an array of 2 floating point numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_latlng")]
        public global::System.Collections.Generic.IList<float>? StartLatlng { get; set; }

        /// <summary>
        /// A pair of latitude/longitude coordinates, represented as an array of 2 floating point numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_latlng")]
        public global::System.Collections.Generic.IList<float>? EndLatlng { get; set; }

        /// <summary>
        /// The category of the climb [0, 5]. Higher is harder ie. 5 is Hors catégorie, 0 is uncategorized in climb_category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("climb_category")]
        public int? ClimbCategory { get; set; }

        /// <summary>
        /// The segments's city.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// The segments's state or geographical region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// The segment's country.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Whether this segment is private.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("athlete_pr_effort")]
        public global::Strava.SummaryPRSegmentEffort? AthletePrEffort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("athlete_segment_stats")]
        public global::Strava.SummarySegmentEffort? AthleteSegmentStats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarySegment" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of this segment
        /// </param>
        /// <param name="name">
        /// The name of this segment
        /// </param>
        /// <param name="activityType"></param>
        /// <param name="distance">
        /// The segment's distance, in meters
        /// </param>
        /// <param name="averageGrade">
        /// The segment's average grade, in percents
        /// </param>
        /// <param name="maximumGrade">
        /// The segments's maximum grade, in percents
        /// </param>
        /// <param name="elevationHigh">
        /// The segments's highest elevation, in meters
        /// </param>
        /// <param name="elevationLow">
        /// The segments's lowest elevation, in meters
        /// </param>
        /// <param name="startLatlng">
        /// A pair of latitude/longitude coordinates, represented as an array of 2 floating point numbers.
        /// </param>
        /// <param name="endLatlng">
        /// A pair of latitude/longitude coordinates, represented as an array of 2 floating point numbers.
        /// </param>
        /// <param name="climbCategory">
        /// The category of the climb [0, 5]. Higher is harder ie. 5 is Hors catégorie, 0 is uncategorized in climb_category.
        /// </param>
        /// <param name="city">
        /// The segments's city.
        /// </param>
        /// <param name="state">
        /// The segments's state or geographical region.
        /// </param>
        /// <param name="country">
        /// The segment's country.
        /// </param>
        /// <param name="private">
        /// Whether this segment is private.
        /// </param>
        /// <param name="athletePrEffort"></param>
        /// <param name="athleteSegmentStats"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummarySegment(
            long? id,
            string? name,
            global::Strava.SummarySegmentActivityType? activityType,
            float? distance,
            float? averageGrade,
            float? maximumGrade,
            float? elevationHigh,
            float? elevationLow,
            global::System.Collections.Generic.IList<float>? startLatlng,
            global::System.Collections.Generic.IList<float>? endLatlng,
            int? climbCategory,
            string? city,
            string? state,
            string? country,
            bool? @private,
            global::Strava.SummaryPRSegmentEffort? athletePrEffort,
            global::Strava.SummarySegmentEffort? athleteSegmentStats)
        {
            this.Id = id;
            this.Name = name;
            this.ActivityType = activityType;
            this.Distance = distance;
            this.AverageGrade = averageGrade;
            this.MaximumGrade = maximumGrade;
            this.ElevationHigh = elevationHigh;
            this.ElevationLow = elevationLow;
            this.StartLatlng = startLatlng;
            this.EndLatlng = endLatlng;
            this.ClimbCategory = climbCategory;
            this.City = city;
            this.State = state;
            this.Country = country;
            this.Private = @private;
            this.AthletePrEffort = athletePrEffort;
            this.AthleteSegmentStats = athleteSegmentStats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarySegment" /> class.
        /// </summary>
        public SummarySegment()
        {
        }

    }
}