
#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionAssistantMessage
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"assistant"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string Role { get; set; } = "assistant";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionTextObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionThinkingBlock, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionRedactedThinkingBlock, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionImageObject>>, object>))]
        public global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionTextObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionThinkingBlock, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionRedactedThinkingBlock, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionImageObject>>, object>? Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionAssistantToolCall>? ToolCalls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        public global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionToolCallFunctionChunk? FunctionCall { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_content")]
        public string? ReasoningContent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionCachedContent? CacheControl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking_blocks")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionThinkingBlock, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionRedactedThinkingBlock>>? ThinkingBlocks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_items")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionReasoningItem>? ReasoningItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAssistantMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="name"></param>
        /// <param name="toolCalls"></param>
        /// <param name="functionCall"></param>
        /// <param name="reasoningContent"></param>
        /// <param name="cacheControl"></param>
        /// <param name="thinkingBlocks"></param>
        /// <param name="reasoningItems"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionAssistantMessage(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionTextObject, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionThinkingBlock, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionRedactedThinkingBlock, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionImageObject>>, object>? content,
            string? name,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionAssistantToolCall>? toolCalls,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionToolCallFunctionChunk? functionCall,
            string? reasoningContent,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionCachedContent? cacheControl,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionThinkingBlock, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionRedactedThinkingBlock>>? thinkingBlocks,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionReasoningItem>? reasoningItems,
            string role = "assistant")
        {
            this.Role = role;
            this.Content = content;
            this.Name = name;
            this.ToolCalls = toolCalls;
            this.FunctionCall = functionCall;
            this.ReasoningContent = reasoningContent;
            this.CacheControl = cacheControl;
            this.ThinkingBlocks = thinkingBlocks;
            this.ReasoningItems = reasoningItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAssistantMessage" /> class.
        /// </summary>
        public ChatCompletionAssistantMessage()
        {
        }

    }
}