#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IMcpManagementClient
    {
        /// <summary>
        /// Store Mcp User Credential<br/>
        /// Store or update the calling user's API key for a BYOK MCP server
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.MCPUserCredentialResponse> StoreMcpUserCredentialV1McpServerServerIdUserCredentialPostAsync(
            string serverId,

            global::Softplan.Soft.Suite.LiteLLM.Sdk.MCPUserCredentialRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store Mcp User Credential<br/>
        /// Store or update the calling user's API key for a BYOK MCP server
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.MCPUserCredentialResponse>> StoreMcpUserCredentialV1McpServerServerIdUserCredentialPostAsResponseAsync(
            string serverId,

            global::Softplan.Soft.Suite.LiteLLM.Sdk.MCPUserCredentialRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store Mcp User Credential<br/>
        /// Store or update the calling user's API key for a BYOK MCP server
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="credential"></param>
        /// <param name="save">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.MCPUserCredentialResponse> StoreMcpUserCredentialV1McpServerServerIdUserCredentialPostAsync(
            string serverId,
            string credential,
            bool? save = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}