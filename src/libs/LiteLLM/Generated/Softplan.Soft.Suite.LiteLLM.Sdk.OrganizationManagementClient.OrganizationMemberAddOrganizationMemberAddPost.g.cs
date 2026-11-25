
#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial class OrganizationManagementClient
    {


        private static readonly global::Softplan.Soft.Suite.LiteLLM.Sdk.EndPointSecurityRequirement s_OrganizationMemberAddOrganizationMemberAddPostSecurityRequirement0 =
            new global::Softplan.Soft.Suite.LiteLLM.Sdk.EndPointSecurityRequirement
            {
                Authorizations = new global::Softplan.Soft.Suite.LiteLLM.Sdk.EndPointAuthorizationRequirement[]
                {                    new global::Softplan.Soft.Suite.LiteLLM.Sdk.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Softplan.Soft.Suite.LiteLLM.Sdk.EndPointSecurityRequirement[] s_OrganizationMemberAddOrganizationMemberAddPostSecurityRequirements =
            new global::Softplan.Soft.Suite.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_OrganizationMemberAddOrganizationMemberAddPostSecurityRequirement0,
            };
        partial void PrepareOrganizationMemberAddOrganizationMemberAddPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationMemberAddRequest request);
        partial void PrepareOrganizationMemberAddOrganizationMemberAddPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationMemberAddRequest request);
        partial void ProcessOrganizationMemberAddOrganizationMemberAddPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrganizationMemberAddOrganizationMemberAddPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Organization Member Add<br/>
        /// [BETA]<br/>
        /// Add new members (either via user_email or user_id) to an organization<br/>
        /// If user doesn't exist, new user row will also be added to User Table<br/>
        /// Only proxy_admin or org_admin of organization, allowed to access this endpoint.<br/>
        /// # Parameters:<br/>
        /// - organization_id: str (required)<br/>
        /// - member: Union[List[Member], Member] (required)<br/>
        ///     - role: Literal[LitellmUserRoles] (required)<br/>
        ///     - user_id: Optional[str]<br/>
        ///     - user_email: Optional[str]<br/>
        /// Note: Either user_id or user_email must be provided for each member.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -X POST 'http://0.0.0.0:4000/organization/member_add'     -H 'Authorization: Bearer sk-1234'     -H 'Content-Type: application/json'     -d '{<br/>
        ///     "organization_id": "45e3e396-ee08-4a61-a88e-16b3ce7e0849",<br/>
        ///     "member": {<br/>
        ///         "role": "internal_user",<br/>
        ///         "user_id": "krrish247652@berri.ai"<br/>
        ///     },<br/>
        ///     "max_budget_in_organization": 100.0<br/>
        /// }'<br/>
        /// ```<br/>
        /// The following is executed in this function:<br/>
        /// 1. Check if organization exists<br/>
        /// 2. Creates a new Internal User if the user_id or user_email is not found in LiteLLM_UserTable<br/>
        /// 3. Add Internal User to the `LiteLLM_OrganizationMembership` table
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationAddMemberResponse> OrganizationMemberAddOrganizationMemberAddPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationMemberAddRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await OrganizationMemberAddOrganizationMemberAddPostAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Organization Member Add<br/>
        /// [BETA]<br/>
        /// Add new members (either via user_email or user_id) to an organization<br/>
        /// If user doesn't exist, new user row will also be added to User Table<br/>
        /// Only proxy_admin or org_admin of organization, allowed to access this endpoint.<br/>
        /// # Parameters:<br/>
        /// - organization_id: str (required)<br/>
        /// - member: Union[List[Member], Member] (required)<br/>
        ///     - role: Literal[LitellmUserRoles] (required)<br/>
        ///     - user_id: Optional[str]<br/>
        ///     - user_email: Optional[str]<br/>
        /// Note: Either user_id or user_email must be provided for each member.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -X POST 'http://0.0.0.0:4000/organization/member_add'     -H 'Authorization: Bearer sk-1234'     -H 'Content-Type: application/json'     -d '{<br/>
        ///     "organization_id": "45e3e396-ee08-4a61-a88e-16b3ce7e0849",<br/>
        ///     "member": {<br/>
        ///         "role": "internal_user",<br/>
        ///         "user_id": "krrish247652@berri.ai"<br/>
        ///     },<br/>
        ///     "max_budget_in_organization": 100.0<br/>
        /// }'<br/>
        /// ```<br/>
        /// The following is executed in this function:<br/>
        /// 1. Check if organization exists<br/>
        /// 2. Creates a new Internal User if the user_id or user_email is not found in LiteLLM_UserTable<br/>
        /// 3. Add Internal User to the `LiteLLM_OrganizationMembership` table
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationAddMemberResponse>> OrganizationMemberAddOrganizationMemberAddPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationMemberAddRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOrganizationMemberAddOrganizationMemberAddPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Softplan.Soft.Suite.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_OrganizationMemberAddOrganizationMemberAddPostSecurityRequirements,
                operationName: "OrganizationMemberAddOrganizationMemberAddPostAsync");

            using var __timeoutCancellationTokenSource = global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Softplan.Soft.Suite.LiteLLM.Sdk.PathBuilder(
                                path: "/organization/member_add",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareOrganizationMemberAddOrganizationMemberAddPostRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OrganizationMemberAddOrganizationMemberAddPost",
                                methodName: "OrganizationMemberAddOrganizationMemberAddPostAsync",
                                pathTemplate: "\"/organization/member_add\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OrganizationMemberAddOrganizationMemberAddPost",
                                methodName: "OrganizationMemberAddOrganizationMemberAddPostAsync",
                                pathTemplate: "\"/organization/member_add\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OrganizationMemberAddOrganizationMemberAddPost",
                                methodName: "OrganizationMemberAddOrganizationMemberAddPostAsync",
                                pathTemplate: "\"/organization/member_add\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessOrganizationMemberAddOrganizationMemberAddPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OrganizationMemberAddOrganizationMemberAddPost",
                                methodName: "OrganizationMemberAddOrganizationMemberAddPostAsync",
                                pathTemplate: "\"/organization/member_add\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OrganizationMemberAddOrganizationMemberAddPost",
                                methodName: "OrganizationMemberAddOrganizationMemberAddPostAsync",
                                pathTemplate: "\"/organization/member_add\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::Softplan.Soft.Suite.LiteLLM.Sdk.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::Softplan.Soft.Suite.LiteLLM.Sdk.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::Softplan.Soft.Suite.LiteLLM.Sdk.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException<global::Softplan.Soft.Suite.LiteLLM.Sdk.HTTPValidationError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessOrganizationMemberAddOrganizationMemberAddPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationAddMemberResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationAddMemberResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationAddMemberResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationAddMemberResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Organization Member Add<br/>
        /// [BETA]<br/>
        /// Add new members (either via user_email or user_id) to an organization<br/>
        /// If user doesn't exist, new user row will also be added to User Table<br/>
        /// Only proxy_admin or org_admin of organization, allowed to access this endpoint.<br/>
        /// # Parameters:<br/>
        /// - organization_id: str (required)<br/>
        /// - member: Union[List[Member], Member] (required)<br/>
        ///     - role: Literal[LitellmUserRoles] (required)<br/>
        ///     - user_id: Optional[str]<br/>
        ///     - user_email: Optional[str]<br/>
        /// Note: Either user_id or user_email must be provided for each member.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -X POST 'http://0.0.0.0:4000/organization/member_add'     -H 'Authorization: Bearer sk-1234'     -H 'Content-Type: application/json'     -d '{<br/>
        ///     "organization_id": "45e3e396-ee08-4a61-a88e-16b3ce7e0849",<br/>
        ///     "member": {<br/>
        ///         "role": "internal_user",<br/>
        ///         "user_id": "krrish247652@berri.ai"<br/>
        ///     },<br/>
        ///     "max_budget_in_organization": 100.0<br/>
        /// }'<br/>
        /// ```<br/>
        /// The following is executed in this function:<br/>
        /// 1. Check if organization exists<br/>
        /// 2. Creates a new Internal User if the user_id or user_email is not found in LiteLLM_UserTable<br/>
        /// 3. Add Internal User to the `LiteLLM_OrganizationMembership` table
        /// </summary>
        /// <param name="member"></param>
        /// <param name="organizationId"></param>
        /// <param name="maxBudgetInOrganization"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationAddMemberResponse> OrganizationMemberAddOrganizationMemberAddPostAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.OrgMember>, global::Softplan.Soft.Suite.LiteLLM.Sdk.OrgMember> member,
            string organizationId,
            double? maxBudgetInOrganization = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationMemberAddRequest
            {
                Member = member,
                OrganizationId = organizationId,
                MaxBudgetInOrganization = maxBudgetInOrganization,
            };

            return await OrganizationMemberAddOrganizationMemberAddPostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}