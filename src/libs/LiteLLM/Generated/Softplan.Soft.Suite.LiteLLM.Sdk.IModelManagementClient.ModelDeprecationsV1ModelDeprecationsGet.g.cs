#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Model Deprecations<br/>
        /// List models with known deprecation/sunset dates, bucketed by urgency.<br/>
        /// Reads `deprecation_date` metadata from `model_prices_and_context_window.json`<br/>
        /// (and any per-deployment `model_info.deprecation_date` overrides) for the<br/>
        /// models configured on this proxy.<br/>
        /// Parameters:<br/>
        ///     warn_within_days: Window (in days) used to bucket "imminent" models,<br/>
        ///         30 by default.<br/>
        /// Returns:<br/>
        ///     A payload with three lists of `ModelDeprecationInfo` entries:<br/>
        ///     - `deprecated`: deprecation date is in the past, so these requests may<br/>
        ///       fail at any time.<br/>
        ///     - `imminent`: deprecation date is within `warn_within_days` from today.<br/>
        ///     - `upcoming`: deprecation date is further out.<br/>
        /// Example:<br/>
        /// ```shell<br/>
        /// curl -X GET 'http://localhost:4000/model/deprecations' \<br/>
        ///     -H 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="warnWithinDays">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.ModelDeprecationResponse> ModelDeprecationsV1ModelDeprecationsGetAsync(
            int? warnWithinDays = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Model Deprecations<br/>
        /// List models with known deprecation/sunset dates, bucketed by urgency.<br/>
        /// Reads `deprecation_date` metadata from `model_prices_and_context_window.json`<br/>
        /// (and any per-deployment `model_info.deprecation_date` overrides) for the<br/>
        /// models configured on this proxy.<br/>
        /// Parameters:<br/>
        ///     warn_within_days: Window (in days) used to bucket "imminent" models,<br/>
        ///         30 by default.<br/>
        /// Returns:<br/>
        ///     A payload with three lists of `ModelDeprecationInfo` entries:<br/>
        ///     - `deprecated`: deprecation date is in the past, so these requests may<br/>
        ///       fail at any time.<br/>
        ///     - `imminent`: deprecation date is within `warn_within_days` from today.<br/>
        ///     - `upcoming`: deprecation date is further out.<br/>
        /// Example:<br/>
        /// ```shell<br/>
        /// curl -X GET 'http://localhost:4000/model/deprecations' \<br/>
        ///     -H 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="warnWithinDays">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.ModelDeprecationResponse>> ModelDeprecationsV1ModelDeprecationsGetAsResponseAsync(
            int? warnWithinDays = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}