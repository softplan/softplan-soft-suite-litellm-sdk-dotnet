#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IMcpByokOauthClient
    {
        /// <summary>
        /// Oauth Authorization Server Mcp<br/>
        /// OAuth authorization server discovery endpoint.<br/>
        /// Supports both legacy pattern (/{server_name}) and root endpoint.
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OauthAuthorizationServerMcpWellKnownOauthAuthorizationServerGetAsync(
            string? mcpServerName = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Oauth Authorization Server Mcp<br/>
        /// OAuth authorization server discovery endpoint.<br/>
        /// Supports both legacy pattern (/{server_name}) and root endpoint.
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> OauthAuthorizationServerMcpWellKnownOauthAuthorizationServerGetAsResponseAsync(
            string? mcpServerName = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}