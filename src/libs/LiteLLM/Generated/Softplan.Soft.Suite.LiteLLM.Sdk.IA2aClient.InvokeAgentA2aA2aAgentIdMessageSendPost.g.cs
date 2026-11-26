#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IA2aClient
    {
        /// <summary>
        /// Invoke Agent A2A<br/>
        /// Invoke an agent using the A2A protocol (JSON-RPC 2.0).<br/>
        /// Supported methods:<br/>
        /// - message/send: Send a message and get a response<br/>
        /// - message/stream: Send a message and stream the response
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> InvokeAgentA2aA2aAgentIdMessageSendPostAsync(
            string agentId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invoke Agent A2A<br/>
        /// Invoke an agent using the A2A protocol (JSON-RPC 2.0).<br/>
        /// Supported methods:<br/>
        /// - message/send: Send a message and get a response<br/>
        /// - message/stream: Send a message and stream the response
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> InvokeAgentA2aA2aAgentIdMessageSendPostAsResponseAsync(
            string agentId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}