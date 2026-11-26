#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IMcpManagementClient
    {
        /// <summary>
        /// List Mcp User Env Var Status<br/>
        /// Per-user MCP env var status across every server the user can access. Used by the dashboard to highlight servers with missing per-user vars.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.MCPUserEnvVarsStatus>> ListMcpUserEnvVarStatusV1McpUserEnvVarsStatusGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Mcp User Env Var Status<br/>
        /// Per-user MCP env var status across every server the user can access. Used by the dashboard to highlight servers with missing per-user vars.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.MCPUserEnvVarsStatus>>> ListMcpUserEnvVarStatusV1McpUserEnvVarsStatusGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}