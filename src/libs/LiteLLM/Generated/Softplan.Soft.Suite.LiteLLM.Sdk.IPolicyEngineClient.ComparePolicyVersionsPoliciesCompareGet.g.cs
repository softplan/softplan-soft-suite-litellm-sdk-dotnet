#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IPolicyEngineClient
    {
        /// <summary>
        /// Compare Policy Versions<br/>
        /// Compare two policy versions. Query params: version_a, version_b (policy version IDs).
        /// </summary>
        /// <param name="versionA"></param>
        /// <param name="versionB"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyVersionCompareResponse> ComparePolicyVersionsPoliciesCompareGetAsync(
            string versionA,
            string versionB,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compare Policy Versions<br/>
        /// Compare two policy versions. Query params: version_a, version_b (policy version IDs).
        /// </summary>
        /// <param name="versionA"></param>
        /// <param name="versionB"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyVersionCompareResponse>> ComparePolicyVersionsPoliciesCompareGetAsResponseAsync(
            string versionA,
            string versionB,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}