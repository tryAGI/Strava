
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MembershipApplication
    {
        /// <summary>
        /// Whether the application for membership was successfully submitted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Whether the membership is currently active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// The membership status of this application
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membership")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.MembershipApplicationMembershipJsonConverter))]
        public global::Strava.MembershipApplicationMembership? Membership { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipApplication" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the application for membership was successfully submitted
        /// </param>
        /// <param name="active">
        /// Whether the membership is currently active
        /// </param>
        /// <param name="membership">
        /// The membership status of this application
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MembershipApplication(
            bool? success,
            bool? active,
            global::Strava.MembershipApplicationMembership? membership)
        {
            this.Success = success;
            this.Active = active;
            this.Membership = membership;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipApplication" /> class.
        /// </summary>
        public MembershipApplication()
        {
        }

    }
}