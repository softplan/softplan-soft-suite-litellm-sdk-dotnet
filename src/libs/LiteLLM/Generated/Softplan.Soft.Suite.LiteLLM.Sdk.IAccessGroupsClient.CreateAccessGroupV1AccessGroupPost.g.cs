#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IAccessGroupsClient
    {
        /// <summary>
        /// Create Access Group
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AccessGroupResponse> CreateAccessGroupV1AccessGroupPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.AccessGroupCreateRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Access Group
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.AccessGroupResponse>> CreateAccessGroupV1AccessGroupPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.AccessGroupCreateRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Access Group
        /// </summary>
        /// <param name="accessAgentIds"></param>
        /// <param name="accessGroupName"></param>
        /// <param name="accessMcpServerIds"></param>
        /// <param name="accessModelNames"></param>
        /// <param name="assignedKeyIds"></param>
        /// <param name="assignedTeamIds"></param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AccessGroupResponse> CreateAccessGroupV1AccessGroupPostAsync(
            string accessGroupName,
            global::System.Collections.Generic.IList<string>? accessAgentIds = default,
            global::System.Collections.Generic.IList<string>? accessMcpServerIds = default,
            global::System.Collections.Generic.IList<string>? accessModelNames = default,
            global::System.Collections.Generic.IList<string>? assignedKeyIds = default,
            global::System.Collections.Generic.IList<string>? assignedTeamIds = default,
            string? description = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}