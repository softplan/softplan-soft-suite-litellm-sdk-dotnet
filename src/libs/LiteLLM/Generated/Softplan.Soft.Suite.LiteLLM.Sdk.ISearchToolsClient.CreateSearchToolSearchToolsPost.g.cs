#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ISearchToolsClient
    {
        /// <summary>
        /// Create Search Tool<br/>
        /// Create a new search tool.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/search_tools" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "search_tool": {<br/>
        ///             "search_tool_name": "litellm-search",<br/>
        ///             "litellm_params": {<br/>
        ///                 "search_provider": "perplexity",<br/>
        ///                 "api_key": "sk-..."<br/>
        ///             },<br/>
        ///             "search_tool_info": {<br/>
        ///                 "description": "Perplexity search tool"<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "search_tool_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "search_tool_name": "litellm-search",<br/>
        ///     "litellm_params": {<br/>
        ///         "search_provider": "perplexity",<br/>
        ///         "api_key": "sk-..."<br/>
        ///     },<br/>
        ///     "search_tool_info": {<br/>
        ///         "description": "Perplexity search tool"<br/>
        ///     },<br/>
        ///     "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///     "updated_at": "2023-11-09T12:34:56.789Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateSearchToolSearchToolsPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.CreateSearchToolRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Search Tool<br/>
        /// Create a new search tool.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/search_tools" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "search_tool": {<br/>
        ///             "search_tool_name": "litellm-search",<br/>
        ///             "litellm_params": {<br/>
        ///                 "search_provider": "perplexity",<br/>
        ///                 "api_key": "sk-..."<br/>
        ///             },<br/>
        ///             "search_tool_info": {<br/>
        ///                 "description": "Perplexity search tool"<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "search_tool_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "search_tool_name": "litellm-search",<br/>
        ///     "litellm_params": {<br/>
        ///         "search_provider": "perplexity",<br/>
        ///         "api_key": "sk-..."<br/>
        ///     },<br/>
        ///     "search_tool_info": {<br/>
        ///         "description": "Perplexity search tool"<br/>
        ///     },<br/>
        ///     "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///     "updated_at": "2023-11-09T12:34:56.789Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CreateSearchToolSearchToolsPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.CreateSearchToolRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Search Tool<br/>
        /// Create a new search tool.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/search_tools" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "search_tool": {<br/>
        ///             "search_tool_name": "litellm-search",<br/>
        ///             "litellm_params": {<br/>
        ///                 "search_provider": "perplexity",<br/>
        ///                 "api_key": "sk-..."<br/>
        ///             },<br/>
        ///             "search_tool_info": {<br/>
        ///                 "description": "Perplexity search tool"<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "search_tool_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "search_tool_name": "litellm-search",<br/>
        ///     "litellm_params": {<br/>
        ///         "search_provider": "perplexity",<br/>
        ///         "api_key": "sk-..."<br/>
        ///     },<br/>
        ///     "search_tool_info": {<br/>
        ///         "description": "Perplexity search tool"<br/>
        ///     },<br/>
        ///     "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///     "updated_at": "2023-11-09T12:34:56.789Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="searchTool">
        /// Search tool configuration.<br/>
        /// Example:<br/>
        ///     {<br/>
        ///         "search_tool_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///         "search_tool_name": "litellm-search",<br/>
        ///         "litellm_params": {<br/>
        ///             "search_provider": "perplexity",<br/>
        ///             "api_key": "sk-..."<br/>
        ///         },<br/>
        ///         "search_tool_info": {<br/>
        ///             "description": "Perplexity search tool"<br/>
        ///         }<br/>
        ///     }
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateSearchToolSearchToolsPostAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.SearchTool searchTool,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}