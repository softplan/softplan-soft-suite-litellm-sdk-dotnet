#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Update Tool Policy<br/>
        /// Set the input_policy and/or output_policy for a tool (global), or block for a specific team/key (override).<br/>
        /// Parameters:<br/>
        /// - tool_name: str - The tool to update<br/>
        /// - input_policy: optional - "trusted" | "untrusted" | "blocked"<br/>
        /// - output_policy: optional - "trusted" | "untrusted"<br/>
        /// - team_id: optional - if set, create/update override for this team only<br/>
        /// - key_hash: optional - if set, create/update override for this key only
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.ToolPolicyUpdateResponse> UpdateToolPolicyV1ToolPolicyPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.ToolPolicyUpdateRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Tool Policy<br/>
        /// Set the input_policy and/or output_policy for a tool (global), or block for a specific team/key (override).<br/>
        /// Parameters:<br/>
        /// - tool_name: str - The tool to update<br/>
        /// - input_policy: optional - "trusted" | "untrusted" | "blocked"<br/>
        /// - output_policy: optional - "trusted" | "untrusted"<br/>
        /// - team_id: optional - if set, create/update override for this team only<br/>
        /// - key_hash: optional - if set, create/update override for this key only
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.ToolPolicyUpdateResponse>> UpdateToolPolicyV1ToolPolicyPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.ToolPolicyUpdateRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Tool Policy<br/>
        /// Set the input_policy and/or output_policy for a tool (global), or block for a specific team/key (override).<br/>
        /// Parameters:<br/>
        /// - tool_name: str - The tool to update<br/>
        /// - input_policy: optional - "trusted" | "untrusted" | "blocked"<br/>
        /// - output_policy: optional - "trusted" | "untrusted"<br/>
        /// - team_id: optional - if set, create/update override for this team only<br/>
        /// - key_hash: optional - if set, create/update override for this key only
        /// </summary>
        /// <param name="inputPolicy"></param>
        /// <param name="keyAlias"></param>
        /// <param name="keyHash"></param>
        /// <param name="outputPolicy"></param>
        /// <param name="teamId"></param>
        /// <param name="toolName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.ToolPolicyUpdateResponse> UpdateToolPolicyV1ToolPolicyPostAsync(
            string toolName,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.ToolPolicyUpdateRequestInputPolicy2? inputPolicy = default,
            string? keyAlias = default,
            string? keyHash = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.ToolPolicyUpdateRequestOutputPolicy2? outputPolicy = default,
            string? teamId = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}