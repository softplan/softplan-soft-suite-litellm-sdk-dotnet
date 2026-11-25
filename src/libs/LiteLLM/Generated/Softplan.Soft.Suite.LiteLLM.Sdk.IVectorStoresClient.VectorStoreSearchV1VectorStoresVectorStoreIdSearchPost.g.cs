#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Vector Store Search<br/>
        /// Search a vector store.<br/>
        /// API Reference:<br/>
        /// https://platform.openai.com/docs/api-reference/vector-stores/search
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> VectorStoreSearchV1VectorStoresVectorStoreIdSearchPostAsync(
            string vectorStoreId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Vector Store Search<br/>
        /// Search a vector store.<br/>
        /// API Reference:<br/>
        /// https://platform.openai.com/docs/api-reference/vector-stores/search
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> VectorStoreSearchV1VectorStoresVectorStoreIdSearchPostAsResponseAsync(
            string vectorStoreId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}