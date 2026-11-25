#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Test Endpoint<br/>
        /// [DEPRECATED] use `/health/liveliness` instead.<br/>
        /// A test endpoint that pings the proxy server to check if it's healthy.<br/>
        /// Parameters:<br/>
        ///     request (Request): The incoming request.<br/>
        /// Returns:<br/>
        ///     dict: A dictionary containing the route of the request URL.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TestEndpointTestGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Endpoint<br/>
        /// [DEPRECATED] use `/health/liveliness` instead.<br/>
        /// A test endpoint that pings the proxy server to check if it's healthy.<br/>
        /// Parameters:<br/>
        ///     request (Request): The incoming request.<br/>
        /// Returns:<br/>
        ///     dict: A dictionary containing the route of the request URL.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TestEndpointTestGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}