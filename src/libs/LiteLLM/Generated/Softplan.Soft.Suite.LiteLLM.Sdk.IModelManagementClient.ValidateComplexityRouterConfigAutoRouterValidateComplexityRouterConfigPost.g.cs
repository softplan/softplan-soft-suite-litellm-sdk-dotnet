#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Validate Complexity Router Config<br/>
        /// Validate a complexity-router config without saving it.<br/>
        /// Runs the same check every write path runs (the router's own pydantic model), so a form can<br/>
        /// show the backend's exact verdict while the operator is still editing rather than after a<br/>
        /// rejected save. Uses the same team opt-in and model-access checks as configuration<br/>
        /// writes for members. Nothing is created, routed, or billed.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.ComplexityRouterConfigValidationResponse> ValidateComplexityRouterConfigAutoRouterValidateComplexityRouterConfigPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.ComplexityRouterConfigValidationRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate Complexity Router Config<br/>
        /// Validate a complexity-router config without saving it.<br/>
        /// Runs the same check every write path runs (the router's own pydantic model), so a form can<br/>
        /// show the backend's exact verdict while the operator is still editing rather than after a<br/>
        /// rejected save. Uses the same team opt-in and model-access checks as configuration<br/>
        /// writes for members. Nothing is created, routed, or billed.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.ComplexityRouterConfigValidationResponse>> ValidateComplexityRouterConfigAutoRouterValidateComplexityRouterConfigPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.ComplexityRouterConfigValidationRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate Complexity Router Config<br/>
        /// Validate a complexity-router config without saving it.<br/>
        /// Runs the same check every write path runs (the router's own pydantic model), so a form can<br/>
        /// show the backend's exact verdict while the operator is still editing rather than after a<br/>
        /// rejected save. Uses the same team opt-in and model-access checks as configuration<br/>
        /// writes for members. Nothing is created, routed, or billed.
        /// </summary>
        /// <param name="complexityRouterConfig"></param>
        /// <param name="teamId">
        /// Team the router is being created for. Required for a team admin, who may only validate their own team's routers
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.ComplexityRouterConfigValidationResponse> ValidateComplexityRouterConfigAutoRouterValidateComplexityRouterConfigPostAsync(
            object complexityRouterConfig,
            string? teamId = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}