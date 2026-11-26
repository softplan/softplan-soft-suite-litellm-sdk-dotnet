#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Preview Auto Router Classifier Prompt<br/>
        /// Get the system prompt an auto-router's LLM classifier sends for an edited tier set
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoRouterClassifierDefaultPromptResponse> PreviewAutoRouterClassifierPromptAutoRouterClassifierDefaultPromptPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoRouterClassifierPromptPreviewRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview Auto Router Classifier Prompt<br/>
        /// Get the system prompt an auto-router's LLM classifier sends for an edited tier set
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoRouterClassifierDefaultPromptResponse>> PreviewAutoRouterClassifierPromptAutoRouterClassifierDefaultPromptPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoRouterClassifierPromptPreviewRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview Auto Router Classifier Prompt<br/>
        /// Get the system prompt an auto-router's LLM classifier sends for an edited tier set
        /// </summary>
        /// <param name="tierDefinitions"></param>
        /// <param name="tierLabels"></param>
        /// <param name="classificationRubric"></param>
        /// <param name="contextWindowSize">
        /// Default Value: 3
        /// </param>
        /// <param name="classificationPrompt"></param>
        /// <param name="classificationExamples"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoRouterClassifierDefaultPromptResponse> PreviewAutoRouterClassifierPromptAutoRouterClassifierDefaultPromptPostAsync(
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.TierDefinition>? tierDefinitions = default,
            global::System.Collections.Generic.Dictionary<string, string>? tierLabels = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.ClassificationRubric? classificationRubric = default,
            int? contextWindowSize = default,
            string? classificationPrompt = default,
            string? classificationExamples = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}