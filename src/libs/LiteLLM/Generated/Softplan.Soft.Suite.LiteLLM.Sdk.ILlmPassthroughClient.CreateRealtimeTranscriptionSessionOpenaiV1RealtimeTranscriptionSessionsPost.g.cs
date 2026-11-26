#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ILlmPassthroughClient
    {
        /// <summary>
        /// Create Realtime Transcription Session<br/>
        /// Create an ephemeral Realtime transcription session<br/>
        /// (POST /v1/realtime/transcription_sessions) for the WebRTC/WebSocket flow.<br/>
        /// Mirrors the client_secrets route but targets the transcription_sessions<br/>
        /// endpoint and encrypts the ephemeral key returned under `client_secret.value`.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.RealtimeTranscriptionSessionResponse> CreateRealtimeTranscriptionSessionOpenaiV1RealtimeTranscriptionSessionsPostAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Realtime Transcription Session<br/>
        /// Create an ephemeral Realtime transcription session<br/>
        /// (POST /v1/realtime/transcription_sessions) for the WebRTC/WebSocket flow.<br/>
        /// Mirrors the client_secrets route but targets the transcription_sessions<br/>
        /// endpoint and encrypts the ephemeral key returned under `client_secret.value`.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.RealtimeTranscriptionSessionResponse>> CreateRealtimeTranscriptionSessionOpenaiV1RealtimeTranscriptionSessionsPostAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}