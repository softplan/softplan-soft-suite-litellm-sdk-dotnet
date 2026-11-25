#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Audio Transcriptions<br/>
        /// Same params as:<br/>
        /// https://platform.openai.com/docs/api-reference/audio/createTranscription?lang=curl
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AudioTranscriptionsV1AudioTranscriptionsPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.BodyAudioTranscriptionsV1AudioTranscriptionsPost request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Audio Transcriptions<br/>
        /// Same params as:<br/>
        /// https://platform.openai.com/docs/api-reference/audio/createTranscription?lang=curl
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> AudioTranscriptionsV1AudioTranscriptionsPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.BodyAudioTranscriptionsV1AudioTranscriptionsPost request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Audio Transcriptions<br/>
        /// Same params as:<br/>
        /// https://platform.openai.com/docs/api-reference/audio/createTranscription?lang=curl
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AudioTranscriptionsV1AudioTranscriptionsPostAsync(
            byte[] file,
            string filename,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Audio Transcriptions<br/>
        /// Same params as:<br/>
        /// https://platform.openai.com/docs/api-reference/audio/createTranscription?lang=curl
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AudioTranscriptionsV1AudioTranscriptionsPostAsync(
            global::System.IO.Stream file,
            string filename,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Audio Transcriptions<br/>
        /// Same params as:<br/>
        /// https://platform.openai.com/docs/api-reference/audio/createTranscription?lang=curl
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> AudioTranscriptionsV1AudioTranscriptionsPostAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}