#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Patch User<br/>
        /// Patch a user according to SCIM v2 protocol
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="feature"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.SCIMUserOutput> PatchUserScimV2UsersUserIdPatchAsync(
            string userId,

            global::Softplan.Soft.Suite.LiteLLM.Sdk.SCIMPatchOp request,
            string? feature = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch User<br/>
        /// Patch a user according to SCIM v2 protocol
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="feature"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.SCIMUserOutput>> PatchUserScimV2UsersUserIdPatchAsResponseAsync(
            string userId,

            global::Softplan.Soft.Suite.LiteLLM.Sdk.SCIMPatchOp request,
            string? feature = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch User<br/>
        /// Patch a user according to SCIM v2 protocol
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="feature"></param>
        /// <param name="operations"></param>
        /// <param name="schemas">
        /// Default Value: [urn:ietf:params:scim:api:messages:2.0:PatchOp]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.SCIMUserOutput> PatchUserScimV2UsersUserIdPatchAsync(
            string userId,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.SCIMPatchOperation> operations,
            string? feature = default,
            global::System.Collections.Generic.IList<string>? schemas = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}