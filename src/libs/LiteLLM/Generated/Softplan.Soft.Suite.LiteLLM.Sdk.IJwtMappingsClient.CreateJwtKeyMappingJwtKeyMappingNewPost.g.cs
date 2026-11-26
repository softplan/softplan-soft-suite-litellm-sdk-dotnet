#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IJwtMappingsClient
    {
        /// <summary>
        /// Create Jwt Key Mapping
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.JWTKeyMappingResponse> CreateJwtKeyMappingJwtKeyMappingNewPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.CreateJWTKeyMappingRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Jwt Key Mapping
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.JWTKeyMappingResponse>> CreateJwtKeyMappingJwtKeyMappingNewPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.CreateJWTKeyMappingRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Jwt Key Mapping
        /// </summary>
        /// <param name="description"></param>
        /// <param name="jwtClaimName"></param>
        /// <param name="jwtClaimValue"></param>
        /// <param name="jwtIssuer"></param>
        /// <param name="key"></param>
        /// <param name="token"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.JWTKeyMappingResponse> CreateJwtKeyMappingJwtKeyMappingNewPostAsync(
            string jwtClaimName,
            string jwtClaimValue,
            string? description = default,
            string? jwtIssuer = default,
            string? key = default,
            string? token = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}