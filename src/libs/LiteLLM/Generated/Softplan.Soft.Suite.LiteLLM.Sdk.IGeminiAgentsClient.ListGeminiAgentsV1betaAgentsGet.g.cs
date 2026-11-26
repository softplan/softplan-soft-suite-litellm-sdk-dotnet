#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IGeminiAgentsClient
    {
        /// <summary>
        /// List Gemini Agents<br/>
        /// List all custom agents on the Gemini side.<br/>
        /// Pass per-request Gemini credentials via the JSON-encoded<br/>
        /// ``litellm_params_template`` query parameter. Flat query parameters<br/>
        /// (e.g. ``?api_key=AIza...``) are intentionally ignored — see<br/>
        /// ``_merge_query_params_into_data`` for the rationale.<br/>
        /// ```bash<br/>
        /// curl "http://localhost:4000/v1beta/agents?litellm_params_template=%7B%22api_key%22%3A%22AIza...%22%7D" \<br/>
        ///     -H "Authorization: Bearer sk-..."<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListGeminiAgentsV1betaAgentsGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Gemini Agents<br/>
        /// List all custom agents on the Gemini side.<br/>
        /// Pass per-request Gemini credentials via the JSON-encoded<br/>
        /// ``litellm_params_template`` query parameter. Flat query parameters<br/>
        /// (e.g. ``?api_key=AIza...``) are intentionally ignored — see<br/>
        /// ``_merge_query_params_into_data`` for the rationale.<br/>
        /// ```bash<br/>
        /// curl "http://localhost:4000/v1beta/agents?litellm_params_template=%7B%22api_key%22%3A%22AIza...%22%7D" \<br/>
        ///     -H "Authorization: Bearer sk-..."<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ListGeminiAgentsV1betaAgentsGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}