#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Delete Access Group<br/>
        /// Delete an access group.<br/>
        /// Removes the access group from all deployments that have it.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X DELETE 'http://localhost:4000/access_group/production-models/delete' \<br/>
        ///   -H 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        /// - access_group: str - The access group name (URL path parameter)<br/>
        /// Returns:<br/>
        /// - DeleteModelGroupResponse with deletion details<br/>
        /// Raises:<br/>
        /// - HTTPException 404: If access group not found
        /// </summary>
        /// <param name="accessGroup"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.DeleteModelGroupResponse> DeleteAccessGroupAccessGroupAccessGroupDeleteDeleteAsync(
            string accessGroup,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Access Group<br/>
        /// Delete an access group.<br/>
        /// Removes the access group from all deployments that have it.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X DELETE 'http://localhost:4000/access_group/production-models/delete' \<br/>
        ///   -H 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        /// - access_group: str - The access group name (URL path parameter)<br/>
        /// Returns:<br/>
        /// - DeleteModelGroupResponse with deletion details<br/>
        /// Raises:<br/>
        /// - HTTPException 404: If access group not found
        /// </summary>
        /// <param name="accessGroup"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.DeleteModelGroupResponse>> DeleteAccessGroupAccessGroupAccessGroupDeleteDeleteAsResponseAsync(
            string accessGroup,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}