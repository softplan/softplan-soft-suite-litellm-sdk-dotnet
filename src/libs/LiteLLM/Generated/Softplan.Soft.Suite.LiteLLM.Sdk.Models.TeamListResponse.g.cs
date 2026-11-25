
#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    /// <summary>
    /// Response to get the list of teams
    /// </summary>
    public sealed partial class TeamListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::Softplan.Soft.Suite.LiteLLM.Sdk.TeamListItem, global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMTeamTable, global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMDeletedTeamTable>> Teams { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamListResponse" /> class.
        /// </summary>
        /// <param name="teams"></param>
        /// <param name="total"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalPages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamListResponse(
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::Softplan.Soft.Suite.LiteLLM.Sdk.TeamListItem, global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMTeamTable, global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMDeletedTeamTable>> teams,
            int total,
            int page,
            int pageSize,
            int totalPages)
        {
            this.Teams = teams ?? throw new global::System.ArgumentNullException(nameof(teams));
            this.Total = total;
            this.Page = page;
            this.PageSize = pageSize;
            this.TotalPages = totalPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamListResponse" /> class.
        /// </summary>
        public TeamListResponse()
        {
        }

    }
}