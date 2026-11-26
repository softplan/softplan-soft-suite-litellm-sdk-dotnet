#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IOrganizationManagementClient
    {
        /// <summary>
        /// Organization Member Delete<br/>
        /// Delete a member from an organization
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OrganizationMemberDeleteOrganizationMemberDeleteDeleteAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationMemberDeleteRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Organization Member Delete<br/>
        /// Delete a member from an organization
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> OrganizationMemberDeleteOrganizationMemberDeleteDeleteAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationMemberDeleteRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Organization Member Delete<br/>
        /// Delete a member from an organization
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userEmail"></param>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OrganizationMemberDeleteOrganizationMemberDeleteDeleteAsync(
            string organizationId,
            string? userId = default,
            string? userEmail = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}