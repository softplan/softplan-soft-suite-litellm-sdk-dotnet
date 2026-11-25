#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IWorkflowManagementClient
    {
        /// <summary>
        /// Create Workflow Run<br/>
        /// Create a new workflow run. Returns run_id and session_id.<br/>
        /// The caller's API key token is stored as created_by so that non-admin keys<br/>
        /// can only see and modify their own runs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateWorkflowRunV1WorkflowsRunsPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.WorkflowRunCreateRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Workflow Run<br/>
        /// Create a new workflow run. Returns run_id and session_id.<br/>
        /// The caller's API key token is stored as created_by so that non-admin keys<br/>
        /// can only see and modify their own runs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CreateWorkflowRunV1WorkflowsRunsPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.WorkflowRunCreateRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Workflow Run<br/>
        /// Create a new workflow run. Returns run_id and session_id.<br/>
        /// The caller's API key token is stored as created_by so that non-admin keys<br/>
        /// can only see and modify their own runs.
        /// </summary>
        /// <param name="workflowType"></param>
        /// <param name="input"></param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateWorkflowRunV1WorkflowsRunsPostAsync(
            string workflowType,
            object? input = default,
            object? metadata = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}