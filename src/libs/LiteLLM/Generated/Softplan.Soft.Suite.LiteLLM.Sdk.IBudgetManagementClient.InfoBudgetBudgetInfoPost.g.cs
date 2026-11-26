#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IBudgetManagementClient
    {
        /// <summary>
        /// Info Budget<br/>
        /// Get the budget id specific information<br/>
        /// Parameters:<br/>
        /// - budgets: List[str] - The list of budget ids to get information for
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> InfoBudgetBudgetInfoPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.BudgetRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Info Budget<br/>
        /// Get the budget id specific information<br/>
        /// Parameters:<br/>
        /// - budgets: List[str] - The list of budget ids to get information for
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> InfoBudgetBudgetInfoPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.BudgetRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Info Budget<br/>
        /// Get the budget id specific information<br/>
        /// Parameters:<br/>
        /// - budgets: List[str] - The list of budget ids to get information for
        /// </summary>
        /// <param name="budgets"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> InfoBudgetBudgetInfoPostAsync(
            global::System.Collections.Generic.IList<string> budgets,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}