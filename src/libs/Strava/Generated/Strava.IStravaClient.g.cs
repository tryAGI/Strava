
#nullable enable

namespace Strava
{
    /// <summary>
    /// The [Swagger Playground](https://developers.strava.com/playground) is the easiest way to familiarize yourself with the Strava API by submitting HTTP requests and observing the responses before you write any client code. It will show what a response will look like with different endpoints depending on the authorization scope you receive from your athletes. To use the Playground, go to https://www.strava.com/settings/api and change your “Authorization Callback Domain” to developers.strava.com. Please note, we only support Swagger 2.0. There is a known issue where you can only select one scope at a time. For more information, please check the section “client code” at https://developers.strava.com/docs.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IStravaClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Strava.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Strava.AutoSDKClientOptions Options { get; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public ActivitiesClient Activities { get; }

        /// <summary>
        /// 
        /// </summary>
        public AthletesClient Athletes { get; }

        /// <summary>
        /// 
        /// </summary>
        public ClubsClient Clubs { get; }

        /// <summary>
        /// 
        /// </summary>
        public GearsClient Gears { get; }

        /// <summary>
        /// 
        /// </summary>
        public RoutesClient Routes { get; }

        /// <summary>
        /// 
        /// </summary>
        public SegmentEffortsClient SegmentEfforts { get; }

        /// <summary>
        /// 
        /// </summary>
        public SegmentsClient Segments { get; }

        /// <summary>
        /// 
        /// </summary>
        public StreamsClient Streams { get; }

        /// <summary>
        /// 
        /// </summary>
        public UploadsClient Uploads { get; }

    }
}