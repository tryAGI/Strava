
#nullable enable

namespace Strava
{
    /// <summary>
    /// An enumeration of the supported types of streams.
    /// </summary>
    public enum StreamType
    {
        /// <summary>
        /// 
        /// </summary>
        Altitude,
        /// <summary>
        /// 
        /// </summary>
        Cadence,
        /// <summary>
        /// 
        /// </summary>
        Distance,
        /// <summary>
        /// 
        /// </summary>
        GradeSmooth,
        /// <summary>
        /// 
        /// </summary>
        Heartrate,
        /// <summary>
        /// 
        /// </summary>
        Latlng,
        /// <summary>
        /// 
        /// </summary>
        Moving,
        /// <summary>
        /// 
        /// </summary>
        Temp,
        /// <summary>
        /// 
        /// </summary>
        Time,
        /// <summary>
        /// 
        /// </summary>
        VelocitySmooth,
        /// <summary>
        /// 
        /// </summary>
        Watts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamType value)
        {
            return value switch
            {
                StreamType.Altitude => "altitude",
                StreamType.Cadence => "cadence",
                StreamType.Distance => "distance",
                StreamType.GradeSmooth => "grade_smooth",
                StreamType.Heartrate => "heartrate",
                StreamType.Latlng => "latlng",
                StreamType.Moving => "moving",
                StreamType.Temp => "temp",
                StreamType.Time => "time",
                StreamType.VelocitySmooth => "velocity_smooth",
                StreamType.Watts => "watts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamType? ToEnum(string value)
        {
            return value switch
            {
                "altitude" => StreamType.Altitude,
                "cadence" => StreamType.Cadence,
                "distance" => StreamType.Distance,
                "grade_smooth" => StreamType.GradeSmooth,
                "heartrate" => StreamType.Heartrate,
                "latlng" => StreamType.Latlng,
                "moving" => StreamType.Moving,
                "temp" => StreamType.Temp,
                "time" => StreamType.Time,
                "velocity_smooth" => StreamType.VelocitySmooth,
                "watts" => StreamType.Watts,
                _ => null,
            };
        }
    }
}