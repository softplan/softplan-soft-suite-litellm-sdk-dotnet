#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IJwtMappingsClient
    {
        /// <summary>
        /// List Jwt Key Mappings
        /// </summary>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Page size<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListJwtKeyMappingsJwtKeyMappingListGetAsync(
            int? page = default,
            int? size = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Jwt Key Mappings
        /// </summary>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Page size<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ListJwtKeyMappingsJwtKeyMappingListGetAsResponseAsync(
            int? page = default,
            int? size = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}