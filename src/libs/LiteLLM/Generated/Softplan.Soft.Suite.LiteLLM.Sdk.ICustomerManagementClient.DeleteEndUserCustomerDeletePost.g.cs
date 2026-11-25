#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ICustomerManagementClient
    {
        /// <summary>
        /// Delete End User<br/>
        /// Delete multiple end-users.<br/>
        /// Parameters:<br/>
        /// - user_ids (List[str], required): The unique `user_id`s for the users to delete<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/customer/delete'         --header 'Authorization: Bearer sk-1234'         --header 'Content-Type: application/json'         --data '{<br/>
        ///         "user_ids" :["ishaan-jaff-5"]<br/>
        /// }'<br/>
        /// See below for all params <br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.DeleteCustomersResponse> DeleteEndUserCustomerDeletePostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.DeleteCustomerRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete End User<br/>
        /// Delete multiple end-users.<br/>
        /// Parameters:<br/>
        /// - user_ids (List[str], required): The unique `user_id`s for the users to delete<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/customer/delete'         --header 'Authorization: Bearer sk-1234'         --header 'Content-Type: application/json'         --data '{<br/>
        ///         "user_ids" :["ishaan-jaff-5"]<br/>
        /// }'<br/>
        /// See below for all params <br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.DeleteCustomersResponse>> DeleteEndUserCustomerDeletePostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.DeleteCustomerRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete End User<br/>
        /// Delete multiple end-users.<br/>
        /// Parameters:<br/>
        /// - user_ids (List[str], required): The unique `user_id`s for the users to delete<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/customer/delete'         --header 'Authorization: Bearer sk-1234'         --header 'Content-Type: application/json'         --data '{<br/>
        ///         "user_ids" :["ishaan-jaff-5"]<br/>
        /// }'<br/>
        /// See below for all params <br/>
        /// ```
        /// </summary>
        /// <param name="userIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.DeleteCustomersResponse> DeleteEndUserCustomerDeletePostAsync(
            global::System.Collections.Generic.IList<string> userIds,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}