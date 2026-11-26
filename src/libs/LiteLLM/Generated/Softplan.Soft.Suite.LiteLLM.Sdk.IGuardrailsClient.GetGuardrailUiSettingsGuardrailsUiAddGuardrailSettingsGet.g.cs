#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Get Guardrail Ui Settings<br/>
        /// Get the UI settings for the guardrails<br/>
        /// Returns:<br/>
        /// - Supported entities for guardrails<br/>
        /// - Supported modes for guardrails<br/>
        /// - PII entity categories for UI organization<br/>
        /// - Content filter settings (patterns and categories)
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetGuardrailUiSettingsGuardrailsUiAddGuardrailSettingsGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Guardrail Ui Settings<br/>
        /// Get the UI settings for the guardrails<br/>
        /// Returns:<br/>
        /// - Supported entities for guardrails<br/>
        /// - Supported modes for guardrails<br/>
        /// - PII entity categories for UI organization<br/>
        /// - Content filter settings (patterns and categories)
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetGuardrailUiSettingsGuardrailsUiAddGuardrailSettingsGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}