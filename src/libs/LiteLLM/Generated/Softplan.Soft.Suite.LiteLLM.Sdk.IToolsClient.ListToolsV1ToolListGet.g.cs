#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List Tools<br/>
        /// List all auto-discovered tools and their policies.<br/>
        /// Parameters:<br/>
        /// - input_policy: Optional filter — one of "trusted", "untrusted", "blocked"
        /// </summary>
        /// <param name="inputPolicy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.ToolListResponse> ListToolsV1ToolListGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.ListToolsV1ToolListGetInputPolicy2? inputPolicy = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Tools<br/>
        /// List all auto-discovered tools and their policies.<br/>
        /// Parameters:<br/>
        /// - input_policy: Optional filter — one of "trusted", "untrusted", "blocked"
        /// </summary>
        /// <param name="inputPolicy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.ToolListResponse>> ListToolsV1ToolListGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.ListToolsV1ToolListGetInputPolicy2? inputPolicy = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}