
#nullable enable

namespace Strava
{
    /// <summary>
    /// The athlete's preferred unit system.
    /// </summary>
    public enum DetailedAthleteVariant2MeasurementPreference
    {
        /// <summary>
        /// 
        /// </summary>
        Feet,
        /// <summary>
        /// 
        /// </summary>
        Meters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetailedAthleteVariant2MeasurementPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetailedAthleteVariant2MeasurementPreference value)
        {
            return value switch
            {
                DetailedAthleteVariant2MeasurementPreference.Feet => "feet",
                DetailedAthleteVariant2MeasurementPreference.Meters => "meters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetailedAthleteVariant2MeasurementPreference? ToEnum(string value)
        {
            return value switch
            {
                "feet" => DetailedAthleteVariant2MeasurementPreference.Feet,
                "meters" => DetailedAthleteVariant2MeasurementPreference.Meters,
                _ => null,
            };
        }
    }
}