#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Reset Team Member Budget Fn<br/>
        /// Put a team member back on the team's shared default member budget (`team_member_budget`).<br/>
        /// Drops the member's own budget row link so team-wide changes made through /team/update<br/>
        /// reach them again. Leaves the member with no budget when the team has no default. Spend is untouched.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.TeamMemberResetBudgetResponse> ResetTeamMemberBudgetFnTeamTeamIdMemberUserIdResetBudgetPostAsync(
            string teamId,
            string userId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reset Team Member Budget Fn<br/>
        /// Put a team member back on the team's shared default member budget (`team_member_budget`).<br/>
        /// Drops the member's own budget row link so team-wide changes made through /team/update<br/>
        /// reach them again. Leaves the member with no budget when the team has no default. Spend is untouched.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.TeamMemberResetBudgetResponse>> ResetTeamMemberBudgetFnTeamTeamIdMemberUserIdResetBudgetPostAsResponseAsync(
            string teamId,
            string userId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}