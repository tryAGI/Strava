
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummaryAthleteVariant2
    {
        /// <summary>
        /// Resource state, indicates level of detail. Possible values: 1 -&gt; "meta", 2 -&gt; "summary", 3 -&gt; "detail"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_state")]
        public int? ResourceState { get; set; }

        /// <summary>
        /// The athlete's first name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstname")]
        public string? Firstname { get; set; }

        /// <summary>
        /// The athlete's last name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastname")]
        public string? Lastname { get; set; }

        /// <summary>
        /// URL to a 62x62 pixel profile picture.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_medium")]
        public string? ProfileMedium { get; set; }

        /// <summary>
        /// URL to a 124x124 pixel profile picture.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        public string? Profile { get; set; }

        /// <summary>
        /// The athlete's city.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// The athlete's state or geographical region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// The athlete's country.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// The athlete's sex.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sex")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.SummaryAthleteVariant2SexJsonConverter))]
        public global::Strava.SummaryAthleteVariant2Sex? Sex { get; set; }

        /// <summary>
        /// Deprecated.  Use summit field instead. Whether the athlete has any Summit subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("premium")]
        public bool? Premium { get; set; }

        /// <summary>
        /// Whether the athlete has any Summit subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summit")]
        public bool? Summit { get; set; }

        /// <summary>
        /// The time at which the athlete was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The time at which the athlete was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryAthleteVariant2" /> class.
        /// </summary>
        /// <param name="resourceState">
        /// Resource state, indicates level of detail. Possible values: 1 -&gt; "meta", 2 -&gt; "summary", 3 -&gt; "detail"
        /// </param>
        /// <param name="firstname">
        /// The athlete's first name.
        /// </param>
        /// <param name="lastname">
        /// The athlete's last name.
        /// </param>
        /// <param name="profileMedium">
        /// URL to a 62x62 pixel profile picture.
        /// </param>
        /// <param name="profile">
        /// URL to a 124x124 pixel profile picture.
        /// </param>
        /// <param name="city">
        /// The athlete's city.
        /// </param>
        /// <param name="state">
        /// The athlete's state or geographical region.
        /// </param>
        /// <param name="country">
        /// The athlete's country.
        /// </param>
        /// <param name="sex">
        /// The athlete's sex.
        /// </param>
        /// <param name="premium">
        /// Deprecated.  Use summit field instead. Whether the athlete has any Summit subscription.
        /// </param>
        /// <param name="summit">
        /// Whether the athlete has any Summit subscription.
        /// </param>
        /// <param name="createdAt">
        /// The time at which the athlete was created.
        /// </param>
        /// <param name="updatedAt">
        /// The time at which the athlete was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummaryAthleteVariant2(
            int? resourceState,
            string? firstname,
            string? lastname,
            string? profileMedium,
            string? profile,
            string? city,
            string? state,
            string? country,
            global::Strava.SummaryAthleteVariant2Sex? sex,
            bool? premium,
            bool? summit,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.ResourceState = resourceState;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.ProfileMedium = profileMedium;
            this.Profile = profile;
            this.City = city;
            this.State = state;
            this.Country = country;
            this.Sex = sex;
            this.Premium = premium;
            this.Summit = summit;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryAthleteVariant2" /> class.
        /// </summary>
        public SummaryAthleteVariant2()
        {
        }

    }
}