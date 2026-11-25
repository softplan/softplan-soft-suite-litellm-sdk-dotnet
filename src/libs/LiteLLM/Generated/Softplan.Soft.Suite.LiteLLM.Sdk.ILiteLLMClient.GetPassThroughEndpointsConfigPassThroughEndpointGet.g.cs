#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ILiteLLMClient
    {
        /// <summary>
        /// Get Pass Through Endpoints<br/>
        /// GET configured pass through endpoint.<br/>
        /// If no endpoint_id given, return all configured endpoints.
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.PassThroughEndpointResponse> GetPassThroughEndpointsConfigPassThroughEndpointGetAsync(
            string? endpointId = default,
            string? teamId = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Pass Through Endpoints<br/>
        /// GET configured pass through endpoint.<br/>
        /// If no endpoint_id given, return all configured endpoints.
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.PassThroughEndpointResponse>> GetPassThroughEndpointsConfigPassThroughEndpointGetAsResponseAsync(
            string? endpointId = default,
            string? teamId = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}