
#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KeyListResponseObject
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, global::Softplan.Soft.Suite.LiteLLM.Sdk.UserAPIKeyAuth, global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMDeletedVerificationToken>>? Keys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_page")]
        public int? CurrentPage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_pages")]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyListResponseObject" /> class.
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="totalCount"></param>
        /// <param name="currentPage"></param>
        /// <param name="totalPages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyListResponseObject(
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, global::Softplan.Soft.Suite.LiteLLM.Sdk.UserAPIKeyAuth, global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMDeletedVerificationToken>>? keys,
            int? totalCount,
            int? currentPage,
            int? totalPages)
        {
            this.Keys = keys;
            this.TotalCount = totalCount;
            this.CurrentPage = currentPage;
            this.TotalPages = totalPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyListResponseObject" /> class.
        /// </summary>
        public KeyListResponseObject()
        {
        }

    }
}