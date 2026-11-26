#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ISsoSettingsClient
    {
        /// <summary>
        /// Update Internal User Settings<br/>
        /// Update the default internal user parameters for SSO users.<br/>
        /// These settings will be applied to new users who sign in via SSO.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateInternalUserSettingsUpdateInternalUserSettingsPatchAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.DefaultInternalUserParams request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Internal User Settings<br/>
        /// Update the default internal user parameters for SSO users.<br/>
        /// These settings will be applied to new users who sign in via SSO.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateInternalUserSettingsUpdateInternalUserSettingsPatchAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.DefaultInternalUserParams request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Internal User Settings<br/>
        /// Update the default internal user parameters for SSO users.<br/>
        /// These settings will be applied to new users who sign in via SSO.
        /// </summary>
        /// <param name="userRole">
        /// Default role assigned to new users created<br/>
        /// Default Value: internal_user_viewer
        /// </param>
        /// <param name="maxBudget">
        /// Default maximum budget (in USD) for new users created
        /// </param>
        /// <param name="budgetDuration">
        /// Default budget duration for new users (e.g. 'daily', 'weekly', 'monthly')
        /// </param>
        /// <param name="models">
        /// Default list of models that new users can access
        /// </param>
        /// <param name="teams">
        /// Default teams for new users created
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateInternalUserSettingsUpdateInternalUserSettingsPatchAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.DefaultInternalUserParamsUserRole2? userRole = default,
            double? maxBudget = default,
            string? budgetDuration = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.NewUserRequestTeam>, object>? teams = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}