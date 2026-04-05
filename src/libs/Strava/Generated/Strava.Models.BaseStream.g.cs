
#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseStream
    {
        /// <summary>
        /// The number of data points in this stream
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_size")]
        public int? OriginalSize { get; set; }

        /// <summary>
        /// The level of detail (sampling) in which this stream was returned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.BaseStreamResolutionJsonConverter))]
        public global::Strava.BaseStreamResolution? Resolution { get; set; }

        /// <summary>
        /// The base series used in the case the stream was downsampled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Strava.JsonConverters.BaseStreamSeriesTypeJsonConverter))]
        public global::Strava.BaseStreamSeriesType? SeriesType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseStream" /> class.
        /// </summary>
        /// <param name="originalSize">
        /// The number of data points in this stream
        /// </param>
        /// <param name="resolution">
        /// The level of detail (sampling) in which this stream was returned
        /// </param>
        /// <param name="seriesType">
        /// The base series used in the case the stream was downsampled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseStream(
            int? originalSize,
            global::Strava.BaseStreamResolution? resolution,
            global::Strava.BaseStreamSeriesType? seriesType)
        {
            this.OriginalSize = originalSize;
            this.Resolution = resolution;
            this.SeriesType = seriesType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseStream" /> class.
        /// </summary>
        public BaseStream()
        {
        }
    }
}