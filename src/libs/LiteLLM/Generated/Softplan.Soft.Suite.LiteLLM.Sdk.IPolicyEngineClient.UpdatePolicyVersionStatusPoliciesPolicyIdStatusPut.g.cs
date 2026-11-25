#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IPolicyEngineClient
    {
        /// <summary>
        /// Update Policy Version Status<br/>
        /// Update a policy version's status. Valid transitions:<br/>
        /// - draft -&gt; published<br/>
        /// - published -&gt; production (demotes current production to published)<br/>
        /// - production -&gt; published (demotes, policy becomes inactive)
        /// </summary>
        /// <param name="policyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyDBResponse> UpdatePolicyVersionStatusPoliciesPolicyIdStatusPutAsync(
            string policyId,

            global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyVersionStatusUpdateRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Policy Version Status<br/>
        /// Update a policy version's status. Valid transitions:<br/>
        /// - draft -&gt; published<br/>
        /// - published -&gt; production (demotes current production to published)<br/>
        /// - production -&gt; published (demotes, policy becomes inactive)
        /// </summary>
        /// <param name="policyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyDBResponse>> UpdatePolicyVersionStatusPoliciesPolicyIdStatusPutAsResponseAsync(
            string policyId,

            global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyVersionStatusUpdateRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Policy Version Status<br/>
        /// Update a policy version's status. Valid transitions:<br/>
        /// - draft -&gt; published<br/>
        /// - published -&gt; production (demotes current production to published)<br/>
        /// - production -&gt; published (demotes, policy becomes inactive)
        /// </summary>
        /// <param name="policyId"></param>
        /// <param name="versionStatus">
        /// New status: 'published' or 'production'.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyDBResponse> UpdatePolicyVersionStatusPoliciesPolicyIdStatusPutAsync(
            string policyId,
            string versionStatus,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}