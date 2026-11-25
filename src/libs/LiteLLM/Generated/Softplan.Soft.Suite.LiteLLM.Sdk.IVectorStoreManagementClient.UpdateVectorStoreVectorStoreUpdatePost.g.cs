#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IVectorStoreManagementClient
    {
        /// <summary>
        /// Update Vector Store<br/>
        /// Update vector store details in both database and in-memory registry.<br/>
        /// The updated data is immediately synchronized to the in-memory registry.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateVectorStoreVectorStoreUpdatePostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.VectorStoreUpdateRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Vector Store<br/>
        /// Update vector store details in both database and in-memory registry.<br/>
        /// The updated data is immediately synchronized to the in-memory registry.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateVectorStoreVectorStoreUpdatePostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.VectorStoreUpdateRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Vector Store<br/>
        /// Update vector store details in both database and in-memory registry.<br/>
        /// The updated data is immediately synchronized to the in-memory registry.
        /// </summary>
        /// <param name="customLlmProvider"></param>
        /// <param name="vectorStoreDescription"></param>
        /// <param name="vectorStoreId"></param>
        /// <param name="vectorStoreMetadata"></param>
        /// <param name="vectorStoreName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateVectorStoreVectorStoreUpdatePostAsync(
            string vectorStoreId,
            string? customLlmProvider = default,
            string? vectorStoreDescription = default,
            object? vectorStoreMetadata = default,
            string? vectorStoreName = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}