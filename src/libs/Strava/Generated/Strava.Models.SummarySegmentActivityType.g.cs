
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public enum SummarySegmentActivityType
    {
        /// <summary>
        /// 
        /// </summary>
        Ride,
        /// <summary>
        /// 
        /// </summary>
        Run,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummarySegmentActivityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummarySegmentActivityType value)
        {
            return value switch
            {
                SummarySegmentActivityType.Ride => "Ride",
                SummarySegmentActivityType.Run => "Run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummarySegmentActivityType? ToEnum(string value)
        {
            return value switch
            {
                "Ride" => SummarySegmentActivityType.Ride,
                "Run" => SummarySegmentActivityType.Run,
                _ => null,
            };
        }
    }
}