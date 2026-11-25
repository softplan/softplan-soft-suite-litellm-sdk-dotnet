#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Update Eval<br/>
        /// Update an evaluation.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: gpt-4-account-1`<br/>
        /// - Pass model via query: `?model=gpt-4-account-1`<br/>
        /// - Pass model via body: `{"model": "gpt-4-account-1"}`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/evals/eval_123"       -H "Authorization: Bearer your-key"       -H "Content-Type: application/json"       -d '{"name": "Updated Name"}'<br/>
        /// ```<br/>
        /// Returns: Updated Eval object
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="customLlmProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.Eval> UpdateEvalV1EvalsEvalIdPostAsync(
            string evalId,
            string? customLlmProvider = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Eval<br/>
        /// Update an evaluation.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: gpt-4-account-1`<br/>
        /// - Pass model via query: `?model=gpt-4-account-1`<br/>
        /// - Pass model via body: `{"model": "gpt-4-account-1"}`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/evals/eval_123"       -H "Authorization: Bearer your-key"       -H "Content-Type: application/json"       -d '{"name": "Updated Name"}'<br/>
        /// ```<br/>
        /// Returns: Updated Eval object
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="customLlmProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.Eval>> UpdateEvalV1EvalsEvalIdPostAsResponseAsync(
            string evalId,
            string? customLlmProvider = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}