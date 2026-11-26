#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IComplianceClient
    {
        /// <summary>
        /// Check Eu Ai Act Compliance<br/>
        /// Check EU AI Act compliance for a spend log entry.<br/>
        /// Checks:<br/>
        /// - Art. 9: Guardrails applied (any guardrail)<br/>
        /// - Art. 5: Content screened before LLM (pre-call guardrails)<br/>
        /// - Art. 12: Audit record complete (user_id, model, timestamp, guardrail_results)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.ComplianceResponse> CheckEuAiActComplianceComplianceEuAiActPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.ComplianceCheckRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Eu Ai Act Compliance<br/>
        /// Check EU AI Act compliance for a spend log entry.<br/>
        /// Checks:<br/>
        /// - Art. 9: Guardrails applied (any guardrail)<br/>
        /// - Art. 5: Content screened before LLM (pre-call guardrails)<br/>
        /// - Art. 12: Audit record complete (user_id, model, timestamp, guardrail_results)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.ComplianceResponse>> CheckEuAiActComplianceComplianceEuAiActPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.ComplianceCheckRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Eu Ai Act Compliance<br/>
        /// Check EU AI Act compliance for a spend log entry.<br/>
        /// Checks:<br/>
        /// - Art. 9: Guardrails applied (any guardrail)<br/>
        /// - Art. 5: Content screened before LLM (pre-call guardrails)<br/>
        /// - Art. 12: Audit record complete (user_id, model, timestamp, guardrail_results)
        /// </summary>
        /// <param name="guardrailInformation"></param>
        /// <param name="model"></param>
        /// <param name="requestId"></param>
        /// <param name="timestamp"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.ComplianceResponse> CheckEuAiActComplianceComplianceEuAiActPostAsync(
            string requestId,
            global::System.Collections.Generic.IList<object>? guardrailInformation = default,
            string? model = default,
            string? timestamp = default,
            string? userId = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}