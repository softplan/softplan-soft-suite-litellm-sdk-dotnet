#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// ✨ (Enterprise) Cancel Fine-Tuning Jobs<br/>
        /// Cancel a fine-tuning job.<br/>
        /// This is the equivalent of POST https://api.openai.com/v1/fine_tuning/jobs/{fine_tuning_job_id}/cancel<br/>
        /// Supported Query Params:<br/>
        /// - `custom_llm_provider`: Name of the LiteLLM provider<br/>
        /// - `fine_tuning_job_id`: The ID of the fine-tuning job to cancel.
        /// </summary>
        /// <param name="fineTuningJobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CancelFineTuningJobFineTuningJobsFineTuningJobIdCancelPostAsync(
            string fineTuningJobId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ (Enterprise) Cancel Fine-Tuning Jobs<br/>
        /// Cancel a fine-tuning job.<br/>
        /// This is the equivalent of POST https://api.openai.com/v1/fine_tuning/jobs/{fine_tuning_job_id}/cancel<br/>
        /// Supported Query Params:<br/>
        /// - `custom_llm_provider`: Name of the LiteLLM provider<br/>
        /// - `fine_tuning_job_id`: The ID of the fine-tuning job to cancel.
        /// </summary>
        /// <param name="fineTuningJobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CancelFineTuningJobFineTuningJobsFineTuningJobIdCancelPostAsResponseAsync(
            string fineTuningJobId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}