
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExplorerSegment
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
        /// The category of the climb [0, 5]. Higher is harder ie. 5 is Hors catégorie, 0 is uncategorized in climb_category. If climb_category = 5, climb_category_desc = HC. If climb_category = 2, climb_category_desc = 3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("climb_category")]
        public int? ClimbCategory { get; set; }

        /// <summary>
        /// The description for the category of the climb
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("climb_category_desc")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.ExplorerSegmentClimbCategoryDescJsonConverter))]
        public global::Strava.ExplorerSegmentClimbCategoryDesc? ClimbCategoryDesc { get; set; }

        /// <summary>
        /// The segment's average grade, in percents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_grade")]
        public float? AvgGrade { get; set; }

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
        /// The segments's evelation difference, in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elev_difference")]
        public float? ElevDifference { get; set; }

        /// <summary>
        /// The segment's distance, in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public float? Distance { get; set; }

        /// <summary>
        /// The polyline of the segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        public string? Points { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExplorerSegment" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of this segment
        /// </param>
        /// <param name="name">
        /// The name of this segment
        /// </param>
        /// <param name="climbCategory">
        /// The category of the climb [0, 5]. Higher is harder ie. 5 is Hors catégorie, 0 is uncategorized in climb_category. If climb_category = 5, climb_category_desc = HC. If climb_category = 2, climb_category_desc = 3.
        /// </param>
        /// <param name="climbCategoryDesc">
        /// The description for the category of the climb
        /// </param>
        /// <param name="avgGrade">
        /// The segment's average grade, in percents
        /// </param>
        /// <param name="startLatlng">
        /// A pair of latitude/longitude coordinates, represented as an array of 2 floating point numbers.
        /// </param>
        /// <param name="endLatlng">
        /// A pair of latitude/longitude coordinates, represented as an array of 2 floating point numbers.
        /// </param>
        /// <param name="elevDifference">
        /// The segments's evelation difference, in meters
        /// </param>
        /// <param name="distance">
        /// The segment's distance, in meters
        /// </param>
        /// <param name="points">
        /// The polyline of the segment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExplorerSegment(
            long? id,
            string? name,
            int? climbCategory,
            global::Strava.ExplorerSegmentClimbCategoryDesc? climbCategoryDesc,
            float? avgGrade,
            global::System.Collections.Generic.IList<float>? startLatlng,
            global::System.Collections.Generic.IList<float>? endLatlng,
            float? elevDifference,
            float? distance,
            string? points)
        {
            this.Id = id;
            this.Name = name;
            this.ClimbCategory = climbCategory;
            this.ClimbCategoryDesc = climbCategoryDesc;
            this.AvgGrade = avgGrade;
            this.StartLatlng = startLatlng;
            this.EndLatlng = endLatlng;
            this.ElevDifference = elevDifference;
            this.Distance = distance;
            this.Points = points;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExplorerSegment" /> class.
        /// </summary>
        public ExplorerSegment()
        {
        }

    }
}