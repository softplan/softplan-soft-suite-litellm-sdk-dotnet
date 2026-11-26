
#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionUserMessage
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"user"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string Role { get; set; } = "user";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionTextObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionImageObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionAudioObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionDocumentObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionVideoObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionFileObject>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionTextObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionImageObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionAudioObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionDocumentObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionVideoObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionFileObject>>> Content { get; set; }

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
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="cacheControl"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionUserMessage(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionTextObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionImageObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionAudioObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionDocumentObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionVideoObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionFileObject>>> content,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionCachedContent? cacheControl,
            string role = "user")
        {
            this.Role = role;
            this.Content = content;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessage" /> class.
        /// </summary>
        public ChatCompletionUserMessage()
        {
        }

    }
}