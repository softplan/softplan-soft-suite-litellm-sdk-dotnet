#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IVantageClient
    {
        /// <summary>
        /// Update Vantage Settings<br/>
        /// Update existing Vantage settings.<br/>
        /// Allows updating individual Vantage configuration fields without requiring all fields.<br/>
        /// Only admin users can update Vantage settings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.VantageInitResponse> UpdateVantageSettingsVantageSettingsPutAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.VantageSettingsUpdate request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Vantage Settings<br/>
        /// Update existing Vantage settings.<br/>
        /// Allows updating individual Vantage configuration fields without requiring all fields.<br/>
        /// Only admin users can update Vantage settings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.VantageInitResponse>> UpdateVantageSettingsVantageSettingsPutAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.VantageSettingsUpdate request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Vantage Settings<br/>
        /// Update existing Vantage settings.<br/>
        /// Allows updating individual Vantage configuration fields without requiring all fields.<br/>
        /// Only admin users can update Vantage settings.
        /// </summary>
        /// <param name="apiKey">
        /// New Vantage API key for authentication
        /// </param>
        /// <param name="baseUrl">
        /// New Vantage API base URL
        /// </param>
        /// <param name="integrationToken">
        /// New Vantage integration token
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.VantageInitResponse> UpdateVantageSettingsVantageSettingsPutAsync(
            string? apiKey = default,
            string? baseUrl = default,
            string? integrationToken = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}