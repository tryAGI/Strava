
#nullable enable

namespace Strava
{
    /// <summary>
    /// Activity tags to set, keyed by tag name with a boolean value (true to add, false to remove). Only the tags you include are changed; any tag you omit — and every other tag on the activity — is left unchanged. Any tag outside the supported set is rejected. Commute is set here rather than via the legacy commute param, and the two cannot be combined in the same request.
    /// </summary>
    public sealed partial class UpdatableActivityTags
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("WithPet")]
        public bool? WithPet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Recovery")]
        public bool? Recovery { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Competition")]
        public bool? Competition { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ForACause")]
        public bool? ForACause { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Commute")]
        public bool? Commute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatableActivityTags" /> class.
        /// </summary>
        /// <param name="withPet"></param>
        /// <param name="recovery"></param>
        /// <param name="competition"></param>
        /// <param name="forACause"></param>
        /// <param name="commute"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatableActivityTags(
            bool? withPet,
            bool? recovery,
            bool? competition,
            bool? forACause,
            bool? commute)
        {
            this.WithPet = withPet;
            this.Recovery = recovery;
            this.Competition = competition;
            this.ForACause = forACause;
            this.Commute = commute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatableActivityTags" /> class.
        /// </summary>
        public UpdatableActivityTags()
        {
        }

    }
}