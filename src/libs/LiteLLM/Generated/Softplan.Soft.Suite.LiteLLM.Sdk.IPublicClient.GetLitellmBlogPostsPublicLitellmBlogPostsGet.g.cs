#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Get Litellm Blog Posts<br/>
        /// Public endpoint to get the latest LiteLLM blog posts.<br/>
        /// Fetches from GitHub with a 1-hour in-process cache.<br/>
        /// Falls back to the bundled local backup on any failure.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.BlogPostsResponse> GetLitellmBlogPostsPublicLitellmBlogPostsGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Litellm Blog Posts<br/>
        /// Public endpoint to get the latest LiteLLM blog posts.<br/>
        /// Fetches from GitHub with a 1-hour in-process cache.<br/>
        /// Falls back to the bundled local backup on any failure.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.BlogPostsResponse>> GetLitellmBlogPostsPublicLitellmBlogPostsGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}