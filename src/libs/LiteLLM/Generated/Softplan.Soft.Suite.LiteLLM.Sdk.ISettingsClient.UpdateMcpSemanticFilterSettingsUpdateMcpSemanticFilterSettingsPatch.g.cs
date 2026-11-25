#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Update Mcp Semantic Filter Settings<br/>
        /// Update MCP semantic filter settings in database.<br/>
        /// Settings will be picked up by all pods within approximately 10 seconds via background polling.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateMcpSemanticFilterSettingsUpdateMcpSemanticFilterSettingsPatchAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.MCPSemanticFilterSettings request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Mcp Semantic Filter Settings<br/>
        /// Update MCP semantic filter settings in database.<br/>
        /// Settings will be picked up by all pods within approximately 10 seconds via background polling.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateMcpSemanticFilterSettingsUpdateMcpSemanticFilterSettingsPatchAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.MCPSemanticFilterSettings request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Mcp Semantic Filter Settings<br/>
        /// Update MCP semantic filter settings in database.<br/>
        /// Settings will be picked up by all pods within approximately 10 seconds via background polling.
        /// </summary>
        /// <param name="enabled">
        /// Enable semantic filtering of MCP tools based on query relevance<br/>
        /// Default Value: false
        /// </param>
        /// <param name="embeddingModel">
        /// Embedding model to use for semantic similarity (e.g., 'text-embedding-3-small', 'text-embedding-ada-002')<br/>
        /// Default Value: text-embedding-3-small
        /// </param>
        /// <param name="topK">
        /// Number of most relevant tools to return<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="similarityThreshold">
        /// Minimum similarity score for tool inclusion (0.0 to 1.0, where 1.0 = exact match)<br/>
        /// Default Value: 0.3F
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateMcpSemanticFilterSettingsUpdateMcpSemanticFilterSettingsPatchAsync(
            bool? enabled = default,
            string? embeddingModel = default,
            int? topK = default,
            double? similarityThreshold = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}