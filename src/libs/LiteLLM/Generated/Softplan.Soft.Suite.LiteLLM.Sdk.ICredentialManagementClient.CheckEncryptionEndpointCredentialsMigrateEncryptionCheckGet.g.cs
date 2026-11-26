#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ICredentialManagementClient
    {
        /// <summary>
        /// Check Encryption Endpoint<br/>
        /// Read-only residual scan for compliance attestation. Reports how many at-rest<br/>
        /// values are still in the legacy format. ``residual_legacy == 0`` attests no<br/>
        /// legacy ciphertext remains. Admin only; performs no writes.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CheckEncryptionEndpointCredentialsMigrateEncryptionCheckGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Encryption Endpoint<br/>
        /// Read-only residual scan for compliance attestation. Reports how many at-rest<br/>
        /// values are still in the legacy format. ``residual_legacy == 0`` attests no<br/>
        /// legacy ciphertext remains. Admin only; performs no writes.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CheckEncryptionEndpointCredentialsMigrateEncryptionCheckGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}