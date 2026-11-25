#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// ✨ (Enterprise) List Fine-Tuning Jobs<br/>
        /// Lists fine-tuning jobs for the organization.<br/>
        /// This is the equivalent of GET https://api.openai.com/v1/fine_tuning/jobs<br/>
        /// Supported Query Params:<br/>
        /// - `custom_llm_provider`: Name of the LiteLLM provider<br/>
        /// - `after`: Identifier for the last job from the previous pagination request.<br/>
        /// - `limit`: Number of fine-tuning jobs to retrieve (default is 20).
        /// </summary>
        /// <param name="customLlmProvider"></param>
        /// <param name="targetModelNames">
        /// Comma separated list of model names to filter by. Example: 'gpt-4o,gpt-4o-mini'
        /// </param>
        /// <param name="after"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListFineTuningJobsFineTuningJobsGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.ListFineTuningJobsFineTuningJobsGetCustomLlmProvider2? customLlmProvider = default,
            string? targetModelNames = default,
            string? after = default,
            int? limit = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ (Enterprise) List Fine-Tuning Jobs<br/>
        /// Lists fine-tuning jobs for the organization.<br/>
        /// This is the equivalent of GET https://api.openai.com/v1/fine_tuning/jobs<br/>
        /// Supported Query Params:<br/>
        /// - `custom_llm_provider`: Name of the LiteLLM provider<br/>
        /// - `after`: Identifier for the last job from the previous pagination request.<br/>
        /// - `limit`: Number of fine-tuning jobs to retrieve (default is 20).
        /// </summary>
        /// <param name="customLlmProvider"></param>
        /// <param name="targetModelNames">
        /// Comma separated list of model names to filter by. Example: 'gpt-4o,gpt-4o-mini'
        /// </param>
        /// <param name="after"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ListFineTuningJobsFineTuningJobsGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.ListFineTuningJobsFineTuningJobsGetCustomLlmProvider2? customLlmProvider = default,
            string? targetModelNames = default,
            string? after = default,
            int? limit = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}