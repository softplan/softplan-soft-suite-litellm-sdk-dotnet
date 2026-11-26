#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Video Create Character<br/>
        /// Create a character from an uploaded video file.<br/>
        /// Follows the OpenAI Videos API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/videos/create-character<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/videos/characters"         -H "Authorization: Bearer sk-1234"         -F "video=@character_video.mp4"         -F "name=my_character"<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> VideoCreateCharacterV1VideosCharactersPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.BodyVideoCreateCharacterV1VideosCharactersPost request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video Create Character<br/>
        /// Create a character from an uploaded video file.<br/>
        /// Follows the OpenAI Videos API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/videos/create-character<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/videos/characters"         -H "Authorization: Bearer sk-1234"         -F "video=@character_video.mp4"         -F "name=my_character"<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> VideoCreateCharacterV1VideosCharactersPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.BodyVideoCreateCharacterV1VideosCharactersPost request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video Create Character<br/>
        /// Create a character from an uploaded video file.<br/>
        /// Follows the OpenAI Videos API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/videos/create-character<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/videos/characters"         -H "Authorization: Bearer sk-1234"         -F "video=@character_video.mp4"         -F "name=my_character"<br/>
        /// ```
        /// </summary>
        /// <param name="video"></param>
        /// <param name="videoname"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> VideoCreateCharacterV1VideosCharactersPostAsync(
            byte[] video,
            string videoname,
            string name,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Video Create Character<br/>
        /// Create a character from an uploaded video file.<br/>
        /// Follows the OpenAI Videos API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/videos/create-character<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/videos/characters"         -H "Authorization: Bearer sk-1234"         -F "video=@character_video.mp4"         -F "name=my_character"<br/>
        /// ```
        /// </summary>
        /// <param name="video">
        /// The stream to send as the multipart 'video' file part.
        /// </param>
        /// <param name="videoname"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> VideoCreateCharacterV1VideosCharactersPostAsync(
            global::System.IO.Stream video,
            string videoname,
            string name,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video Create Character<br/>
        /// Create a character from an uploaded video file.<br/>
        /// Follows the OpenAI Videos API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/videos/create-character<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/videos/characters"         -H "Authorization: Bearer sk-1234"         -F "video=@character_video.mp4"         -F "name=my_character"<br/>
        /// ```
        /// </summary>
        /// <param name="video">
        /// The stream to send as the multipart 'video' file part.
        /// </param>
        /// <param name="videoname"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> VideoCreateCharacterV1VideosCharactersPostAsResponseAsync(
            global::System.IO.Stream video,
            string videoname,
            string name,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}