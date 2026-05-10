
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClubAthlete
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
        /// The athlete's last initial.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastname")]
        public string? Lastname { get; set; }

        /// <summary>
        /// The athlete's member status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member")]
        public string? Member { get; set; }

        /// <summary>
        /// Whether the athlete is a club admin.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("admin")]
        public bool? Admin { get; set; }

        /// <summary>
        /// Whether the athlete is club owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public bool? Owner { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClubAthlete" /> class.
        /// </summary>
        /// <param name="resourceState">
        /// Resource state, indicates level of detail. Possible values: 1 -&gt; "meta", 2 -&gt; "summary", 3 -&gt; "detail"
        /// </param>
        /// <param name="firstname">
        /// The athlete's first name.
        /// </param>
        /// <param name="lastname">
        /// The athlete's last initial.
        /// </param>
        /// <param name="member">
        /// The athlete's member status.
        /// </param>
        /// <param name="admin">
        /// Whether the athlete is a club admin.
        /// </param>
        /// <param name="owner">
        /// Whether the athlete is club owner.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClubAthlete(
            int? resourceState,
            string? firstname,
            string? lastname,
            string? member,
            bool? admin,
            bool? owner)
        {
            this.ResourceState = resourceState;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Member = member;
            this.Admin = admin;
            this.Owner = owner;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClubAthlete" /> class.
        /// </summary>
        public ClubAthlete()
        {
        }

    }
}