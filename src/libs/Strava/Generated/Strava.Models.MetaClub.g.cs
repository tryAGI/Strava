
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetaClub
    {
        /// <summary>
        /// The club's unique identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Resource state, indicates level of detail. Possible values: 1 -&gt; "meta", 2 -&gt; "summary", 3 -&gt; "detail"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_state")]
        public int? ResourceState { get; set; }

        /// <summary>
        /// The club's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaClub" /> class.
        /// </summary>
        /// <param name="id">
        /// The club's unique identifier.
        /// </param>
        /// <param name="resourceState">
        /// Resource state, indicates level of detail. Possible values: 1 -&gt; "meta", 2 -&gt; "summary", 3 -&gt; "detail"
        /// </param>
        /// <param name="name">
        /// The club's name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetaClub(
            long? id,
            int? resourceState,
            string? name)
        {
            this.Id = id;
            this.ResourceState = resourceState;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaClub" /> class.
        /// </summary>
        public MetaClub()
        {
        }
    }
}