#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Guardrails Usage Logs<br/>
        /// Return paginated run logs for a guardrail (or policy) from SpendLogs via index.
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="policyId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="action"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.UsageLogsResponse> GuardrailsUsageLogsGuardrailsUsageLogsGetAsync(
            string? guardrailId = default,
            string? policyId = default,
            int? page = default,
            int? pageSize = default,
            string? action = default,
            string? startDate = default,
            string? endDate = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Guardrails Usage Logs<br/>
        /// Return paginated run logs for a guardrail (or policy) from SpendLogs via index.
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="policyId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="action"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.UsageLogsResponse>> GuardrailsUsageLogsGuardrailsUsageLogsGetAsResponseAsync(
            string? guardrailId = default,
            string? policyId = default,
            int? page = default,
            int? pageSize = default,
            string? action = default,
            string? startDate = default,
            string? endDate = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}