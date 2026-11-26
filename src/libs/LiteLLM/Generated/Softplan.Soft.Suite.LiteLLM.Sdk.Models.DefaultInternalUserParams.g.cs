
#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    /// <summary>
    /// Default parameters to apply when a new user signs in via SSO or is created on the /user/new API endpoint
    /// </summary>
    public sealed partial class DefaultInternalUserParams
    {
        /// <summary>
        /// Default role assigned to new users created<br/>
        /// Default Value: internal_user_viewer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_role")]
        public global::Softplan.Soft.Suite.LiteLLM.Sdk.DefaultInternalUserParamsUserRole2? UserRole { get; set; }

        /// <summary>
        /// Default maximum budget (in USD) for new users created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget")]
        public double? MaxBudget { get; set; }

        /// <summary>
        /// Default budget duration for new users (e.g. 'daily', 'weekly', 'monthly')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_duration")]
        public string? BudgetDuration { get; set; }

        /// <summary>
        /// Default list of models that new users can access
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Default teams for new users created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.NewUserRequestTeam>, object>))]
        public global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.NewUserRequestTeam>, object>? Teams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultInternalUserParams" /> class.
        /// </summary>
        /// <param name="userRole">
        /// Default role assigned to new users created<br/>
        /// Default Value: internal_user_viewer
        /// </param>
        /// <param name="maxBudget">
        /// Default maximum budget (in USD) for new users created
        /// </param>
        /// <param name="budgetDuration">
        /// Default budget duration for new users (e.g. 'daily', 'weekly', 'monthly')
        /// </param>
        /// <param name="models">
        /// Default list of models that new users can access
        /// </param>
        /// <param name="teams">
        /// Default teams for new users created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DefaultInternalUserParams(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.DefaultInternalUserParamsUserRole2? userRole,
            double? maxBudget,
            string? budgetDuration,
            global::System.Collections.Generic.IList<string>? models,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.NewUserRequestTeam>, object>? teams)
        {
            this.UserRole = userRole;
            this.MaxBudget = maxBudget;
            this.BudgetDuration = budgetDuration;
            this.Models = models;
            this.Teams = teams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultInternalUserParams" /> class.
        /// </summary>
        public DefaultInternalUserParams()
        {
        }

    }
}