#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IProjectManagementClient
    {
        /// <summary>
        /// Delete Project<br/>
        /// Delete projects<br/>
        /// Parameters:<br/>
        /// - project_ids: *List[str]* - List of project ids to delete<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location --request DELETE 'http://0.0.0.0:4000/project/delete' \<br/>
        /// --header 'Authorization: Bearer sk-1234' \<br/>
        /// --header 'Content-Type: application/json' \<br/>
        /// --data '{<br/>
        ///     "project_ids": ["project-123", "project-456"]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMProjectTable>> DeleteProjectProjectDeleteDeleteAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.DeleteProjectRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Project<br/>
        /// Delete projects<br/>
        /// Parameters:<br/>
        /// - project_ids: *List[str]* - List of project ids to delete<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location --request DELETE 'http://0.0.0.0:4000/project/delete' \<br/>
        /// --header 'Authorization: Bearer sk-1234' \<br/>
        /// --header 'Content-Type: application/json' \<br/>
        /// --data '{<br/>
        ///     "project_ids": ["project-123", "project-456"]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMProjectTable>>> DeleteProjectProjectDeleteDeleteAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.DeleteProjectRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Project<br/>
        /// Delete projects<br/>
        /// Parameters:<br/>
        /// - project_ids: *List[str]* - List of project ids to delete<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location --request DELETE 'http://0.0.0.0:4000/project/delete' \<br/>
        /// --header 'Authorization: Bearer sk-1234' \<br/>
        /// --header 'Content-Type: application/json' \<br/>
        /// --data '{<br/>
        ///     "project_ids": ["project-123", "project-456"]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="projectIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMProjectTable>> DeleteProjectProjectDeleteDeleteAsync(
            global::System.Collections.Generic.IList<string> projectIds,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}