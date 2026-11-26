#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IOrganizationManagementClient
    {
        /// <summary>
        /// Delete Organization<br/>
        /// Delete an organization<br/>
        /// # Parameters:<br/>
        /// - organization_ids: List[str] - The organization ids to delete.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMOrganizationTableWithMembers>> DeleteOrganizationOrganizationDeleteDeleteAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.DeleteOrganizationRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Organization<br/>
        /// Delete an organization<br/>
        /// # Parameters:<br/>
        /// - organization_ids: List[str] - The organization ids to delete.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMOrganizationTableWithMembers>>> DeleteOrganizationOrganizationDeleteDeleteAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.DeleteOrganizationRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Organization<br/>
        /// Delete an organization<br/>
        /// # Parameters:<br/>
        /// - organization_ids: List[str] - The organization ids to delete.
        /// </summary>
        /// <param name="organizationIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMOrganizationTableWithMembers>> DeleteOrganizationOrganizationDeleteDeleteAsync(
            global::System.Collections.Generic.IList<string> organizationIds,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}