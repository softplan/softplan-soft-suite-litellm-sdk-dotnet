#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Cancel Batch<br/>
        /// Cancel a batch.<br/>
        /// This is the equivalent of POST https://api.openai.com/v1/batches/{batch_id}/cancel<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/batch/cancel<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/batches/batch_abc123/cancel         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -X POST<br/>
        /// ```
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="provider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CancelBatchBatchesBatchIdCancelPostAsync(
            string batchId,
            string? provider = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Batch<br/>
        /// Cancel a batch.<br/>
        /// This is the equivalent of POST https://api.openai.com/v1/batches/{batch_id}/cancel<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/batch/cancel<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/batches/batch_abc123/cancel         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -X POST<br/>
        /// ```
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="provider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CancelBatchBatchesBatchIdCancelPostAsResponseAsync(
            string batchId,
            string? provider = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}