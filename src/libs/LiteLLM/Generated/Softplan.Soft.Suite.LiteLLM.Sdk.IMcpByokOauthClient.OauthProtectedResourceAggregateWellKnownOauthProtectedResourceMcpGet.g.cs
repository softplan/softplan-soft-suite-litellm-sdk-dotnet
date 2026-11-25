#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IMcpByokOauthClient
    {
        /// <summary>
        /// Oauth Protected Resource Aggregate<br/>
        /// OAuth protected resource discovery for the aggregate /mcp endpoint.<br/>
        /// The single-segment ``/mcp`` path does not collide with any per-server PRM pattern<br/>
        /// (those are two-segment: ``/mcp/{server}`` or ``/{server}/mcp``), so this unambiguously<br/>
        /// describes the aggregate resource.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OauthProtectedResourceAggregateWellKnownOauthProtectedResourceMcpGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Oauth Protected Resource Aggregate<br/>
        /// OAuth protected resource discovery for the aggregate /mcp endpoint.<br/>
        /// The single-segment ``/mcp`` path does not collide with any per-server PRM pattern<br/>
        /// (those are two-segment: ``/mcp/{server}`` or ``/{server}/mcp``), so this unambiguously<br/>
        /// describes the aggregate resource.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> OauthProtectedResourceAggregateWellKnownOauthProtectedResourceMcpGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}