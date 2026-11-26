#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ILiteLLMClient
    {
        /// <summary>
        /// Aggregate Mcp Route<br/>
        /// Serve the aggregate MCP endpoint on the bare ``/mcp`` spelling: the<br/>
        /// ``/mcp`` mount cannot match its bare prefix, and the resulting 307 breaks<br/>
        /// MCP clients behind TLS-terminating proxies.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AggregateMcpRouteMcpOptionsAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Aggregate Mcp Route<br/>
        /// Serve the aggregate MCP endpoint on the bare ``/mcp`` spelling: the<br/>
        /// ``/mcp`` mount cannot match its bare prefix, and the resulting 307 breaks<br/>
        /// MCP clients behind TLS-terminating proxies.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> AggregateMcpRouteMcpOptionsAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}