#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IGoogleGenaiEndpointsClient
    {
        /// <summary>
        /// Google Count Tokens<br/>
        /// ```json<br/>
        /// return {<br/>
        ///     "totalTokens": 31,<br/>
        ///     "totalBillableCharacters": 96,<br/>
        ///     "promptTokensDetails": [<br/>
        ///         {<br/>
        ///         "modality": "TEXT",<br/>
        ///         "tokenCount": 31<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.TokenCountDetailsResponse> GoogleCountTokensV1betaModelsModelNameCountTokensPostAsync(
            string modelName,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Google Count Tokens<br/>
        /// ```json<br/>
        /// return {<br/>
        ///     "totalTokens": 31,<br/>
        ///     "totalBillableCharacters": 96,<br/>
        ///     "promptTokensDetails": [<br/>
        ///         {<br/>
        ///         "modality": "TEXT",<br/>
        ///         "tokenCount": 31<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.TokenCountDetailsResponse>> GoogleCountTokensV1betaModelsModelNameCountTokensPostAsResponseAsync(
            string modelName,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}