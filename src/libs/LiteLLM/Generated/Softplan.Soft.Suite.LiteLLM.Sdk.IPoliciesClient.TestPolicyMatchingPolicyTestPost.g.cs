#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IPoliciesClient
    {
        /// <summary>
        /// Test Policy Matching<br/>
        /// Test which policies would match a given request context.<br/>
        /// This is useful for debugging and understanding policy behavior.<br/>
        /// Request body:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "team_alias": "healthcare-team",<br/>
        ///     "key_alias": "my-api-key",<br/>
        ///     "model": "gpt-4"<br/>
        /// }<br/>
        /// ```<br/>
        /// Returns:<br/>
        /// - matching_policies: List of policy names that match<br/>
        /// - resolved_guardrails: Final list of guardrails that would be applied
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyTestResponse> TestPolicyMatchingPolicyTestPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyMatchContext request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Policy Matching<br/>
        /// Test which policies would match a given request context.<br/>
        /// This is useful for debugging and understanding policy behavior.<br/>
        /// Request body:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "team_alias": "healthcare-team",<br/>
        ///     "key_alias": "my-api-key",<br/>
        ///     "model": "gpt-4"<br/>
        /// }<br/>
        /// ```<br/>
        /// Returns:<br/>
        /// - matching_policies: List of policy names that match<br/>
        /// - resolved_guardrails: Final list of guardrails that would be applied
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyTestResponse>> TestPolicyMatchingPolicyTestPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyMatchContext request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Policy Matching<br/>
        /// Test which policies would match a given request context.<br/>
        /// This is useful for debugging and understanding policy behavior.<br/>
        /// Request body:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "team_alias": "healthcare-team",<br/>
        ///     "key_alias": "my-api-key",<br/>
        ///     "model": "gpt-4"<br/>
        /// }<br/>
        /// ```<br/>
        /// Returns:<br/>
        /// - matching_policies: List of policy names that match<br/>
        /// - resolved_guardrails: Final list of guardrails that would be applied
        /// </summary>
        /// <param name="keyAlias">
        /// API key alias from the request.
        /// </param>
        /// <param name="model">
        /// Model name from the request.
        /// </param>
        /// <param name="tags">
        /// Tags from key/team metadata.
        /// </param>
        /// <param name="teamAlias">
        /// Team alias from the request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.PolicyTestResponse> TestPolicyMatchingPolicyTestPostAsync(
            string? keyAlias = default,
            string? model = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? teamAlias = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}