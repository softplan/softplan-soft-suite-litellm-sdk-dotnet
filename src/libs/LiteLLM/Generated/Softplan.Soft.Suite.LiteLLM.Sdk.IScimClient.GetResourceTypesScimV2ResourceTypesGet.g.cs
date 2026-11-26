#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Get Resource Types<br/>
        /// SCIM ResourceTypes endpoint per RFC 7644 Section 4.<br/>
        /// Returns a ListResponse of all resource types supported by this service provider.
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetResourceTypesScimV2ResourceTypesGetAsync(
            string? feature = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Resource Types<br/>
        /// SCIM ResourceTypes endpoint per RFC 7644 Section 4.<br/>
        /// Returns a ListResponse of all resource types supported by this service provider.
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetResourceTypesScimV2ResourceTypesGetAsResponseAsync(
            string? feature = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}