#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IWorkflowManagementClient
    {
        /// <summary>
        /// Append Workflow Message<br/>
        /// Append a conversation message. Stores full content (not truncated).<br/>
        /// Uses optimistic concurrency for sequence numbers.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AppendWorkflowMessageV1WorkflowsRunsRunIdMessagesPostAsync(
            string runId,

            global::Softplan.Soft.Suite.LiteLLM.Sdk.WorkflowMessageCreateRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Append Workflow Message<br/>
        /// Append a conversation message. Stores full content (not truncated).<br/>
        /// Uses optimistic concurrency for sequence numbers.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> AppendWorkflowMessageV1WorkflowsRunsRunIdMessagesPostAsResponseAsync(
            string runId,

            global::Softplan.Soft.Suite.LiteLLM.Sdk.WorkflowMessageCreateRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Append Workflow Message<br/>
        /// Append a conversation message. Stores full content (not truncated).<br/>
        /// Uses optimistic concurrency for sequence numbers.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AppendWorkflowMessageV1WorkflowsRunsRunIdMessagesPostAsync(
            string runId,
            string role,
            string content,
            string? sessionId = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}