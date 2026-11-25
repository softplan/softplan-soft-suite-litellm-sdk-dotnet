#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IA2aClient
    {
        /// <summary>
        /// Get Agent Card<br/>
        /// Get the agent card for an agent (A2A discovery endpoint).<br/>
        /// Supports both standard paths:<br/>
        /// - /.well-known/agent-card.json<br/>
        /// - /.well-known/agent.json<br/>
        /// The URL in the agent card is rewritten to point to the LiteLLM proxy,<br/>
        /// so all subsequent A2A calls go through LiteLLM for logging and cost tracking.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetAgentCardA2aAgentIdWellKnownAgentJsonGetAsync(
            string agentId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Agent Card<br/>
        /// Get the agent card for an agent (A2A discovery endpoint).<br/>
        /// Supports both standard paths:<br/>
        /// - /.well-known/agent-card.json<br/>
        /// - /.well-known/agent.json<br/>
        /// The URL in the agent card is rewritten to point to the LiteLLM proxy,<br/>
        /// so all subsequent A2A calls go through LiteLLM for logging and cost tracking.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetAgentCardA2aAgentIdWellKnownAgentJsonGetAsResponseAsync(
            string agentId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}