#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IClaudeCodeMarketplaceClient
    {
        /// <summary>
        /// Delete Plugin<br/>
        /// Delete a plugin from the marketplace.<br/>
        /// Requires a proxy admin API key.<br/>
        /// Parameters:<br/>
        ///     - plugin_name: The name of the plugin to delete
        /// </summary>
        /// <param name="pluginName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeletePluginClaudeCodePluginsPluginNameDeleteAsync(
            string pluginName,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Plugin<br/>
        /// Delete a plugin from the marketplace.<br/>
        /// Requires a proxy admin API key.<br/>
        /// Parameters:<br/>
        ///     - plugin_name: The name of the plugin to delete
        /// </summary>
        /// <param name="pluginName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> DeletePluginClaudeCodePluginsPluginNameDeleteAsResponseAsync(
            string pluginName,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}