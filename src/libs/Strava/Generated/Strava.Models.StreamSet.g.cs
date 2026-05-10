
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamSet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.TimeStreamJsonConverter))]
        public global::Strava.TimeStream? Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.DistanceStreamJsonConverter))]
        public global::Strava.DistanceStream? Distance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latlng")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.LatLngStreamJsonConverter))]
        public global::Strava.LatLngStream? Latlng { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("altitude")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.AltitudeStreamJsonConverter))]
        public global::Strava.AltitudeStream? Altitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("velocity_smooth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.SmoothVelocityStreamJsonConverter))]
        public global::Strava.SmoothVelocityStream? VelocitySmooth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heartrate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.HeartrateStreamJsonConverter))]
        public global::Strava.HeartrateStream? Heartrate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cadence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.CadenceStreamJsonConverter))]
        public global::Strava.CadenceStream? Cadence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.PowerStreamJsonConverter))]
        public global::Strava.PowerStream? Watts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.TemperatureStreamJsonConverter))]
        public global::Strava.TemperatureStream? Temp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moving")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.MovingStreamJsonConverter))]
        public global::Strava.MovingStream? Moving { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grade_smooth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.SmoothGradeStreamJsonConverter))]
        public global::Strava.SmoothGradeStream? GradeSmooth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamSet" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="distance"></param>
        /// <param name="latlng"></param>
        /// <param name="altitude"></param>
        /// <param name="velocitySmooth"></param>
        /// <param name="heartrate"></param>
        /// <param name="cadence"></param>
        /// <param name="watts"></param>
        /// <param name="temp"></param>
        /// <param name="moving"></param>
        /// <param name="gradeSmooth"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamSet(
            global::Strava.TimeStream? time,
            global::Strava.DistanceStream? distance,
            global::Strava.LatLngStream? latlng,
            global::Strava.AltitudeStream? altitude,
            global::Strava.SmoothVelocityStream? velocitySmooth,
            global::Strava.HeartrateStream? heartrate,
            global::Strava.CadenceStream? cadence,
            global::Strava.PowerStream? watts,
            global::Strava.TemperatureStream? temp,
            global::Strava.MovingStream? moving,
            global::Strava.SmoothGradeStream? gradeSmooth)
        {
            this.Time = time;
            this.Distance = distance;
            this.Latlng = latlng;
            this.Altitude = altitude;
            this.VelocitySmooth = velocitySmooth;
            this.Heartrate = heartrate;
            this.Cadence = cadence;
            this.Watts = watts;
            this.Temp = temp;
            this.Moving = moving;
            this.GradeSmooth = gradeSmooth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamSet" /> class.
        /// </summary>
        public StreamSet()
        {
        }

    }
}