#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Update Model<br/>
        /// Edit existing model params
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateModelModelUpdatePostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.UpdateDeployment request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Model<br/>
        /// Edit existing model params
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateModelModelUpdatePostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.UpdateDeployment request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Model<br/>
        /// Edit existing model params
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="litellmParams"></param>
        /// <param name="modelInfo"></param>
        /// <param name="blocked"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateModelModelUpdatePostAsync(
            string? modelName = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.UpdateLiteLLMParams? litellmParams = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.ModelInfo? modelInfo = default,
            bool? blocked = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}