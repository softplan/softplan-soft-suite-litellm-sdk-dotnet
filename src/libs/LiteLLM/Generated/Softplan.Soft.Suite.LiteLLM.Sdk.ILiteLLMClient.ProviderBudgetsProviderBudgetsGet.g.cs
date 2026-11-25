#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ILiteLLMClient
    {
        /// <summary>
        /// Provider Budgets<br/>
        /// Provider Budget Routing - Get Budget, Spend Details https://docs.litellm.ai/docs/proxy/provider_budget_routing<br/>
        /// Use this endpoint to check current budget, spend and budget reset time for a provider<br/>
        /// Example Request<br/>
        /// ```bash<br/>
        /// curl -X GET http://localhost:4000/provider/budgets     -H "Content-Type: application/json"     -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Example Response<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "providers": {<br/>
        ///         "openai": {<br/>
        ///             "budget_limit": 1e-12,<br/>
        ///             "time_period": "1d",<br/>
        ///             "spend": 0.0,<br/>
        ///             "budget_reset_at": null<br/>
        ///         },<br/>
        ///         "azure": {<br/>
        ///             "budget_limit": 100.0,<br/>
        ///             "time_period": "1d",<br/>
        ///             "spend": 0.0,<br/>
        ///             "budget_reset_at": null<br/>
        ///         },<br/>
        ///         "anthropic": {<br/>
        ///             "budget_limit": 100.0,<br/>
        ///             "time_period": "10d",<br/>
        ///             "spend": 0.0,<br/>
        ///             "budget_reset_at": null<br/>
        ///         },<br/>
        ///         "vertex_ai": {<br/>
        ///             "budget_limit": 100.0,<br/>
        ///             "time_period": "12d",<br/>
        ///             "spend": 0.0,<br/>
        ///             "budget_reset_at": null<br/>
        ///         }<br/>
        ///     }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.ProviderBudgetResponse> ProviderBudgetsProviderBudgetsGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Provider Budgets<br/>
        /// Provider Budget Routing - Get Budget, Spend Details https://docs.litellm.ai/docs/proxy/provider_budget_routing<br/>
        /// Use this endpoint to check current budget, spend and budget reset time for a provider<br/>
        /// Example Request<br/>
        /// ```bash<br/>
        /// curl -X GET http://localhost:4000/provider/budgets     -H "Content-Type: application/json"     -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Example Response<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "providers": {<br/>
        ///         "openai": {<br/>
        ///             "budget_limit": 1e-12,<br/>
        ///             "time_period": "1d",<br/>
        ///             "spend": 0.0,<br/>
        ///             "budget_reset_at": null<br/>
        ///         },<br/>
        ///         "azure": {<br/>
        ///             "budget_limit": 100.0,<br/>
        ///             "time_period": "1d",<br/>
        ///             "spend": 0.0,<br/>
        ///             "budget_reset_at": null<br/>
        ///         },<br/>
        ///         "anthropic": {<br/>
        ///             "budget_limit": 100.0,<br/>
        ///             "time_period": "10d",<br/>
        ///             "spend": 0.0,<br/>
        ///             "budget_reset_at": null<br/>
        ///         },<br/>
        ///         "vertex_ai": {<br/>
        ///             "budget_limit": 100.0,<br/>
        ///             "time_period": "12d",<br/>
        ///             "spend": 0.0,<br/>
        ///             "budget_reset_at": null<br/>
        ///         }<br/>
        ///     }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.ProviderBudgetResponse>> ProviderBudgetsProviderBudgetsGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}