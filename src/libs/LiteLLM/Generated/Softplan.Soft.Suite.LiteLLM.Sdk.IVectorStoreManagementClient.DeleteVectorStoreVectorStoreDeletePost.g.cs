#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IVectorStoreManagementClient
    {
        /// <summary>
        /// Delete Vector Store<br/>
        /// Delete a vector store from both database and in-memory registry.<br/>
        /// Parameters:<br/>
        /// - vector_store_id: str - ID of the vector store to delete
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteVectorStoreVectorStoreDeletePostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.VectorStoreDeleteRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Vector Store<br/>
        /// Delete a vector store from both database and in-memory registry.<br/>
        /// Parameters:<br/>
        /// - vector_store_id: str - ID of the vector store to delete
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> DeleteVectorStoreVectorStoreDeletePostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.VectorStoreDeleteRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Vector Store<br/>
        /// Delete a vector store from both database and in-memory registry.<br/>
        /// Parameters:<br/>
        /// - vector_store_id: str - ID of the vector store to delete
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteVectorStoreVectorStoreDeletePostAsync(
            string vectorStoreId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}