#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ICachingClient
    {
        /// <summary>
        /// Cache Flushall<br/>
        /// A function to flush all items from the cache. (All items will be deleted from the cache with this)<br/>
        /// Raises HTTPException if the cache is not initialized or if the cache type does not support flushing.<br/>
        /// Returns a dictionary with the status of the operation.<br/>
        /// Usage:<br/>
        /// ```<br/>
        /// curl -X POST http://0.0.0.0:4000/cache/flushall -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CacheFlushallCacheFlushallPostAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cache Flushall<br/>
        /// A function to flush all items from the cache. (All items will be deleted from the cache with this)<br/>
        /// Raises HTTPException if the cache is not initialized or if the cache type does not support flushing.<br/>
        /// Returns a dictionary with the status of the operation.<br/>
        /// Usage:<br/>
        /// ```<br/>
        /// curl -X POST http://0.0.0.0:4000/cache/flushall -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CacheFlushallCacheFlushallPostAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}