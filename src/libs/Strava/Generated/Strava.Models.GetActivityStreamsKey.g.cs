
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetActivityStreamsKey
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
    public static class GetActivityStreamsKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetActivityStreamsKey value)
        {
            return value switch
            {
                GetActivityStreamsKey.Altitude => "altitude",
                GetActivityStreamsKey.Cadence => "cadence",
                GetActivityStreamsKey.Distance => "distance",
                GetActivityStreamsKey.GradeSmooth => "grade_smooth",
                GetActivityStreamsKey.Heartrate => "heartrate",
                GetActivityStreamsKey.Latlng => "latlng",
                GetActivityStreamsKey.Moving => "moving",
                GetActivityStreamsKey.Temp => "temp",
                GetActivityStreamsKey.Time => "time",
                GetActivityStreamsKey.VelocitySmooth => "velocity_smooth",
                GetActivityStreamsKey.Watts => "watts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetActivityStreamsKey? ToEnum(string value)
        {
            return value switch
            {
                "altitude" => GetActivityStreamsKey.Altitude,
                "cadence" => GetActivityStreamsKey.Cadence,
                "distance" => GetActivityStreamsKey.Distance,
                "grade_smooth" => GetActivityStreamsKey.GradeSmooth,
                "heartrate" => GetActivityStreamsKey.Heartrate,
                "latlng" => GetActivityStreamsKey.Latlng,
                "moving" => GetActivityStreamsKey.Moving,
                "temp" => GetActivityStreamsKey.Temp,
                "time" => GetActivityStreamsKey.Time,
                "velocity_smooth" => GetActivityStreamsKey.VelocitySmooth,
                "watts" => GetActivityStreamsKey.Watts,
                _ => null,
            };
        }
    }
}