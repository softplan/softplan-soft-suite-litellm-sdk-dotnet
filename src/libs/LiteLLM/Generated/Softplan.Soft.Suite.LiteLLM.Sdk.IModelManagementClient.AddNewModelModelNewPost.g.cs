#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Add New Model<br/>
        /// Allows adding new models to the model list in the config.yaml
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddNewModelModelNewPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.Deployment request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add New Model<br/>
        /// Allows adding new models to the model list in the config.yaml
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> AddNewModelModelNewPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.Deployment request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add New Model<br/>
        /// Allows adding new models to the model list in the config.yaml
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="litellmParams">
        /// LiteLLM Params with 'model' requirement - used for completions
        /// </param>
        /// <param name="modelInfo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddNewModelModelNewPostAsync(
            string modelName,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMParams litellmParams,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.ModelInfo modelInfo,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}