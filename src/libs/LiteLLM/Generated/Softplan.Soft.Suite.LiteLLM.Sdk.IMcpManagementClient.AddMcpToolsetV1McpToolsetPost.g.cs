#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IMcpManagementClient
    {
        /// <summary>
        /// Add Mcp Toolset<br/>
        /// Create a new MCP toolset (admin only)
        /// </summary>
        /// <param name="litellmChangedBy"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddMcpToolsetV1McpToolsetPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.NewMCPToolsetRequest request,
            string? litellmChangedBy = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Mcp Toolset<br/>
        /// Create a new MCP toolset (admin only)
        /// </summary>
        /// <param name="litellmChangedBy"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> AddMcpToolsetV1McpToolsetPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.NewMCPToolsetRequest request,
            string? litellmChangedBy = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Mcp Toolset<br/>
        /// Create a new MCP toolset (admin only)
        /// </summary>
        /// <param name="litellmChangedBy"></param>
        /// <param name="description"></param>
        /// <param name="tools">
        /// Default Value: []
        /// </param>
        /// <param name="toolsetName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddMcpToolsetV1McpToolsetPostAsync(
            string toolsetName,
            string? litellmChangedBy = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.MCPToolsetTool>? tools = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}