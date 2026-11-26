#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ITagManagementClient
    {
        /// <summary>
        /// Delete Tag<br/>
        /// Delete a tag.<br/>
        /// Parameters:<br/>
        /// - name: str - The name of the tag to delete
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteTagTagDeletePostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.TagDeleteRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Tag<br/>
        /// Delete a tag.<br/>
        /// Parameters:<br/>
        /// - name: str - The name of the tag to delete
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> DeleteTagTagDeletePostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.TagDeleteRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Tag<br/>
        /// Delete a tag.<br/>
        /// Parameters:<br/>
        /// - name: str - The name of the tag to delete
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteTagTagDeletePostAsync(
            string name,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}