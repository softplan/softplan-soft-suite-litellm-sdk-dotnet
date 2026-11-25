#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IBudgetSpendTrackingClient
    {
        /// <summary>
        /// Get Gateway Daily Activity<br/>
        /// Successful and failed gateway requests, counted at the ASGI edge.<br/>
        /// Deployment-wide: the underlying table has no per-key or per-user dimension,<br/>
        /// so this is admin-only.
        /// </summary>
        /// <param name="startDate">
        /// Start date in YYYY-MM-DD format
        /// </param>
        /// <param name="endDate">
        /// End date in YYYY-MM-DD format
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.GatewayRequestActivityResponse> GetGatewayDailyActivityGatewayDailyActivityGetAsync(
            string? startDate = default,
            string? endDate = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Gateway Daily Activity<br/>
        /// Successful and failed gateway requests, counted at the ASGI edge.<br/>
        /// Deployment-wide: the underlying table has no per-key or per-user dimension,<br/>
        /// so this is admin-only.
        /// </summary>
        /// <param name="startDate">
        /// Start date in YYYY-MM-DD format
        /// </param>
        /// <param name="endDate">
        /// End date in YYYY-MM-DD format
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.GatewayRequestActivityResponse>> GetGatewayDailyActivityGatewayDailyActivityGetAsResponseAsync(
            string? startDate = default,
            string? endDate = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}