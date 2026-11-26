#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IFallbackManagementClient
    {
        /// <summary>
        /// Get Fallback<br/>
        /// Get fallback configuration for a specific model.<br/>
        /// **Parameters:**<br/>
        /// - `model`: The model name to get fallbacks for<br/>
        /// - `fallback_type`: Type of fallback to retrieve (query parameter)<br/>
        /// **Example:**<br/>
        /// ```<br/>
        /// GET /fallback/gpt-3.5-turbo?fallback_type=general<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="fallbackType">
        /// Default Value: general
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.FallbackGetResponse> GetFallbackFallbackModelGetAsync(
            string model,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.GetFallbackFallbackModelGetFallbackType? fallbackType = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Fallback<br/>
        /// Get fallback configuration for a specific model.<br/>
        /// **Parameters:**<br/>
        /// - `model`: The model name to get fallbacks for<br/>
        /// - `fallback_type`: Type of fallback to retrieve (query parameter)<br/>
        /// **Example:**<br/>
        /// ```<br/>
        /// GET /fallback/gpt-3.5-turbo?fallback_type=general<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="fallbackType">
        /// Default Value: general
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.FallbackGetResponse>> GetFallbackFallbackModelGetAsResponseAsync(
            string model,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.GetFallbackFallbackModelGetFallbackType? fallbackType = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}