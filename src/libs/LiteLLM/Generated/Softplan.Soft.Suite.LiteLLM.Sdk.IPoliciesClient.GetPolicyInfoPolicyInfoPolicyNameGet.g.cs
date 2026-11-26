#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IPoliciesClient
    {
        /// <summary>
        /// Get Policy Info<br/>
        /// Get detailed information about a specific policy.<br/>
        /// Returns:<br/>
        /// - Policy configuration<br/>
        /// - Resolved guardrails (after inheritance)<br/>
        /// - Inheritance chain
        /// </summary>
        /// <param name="policyName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyInfoResponse> GetPolicyInfoPolicyInfoPolicyNameGetAsync(
            string policyName,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Policy Info<br/>
        /// Get detailed information about a specific policy.<br/>
        /// Returns:<br/>
        /// - Policy configuration<br/>
        /// - Resolved guardrails (after inheritance)<br/>
        /// - Inheritance chain
        /// </summary>
        /// <param name="policyName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyInfoResponse>> GetPolicyInfoPolicyInfoPolicyNameGetAsResponseAsync(
            string policyName,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}