#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ICustomerManagementClient
    {
        /// <summary>
        /// Update End User<br/>
        /// Example curl <br/>
        /// Parameters:<br/>
        /// - user_id: str<br/>
        /// - alias: Optional[str] = None  # human-friendly alias<br/>
        /// - blocked: bool = False  # allow/disallow requests for this end-user<br/>
        /// - max_budget: Optional[float] = None<br/>
        /// - budget_id: Optional[str] = None  # give either a budget_id or max_budget<br/>
        /// - allowed_model_region: Optional[AllowedModelRegion] = (<br/>
        ///     None  # require all user requests to use models in this specific region<br/>
        /// )<br/>
        /// - default_model: Optional[str] = (<br/>
        ///     None  # if no equivalent model in allowed region - default all requests to this model<br/>
        /// )<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - Customer-specific object permissions to control access to resources.<br/>
        ///     Supported fields:<br/>
        ///     * mcp_servers: List[str] - List of allowed MCP server IDs<br/>
        ///     * mcp_access_groups: List[str] - List of MCP access group names<br/>
        ///     * mcp_tool_permissions: Dict[str, List[str]] - Map of server ID to allowed tool names<br/>
        ///     * vector_stores: List[str] - List of allowed vector store IDs<br/>
        ///     * agents: List[str] - List of allowed agent IDs<br/>
        ///     * agent_access_groups: List[str] - List of agent access group names<br/>
        ///     Example: {"mcp_servers": ["server_1"], "vector_stores": ["vector_store_1"]}<br/>
        ///     IF null or {} then no object-level restrictions apply.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/customer/update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "user_id": "test-litellm-user-4",<br/>
        ///     "budget_id": "paid_tier"<br/>
        /// }'<br/>
        /// # Updating object permissions<br/>
        /// curl -L -X POST 'http://localhost:4000/customer/update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "user_id": "user_1",<br/>
        ///     "object_permission": {<br/>
        ///       "mcp_servers": ["server_3"],<br/>
        ///       "vector_stores": ["vector_store_2", "vector_store_3"]<br/>
        ///     }<br/>
        ///   }'<br/>
        /// See below for all params<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.CustomerResponse> UpdateEndUserCustomerUpdatePostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.UpdateCustomerRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update End User<br/>
        /// Example curl <br/>
        /// Parameters:<br/>
        /// - user_id: str<br/>
        /// - alias: Optional[str] = None  # human-friendly alias<br/>
        /// - blocked: bool = False  # allow/disallow requests for this end-user<br/>
        /// - max_budget: Optional[float] = None<br/>
        /// - budget_id: Optional[str] = None  # give either a budget_id or max_budget<br/>
        /// - allowed_model_region: Optional[AllowedModelRegion] = (<br/>
        ///     None  # require all user requests to use models in this specific region<br/>
        /// )<br/>
        /// - default_model: Optional[str] = (<br/>
        ///     None  # if no equivalent model in allowed region - default all requests to this model<br/>
        /// )<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - Customer-specific object permissions to control access to resources.<br/>
        ///     Supported fields:<br/>
        ///     * mcp_servers: List[str] - List of allowed MCP server IDs<br/>
        ///     * mcp_access_groups: List[str] - List of MCP access group names<br/>
        ///     * mcp_tool_permissions: Dict[str, List[str]] - Map of server ID to allowed tool names<br/>
        ///     * vector_stores: List[str] - List of allowed vector store IDs<br/>
        ///     * agents: List[str] - List of allowed agent IDs<br/>
        ///     * agent_access_groups: List[str] - List of agent access group names<br/>
        ///     Example: {"mcp_servers": ["server_1"], "vector_stores": ["vector_store_1"]}<br/>
        ///     IF null or {} then no object-level restrictions apply.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/customer/update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "user_id": "test-litellm-user-4",<br/>
        ///     "budget_id": "paid_tier"<br/>
        /// }'<br/>
        /// # Updating object permissions<br/>
        /// curl -L -X POST 'http://localhost:4000/customer/update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "user_id": "user_1",<br/>
        ///     "object_permission": {<br/>
        ///       "mcp_servers": ["server_3"],<br/>
        ///       "vector_stores": ["vector_store_2", "vector_store_3"]<br/>
        ///     }<br/>
        ///   }'<br/>
        /// See below for all params<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.CustomerResponse>> UpdateEndUserCustomerUpdatePostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.UpdateCustomerRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update End User<br/>
        /// Example curl <br/>
        /// Parameters:<br/>
        /// - user_id: str<br/>
        /// - alias: Optional[str] = None  # human-friendly alias<br/>
        /// - blocked: bool = False  # allow/disallow requests for this end-user<br/>
        /// - max_budget: Optional[float] = None<br/>
        /// - budget_id: Optional[str] = None  # give either a budget_id or max_budget<br/>
        /// - allowed_model_region: Optional[AllowedModelRegion] = (<br/>
        ///     None  # require all user requests to use models in this specific region<br/>
        /// )<br/>
        /// - default_model: Optional[str] = (<br/>
        ///     None  # if no equivalent model in allowed region - default all requests to this model<br/>
        /// )<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - Customer-specific object permissions to control access to resources.<br/>
        ///     Supported fields:<br/>
        ///     * mcp_servers: List[str] - List of allowed MCP server IDs<br/>
        ///     * mcp_access_groups: List[str] - List of MCP access group names<br/>
        ///     * mcp_tool_permissions: Dict[str, List[str]] - Map of server ID to allowed tool names<br/>
        ///     * vector_stores: List[str] - List of allowed vector store IDs<br/>
        ///     * agents: List[str] - List of allowed agent IDs<br/>
        ///     * agent_access_groups: List[str] - List of agent access group names<br/>
        ///     Example: {"mcp_servers": ["server_1"], "vector_stores": ["vector_store_1"]}<br/>
        ///     IF null or {} then no object-level restrictions apply.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/customer/update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "user_id": "test-litellm-user-4",<br/>
        ///     "budget_id": "paid_tier"<br/>
        /// }'<br/>
        /// # Updating object permissions<br/>
        /// curl -L -X POST 'http://localhost:4000/customer/update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "user_id": "user_1",<br/>
        ///     "object_permission": {<br/>
        ///       "mcp_servers": ["server_3"],<br/>
        ///       "vector_stores": ["vector_store_2", "vector_store_3"]<br/>
        ///     }<br/>
        ///   }'<br/>
        /// See below for all params<br/>
        /// ```
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="alias"></param>
        /// <param name="blocked">
        /// Default Value: false
        /// </param>
        /// <param name="maxBudget"></param>
        /// <param name="budgetId"></param>
        /// <param name="allowedModelRegion"></param>
        /// <param name="defaultModel"></param>
        /// <param name="objectPermission"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.CustomerResponse> UpdateEndUserCustomerUpdatePostAsync(
            string userId,
            string? alias = default,
            bool? blocked = default,
            double? maxBudget = default,
            string? budgetId = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.UpdateCustomerRequestAllowedModelRegion2? allowedModelRegion = default,
            string? defaultModel = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMObjectPermissionBase? objectPermission = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}