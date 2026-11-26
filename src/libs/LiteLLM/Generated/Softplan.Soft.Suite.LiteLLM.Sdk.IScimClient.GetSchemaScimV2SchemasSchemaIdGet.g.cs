#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Get Schema<br/>
        /// Get a single Schema by its URI per RFC 7643 Section 7.
        /// </summary>
        /// <param name="schemaId"></param>
        /// <param name="feature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetSchemaScimV2SchemasSchemaIdGetAsync(
            string schemaId,
            string? feature = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Schema<br/>
        /// Get a single Schema by its URI per RFC 7643 Section 7.
        /// </summary>
        /// <param name="schemaId"></param>
        /// <param name="feature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetSchemaScimV2SchemasSchemaIdGetAsResponseAsync(
            string schemaId,
            string? feature = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}