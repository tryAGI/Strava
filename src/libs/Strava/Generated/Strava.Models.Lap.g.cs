
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Lap
    {
        /// <summary>
        /// The unique identifier of this lap
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity")]
        public global::Strava.MetaActivity? Activity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("athlete")]
        public global::Strava.MetaAthlete? Athlete { get; set; }

        /// <summary>
        /// The lap's average cadence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_cadence")]
        public float? AverageCadence { get; set; }

        /// <summary>
        /// The lap's average speed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_speed")]
        public float? AverageSpeed { get; set; }

        /// <summary>
        /// The lap's distance, in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public float? Distance { get; set; }

        /// <summary>
        /// The lap's elapsed time, in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elapsed_time")]
        public int? ElapsedTime { get; set; }

        /// <summary>
        /// The start index of this effort in its activity's stream
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// The end index of this effort in its activity's stream
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// The index of this lap in the activity it belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lap_index")]
        public int? LapIndex { get; set; }

        /// <summary>
        /// The maximum speed of this lat, in meters per second
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_speed")]
        public float? MaxSpeed { get; set; }

        /// <summary>
        /// The lap's moving time, in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moving_time")]
        public int? MovingTime { get; set; }

        /// <summary>
        /// The name of the lap
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The athlete's pace zone during this lap
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pace_zone")]
        public int? PaceZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split")]
        public int? Split { get; set; }

        /// <summary>
        /// The time at which the lap was started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// The time at which the lap was started in the local timezone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date_local")]
        public global::System.DateTime? StartDateLocal { get; set; }

        /// <summary>
        /// The elevation gain of this lap, in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_elevation_gain")]
        public float? TotalElevationGain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Lap" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of this lap
        /// </param>
        /// <param name="activity"></param>
        /// <param name="athlete"></param>
        /// <param name="averageCadence">
        /// The lap's average cadence
        /// </param>
        /// <param name="averageSpeed">
        /// The lap's average speed
        /// </param>
        /// <param name="distance">
        /// The lap's distance, in meters
        /// </param>
        /// <param name="elapsedTime">
        /// The lap's elapsed time, in seconds
        /// </param>
        /// <param name="startIndex">
        /// The start index of this effort in its activity's stream
        /// </param>
        /// <param name="endIndex">
        /// The end index of this effort in its activity's stream
        /// </param>
        /// <param name="lapIndex">
        /// The index of this lap in the activity it belongs to
        /// </param>
        /// <param name="maxSpeed">
        /// The maximum speed of this lat, in meters per second
        /// </param>
        /// <param name="movingTime">
        /// The lap's moving time, in seconds
        /// </param>
        /// <param name="name">
        /// The name of the lap
        /// </param>
        /// <param name="paceZone">
        /// The athlete's pace zone during this lap
        /// </param>
        /// <param name="split"></param>
        /// <param name="startDate">
        /// The time at which the lap was started.
        /// </param>
        /// <param name="startDateLocal">
        /// The time at which the lap was started in the local timezone.
        /// </param>
        /// <param name="totalElevationGain">
        /// The elevation gain of this lap, in meters
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Lap(
            long? id,
            global::Strava.MetaActivity? activity,
            global::Strava.MetaAthlete? athlete,
            float? averageCadence,
            float? averageSpeed,
            float? distance,
            int? elapsedTime,
            int? startIndex,
            int? endIndex,
            int? lapIndex,
            float? maxSpeed,
            int? movingTime,
            string? name,
            int? paceZone,
            int? split,
            global::System.DateTime? startDate,
            global::System.DateTime? startDateLocal,
            float? totalElevationGain)
        {
            this.Id = id;
            this.Activity = activity;
            this.Athlete = athlete;
            this.AverageCadence = averageCadence;
            this.AverageSpeed = averageSpeed;
            this.Distance = distance;
            this.ElapsedTime = elapsedTime;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.LapIndex = lapIndex;
            this.MaxSpeed = maxSpeed;
            this.MovingTime = movingTime;
            this.Name = name;
            this.PaceZone = paceZone;
            this.Split = split;
            this.StartDate = startDate;
            this.StartDateLocal = startDateLocal;
            this.TotalElevationGain = totalElevationGain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Lap" /> class.
        /// </summary>
        public Lap()
        {
        }
    }
}