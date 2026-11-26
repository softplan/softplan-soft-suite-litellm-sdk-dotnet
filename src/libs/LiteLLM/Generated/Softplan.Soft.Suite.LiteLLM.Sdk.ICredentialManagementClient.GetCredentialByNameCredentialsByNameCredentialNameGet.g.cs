#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ICredentialManagementClient
    {
        /// <summary>
        /// Get Credential By Name<br/>
        /// [BETA] endpoint. This might change unexpectedly.
        /// </summary>
        /// <param name="credentialName">
        /// The credential name, percent-decoded; may contain slashes
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.CredentialItem> GetCredentialByNameCredentialsByNameCredentialNameGetAsync(
            string credentialName,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Credential By Name<br/>
        /// [BETA] endpoint. This might change unexpectedly.
        /// </summary>
        /// <param name="credentialName">
        /// The credential name, percent-decoded; may contain slashes
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.CredentialItem>> GetCredentialByNameCredentialsByNameCredentialNameGetAsResponseAsync(
            string credentialName,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}