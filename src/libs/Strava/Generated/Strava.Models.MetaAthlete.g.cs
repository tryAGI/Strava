
#nullable enable

namespace Strava
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MetaAthlete
    {
        /// <summary>
        /// The unique identifier of the athlete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// The unique identifier of the upload in string format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_str")]
        public string? IdStr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaAthlete" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the athlete
        /// </param>
        /// <param name="idStr">
        /// The unique identifier of the upload in string format
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetaAthlete(
            long? id,
            string? idStr)
        {
            this.Id = id;
            this.IdStr = idStr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaAthlete" /> class.
        /// </summary>
        public MetaAthlete()
        {
        }

    }
}