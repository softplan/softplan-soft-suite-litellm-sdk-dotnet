#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// List Team<br/>
        /// ```<br/>
        /// curl --location --request GET 'http://0.0.0.0:4000/team/list'         --header 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        /// - user_id: str - Optional. If passed will only return teams that the user_id is a member of.<br/>
        /// - organization_id: str - Optional. If passed will only return teams that belong to the organization_id. Pass 'default_organization' to get all teams without organization_id.
        /// </summary>
        /// <param name="userId">
        /// Only return teams which this 'user_id' belongs to
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListTeamTeamListGetAsync(
            string? userId = default,
            string? organizationId = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Team<br/>
        /// ```<br/>
        /// curl --location --request GET 'http://0.0.0.0:4000/team/list'         --header 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        /// - user_id: str - Optional. If passed will only return teams that the user_id is a member of.<br/>
        /// - organization_id: str - Optional. If passed will only return teams that belong to the organization_id. Pass 'default_organization' to get all teams without organization_id.
        /// </summary>
        /// <param name="userId">
        /// Only return teams which this 'user_id' belongs to
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ListTeamTeamListGetAsResponseAsync(
            string? userId = default,
            string? organizationId = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}