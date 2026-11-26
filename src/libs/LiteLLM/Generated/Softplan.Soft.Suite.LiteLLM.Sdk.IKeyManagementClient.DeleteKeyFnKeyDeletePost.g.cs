#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IKeyManagementClient
    {
        /// <summary>
        /// Delete Key Fn<br/>
        /// Delete a key from the key management system.<br/>
        /// Parameters::<br/>
        /// - keys (List[str]): A list of keys or hashed keys to delete. Example {"keys": ["sk-QWrxEynunsNpV1zT48HIrw", "837e17519f44683334df5291321d97b8bf1098cd490e49e215f6fea935aa28be"]}<br/>
        /// - key_aliases (List[str]): A list of key aliases to delete. Can be passed instead of `keys`.Example {"key_aliases": ["alias1", "alias2"]}<br/>
        /// Returns:<br/>
        /// - deleted_keys (List[str]): A list of deleted keys. Example {"deleted_keys": ["sk-QWrxEynunsNpV1zT48HIrw", "837e17519f44683334df5291321d97b8bf1098cd490e49e215f6fea935aa28be"]}<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/key/delete'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "keys": ["sk-QWrxEynunsNpV1zT48HIrw"]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Raises:<br/>
        ///     HTTPException: If an error occurs during key deletion.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteKeyFnKeyDeletePostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.KeyRequest request,
            string? litellmChangedBy = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Key Fn<br/>
        /// Delete a key from the key management system.<br/>
        /// Parameters::<br/>
        /// - keys (List[str]): A list of keys or hashed keys to delete. Example {"keys": ["sk-QWrxEynunsNpV1zT48HIrw", "837e17519f44683334df5291321d97b8bf1098cd490e49e215f6fea935aa28be"]}<br/>
        /// - key_aliases (List[str]): A list of key aliases to delete. Can be passed instead of `keys`.Example {"key_aliases": ["alias1", "alias2"]}<br/>
        /// Returns:<br/>
        /// - deleted_keys (List[str]): A list of deleted keys. Example {"deleted_keys": ["sk-QWrxEynunsNpV1zT48HIrw", "837e17519f44683334df5291321d97b8bf1098cd490e49e215f6fea935aa28be"]}<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/key/delete'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "keys": ["sk-QWrxEynunsNpV1zT48HIrw"]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Raises:<br/>
        ///     HTTPException: If an error occurs during key deletion.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<string>> DeleteKeyFnKeyDeletePostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.KeyRequest request,
            string? litellmChangedBy = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Key Fn<br/>
        /// Delete a key from the key management system.<br/>
        /// Parameters::<br/>
        /// - keys (List[str]): A list of keys or hashed keys to delete. Example {"keys": ["sk-QWrxEynunsNpV1zT48HIrw", "837e17519f44683334df5291321d97b8bf1098cd490e49e215f6fea935aa28be"]}<br/>
        /// - key_aliases (List[str]): A list of key aliases to delete. Can be passed instead of `keys`.Example {"key_aliases": ["alias1", "alias2"]}<br/>
        /// Returns:<br/>
        /// - deleted_keys (List[str]): A list of deleted keys. Example {"deleted_keys": ["sk-QWrxEynunsNpV1zT48HIrw", "837e17519f44683334df5291321d97b8bf1098cd490e49e215f6fea935aa28be"]}<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/key/delete'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "keys": ["sk-QWrxEynunsNpV1zT48HIrw"]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Raises:<br/>
        ///     HTTPException: If an error occurs during key deletion.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="keys"></param>
        /// <param name="keyAliases"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteKeyFnKeyDeletePostAsync(
            string? litellmChangedBy = default,
            global::System.Collections.Generic.IList<string>? keys = default,
            global::System.Collections.Generic.IList<string>? keyAliases = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}