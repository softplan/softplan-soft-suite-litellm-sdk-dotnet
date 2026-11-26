#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IClaudeCodeMarketplaceClient
    {
        /// <summary>
        /// Get Plugin<br/>
        /// Get details of a specific plugin.<br/>
        /// Parameters:<br/>
        ///     - plugin_name: The name of the plugin<br/>
        /// Returns:<br/>
        ///     Plugin details including source and metadata.
        /// </summary>
        /// <param name="pluginName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetPluginClaudeCodePluginsPluginNameGetAsync(
            string pluginName,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Plugin<br/>
        /// Get details of a specific plugin.<br/>
        /// Parameters:<br/>
        ///     - plugin_name: The name of the plugin<br/>
        /// Returns:<br/>
        ///     Plugin details including source and metadata.
        /// </summary>
        /// <param name="pluginName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetPluginClaudeCodePluginsPluginNameGetAsResponseAsync(
            string pluginName,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}