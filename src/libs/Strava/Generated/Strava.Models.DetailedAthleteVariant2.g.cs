
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetailedAthleteVariant2
    {
        /// <summary>
        /// The athlete's follower count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("follower_count")]
        public int? FollowerCount { get; set; }

        /// <summary>
        /// The athlete's friend count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("friend_count")]
        public int? FriendCount { get; set; }

        /// <summary>
        /// The athlete's preferred unit system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measurement_preference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.DetailedAthleteVariant2MeasurementPreferenceJsonConverter))]
        public global::Strava.DetailedAthleteVariant2MeasurementPreference? MeasurementPreference { get; set; }

        /// <summary>
        /// The athlete's FTP (Functional Threshold Power).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ftp")]
        public int? Ftp { get; set; }

        /// <summary>
        /// The athlete's weight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public float? Weight { get; set; }

        /// <summary>
        /// The athlete's clubs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clubs")]
        public global::System.Collections.Generic.IList<global::Strava.SummaryClub>? Clubs { get; set; }

        /// <summary>
        /// The athlete's bikes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bikes")]
        public global::System.Collections.Generic.IList<global::Strava.SummaryGear>? Bikes { get; set; }

        /// <summary>
        /// The athlete's shoes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shoes")]
        public global::System.Collections.Generic.IList<global::Strava.SummaryGear>? Shoes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedAthleteVariant2" /> class.
        /// </summary>
        /// <param name="followerCount">
        /// The athlete's follower count.
        /// </param>
        /// <param name="friendCount">
        /// The athlete's friend count.
        /// </param>
        /// <param name="measurementPreference">
        /// The athlete's preferred unit system.
        /// </param>
        /// <param name="ftp">
        /// The athlete's FTP (Functional Threshold Power).
        /// </param>
        /// <param name="weight">
        /// The athlete's weight.
        /// </param>
        /// <param name="clubs">
        /// The athlete's clubs.
        /// </param>
        /// <param name="bikes">
        /// The athlete's bikes.
        /// </param>
        /// <param name="shoes">
        /// The athlete's shoes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetailedAthleteVariant2(
            int? followerCount,
            int? friendCount,
            global::Strava.DetailedAthleteVariant2MeasurementPreference? measurementPreference,
            int? ftp,
            float? weight,
            global::System.Collections.Generic.IList<global::Strava.SummaryClub>? clubs,
            global::System.Collections.Generic.IList<global::Strava.SummaryGear>? bikes,
            global::System.Collections.Generic.IList<global::Strava.SummaryGear>? shoes)
        {
            this.FollowerCount = followerCount;
            this.FriendCount = friendCount;
            this.MeasurementPreference = measurementPreference;
            this.Ftp = ftp;
            this.Weight = weight;
            this.Clubs = clubs;
            this.Bikes = bikes;
            this.Shoes = shoes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedAthleteVariant2" /> class.
        /// </summary>
        public DetailedAthleteVariant2()
        {
        }
    }
}