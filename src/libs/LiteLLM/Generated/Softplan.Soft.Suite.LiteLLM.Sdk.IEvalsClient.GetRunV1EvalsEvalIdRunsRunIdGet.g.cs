#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Get Run<br/>
        /// Get a specific run by ID.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: gpt-4-account-1`<br/>
        /// - Pass model via query: `?model=gpt-4-account-1`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// curl "http://localhost:4000/v1/evals/eval_123/runs/run_456"       -H "Authorization: Bearer your-key"<br/>
        /// ```<br/>
        /// Returns: Run object with full details
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="runId"></param>
        /// <param name="customLlmProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.Run> GetRunV1EvalsEvalIdRunsRunIdGetAsync(
            string evalId,
            string runId,
            string? customLlmProvider = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Run<br/>
        /// Get a specific run by ID.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: gpt-4-account-1`<br/>
        /// - Pass model via query: `?model=gpt-4-account-1`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// curl "http://localhost:4000/v1/evals/eval_123/runs/run_456"       -H "Authorization: Bearer your-key"<br/>
        /// ```<br/>
        /// Returns: Run object with full details
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="runId"></param>
        /// <param name="customLlmProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.Run>> GetRunV1EvalsEvalIdRunsRunIdGetAsResponseAsync(
            string evalId,
            string runId,
            string? customLlmProvider = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}