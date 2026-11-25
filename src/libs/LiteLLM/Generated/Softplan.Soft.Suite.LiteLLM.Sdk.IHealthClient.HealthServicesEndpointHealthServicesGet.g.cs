#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Health Services Endpoint<br/>
        /// Use this admin-only endpoint to check if the service is healthy.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -L -X GET 'http://0.0.0.0:4000/health/services?service=datadog'     -H 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="service">
        /// Specify the service being hit.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthServicesEndpointHealthServicesGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::Softplan.Soft.Suite.LiteLLM.Sdk.HealthServicesEndpointHealthServicesGetService2?, string> service,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Health Services Endpoint<br/>
        /// Use this admin-only endpoint to check if the service is healthy.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -L -X GET 'http://0.0.0.0:4000/health/services?service=datadog'     -H 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="service">
        /// Specify the service being hit.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> HealthServicesEndpointHealthServicesGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::Softplan.Soft.Suite.LiteLLM.Sdk.HealthServicesEndpointHealthServicesGetService2?, string> service,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}