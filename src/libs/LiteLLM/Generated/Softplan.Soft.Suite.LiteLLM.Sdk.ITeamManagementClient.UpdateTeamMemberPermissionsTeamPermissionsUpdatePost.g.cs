#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Update Team Member Permissions<br/>
        /// Update the team member permissions for a team
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMTeamTable> UpdateTeamMemberPermissionsTeamPermissionsUpdatePostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.UpdateTeamMemberPermissionsRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Team Member Permissions<br/>
        /// Update the team member permissions for a team
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMTeamTable>> UpdateTeamMemberPermissionsTeamPermissionsUpdatePostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.UpdateTeamMemberPermissionsRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Team Member Permissions<br/>
        /// Update the team member permissions for a team
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="teamMemberPermissions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMTeamTable> UpdateTeamMemberPermissionsTeamPermissionsUpdatePostAsync(
            string teamId,
            global::System.Collections.Generic.IList<string> teamMemberPermissions,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}