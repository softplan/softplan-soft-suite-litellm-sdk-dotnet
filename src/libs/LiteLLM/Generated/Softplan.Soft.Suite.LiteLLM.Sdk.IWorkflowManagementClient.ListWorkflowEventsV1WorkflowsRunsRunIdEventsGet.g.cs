#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IWorkflowManagementClient
    {
        /// <summary>
        /// List Workflow Events<br/>
        /// Fetch event log for a run, ordered by sequence_number. Default limit 100, max 500.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListWorkflowEventsV1WorkflowsRunsRunIdEventsGetAsync(
            string runId,
            int? limit = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Workflow Events<br/>
        /// Fetch event log for a run, ordered by sequence_number. Default limit 100, max 500.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ListWorkflowEventsV1WorkflowsRunsRunIdEventsGetAsResponseAsync(
            string runId,
            int? limit = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}