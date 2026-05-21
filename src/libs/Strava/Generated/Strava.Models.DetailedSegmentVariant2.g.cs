
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetailedSegmentVariant2
    {
        /// <summary>
        /// The time at which the segment was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The time at which the segment was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The segment's total elevation gain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_elevation_gain")]
        public float? TotalElevationGain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("map")]
        public global::Strava.PolylineMap? Map { get; set; }

        /// <summary>
        /// The total number of efforts for this segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort_count")]
        public int? EffortCount { get; set; }

        /// <summary>
        /// The number of unique athletes who have an effort for this segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("athlete_count")]
        public int? AthleteCount { get; set; }

        /// <summary>
        /// Whether this segment is considered hazardous
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hazardous")]
        public bool? Hazardous { get; set; }

        /// <summary>
        /// The number of stars for this segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("star_count")]
        public int? StarCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedSegmentVariant2" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The time at which the segment was created.
        /// </param>
        /// <param name="updatedAt">
        /// The time at which the segment was last updated.
        /// </param>
        /// <param name="totalElevationGain">
        /// The segment's total elevation gain.
        /// </param>
        /// <param name="map"></param>
        /// <param name="effortCount">
        /// The total number of efforts for this segment
        /// </param>
        /// <param name="athleteCount">
        /// The number of unique athletes who have an effort for this segment
        /// </param>
        /// <param name="hazardous">
        /// Whether this segment is considered hazardous
        /// </param>
        /// <param name="starCount">
        /// The number of stars for this segment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetailedSegmentVariant2(
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            float? totalElevationGain,
            global::Strava.PolylineMap? map,
            int? effortCount,
            int? athleteCount,
            bool? hazardous,
            int? starCount)
        {
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.TotalElevationGain = totalElevationGain;
            this.Map = map;
            this.EffortCount = effortCount;
            this.AthleteCount = athleteCount;
            this.Hazardous = hazardous;
            this.StarCount = starCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedSegmentVariant2" /> class.
        /// </summary>
        public DetailedSegmentVariant2()
        {
        }

    }
}