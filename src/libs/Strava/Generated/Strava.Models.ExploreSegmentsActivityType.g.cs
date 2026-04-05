
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExploreSegmentsActivityType
    {
        /// <summary>
        /// 
        /// </summary>
        Riding,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExploreSegmentsActivityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExploreSegmentsActivityType value)
        {
            return value switch
            {
                ExploreSegmentsActivityType.Riding => "riding",
                ExploreSegmentsActivityType.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExploreSegmentsActivityType? ToEnum(string value)
        {
            return value switch
            {
                "riding" => ExploreSegmentsActivityType.Riding,
                "running" => ExploreSegmentsActivityType.Running,
                _ => null,
            };
        }
    }
}