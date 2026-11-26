#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IClaudeCodeMarketplaceClient
    {
        /// <summary>
        /// Enable Plugin<br/>
        /// Enable a disabled plugin.<br/>
        /// Requires a proxy admin API key.<br/>
        /// Parameters:<br/>
        ///     - plugin_name: The name of the plugin to enable
        /// </summary>
        /// <param name="pluginName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> EnablePluginClaudeCodePluginsPluginNameEnablePostAsync(
            string pluginName,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable Plugin<br/>
        /// Enable a disabled plugin.<br/>
        /// Requires a proxy admin API key.<br/>
        /// Parameters:<br/>
        ///     - plugin_name: The name of the plugin to enable
        /// </summary>
        /// <param name="pluginName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> EnablePluginClaudeCodePluginsPluginNameEnablePostAsResponseAsync(
            string pluginName,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}