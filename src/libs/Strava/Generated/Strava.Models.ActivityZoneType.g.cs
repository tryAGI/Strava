
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActivityZoneType
    {
        /// <summary>
        /// 
        /// </summary>
        Heartrate,
        /// <summary>
        /// 
        /// </summary>
        Power,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActivityZoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActivityZoneType value)
        {
            return value switch
            {
                ActivityZoneType.Heartrate => "heartrate",
                ActivityZoneType.Power => "power",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActivityZoneType? ToEnum(string value)
        {
            return value switch
            {
                "heartrate" => ActivityZoneType.Heartrate,
                "power" => ActivityZoneType.Power,
                _ => null,
            };
        }
    }
}