#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IPolicyEngineClient
    {
        /// <summary>
        /// Get Policy<br/>
        /// Get a policy by ID.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/policies/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```
        /// </summary>
        /// <param name="policyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyDBResponse> GetPolicyPoliciesPolicyIdGetAsync(
            string policyId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Policy<br/>
        /// Get a policy by ID.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/policies/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```
        /// </summary>
        /// <param name="policyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyDBResponse>> GetPolicyPoliciesPolicyIdGetAsResponseAsync(
            string policyId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}