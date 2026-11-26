#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IAnthropicPassthroughClient
    {
        /// <summary>
        /// Anthropic Response<br/>
        /// Use `{PROXY_BASE_URL}/anthropic/v1/messages` instead - [Docs](https://docs.litellm.ai/docs/pass_through/anthropic_completion).<br/>
        /// This was a BETA endpoint that calls 100+ LLMs in the anthropic format.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AnthropicResponseV1MessagesPostAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Anthropic Response<br/>
        /// Use `{PROXY_BASE_URL}/anthropic/v1/messages` instead - [Docs](https://docs.litellm.ai/docs/pass_through/anthropic_completion).<br/>
        /// This was a BETA endpoint that calls 100+ LLMs in the anthropic format.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> AnthropicResponseV1MessagesPostAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}