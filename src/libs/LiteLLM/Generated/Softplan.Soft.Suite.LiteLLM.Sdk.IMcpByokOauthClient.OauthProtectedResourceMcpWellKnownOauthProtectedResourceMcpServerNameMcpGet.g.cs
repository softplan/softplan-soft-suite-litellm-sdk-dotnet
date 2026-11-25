#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IMcpByokOauthClient
    {
        /// <summary>
        /// Oauth Protected Resource Mcp<br/>
        /// OAuth protected resource discovery endpoint using LiteLLM legacy URL pattern.<br/>
        /// Legacy pattern: /{server_name}/mcp<br/>
        /// Discovery path: /.well-known/oauth-protected-resource/{server_name}/mcp<br/>
        /// This endpoint is kept for backward compatibility. New integrations should<br/>
        /// use the standard MCP pattern (/mcp/{server_name}) instead.
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OauthProtectedResourceMcpWellKnownOauthProtectedResourceMcpServerNameMcpGetAsync(
            string? mcpServerName,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Oauth Protected Resource Mcp<br/>
        /// OAuth protected resource discovery endpoint using LiteLLM legacy URL pattern.<br/>
        /// Legacy pattern: /{server_name}/mcp<br/>
        /// Discovery path: /.well-known/oauth-protected-resource/{server_name}/mcp<br/>
        /// This endpoint is kept for backward compatibility. New integrations should<br/>
        /// use the standard MCP pattern (/mcp/{server_name}) instead.
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> OauthProtectedResourceMcpWellKnownOauthProtectedResourceMcpServerNameMcpGetAsResponseAsync(
            string? mcpServerName,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}