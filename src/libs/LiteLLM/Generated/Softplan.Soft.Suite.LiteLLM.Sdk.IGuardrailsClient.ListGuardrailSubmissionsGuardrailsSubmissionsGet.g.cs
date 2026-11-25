#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// List Guardrail Submissions<br/>
        /// List team guardrail submissions. Returns only guardrails with a team_id.<br/>
        /// Admins see all submissions. Non-admin users see submissions for teams they are<br/>
        /// a member of.<br/>
        /// Status values: pending_review (team-registered, awaiting approval), active (approved), rejected.<br/>
        /// Optional filters:<br/>
        /// - status: pending_review | active | rejected<br/>
        /// - team_id: filter by specific team (non-admins must be a member of that team)<br/>
        /// - search: name/description
        /// </summary>
        /// <param name="status"></param>
        /// <param name="teamId"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.ListGuardrailSubmissionsResponse> ListGuardrailSubmissionsGuardrailsSubmissionsGetAsync(
            string? status = default,
            string? teamId = default,
            string? search = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Guardrail Submissions<br/>
        /// List team guardrail submissions. Returns only guardrails with a team_id.<br/>
        /// Admins see all submissions. Non-admin users see submissions for teams they are<br/>
        /// a member of.<br/>
        /// Status values: pending_review (team-registered, awaiting approval), active (approved), rejected.<br/>
        /// Optional filters:<br/>
        /// - status: pending_review | active | rejected<br/>
        /// - team_id: filter by specific team (non-admins must be a member of that team)<br/>
        /// - search: name/description
        /// </summary>
        /// <param name="status"></param>
        /// <param name="teamId"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.ListGuardrailSubmissionsResponse>> ListGuardrailSubmissionsGuardrailsSubmissionsGetAsResponseAsync(
            string? status = default,
            string? teamId = default,
            string? search = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}