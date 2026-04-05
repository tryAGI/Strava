
#nullable enable

namespace Strava
{
    /// <summary>
    /// The athlete's sex.
    /// </summary>
    public enum SummaryAthleteVariant2Sex
    {
        /// <summary>
        /// 
        /// </summary>
        F,
        /// <summary>
        /// 
        /// </summary>
        M,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummaryAthleteVariant2SexExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummaryAthleteVariant2Sex value)
        {
            return value switch
            {
                SummaryAthleteVariant2Sex.F => "F",
                SummaryAthleteVariant2Sex.M => "M",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummaryAthleteVariant2Sex? ToEnum(string value)
        {
            return value switch
            {
                "F" => SummaryAthleteVariant2Sex.F,
                "M" => SummaryAthleteVariant2Sex.M,
                _ => null,
            };
        }
    }
}