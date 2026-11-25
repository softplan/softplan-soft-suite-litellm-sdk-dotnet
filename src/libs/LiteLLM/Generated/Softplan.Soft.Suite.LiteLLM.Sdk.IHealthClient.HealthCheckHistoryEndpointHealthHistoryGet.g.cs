#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Health Check History Endpoint<br/>
        /// Get health check history for models<br/>
        /// Returns historical health check data with optional filtering.
        /// </summary>
        /// <param name="model">
        /// Filter by specific model name
        /// </param>
        /// <param name="statusFilter">
        /// Filter by status (healthy/unhealthy)
        /// </param>
        /// <param name="limit">
        /// Number of records to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Number of records to skip<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthCheckHistoryEndpointHealthHistoryGetAsync(
            string? model = default,
            string? statusFilter = default,
            int? limit = default,
            int? offset = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Health Check History Endpoint<br/>
        /// Get health check history for models<br/>
        /// Returns historical health check data with optional filtering.
        /// </summary>
        /// <param name="model">
        /// Filter by specific model name
        /// </param>
        /// <param name="statusFilter">
        /// Filter by status (healthy/unhealthy)
        /// </param>
        /// <param name="limit">
        /// Number of records to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Number of records to skip<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> HealthCheckHistoryEndpointHealthHistoryGetAsResponseAsync(
            string? model = default,
            string? statusFilter = default,
            int? limit = default,
            int? offset = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}