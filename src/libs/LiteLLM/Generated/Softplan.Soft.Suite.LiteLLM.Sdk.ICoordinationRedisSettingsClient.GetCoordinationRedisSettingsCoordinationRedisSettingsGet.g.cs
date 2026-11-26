#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ICoordinationRedisSettingsClient
    {
        /// <summary>
        /// Get Coordination Redis Settings<br/>
        /// Get the coordination Redis configuration and available settings.<br/>
        /// Returns:<br/>
        /// - values: current coordination Redis settings, with password/sentinel_password/url redacted<br/>
        /// - fields: all configurable settings with their metadata (type, description, default, section)<br/>
        /// - source: "coordination_redis" | "cache_backend" | "environment" | null
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.CoordinationRedisSettingsResponse> GetCoordinationRedisSettingsCoordinationRedisSettingsGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Coordination Redis Settings<br/>
        /// Get the coordination Redis configuration and available settings.<br/>
        /// Returns:<br/>
        /// - values: current coordination Redis settings, with password/sentinel_password/url redacted<br/>
        /// - fields: all configurable settings with their metadata (type, description, default, section)<br/>
        /// - source: "coordination_redis" | "cache_backend" | "environment" | null
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.CoordinationRedisSettingsResponse>> GetCoordinationRedisSettingsCoordinationRedisSettingsGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}