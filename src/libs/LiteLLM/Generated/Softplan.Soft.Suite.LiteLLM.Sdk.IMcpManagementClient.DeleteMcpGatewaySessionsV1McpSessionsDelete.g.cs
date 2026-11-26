#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IMcpManagementClient
    {
        /// <summary>
        /// Delete Mcp Gateway Sessions<br/>
        /// Force-close live stateful MCP gateway sessions on this proxy worker, selected by session id prefix and/or by the LiteLLM user that opened them (proxy admin only).
        /// </summary>
        /// <param name="sessionIdPrefix"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.MCPGatewaySessionsTerminateResponse> DeleteMcpGatewaySessionsV1McpSessionsDeleteAsync(
            string? sessionIdPrefix = default,
            string? userId = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Mcp Gateway Sessions<br/>
        /// Force-close live stateful MCP gateway sessions on this proxy worker, selected by session id prefix and/or by the LiteLLM user that opened them (proxy admin only).
        /// </summary>
        /// <param name="sessionIdPrefix"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.MCPGatewaySessionsTerminateResponse>> DeleteMcpGatewaySessionsV1McpSessionsDeleteAsResponseAsync(
            string? sessionIdPrefix = default,
            string? userId = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}