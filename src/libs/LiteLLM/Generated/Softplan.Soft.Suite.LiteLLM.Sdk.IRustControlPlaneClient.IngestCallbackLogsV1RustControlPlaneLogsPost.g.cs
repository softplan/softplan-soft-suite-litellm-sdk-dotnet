#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IRustControlPlaneClient
    {
        /// <summary>
        /// Ingest Callback Logs<br/>
        /// Replay a batch of finished logging payloads through the callback fan-out.<br/>
        /// Admin-only: the payloads write spend logs and trigger every callback, so this<br/>
        /// is a trusted internal route, not a public surface.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.CallbackLogsResponse> IngestCallbackLogsV1RustControlPlaneLogsPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.CallbackLogsRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ingest Callback Logs<br/>
        /// Replay a batch of finished logging payloads through the callback fan-out.<br/>
        /// Admin-only: the payloads write spend logs and trigger every callback, so this<br/>
        /// is a trusted internal route, not a public surface.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.CallbackLogsResponse>> IngestCallbackLogsV1RustControlPlaneLogsPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.CallbackLogsRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ingest Callback Logs<br/>
        /// Replay a batch of finished logging payloads through the callback fan-out.<br/>
        /// Admin-only: the payloads write spend logs and trigger every callback, so this<br/>
        /// is a trusted internal route, not a public surface.
        /// </summary>
        /// <param name="records"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.CallbackLogsResponse> IngestCallbackLogsV1RustControlPlaneLogsPostAsync(
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.CallbackLogRecord> records,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}