#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Create Group<br/>
        /// Create a group according to SCIM v2 protocol
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.SCIMGroup> CreateGroupScimV2GroupsPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.SCIMGroup request,
            string? feature = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Group<br/>
        /// Create a group according to SCIM v2 protocol
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.SCIMGroup>> CreateGroupScimV2GroupsPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.SCIMGroup request,
            string? feature = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Group<br/>
        /// Create a group according to SCIM v2 protocol
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="displayName"></param>
        /// <param name="externalId"></param>
        /// <param name="id"></param>
        /// <param name="members"></param>
        /// <param name="meta"></param>
        /// <param name="schemas"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.SCIMGroup> CreateGroupScimV2GroupsPostAsync(
            string displayName,
            global::System.Collections.Generic.IList<string> schemas,
            string? feature = default,
            string? externalId = default,
            string? id = default,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.SCIMMember>? members = default,
            object? meta = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}