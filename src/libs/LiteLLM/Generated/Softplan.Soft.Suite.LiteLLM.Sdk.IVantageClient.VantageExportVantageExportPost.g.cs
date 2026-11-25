#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IVantageClient
    {
        /// <summary>
        /// Vantage Export<br/>
        /// Perform an actual export using the Vantage logger.<br/>
        /// Exports usage data in FOCUS CSV format to the Vantage API.<br/>
        /// Parameters:<br/>
        /// - limit: Optional limit on number of records to export<br/>
        /// - start_time_utc: Optional start time for data export<br/>
        /// - end_time_utc: Optional end time for data export<br/>
        /// Only admin users can perform Vantage exports.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.VantageExportResponse> VantageExportVantageExportPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.VantageExportRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Vantage Export<br/>
        /// Perform an actual export using the Vantage logger.<br/>
        /// Exports usage data in FOCUS CSV format to the Vantage API.<br/>
        /// Parameters:<br/>
        /// - limit: Optional limit on number of records to export<br/>
        /// - start_time_utc: Optional start time for data export<br/>
        /// - end_time_utc: Optional end time for data export<br/>
        /// Only admin users can perform Vantage exports.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.VantageExportResponse>> VantageExportVantageExportPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.VantageExportRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Vantage Export<br/>
        /// Perform an actual export using the Vantage logger.<br/>
        /// Exports usage data in FOCUS CSV format to the Vantage API.<br/>
        /// Parameters:<br/>
        /// - limit: Optional limit on number of records to export<br/>
        /// - start_time_utc: Optional start time for data export<br/>
        /// - end_time_utc: Optional end time for data export<br/>
        /// Only admin users can perform Vantage exports.
        /// </summary>
        /// <param name="endTimeUtc">
        /// End time for data export in UTC
        /// </param>
        /// <param name="limit">
        /// Optional limit on number of records to export (default: no limit)
        /// </param>
        /// <param name="startTimeUtc">
        /// Start time for data export in UTC
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.VantageExportResponse> VantageExportVantageExportPostAsync(
            global::System.DateTime? endTimeUtc = default,
            int? limit = default,
            global::System.DateTime? startTimeUtc = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}