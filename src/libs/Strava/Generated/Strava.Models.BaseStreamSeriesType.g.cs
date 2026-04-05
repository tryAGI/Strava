
#nullable enable

namespace Strava
{
    /// <summary>
    /// The base series used in the case the stream was downsampled
    /// </summary>
    public enum BaseStreamSeriesType
    {
        /// <summary>
        /// 
        /// </summary>
        Distance,
        /// <summary>
        /// 
        /// </summary>
        Time,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseStreamSeriesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseStreamSeriesType value)
        {
            return value switch
            {
                BaseStreamSeriesType.Distance => "distance",
                BaseStreamSeriesType.Time => "time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseStreamSeriesType? ToEnum(string value)
        {
            return value switch
            {
                "distance" => BaseStreamSeriesType.Distance,
                "time" => BaseStreamSeriesType.Time,
                _ => null,
            };
        }
    }
}