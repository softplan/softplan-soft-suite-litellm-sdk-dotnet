#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IConfigOverridesClient
    {
        /// <summary>
        /// Get Cyberark Config<br/>
        /// Get current CyberArk Conjur configuration.<br/>
        /// Returns decrypted values from DB, or falls back to current env vars.<br/>
        /// Sensitive fields are masked before leaving the server.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.ConfigOverrideSettingsResponse> GetCyberarkConfigConfigOverridesCyberarkGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Cyberark Config<br/>
        /// Get current CyberArk Conjur configuration.<br/>
        /// Returns decrypted values from DB, or falls back to current env vars.<br/>
        /// Sensitive fields are masked before leaving the server.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.ConfigOverrideSettingsResponse>> GetCyberarkConfigConfigOverridesCyberarkGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}