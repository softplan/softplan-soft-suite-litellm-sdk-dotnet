#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IOrganizationManagementClient
    {
        /// <summary>
        /// Organization Member Add<br/>
        /// [BETA]<br/>
        /// Add new members (either via user_email or user_id) to an organization<br/>
        /// If user doesn't exist, new user row will also be added to User Table<br/>
        /// Only proxy_admin or org_admin of organization, allowed to access this endpoint.<br/>
        /// # Parameters:<br/>
        /// - organization_id: str (required)<br/>
        /// - member: Union[List[Member], Member] (required)<br/>
        ///     - role: Literal[LitellmUserRoles] (required)<br/>
        ///     - user_id: Optional[str]<br/>
        ///     - user_email: Optional[str]<br/>
        /// Note: Either user_id or user_email must be provided for each member.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -X POST 'http://0.0.0.0:4000/organization/member_add'     -H 'Authorization: Bearer sk-1234'     -H 'Content-Type: application/json'     -d '{<br/>
        ///     "organization_id": "45e3e396-ee08-4a61-a88e-16b3ce7e0849",<br/>
        ///     "member": {<br/>
        ///         "role": "internal_user",<br/>
        ///         "user_id": "krrish247652@berri.ai"<br/>
        ///     },<br/>
        ///     "max_budget_in_organization": 100.0<br/>
        /// }'<br/>
        /// ```<br/>
        /// The following is executed in this function:<br/>
        /// 1. Check if organization exists<br/>
        /// 2. Creates a new Internal User if the user_id or user_email is not found in LiteLLM_UserTable<br/>
        /// 3. Add Internal User to the `LiteLLM_OrganizationMembership` table
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationAddMemberResponse> OrganizationMemberAddOrganizationMemberAddPostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationMemberAddRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Organization Member Add<br/>
        /// [BETA]<br/>
        /// Add new members (either via user_email or user_id) to an organization<br/>
        /// If user doesn't exist, new user row will also be added to User Table<br/>
        /// Only proxy_admin or org_admin of organization, allowed to access this endpoint.<br/>
        /// # Parameters:<br/>
        /// - organization_id: str (required)<br/>
        /// - member: Union[List[Member], Member] (required)<br/>
        ///     - role: Literal[LitellmUserRoles] (required)<br/>
        ///     - user_id: Optional[str]<br/>
        ///     - user_email: Optional[str]<br/>
        /// Note: Either user_id or user_email must be provided for each member.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -X POST 'http://0.0.0.0:4000/organization/member_add'     -H 'Authorization: Bearer sk-1234'     -H 'Content-Type: application/json'     -d '{<br/>
        ///     "organization_id": "45e3e396-ee08-4a61-a88e-16b3ce7e0849",<br/>
        ///     "member": {<br/>
        ///         "role": "internal_user",<br/>
        ///         "user_id": "krrish247652@berri.ai"<br/>
        ///     },<br/>
        ///     "max_budget_in_organization": 100.0<br/>
        /// }'<br/>
        /// ```<br/>
        /// The following is executed in this function:<br/>
        /// 1. Check if organization exists<br/>
        /// 2. Creates a new Internal User if the user_id or user_email is not found in LiteLLM_UserTable<br/>
        /// 3. Add Internal User to the `LiteLLM_OrganizationMembership` table
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationAddMemberResponse>> OrganizationMemberAddOrganizationMemberAddPostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationMemberAddRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Organization Member Add<br/>
        /// [BETA]<br/>
        /// Add new members (either via user_email or user_id) to an organization<br/>
        /// If user doesn't exist, new user row will also be added to User Table<br/>
        /// Only proxy_admin or org_admin of organization, allowed to access this endpoint.<br/>
        /// # Parameters:<br/>
        /// - organization_id: str (required)<br/>
        /// - member: Union[List[Member], Member] (required)<br/>
        ///     - role: Literal[LitellmUserRoles] (required)<br/>
        ///     - user_id: Optional[str]<br/>
        ///     - user_email: Optional[str]<br/>
        /// Note: Either user_id or user_email must be provided for each member.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -X POST 'http://0.0.0.0:4000/organization/member_add'     -H 'Authorization: Bearer sk-1234'     -H 'Content-Type: application/json'     -d '{<br/>
        ///     "organization_id": "45e3e396-ee08-4a61-a88e-16b3ce7e0849",<br/>
        ///     "member": {<br/>
        ///         "role": "internal_user",<br/>
        ///         "user_id": "krrish247652@berri.ai"<br/>
        ///     },<br/>
        ///     "max_budget_in_organization": 100.0<br/>
        /// }'<br/>
        /// ```<br/>
        /// The following is executed in this function:<br/>
        /// 1. Check if organization exists<br/>
        /// 2. Creates a new Internal User if the user_id or user_email is not found in LiteLLM_UserTable<br/>
        /// 3. Add Internal User to the `LiteLLM_OrganizationMembership` table
        /// </summary>
        /// <param name="member"></param>
        /// <param name="organizationId"></param>
        /// <param name="maxBudgetInOrganization"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.OrganizationAddMemberResponse> OrganizationMemberAddOrganizationMemberAddPostAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.OrgMember>, global::Softplan.Soft.Suite.LiteLLM.Sdk.OrgMember> member,
            string organizationId,
            double? maxBudgetInOrganization = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}