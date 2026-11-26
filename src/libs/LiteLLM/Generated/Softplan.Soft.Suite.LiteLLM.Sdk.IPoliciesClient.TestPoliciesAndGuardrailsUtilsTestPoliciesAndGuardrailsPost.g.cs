#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IPoliciesClient
    {
        /// <summary>
        /// Test Policies And Guardrails<br/>
        /// Apply policies and/or guardrails to inputs (for compliance UI testing).<br/>
        /// Use inputs_list for batch testing: each input is processed as a separate call so<br/>
        /// per-input block/allow and errors are returned.<br/>
        /// Use inputs for a single call (legacy).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TestPoliciesAndGuardrailsUtilsTestPoliciesAndGuardrailsPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.TestPoliciesAndGuardrailsRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Policies And Guardrails<br/>
        /// Apply policies and/or guardrails to inputs (for compliance UI testing).<br/>
        /// Use inputs_list for batch testing: each input is processed as a separate call so<br/>
        /// per-input block/allow and errors are returned.<br/>
        /// Use inputs for a single call (legacy).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TestPoliciesAndGuardrailsUtilsTestPoliciesAndGuardrailsPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.TestPoliciesAndGuardrailsRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Policies And Guardrails<br/>
        /// Apply policies and/or guardrails to inputs (for compliance UI testing).<br/>
        /// Use inputs_list for batch testing: each input is processed as a separate call so<br/>
        /// per-input block/allow and errors are returned.<br/>
        /// Use inputs for a single call (legacy).
        /// </summary>
        /// <param name="agentId">
        /// When set, call chat completion with this model/agent for each input and include the response in the result.
        /// </param>
        /// <param name="guardrailNames">
        /// Guardrail names to apply directly
        /// </param>
        /// <param name="inputType">
        /// Whether inputs are request or response<br/>
        /// Default Value: request
        /// </param>
        /// <param name="inputsList">
        /// List of GenericGuardrailAPIInputs; each item processed separately (for batch compliance testing).<br/>
        /// Default Value: []
        /// </param>
        /// <param name="policyNames">
        /// Policy names to resolve guardrails from
        /// </param>
        /// <param name="requestData">
        /// Request context (model, user_id, etc.)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TestPoliciesAndGuardrailsUtilsTestPoliciesAndGuardrailsPostAsync(
            string? agentId = default,
            global::System.Collections.Generic.IList<string>? guardrailNames = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.TestPoliciesAndGuardrailsRequestInputType? inputType = default,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.GenericGuardrailAPIInputs>? inputsList = default,
            global::System.Collections.Generic.IList<string>? policyNames = default,
            object? requestData = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}