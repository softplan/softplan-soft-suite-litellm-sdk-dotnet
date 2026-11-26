#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IUiThemeSettingsClient
    {
        /// <summary>
        /// Update Ui Theme Settings<br/>
        /// Update UI theme configuration.<br/>
        /// Updates logo settings for the admin UI.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateUiThemeSettingsUpdateUiThemeSettingsPatchAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.UIThemeConfig request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Ui Theme Settings<br/>
        /// Update UI theme configuration.<br/>
        /// Updates logo settings for the admin UI.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateUiThemeSettingsUpdateUiThemeSettingsPatchAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.UIThemeConfig request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Ui Theme Settings<br/>
        /// Update UI theme configuration.<br/>
        /// Updates logo settings for the admin UI.
        /// </summary>
        /// <param name="logoUrl">
        /// URL or path to custom logo image. Can be a local file path or HTTP/HTTPS URL
        /// </param>
        /// <param name="logoUrlDark">
        /// URL or path to a custom logo image for dark mode. Can be a local file path or HTTP/HTTPS URL. Leave unset to reuse logo_url in dark mode
        /// </param>
        /// <param name="faviconUrl">
        /// URL to custom favicon image. Must be an HTTP/HTTPS URL to a .ico, .png, or .svg file
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateUiThemeSettingsUpdateUiThemeSettingsPatchAsync(
            string? logoUrl = default,
            string? logoUrlDark = default,
            string? faviconUrl = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}