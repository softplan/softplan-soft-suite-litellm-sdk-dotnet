#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IOrganizationManagementClient
    {
        /// <summary>
        /// Organization Member Update<br/>
        /// Update a member's role in an organization
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMOrganizationMembershipTable> OrganizationMemberUpdateOrganizationMemberUpdatePatchAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationMemberUpdateRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Organization Member Update<br/>
        /// Update a member's role in an organization
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMOrganizationMembershipTable>> OrganizationMemberUpdateOrganizationMemberUpdatePatchAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationMemberUpdateRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Organization Member Update<br/>
        /// Update a member's role in an organization
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userEmail"></param>
        /// <param name="organizationId"></param>
        /// <param name="maxBudgetInOrganization"></param>
        /// <param name="role"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMOrganizationMembershipTable> OrganizationMemberUpdateOrganizationMemberUpdatePatchAsync(
            string organizationId,
            string? userId = default,
            string? userEmail = default,
            double? maxBudgetInOrganization = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.LitellmUserRoles? role = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}