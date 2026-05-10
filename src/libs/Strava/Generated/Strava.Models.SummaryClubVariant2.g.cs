
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummaryClubVariant2
    {
        /// <summary>
        /// URL to a 60x60 pixel profile picture.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_medium")]
        public string? ProfileMedium { get; set; }

        /// <summary>
        /// URL to a ~1185x580 pixel cover photo.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_photo")]
        public string? CoverPhoto { get; set; }

        /// <summary>
        /// URL to a ~360x176  pixel cover photo.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_photo_small")]
        public string? CoverPhotoSmall { get; set; }

        /// <summary>
        /// Deprecated. Prefer to use activity_types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sport_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.SummaryClubVariant2SportTypeJsonConverter))]
        public global::Strava.SummaryClubVariant2SportType? SportType { get; set; }

        /// <summary>
        /// The activity types that count for a club. This takes precedence over sport_type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_types")]
        public global::System.Collections.Generic.IList<global::Strava.ActivityType>? ActivityTypes { get; set; }

        /// <summary>
        /// The club's city.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// The club's state or geographical region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// The club's country.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Whether the club is private.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// The club's member count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_count")]
        public int? MemberCount { get; set; }

        /// <summary>
        /// Whether the club is featured or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featured")]
        public bool? Featured { get; set; }

        /// <summary>
        /// Whether the club is verified or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        public bool? Verified { get; set; }

        /// <summary>
        /// The club's vanity URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryClubVariant2" /> class.
        /// </summary>
        /// <param name="profileMedium">
        /// URL to a 60x60 pixel profile picture.
        /// </param>
        /// <param name="coverPhoto">
        /// URL to a ~1185x580 pixel cover photo.
        /// </param>
        /// <param name="coverPhotoSmall">
        /// URL to a ~360x176  pixel cover photo.
        /// </param>
        /// <param name="sportType">
        /// Deprecated. Prefer to use activity_types.
        /// </param>
        /// <param name="activityTypes">
        /// The activity types that count for a club. This takes precedence over sport_type.
        /// </param>
        /// <param name="city">
        /// The club's city.
        /// </param>
        /// <param name="state">
        /// The club's state or geographical region.
        /// </param>
        /// <param name="country">
        /// The club's country.
        /// </param>
        /// <param name="private">
        /// Whether the club is private.
        /// </param>
        /// <param name="memberCount">
        /// The club's member count.
        /// </param>
        /// <param name="featured">
        /// Whether the club is featured or not.
        /// </param>
        /// <param name="verified">
        /// Whether the club is verified or not.
        /// </param>
        /// <param name="url">
        /// The club's vanity URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummaryClubVariant2(
            string? profileMedium,
            string? coverPhoto,
            string? coverPhotoSmall,
            global::Strava.SummaryClubVariant2SportType? sportType,
            global::System.Collections.Generic.IList<global::Strava.ActivityType>? activityTypes,
            string? city,
            string? state,
            string? country,
            bool? @private,
            int? memberCount,
            bool? featured,
            bool? verified,
            string? url)
        {
            this.ProfileMedium = profileMedium;
            this.CoverPhoto = coverPhoto;
            this.CoverPhotoSmall = coverPhotoSmall;
            this.SportType = sportType;
            this.ActivityTypes = activityTypes;
            this.City = city;
            this.State = state;
            this.Country = country;
            this.Private = @private;
            this.MemberCount = memberCount;
            this.Featured = featured;
            this.Verified = verified;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryClubVariant2" /> class.
        /// </summary>
        public SummaryClubVariant2()
        {
        }

    }
}