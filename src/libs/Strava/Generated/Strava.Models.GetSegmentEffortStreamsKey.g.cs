
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSegmentEffortStreamsKey
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
    public static class GetSegmentEffortStreamsKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSegmentEffortStreamsKey value)
        {
            return value switch
            {
                GetSegmentEffortStreamsKey.Altitude => "altitude",
                GetSegmentEffortStreamsKey.Cadence => "cadence",
                GetSegmentEffortStreamsKey.Distance => "distance",
                GetSegmentEffortStreamsKey.GradeSmooth => "grade_smooth",
                GetSegmentEffortStreamsKey.Heartrate => "heartrate",
                GetSegmentEffortStreamsKey.Latlng => "latlng",
                GetSegmentEffortStreamsKey.Moving => "moving",
                GetSegmentEffortStreamsKey.Temp => "temp",
                GetSegmentEffortStreamsKey.Time => "time",
                GetSegmentEffortStreamsKey.VelocitySmooth => "velocity_smooth",
                GetSegmentEffortStreamsKey.Watts => "watts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSegmentEffortStreamsKey? ToEnum(string value)
        {
            return value switch
            {
                "altitude" => GetSegmentEffortStreamsKey.Altitude,
                "cadence" => GetSegmentEffortStreamsKey.Cadence,
                "distance" => GetSegmentEffortStreamsKey.Distance,
                "grade_smooth" => GetSegmentEffortStreamsKey.GradeSmooth,
                "heartrate" => GetSegmentEffortStreamsKey.Heartrate,
                "latlng" => GetSegmentEffortStreamsKey.Latlng,
                "moving" => GetSegmentEffortStreamsKey.Moving,
                "temp" => GetSegmentEffortStreamsKey.Temp,
                "time" => GetSegmentEffortStreamsKey.Time,
                "velocity_smooth" => GetSegmentEffortStreamsKey.VelocitySmooth,
                "watts" => GetSegmentEffortStreamsKey.Watts,
                _ => null,
            };
        }
    }
}