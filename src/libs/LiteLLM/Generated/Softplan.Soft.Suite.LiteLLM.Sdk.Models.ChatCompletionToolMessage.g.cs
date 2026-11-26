
#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionToolMessage
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"tool"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string Role { get; set; } = "tool";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionTextObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionImageObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionToolReferenceObject>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionTextObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionImageObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionToolReferenceObject>>> Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionToolMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="toolCallId"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionToolMessage(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionTextObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionImageObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionToolReferenceObject>>> content,
            string toolCallId,
            string role = "tool")
        {
            this.Role = role;
            this.Content = content;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionToolMessage" /> class.
        /// </summary>
        public ChatCompletionToolMessage()
        {
        }

    }
}