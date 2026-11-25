#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Get Auto Router Classifier Default Prompt<br/>
        /// Get the built-in system prompt used by an auto-router's LLM classifier
        /// </summary>
        /// <param name="contextWindowSize">
        /// Default Value: 3
        /// </param>
        /// <param name="tierLabels"></param>
        /// <param name="classificationRubric"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoRouterClassifierDefaultPromptResponse> GetAutoRouterClassifierDefaultPromptAutoRouterClassifierDefaultPromptGetAsync(
            int? contextWindowSize = default,
            string? tierLabels = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.ClassificationRubric? classificationRubric = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Auto Router Classifier Default Prompt<br/>
        /// Get the built-in system prompt used by an auto-router's LLM classifier
        /// </summary>
        /// <param name="contextWindowSize">
        /// Default Value: 3
        /// </param>
        /// <param name="tierLabels"></param>
        /// <param name="classificationRubric"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoRouterClassifierDefaultPromptResponse>> GetAutoRouterClassifierDefaultPromptAutoRouterClassifierDefaultPromptGetAsResponseAsync(
            int? contextWindowSize = default,
            string? tierLabels = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.ClassificationRubric? classificationRubric = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}