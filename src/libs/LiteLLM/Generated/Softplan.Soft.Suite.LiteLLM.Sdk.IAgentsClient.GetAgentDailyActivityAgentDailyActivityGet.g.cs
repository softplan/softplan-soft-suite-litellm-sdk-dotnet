#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get Agent Daily Activity<br/>
        /// Get daily activity for specific agents or all accessible agents.
        /// </summary>
        /// <param name="agentIds"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="model"></param>
        /// <param name="apiKey"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="excludeAgentIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.SpendAnalyticsPaginatedResponse> GetAgentDailyActivityAgentDailyActivityGetAsync(
            string? agentIds = default,
            string? startDate = default,
            string? endDate = default,
            string? model = default,
            string? apiKey = default,
            int? page = default,
            int? pageSize = default,
            string? excludeAgentIds = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Agent Daily Activity<br/>
        /// Get daily activity for specific agents or all accessible agents.
        /// </summary>
        /// <param name="agentIds"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="model"></param>
        /// <param name="apiKey"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="excludeAgentIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.SpendAnalyticsPaginatedResponse>> GetAgentDailyActivityAgentDailyActivityGetAsResponseAsync(
            string? agentIds = default,
            string? startDate = default,
            string? endDate = default,
            string? model = default,
            string? apiKey = default,
            int? page = default,
            int? pageSize = default,
            string? excludeAgentIds = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}