#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ILiteLLMClient
    {
        /// <summary>
        /// Get Active Tasks Stats<br/>
        /// Returns:<br/>
        ///   total_active_tasks: int<br/>
        ///   by_name: { coroutine_name: count }
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetActiveTasksStatsDebugAsyncioTasksGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Active Tasks Stats<br/>
        /// Returns:<br/>
        ///   total_active_tasks: int<br/>
        ///   by_name: { coroutine_name: count }
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetActiveTasksStatsDebugAsyncioTasksGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}