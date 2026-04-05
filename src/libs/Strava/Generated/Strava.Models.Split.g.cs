
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Split
    {
        /// <summary>
        /// The average speed of this split, in meters per second
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_speed")]
        public float? AverageSpeed { get; set; }

        /// <summary>
        /// The distance of this split, in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public float? Distance { get; set; }

        /// <summary>
        /// The elapsed time of this split, in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elapsed_time")]
        public int? ElapsedTime { get; set; }

        /// <summary>
        /// The elevation difference of this split, in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elevation_difference")]
        public float? ElevationDifference { get; set; }

        /// <summary>
        /// The pacing zone of this split
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pace_zone")]
        public int? PaceZone { get; set; }

        /// <summary>
        /// The moving time of this split, in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moving_time")]
        public int? MovingTime { get; set; }

        /// <summary>
        /// N/A
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split")]
        public int? Split1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Split" /> class.
        /// </summary>
        /// <param name="averageSpeed">
        /// The average speed of this split, in meters per second
        /// </param>
        /// <param name="distance">
        /// The distance of this split, in meters
        /// </param>
        /// <param name="elapsedTime">
        /// The elapsed time of this split, in seconds
        /// </param>
        /// <param name="elevationDifference">
        /// The elevation difference of this split, in meters
        /// </param>
        /// <param name="paceZone">
        /// The pacing zone of this split
        /// </param>
        /// <param name="movingTime">
        /// The moving time of this split, in seconds
        /// </param>
        /// <param name="split1">
        /// N/A
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Split(
            float? averageSpeed,
            float? distance,
            int? elapsedTime,
            float? elevationDifference,
            int? paceZone,
            int? movingTime,
            int? split1)
        {
            this.AverageSpeed = averageSpeed;
            this.Distance = distance;
            this.ElapsedTime = elapsedTime;
            this.ElevationDifference = elevationDifference;
            this.PaceZone = paceZone;
            this.MovingTime = movingTime;
            this.Split1 = split1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Split" /> class.
        /// </summary>
        public Split()
        {
        }
    }
}