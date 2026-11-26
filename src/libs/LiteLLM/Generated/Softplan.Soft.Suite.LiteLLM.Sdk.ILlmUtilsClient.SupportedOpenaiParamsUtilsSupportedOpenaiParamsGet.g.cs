#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ILlmUtilsClient
    {
        /// <summary>
        /// Supported Openai Params<br/>
        /// Returns supported openai params for a given litellm model name<br/>
        /// e.g. `gpt-4` vs `gpt-3.5-turbo`<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X GET --location 'http://localhost:4000/utils/supported_openai_params?model=gpt-3.5-turbo-16k'         --header 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SupportedOpenaiParamsUtilsSupportedOpenaiParamsGetAsync(
            string model,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Supported Openai Params<br/>
        /// Returns supported openai params for a given litellm model name<br/>
        /// e.g. `gpt-4` vs `gpt-3.5-turbo`<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X GET --location 'http://localhost:4000/utils/supported_openai_params?model=gpt-3.5-turbo-16k'         --header 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> SupportedOpenaiParamsUtilsSupportedOpenaiParamsGetAsResponseAsync(
            string model,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}