#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IBudgetSpendTrackingClient
    {
        /// <summary>
        /// Get Team Spend Report<br/>
        /// Get spend for the calling key's team over a date range, grouped by api_key with a per-model breakdown.<br/>
        /// Callable by any key that belongs to a team: non-admin callers are always<br/>
        /// scoped to their key's team_id, while proxy admins may pass `?team_id=` to<br/>
        /// view any team.
        /// </summary>
        /// <param name="startDate">
        /// Time from which to start viewing spend (YYYY-MM-DD)
        /// </param>
        /// <param name="endDate">
        /// Time till which to view spend (YYYY-MM-DD)
        /// </param>
        /// <param name="teamId">
        /// View spend for a specific team_id. Proxy admin only; other callers are scoped to their key's team.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<object>> GetTeamSpendReportTeamSpendReportGetAsync(
            string? startDate = default,
            string? endDate = default,
            string? teamId = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Team Spend Report<br/>
        /// Get spend for the calling key's team over a date range, grouped by api_key with a per-model breakdown.<br/>
        /// Callable by any key that belongs to a team: non-admin callers are always<br/>
        /// scoped to their key's team_id, while proxy admins may pass `?team_id=` to<br/>
        /// view any team.
        /// </summary>
        /// <param name="startDate">
        /// Time from which to start viewing spend (YYYY-MM-DD)
        /// </param>
        /// <param name="endDate">
        /// Time till which to view spend (YYYY-MM-DD)
        /// </param>
        /// <param name="teamId">
        /// View spend for a specific team_id. Proxy admin only; other callers are scoped to their key's team.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<object>>> GetTeamSpendReportTeamSpendReportGetAsResponseAsync(
            string? startDate = default,
            string? endDate = default,
            string? teamId = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}