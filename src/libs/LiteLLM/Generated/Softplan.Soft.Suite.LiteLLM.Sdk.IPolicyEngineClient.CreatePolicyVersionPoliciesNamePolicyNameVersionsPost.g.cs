#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IPolicyEngineClient
    {
        /// <summary>
        /// Create Policy Version<br/>
        /// Create a new draft version of a policy. Copies all fields from the source.<br/>
        /// Source is current production if source_policy_id is not provided.
        /// </summary>
        /// <param name="policyName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyDBResponse> CreatePolicyVersionPoliciesNamePolicyNameVersionsPostAsync(
            string policyName,

            global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyVersionCreateRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Policy Version<br/>
        /// Create a new draft version of a policy. Copies all fields from the source.<br/>
        /// Source is current production if source_policy_id is not provided.
        /// </summary>
        /// <param name="policyName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyDBResponse>> CreatePolicyVersionPoliciesNamePolicyNameVersionsPostAsResponseAsync(
            string policyName,

            global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyVersionCreateRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Policy Version<br/>
        /// Create a new draft version of a policy. Copies all fields from the source.<br/>
        /// Source is current production if source_policy_id is not provided.
        /// </summary>
        /// <param name="policyName"></param>
        /// <param name="sourcePolicyId">
        /// Policy ID to clone from. If None, clone from current production version.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyDBResponse> CreatePolicyVersionPoliciesNamePolicyNameVersionsPostAsync(
            string policyName,
            string? sourcePolicyId = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}