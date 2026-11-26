#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IProjectManagementClient
    {
        /// <summary>
        /// Project Info<br/>
        /// Get information about a specific project<br/>
        /// Parameters:<br/>
        /// - project_id: *str* - The project id to fetch info for<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/project/info?project_id=project-123' \<br/>
        /// --header 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMProjectTable> ProjectInfoProjectInfoGetAsync(
            string projectId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Project Info<br/>
        /// Get information about a specific project<br/>
        /// Parameters:<br/>
        /// - project_id: *str* - The project id to fetch info for<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/project/info?project_id=project-123' \<br/>
        /// --header 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMProjectTable>> ProjectInfoProjectInfoGetAsResponseAsync(
            string projectId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}