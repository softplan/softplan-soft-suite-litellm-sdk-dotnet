#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Index Create<br/>
        /// Create an index. Just writes the index to the database.<br/>
        /// ```bash<br/>
        /// curl -L -X POST 'http://0.0.0.0:4000/v1/indexes'         -H 'Content-Type: application/json'         -H 'Authorization: Bearer sk-1234'         -d '{<br/>
        ///         "index_name": "dall-e-3",<br/>
        ///         "litellm_params": {<br/>
        ///             "vector_store_index": "real-index-name",<br/>
        ///             "vector_store_name": "azure-ai-search"<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> IndexCreateV1IndexesPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.IndexCreateRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Index Create<br/>
        /// Create an index. Just writes the index to the database.<br/>
        /// ```bash<br/>
        /// curl -L -X POST 'http://0.0.0.0:4000/v1/indexes'         -H 'Content-Type: application/json'         -H 'Authorization: Bearer sk-1234'         -d '{<br/>
        ///         "index_name": "dall-e-3",<br/>
        ///         "litellm_params": {<br/>
        ///             "vector_store_index": "real-index-name",<br/>
        ///             "vector_store_name": "azure-ai-search"<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> IndexCreateV1IndexesPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.IndexCreateRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Index Create<br/>
        /// Create an index. Just writes the index to the database.<br/>
        /// ```bash<br/>
        /// curl -L -X POST 'http://0.0.0.0:4000/v1/indexes'         -H 'Content-Type: application/json'         -H 'Authorization: Bearer sk-1234'         -d '{<br/>
        ///         "index_name": "dall-e-3",<br/>
        ///         "litellm_params": {<br/>
        ///             "vector_store_index": "real-index-name",<br/>
        ///             "vector_store_name": "azure-ai-search"<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="indexInfo"></param>
        /// <param name="indexName"></param>
        /// <param name="litellmParams"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> IndexCreateV1IndexesPostAsync(
            string indexName,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.IndexCreateLiteLLMParams litellmParams,
            object? indexInfo = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}