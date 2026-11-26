#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Policies Usage Overview<br/>
        /// Return policy performance overview for the dashboard.
        /// </summary>
        /// <param name="startDate">
        /// YYYY-MM-DD
        /// </param>
        /// <param name="endDate">
        /// YYYY-MM-DD
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.UsageOverviewResponse> PoliciesUsageOverviewPoliciesUsageOverviewGetAsync(
            string? startDate = default,
            string? endDate = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Policies Usage Overview<br/>
        /// Return policy performance overview for the dashboard.
        /// </summary>
        /// <param name="startDate">
        /// YYYY-MM-DD
        /// </param>
        /// <param name="endDate">
        /// YYYY-MM-DD
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.UsageOverviewResponse>> PoliciesUsageOverviewPoliciesUsageOverviewGetAsResponseAsync(
            string? startDate = default,
            string? endDate = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}