#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IAdaptiveRouterClient
    {
        /// <summary>
        /// Get Adaptive Router State<br/>
        /// Return live bandit posteriors + queue depth for every configured adaptive router.<br/>
        /// Admin-only. Returns 404 if no adaptive router is configured.<br/>
        /// Response shape: `{"routers": [&lt;snapshot&gt;, ...]}` — one snapshot per<br/>
        /// adaptive-router deployment. Each snapshot's `router_name` field identifies<br/>
        /// which deployment it came from.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetAdaptiveRouterStateAdaptiveRouterStateGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Adaptive Router State<br/>
        /// Return live bandit posteriors + queue depth for every configured adaptive router.<br/>
        /// Admin-only. Returns 404 if no adaptive router is configured.<br/>
        /// Response shape: `{"routers": [&lt;snapshot&gt;, ...]}` — one snapshot per<br/>
        /// adaptive-router deployment. Each snapshot's `router_name` field identifies<br/>
        /// which deployment it came from.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetAdaptiveRouterStateAdaptiveRouterStateGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}