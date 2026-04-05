
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetailedGearVariant2
    {
        /// <summary>
        /// The gear's brand name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brand_name")]
        public string? BrandName { get; set; }

        /// <summary>
        /// The gear's model name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// The gear's frame type (bike only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_type")]
        public int? FrameType { get; set; }

        /// <summary>
        /// The gear's description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedGearVariant2" /> class.
        /// </summary>
        /// <param name="brandName">
        /// The gear's brand name.
        /// </param>
        /// <param name="modelName">
        /// The gear's model name.
        /// </param>
        /// <param name="frameType">
        /// The gear's frame type (bike only).
        /// </param>
        /// <param name="description">
        /// The gear's description.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetailedGearVariant2(
            string? brandName,
            string? modelName,
            int? frameType,
            string? description)
        {
            this.BrandName = brandName;
            this.ModelName = modelName;
            this.FrameType = frameType;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedGearVariant2" /> class.
        /// </summary>
        public DetailedGearVariant2()
        {
        }
    }
}