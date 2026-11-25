
#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionSystemMessage
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"system"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string Role { get; set; } = "system";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<object>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, global::System.Collections.Generic.IList<object>> Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionCachedContent? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionSystemMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="name"></param>
        /// <param name="cacheControl"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionSystemMessage(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, global::System.Collections.Generic.IList<object>> content,
            string? name,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionCachedContent? cacheControl,
            string role = "system")
        {
            this.Role = role;
            this.Content = content;
            this.Name = name;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionSystemMessage" /> class.
        /// </summary>
        public ChatCompletionSystemMessage()
        {
        }

    }
}