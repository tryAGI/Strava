
#nullable enable

namespace Strava
{
    public partial class UploadsClient
    {


        private static readonly global::Strava.EndPointSecurityRequirement s_CreateUploadSecurityRequirement0 =
            new global::Strava.EndPointSecurityRequirement
            {
                Authorizations = new global::Strava.EndPointAuthorizationRequirement[]
                {                    new global::Strava.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Strava.EndPointSecurityRequirement[] s_CreateUploadSecurityRequirements =
            new global::Strava.EndPointSecurityRequirement[]
            {                s_CreateUploadSecurityRequirement0,
            };
        partial void PrepareCreateUploadArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Strava.CreateUploadRequest request);
        partial void PrepareCreateUploadRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Strava.CreateUploadRequest request);
        partial void ProcessCreateUploadResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateUploadResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload Activity<br/>
        /// Uploads a new data file to create an activity from. Requires activity:write scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Strava.Upload> CreateUploadAsync(

            global::Strava.CreateUploadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateUploadArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Strava.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateUploadSecurityRequirements,
                operationName: "CreateUploadAsync");

            var __pathBuilder = new global::Strava.PathBuilder(
                path: "/uploads",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (request.File != default)
            {

                var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentFile,
                    name: "\"file\"",
                    fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
                if (__contentFile.Headers.ContentDisposition != null)
                {
                    __contentFile.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.Name != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Name}"),
                    name: "\"name\"");
            } 
            if (request.Description != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Description}"),
                    name: "\"description\"");
            } 
            if (request.Trainer != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Trainer}"),
                    name: "\"trainer\"");
            } 
            if (request.Commute != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Commute}"),
                    name: "\"commute\"");
            } 
            if (request.DataType != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DataType?.ToValueString()}"),
                    name: "\"data_type\"");
            } 
            if (request.ExternalId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ExternalId}"),
                    name: "\"external_id\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateUploadRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateUploadResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Unexpected error.
            if (!__response.IsSuccessStatusCode)
            {
                string? __content_default = null;
                global::System.Exception? __exception_default = null;
                global::Strava.Fault? __value_default = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_default = global::Strava.Fault.FromJson(__content_default, JsonSerializerContext);
                    }
                    else
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_default = global::Strava.Fault.FromJson(__content_default, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_default = __ex;
                }

                throw new global::Strava.ApiException<global::Strava.Fault>(
                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_default,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_default,
                    ResponseObject = __value_default,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateUploadResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Strava.Upload.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Strava.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Strava.Upload.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Strava.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Upload Activity<br/>
        /// Uploads a new data file to create an activity from. Requires activity:write scope.
        /// </summary>
        /// <param name="file">
        /// The uploaded file.
        /// </param>
        /// <param name="filename">
        /// The uploaded file.
        /// </param>
        /// <param name="name">
        /// The desired name of the resulting activity.
        /// </param>
        /// <param name="description">
        /// The desired description of the resulting activity.
        /// </param>
        /// <param name="trainer">
        /// Whether the resulting activity should be marked as having been performed on a trainer.
        /// </param>
        /// <param name="commute">
        /// Whether the resulting activity should be tagged as a commute.
        /// </param>
        /// <param name="dataType">
        /// The format of the uploaded file.
        /// </param>
        /// <param name="externalId">
        /// The desired external identifier of the resulting activity.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Strava.Upload> CreateUploadAsync(
            byte[]? file = default,
            string? filename = default,
            string? name = default,
            string? description = default,
            string? trainer = default,
            string? commute = default,
            global::Strava.CreateUploadRequestDataType? dataType = default,
            string? externalId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Strava.CreateUploadRequest
            {
                File = file,
                Filename = filename,
                Name = name,
                Description = description,
                Trainer = trainer,
                Commute = commute,
                DataType = dataType,
                ExternalId = externalId,
            };

            return await CreateUploadAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}