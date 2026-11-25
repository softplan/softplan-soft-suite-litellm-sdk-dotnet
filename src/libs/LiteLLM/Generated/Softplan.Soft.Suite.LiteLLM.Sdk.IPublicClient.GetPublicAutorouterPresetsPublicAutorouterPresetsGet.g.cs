#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Get Public Autorouter Presets<br/>
        /// Return the auto-router preset catalog the dashboard's template picker renders.<br/>
        /// Resolved once per process, like the model cost map: fetched from ``litellm.autorouter_presets_url``<br/>
        /// (override with ``LITELLM_AUTOROUTER_PRESETS_URL``) on the first request, falling back to the<br/>
        /// catalog bundled with the package on any failure. Set ``LITELLM_LOCAL_AUTOROUTER_PRESETS=True``<br/>
        /// to serve the bundled catalog only. A restart picks up a newly published catalog.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoRouterPresetRecord>> GetPublicAutorouterPresetsPublicAutorouterPresetsGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Public Autorouter Presets<br/>
        /// Return the auto-router preset catalog the dashboard's template picker renders.<br/>
        /// Resolved once per process, like the model cost map: fetched from ``litellm.autorouter_presets_url``<br/>
        /// (override with ``LITELLM_AUTOROUTER_PRESETS_URL``) on the first request, falling back to the<br/>
        /// catalog bundled with the package on any failure. Set ``LITELLM_LOCAL_AUTOROUTER_PRESETS=True``<br/>
        /// to serve the bundled catalog only. A restart picks up a newly published catalog.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.Dictionary<string, global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoRouterPresetRecord>>> GetPublicAutorouterPresetsPublicAutorouterPresetsGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}