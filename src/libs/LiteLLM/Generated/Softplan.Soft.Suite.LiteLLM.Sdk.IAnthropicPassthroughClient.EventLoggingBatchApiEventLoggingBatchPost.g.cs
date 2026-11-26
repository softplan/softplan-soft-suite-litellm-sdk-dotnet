#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IAnthropicPassthroughClient
    {
        /// <summary>
        /// Event Logging Batch<br/>
        /// Stubbed endpoint for Anthropic event logging batch requests.<br/>
        /// This endpoint accepts event logging requests but does nothing with them.<br/>
        /// It exists to prevent 404 errors from Claude Code clients that send telemetry.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> EventLoggingBatchApiEventLoggingBatchPostAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Event Logging Batch<br/>
        /// Stubbed endpoint for Anthropic event logging batch requests.<br/>
        /// This endpoint accepts event logging requests but does nothing with them.<br/>
        /// It exists to prevent 404 errors from Claude Code clients that send telemetry.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> EventLoggingBatchApiEventLoggingBatchPostAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}