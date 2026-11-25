#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IGoogleGenaiEndpointsClient
    {
        /// <summary>
        /// Cancel Interaction<br/>
        /// Cancel an interaction by ID.<br/>
        /// Per OpenAPI spec: POST /{api_version}/interactions/{interaction_id}:cancel
        /// </summary>
        /// <param name="interactionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CancelInteractionV1betaInteractionsInteractionIdCancelPostAsync(
            string interactionId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Interaction<br/>
        /// Cancel an interaction by ID.<br/>
        /// Per OpenAPI spec: POST /{api_version}/interactions/{interaction_id}:cancel
        /// </summary>
        /// <param name="interactionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CancelInteractionV1betaInteractionsInteractionIdCancelPostAsResponseAsync(
            string interactionId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}