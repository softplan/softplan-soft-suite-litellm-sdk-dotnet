#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ICostOptimizationClient
    {
        /// <summary>
        /// Get Prompt Caching Requests
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="filter">
        /// Default Value: all
        /// </param>
        /// <param name="cursorStartTime"></param>
        /// <param name="cursorRequestId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.PromptCachingRequestsResponse> GetPromptCachingRequestsCostOptimizationPromptCachingRequestsGetAsync(
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            int? pageSize = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.GetPromptCachingRequestsCostOptimizationPromptCachingRequestsGetFilter? filter = default,
            global::System.DateTime? cursorStartTime = default,
            string? cursorRequestId = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Prompt Caching Requests
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="filter">
        /// Default Value: all
        /// </param>
        /// <param name="cursorStartTime"></param>
        /// <param name="cursorRequestId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.PromptCachingRequestsResponse>> GetPromptCachingRequestsCostOptimizationPromptCachingRequestsGetAsResponseAsync(
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            int? pageSize = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.GetPromptCachingRequestsCostOptimizationPromptCachingRequestsGetFilter? filter = default,
            global::System.DateTime? cursorStartTime = default,
            string? cursorRequestId = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}