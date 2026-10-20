
#nullable enable

namespace Strava
{
    /// <summary>
    ///
    /// </summary>
    public enum SummaryActivityVariant2Tag
    {
        /// <summary>
        ///
        /// </summary>
        Commute,
        /// <summary>
        ///
        /// </summary>
        Competition,
        /// <summary>
        ///
        /// </summary>
        ForACause,
        /// <summary>
        ///
        /// </summary>
        Recovery,
        /// <summary>
        ///
        /// </summary>
        WithPet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummaryActivityVariant2TagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummaryActivityVariant2Tag value)
        {
            return value switch
            {
                SummaryActivityVariant2Tag.Commute => "Commute",
                SummaryActivityVariant2Tag.Competition => "Competition",
                SummaryActivityVariant2Tag.ForACause => "ForACause",
                SummaryActivityVariant2Tag.Recovery => "Recovery",
                SummaryActivityVariant2Tag.WithPet => "WithPet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummaryActivityVariant2Tag? ToEnum(string value)
        {
            return value switch
            {
                "Commute" => SummaryActivityVariant2Tag.Commute,
                "Competition" => SummaryActivityVariant2Tag.Competition,
                "ForACause" => SummaryActivityVariant2Tag.ForACause,
                "Recovery" => SummaryActivityVariant2Tag.Recovery,
                "WithPet" => SummaryActivityVariant2Tag.WithPet,
                _ => null,
            };
        }
    }
}