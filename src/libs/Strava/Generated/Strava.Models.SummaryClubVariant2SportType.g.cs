
#nullable enable

namespace Strava
{
    /// <summary>
    /// Deprecated. Prefer to use activity_types.
    /// </summary>
    public enum SummaryClubVariant2SportType
    {
        /// <summary>
        /// 
        /// </summary>
        Cycling,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Triathlon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummaryClubVariant2SportTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummaryClubVariant2SportType value)
        {
            return value switch
            {
                SummaryClubVariant2SportType.Cycling => "cycling",
                SummaryClubVariant2SportType.Other => "other",
                SummaryClubVariant2SportType.Running => "running",
                SummaryClubVariant2SportType.Triathlon => "triathlon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummaryClubVariant2SportType? ToEnum(string value)
        {
            return value switch
            {
                "cycling" => SummaryClubVariant2SportType.Cycling,
                "other" => SummaryClubVariant2SportType.Other,
                "running" => SummaryClubVariant2SportType.Running,
                "triathlon" => SummaryClubVariant2SportType.Triathlon,
                _ => null,
            };
        }
    }
}