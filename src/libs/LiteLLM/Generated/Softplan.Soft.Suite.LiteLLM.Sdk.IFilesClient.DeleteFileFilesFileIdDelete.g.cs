#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Delete File<br/>
        /// Deletes a specified file. that can be used across - Assistants API, Batch API <br/>
        /// This is the equivalent of DELETE https://api.openai.com/v1/files/{file_id}<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/files/delete<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/files/file-abc123     -X DELETE     -H "Authorization: Bearer $OPENAI_API_KEY"<br/>
        /// ```
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="provider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteFileFilesFileIdDeleteAsync(
            string fileId,
            string? provider = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete File<br/>
        /// Deletes a specified file. that can be used across - Assistants API, Batch API <br/>
        /// This is the equivalent of DELETE https://api.openai.com/v1/files/{file_id}<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/files/delete<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/files/file-abc123     -X DELETE     -H "Authorization: Bearer $OPENAI_API_KEY"<br/>
        /// ```
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="provider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> DeleteFileFilesFileIdDeleteAsResponseAsync(
            string fileId,
            string? provider = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}