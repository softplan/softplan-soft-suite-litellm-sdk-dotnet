#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ICacheSettingsClient
    {
        /// <summary>
        /// Get Cache Settings<br/>
        /// Get cache configuration and available settings.<br/>
        /// Returns:<br/>
        /// - fields: List of all configurable cache settings with their metadata (type, description, default, options)<br/>
        /// - current_values: Current values of cache settings from database
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.CacheSettingsResponse> GetCacheSettingsCacheSettingsGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Cache Settings<br/>
        /// Get cache configuration and available settings.<br/>
        /// Returns:<br/>
        /// - fields: List of all configurable cache settings with their metadata (type, description, default, options)<br/>
        /// - current_values: Current values of cache settings from database
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.CacheSettingsResponse>> GetCacheSettingsCacheSettingsGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}