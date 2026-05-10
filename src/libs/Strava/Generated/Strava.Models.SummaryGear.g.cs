
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummaryGear
    {
        /// <summary>
        /// The gear's unique identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Resource state, indicates level of detail. Possible values: 2 -&gt; "summary", 3 -&gt; "detail"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_state")]
        public int? ResourceState { get; set; }

        /// <summary>
        /// Whether this gear's is the owner's default one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        public bool? Primary { get; set; }

        /// <summary>
        /// The gear's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The distance logged with this gear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public float? Distance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryGear" /> class.
        /// </summary>
        /// <param name="id">
        /// The gear's unique identifier.
        /// </param>
        /// <param name="resourceState">
        /// Resource state, indicates level of detail. Possible values: 2 -&gt; "summary", 3 -&gt; "detail"
        /// </param>
        /// <param name="primary">
        /// Whether this gear's is the owner's default one.
        /// </param>
        /// <param name="name">
        /// The gear's name.
        /// </param>
        /// <param name="distance">
        /// The distance logged with this gear.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummaryGear(
            string? id,
            int? resourceState,
            bool? primary,
            string? name,
            float? distance)
        {
            this.Id = id;
            this.ResourceState = resourceState;
            this.Primary = primary;
            this.Name = name;
            this.Distance = distance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryGear" /> class.
        /// </summary>
        public SummaryGear()
        {
        }

    }
}