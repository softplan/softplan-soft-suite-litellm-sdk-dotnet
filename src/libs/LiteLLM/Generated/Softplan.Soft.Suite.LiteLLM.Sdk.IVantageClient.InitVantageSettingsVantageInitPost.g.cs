#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IVantageClient
    {
        /// <summary>
        /// Init Vantage Settings<br/>
        /// Initialize Vantage settings and store in the database.<br/>
        /// Parameters:<br/>
        /// - api_key: Vantage API key for authentication<br/>
        /// - integration_token: Vantage integration token for the cost-import endpoint<br/>
        /// - base_url: Vantage API base URL (default: https://api.vantage.sh)<br/>
        /// Only admin users can configure Vantage settings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.VantageInitResponse> InitVantageSettingsVantageInitPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.VantageInitRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Init Vantage Settings<br/>
        /// Initialize Vantage settings and store in the database.<br/>
        /// Parameters:<br/>
        /// - api_key: Vantage API key for authentication<br/>
        /// - integration_token: Vantage integration token for the cost-import endpoint<br/>
        /// - base_url: Vantage API base URL (default: https://api.vantage.sh)<br/>
        /// Only admin users can configure Vantage settings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.VantageInitResponse>> InitVantageSettingsVantageInitPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.VantageInitRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Init Vantage Settings<br/>
        /// Initialize Vantage settings and store in the database.<br/>
        /// Parameters:<br/>
        /// - api_key: Vantage API key for authentication<br/>
        /// - integration_token: Vantage integration token for the cost-import endpoint<br/>
        /// - base_url: Vantage API base URL (default: https://api.vantage.sh)<br/>
        /// Only admin users can configure Vantage settings.
        /// </summary>
        /// <param name="apiKey">
        /// Vantage API key for authentication
        /// </param>
        /// <param name="baseUrl">
        /// Vantage API base URL (default: https://api.vantage.sh)<br/>
        /// Default Value: https://api.vantage.sh
        /// </param>
        /// <param name="integrationToken">
        /// Vantage integration token for the cost-import endpoint
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.VantageInitResponse> InitVantageSettingsVantageInitPostAsync(
            string apiKey,
            string integrationToken,
            string? baseUrl = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}