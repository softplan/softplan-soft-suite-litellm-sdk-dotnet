#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IPoliciesClient
    {
        /// <summary>
        /// Get Policy Templates<br/>
        /// Get policy templates for the UI (pre-configured guardrail combinations).<br/>
        /// Fetches from GitHub with automatic fallback to local backup on failure.<br/>
        /// Set LITELLM_LOCAL_POLICY_TEMPLATES=true to skip GitHub and use local backup only.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<object>> GetPolicyTemplatesPolicyTemplatesGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Policy Templates<br/>
        /// Get policy templates for the UI (pre-configured guardrail combinations).<br/>
        /// Fetches from GitHub with automatic fallback to local backup on failure.<br/>
        /// Set LITELLM_LOCAL_POLICY_TEMPLATES=true to skip GitHub and use local backup only.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<object>>> GetPolicyTemplatesPolicyTemplatesGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}