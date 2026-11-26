#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IJwtMappingsClient
    {
        /// <summary>
        /// Update Jwt Key Mapping
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.JWTKeyMappingResponse> UpdateJwtKeyMappingJwtKeyMappingUpdatePostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.UpdateJWTKeyMappingRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Jwt Key Mapping
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.JWTKeyMappingResponse>> UpdateJwtKeyMappingJwtKeyMappingUpdatePostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.UpdateJWTKeyMappingRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Jwt Key Mapping
        /// </summary>
        /// <param name="description"></param>
        /// <param name="id"></param>
        /// <param name="isActive"></param>
        /// <param name="jwtIssuer"></param>
        /// <param name="key"></param>
        /// <param name="token"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.JWTKeyMappingResponse> UpdateJwtKeyMappingJwtKeyMappingUpdatePostAsync(
            string id,
            string? description = default,
            bool? isActive = default,
            string? jwtIssuer = default,
            string? key = default,
            string? token = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}