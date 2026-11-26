#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ICredentialManagementClient
    {
        /// <summary>
        /// Migrate Encryption Endpoint<br/>
        /// Re-encrypt all at-rest credentials into the AES-256-GCM (``v2:gcm:``) format.<br/>
        /// Admin only. Requires ``general_settings.encryption_algorithm: aes-256-gcm``.<br/>
        /// Idempotent and resumable — re-running skips already-migrated values. Pass<br/>
        /// ``dry_run=true`` for a non-mutating scan (equivalent to ``--check``).
        /// </summary>
        /// <param name="dryRun">
        /// If true, scan and report without writing any changes.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MigrateEncryptionEndpointCredentialsMigrateEncryptionPostAsync(
            bool? dryRun = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Migrate Encryption Endpoint<br/>
        /// Re-encrypt all at-rest credentials into the AES-256-GCM (``v2:gcm:``) format.<br/>
        /// Admin only. Requires ``general_settings.encryption_algorithm: aes-256-gcm``.<br/>
        /// Idempotent and resumable — re-running skips already-migrated values. Pass<br/>
        /// ``dry_run=true`` for a non-mutating scan (equivalent to ``--check``).
        /// </summary>
        /// <param name="dryRun">
        /// If true, scan and report without writing any changes.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> MigrateEncryptionEndpointCredentialsMigrateEncryptionPostAsResponseAsync(
            bool? dryRun = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}