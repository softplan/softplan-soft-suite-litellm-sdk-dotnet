
#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionThinkingBlock
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"thinking"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "thinking";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public string? Thinking { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<object, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionCachedContent, object>))]
        public global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<object, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionCachedContent, object>? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionThinkingBlock" /> class.
        /// </summary>
        /// <param name="thinking"></param>
        /// <param name="signature"></param>
        /// <param name="cacheControl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionThinkingBlock(
            string? thinking,
            string? signature,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<object, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionCachedContent, object>? cacheControl,
            string type = "thinking")
        {
            this.Type = type;
            this.Thinking = thinking;
            this.Signature = signature;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionThinkingBlock" /> class.
        /// </summary>
        public ChatCompletionThinkingBlock()
        {
        }

    }
}