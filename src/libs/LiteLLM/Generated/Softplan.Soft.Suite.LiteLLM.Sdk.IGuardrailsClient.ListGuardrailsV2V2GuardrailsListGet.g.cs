#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// List Guardrails V2<br/>
        /// List the guardrails that are available in the database using GuardrailRegistry<br/>
        /// 👉 [Guardrail docs](https://docs.litellm.ai/docs/proxy/guardrails/quick_start)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/v2/guardrails/list" -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "guardrails": [<br/>
        ///         {<br/>
        ///             "guardrail_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///             "guardrail_name": "my-bedrock-guard",<br/>
        ///             "litellm_params": {<br/>
        ///                 "guardrail": "bedrock",<br/>
        ///                 "mode": "pre_call",<br/>
        ///                 "guardrailIdentifier": "ff6ujrregl1q",<br/>
        ///                 "guardrailVersion": "DRAFT",<br/>
        ///                 "default_on": true<br/>
        ///             },<br/>
        ///             "guardrail_info": {<br/>
        ///                 "description": "Bedrock content moderation guardrail"<br/>
        ///             }<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.ListGuardrailsResponse> ListGuardrailsV2V2GuardrailsListGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Guardrails V2<br/>
        /// List the guardrails that are available in the database using GuardrailRegistry<br/>
        /// 👉 [Guardrail docs](https://docs.litellm.ai/docs/proxy/guardrails/quick_start)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/v2/guardrails/list" -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "guardrails": [<br/>
        ///         {<br/>
        ///             "guardrail_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///             "guardrail_name": "my-bedrock-guard",<br/>
        ///             "litellm_params": {<br/>
        ///                 "guardrail": "bedrock",<br/>
        ///                 "mode": "pre_call",<br/>
        ///                 "guardrailIdentifier": "ff6ujrregl1q",<br/>
        ///                 "guardrailVersion": "DRAFT",<br/>
        ///                 "default_on": true<br/>
        ///             },<br/>
        ///             "guardrail_info": {<br/>
        ///                 "description": "Bedrock content moderation guardrail"<br/>
        ///             }<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.ListGuardrailsResponse>> ListGuardrailsV2V2GuardrailsListGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}