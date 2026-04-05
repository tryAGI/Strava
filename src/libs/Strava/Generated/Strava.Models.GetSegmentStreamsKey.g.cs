
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSegmentStreamsKey
    {
        /// <summary>
        /// 
        /// </summary>
        Altitude,
        /// <summary>
        /// 
        /// </summary>
        Distance,
        /// <summary>
        /// 
        /// </summary>
        Latlng,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSegmentStreamsKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSegmentStreamsKey value)
        {
            return value switch
            {
                GetSegmentStreamsKey.Altitude => "altitude",
                GetSegmentStreamsKey.Distance => "distance",
                GetSegmentStreamsKey.Latlng => "latlng",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSegmentStreamsKey? ToEnum(string value)
        {
            return value switch
            {
                "altitude" => GetSegmentStreamsKey.Altitude,
                "distance" => GetSegmentStreamsKey.Distance,
                "latlng" => GetSegmentStreamsKey.Latlng,
                _ => null,
            };
        }
    }
}