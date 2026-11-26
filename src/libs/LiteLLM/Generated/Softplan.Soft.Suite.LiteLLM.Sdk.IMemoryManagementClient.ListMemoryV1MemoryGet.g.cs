#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IMemoryManagementClient
    {
        /// <summary>
        /// List Memory<br/>
        /// List memory entries visible to the caller.
        /// </summary>
        /// <param name="key">
        /// Filter by exact key match.
        /// </param>
        /// <param name="keyPrefix">
        /// Filter by key prefix (Redis-style namespace scan). Mutually exclusive with `key`; if both are provided, `key_prefix` wins.
        /// </param>
        /// <param name="search">
        /// Match entries whose key starts with this value or whose memory_id equals it. Takes precedence over `key_prefix` and `key` when provided.
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.MemoryListResponse> ListMemoryV1MemoryGetAsync(
            string? key = default,
            string? keyPrefix = default,
            string? search = default,
            int? page = default,
            int? pageSize = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Memory<br/>
        /// List memory entries visible to the caller.
        /// </summary>
        /// <param name="key">
        /// Filter by exact key match.
        /// </param>
        /// <param name="keyPrefix">
        /// Filter by key prefix (Redis-style namespace scan). Mutually exclusive with `key`; if both are provided, `key_prefix` wins.
        /// </param>
        /// <param name="search">
        /// Match entries whose key starts with this value or whose memory_id equals it. Takes precedence over `key_prefix` and `key` when provided.
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.MemoryListResponse>> ListMemoryV1MemoryGetAsResponseAsync(
            string? key = default,
            string? keyPrefix = default,
            string? search = default,
            int? page = default,
            int? pageSize = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}