
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetailedClubVariant2
    {
        /// <summary>
        /// The membership status of the logged-in athlete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membership")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.DetailedClubVariant2MembershipJsonConverter))]
        public global::Strava.DetailedClubVariant2Membership? Membership { get; set; }

        /// <summary>
        /// Whether the currently logged-in athlete is an administrator of this club.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("admin")]
        public bool? Admin { get; set; }

        /// <summary>
        /// Whether the currently logged-in athlete is the owner of this club.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public bool? Owner { get; set; }

        /// <summary>
        /// The number of athletes in the club that the logged-in athlete follows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("following_count")]
        public int? FollowingCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedClubVariant2" /> class.
        /// </summary>
        /// <param name="membership">
        /// The membership status of the logged-in athlete.
        /// </param>
        /// <param name="admin">
        /// Whether the currently logged-in athlete is an administrator of this club.
        /// </param>
        /// <param name="owner">
        /// Whether the currently logged-in athlete is the owner of this club.
        /// </param>
        /// <param name="followingCount">
        /// The number of athletes in the club that the logged-in athlete follows.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetailedClubVariant2(
            global::Strava.DetailedClubVariant2Membership? membership,
            bool? admin,
            bool? owner,
            int? followingCount)
        {
            this.Membership = membership;
            this.Admin = admin;
            this.Owner = owner;
            this.FollowingCount = followingCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedClubVariant2" /> class.
        /// </summary>
        public DetailedClubVariant2()
        {
        }
    }
}