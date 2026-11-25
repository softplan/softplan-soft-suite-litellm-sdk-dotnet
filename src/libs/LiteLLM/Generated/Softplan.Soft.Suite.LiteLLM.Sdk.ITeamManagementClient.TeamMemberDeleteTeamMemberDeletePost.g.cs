#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Team Member Delete<br/>
        /// [BETA]<br/>
        /// delete members (either via user_email or user_id) from a team<br/>
        /// If user doesn't exist, an exception will be raised<br/>
        /// ```<br/>
        /// curl -X POST 'http://0.0.0.0:8000/team/member_delete' <br/>
        /// -H 'Authorization: Bearer sk-1234' <br/>
        /// -H 'Content-Type: application/json' <br/>
        /// -d '{<br/>
        ///     "team_id": "45e3e396-ee08-4a61-a88e-16b3ce7e0849",<br/>
        ///     "user_id": "krrish247652@berri.ai"<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TeamMemberDeleteTeamMemberDeletePostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.TeamMemberDeleteRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Team Member Delete<br/>
        /// [BETA]<br/>
        /// delete members (either via user_email or user_id) from a team<br/>
        /// If user doesn't exist, an exception will be raised<br/>
        /// ```<br/>
        /// curl -X POST 'http://0.0.0.0:8000/team/member_delete' <br/>
        /// -H 'Authorization: Bearer sk-1234' <br/>
        /// -H 'Content-Type: application/json' <br/>
        /// -d '{<br/>
        ///     "team_id": "45e3e396-ee08-4a61-a88e-16b3ce7e0849",<br/>
        ///     "user_id": "krrish247652@berri.ai"<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TeamMemberDeleteTeamMemberDeletePostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.TeamMemberDeleteRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Team Member Delete<br/>
        /// [BETA]<br/>
        /// delete members (either via user_email or user_id) from a team<br/>
        /// If user doesn't exist, an exception will be raised<br/>
        /// ```<br/>
        /// curl -X POST 'http://0.0.0.0:8000/team/member_delete' <br/>
        /// -H 'Authorization: Bearer sk-1234' <br/>
        /// -H 'Content-Type: application/json' <br/>
        /// -d '{<br/>
        ///     "team_id": "45e3e396-ee08-4a61-a88e-16b3ce7e0849",<br/>
        ///     "user_id": "krrish247652@berri.ai"<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userEmail"></param>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TeamMemberDeleteTeamMemberDeletePostAsync(
            string teamId,
            string? userId = default,
            string? userEmail = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}