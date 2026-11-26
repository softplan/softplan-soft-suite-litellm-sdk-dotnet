#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ICustomerManagementClient
    {
        /// <summary>
        /// List End User<br/>
        /// [Admin-only] List all available customers<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location --request GET 'http://0.0.0.0:4000/customer/list'         --header 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.CustomerResponse>> ListEndUserCustomerListGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List End User<br/>
        /// [Admin-only] List all available customers<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location --request GET 'http://0.0.0.0:4000/customer/list'         --header 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.CustomerResponse>>> ListEndUserCustomerListGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}