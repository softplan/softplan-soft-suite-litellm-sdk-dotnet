#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Get Users<br/>
        /// Get a list of users according to SCIM v2 protocol
        /// </summary>
        /// <param name="startIndex">
        /// Default Value: 1
        /// </param>
        /// <param name="count">
        /// Default Value: 10
        /// </param>
        /// <param name="filter"></param>
        /// <param name="feature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.SCIMListResponse> GetUsersScimV2UsersGetAsync(
            int? startIndex = default,
            int? count = default,
            string? filter = default,
            string? feature = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Users<br/>
        /// Get a list of users according to SCIM v2 protocol
        /// </summary>
        /// <param name="startIndex">
        /// Default Value: 1
        /// </param>
        /// <param name="count">
        /// Default Value: 10
        /// </param>
        /// <param name="filter"></param>
        /// <param name="feature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.SCIMListResponse>> GetUsersScimV2UsersGetAsResponseAsync(
            int? startIndex = default,
            int? count = default,
            string? filter = default,
            string? feature = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}