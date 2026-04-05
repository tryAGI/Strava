
#nullable enable

namespace Strava
{
    /// <summary>
    /// The level of detail (sampling) in which this stream was returned
    /// </summary>
    public enum BaseStreamResolution
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseStreamResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseStreamResolution value)
        {
            return value switch
            {
                BaseStreamResolution.High => "high",
                BaseStreamResolution.Low => "low",
                BaseStreamResolution.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseStreamResolution? ToEnum(string value)
        {
            return value switch
            {
                "high" => BaseStreamResolution.High,
                "low" => BaseStreamResolution.Low,
                "medium" => BaseStreamResolution.Medium,
                _ => null,
            };
        }
    }
}