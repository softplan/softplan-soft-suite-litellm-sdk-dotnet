#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ITypeSafeClient
    {
        /// <summary>
        /// TypeSafe Jev System One<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/typesafe)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.TypeSafeSystemOneResponse> SystemOneAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.TypeSafeSystemOneRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// TypeSafe Jev System One<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/typesafe)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.TypeSafeSystemOneResponse>> SystemOneAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.TypeSafeSystemOneRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// TypeSafe Jev System One<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/typesafe)
        /// </summary>
        /// <param name="state">
        /// Content to evaluate, as plain text or structured data.
        /// </param>
        /// <param name="model">
        /// Jev model identifier.<br/>
        /// Default Value: jev-latest
        /// </param>
        /// <param name="questions">
        /// Questions to evaluate against the state, keyed by question id.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.TypeSafeSystemOneResponse> SystemOneAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, object, global::System.Collections.Generic.IList<object>> state,
            global::System.Collections.Generic.Dictionary<string, global::Softplan.Soft.Suite.LiteLLM.Sdk.TypeSafeQuestion> questions,
            string model = "jev-latest",
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}