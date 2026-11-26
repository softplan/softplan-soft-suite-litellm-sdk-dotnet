
#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenericGuardrailAPIInputs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<string>? Images { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_holdback_chars")]
        public global::System.Collections.Generic.IList<int>? StreamHoldbackChars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured_messages")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionUserMessage, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionAssistantMessage, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionToolMessage, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionSystemMessage, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionFunctionMessage, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionDeveloperMessage>>? StructuredMessages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texts")]
        public global::System.Collections.Generic.IList<string>? Texts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionToolCallChunk>, global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionMessageToolCall>>))]
        public global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionToolCallChunk>, global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionMessageToolCall>>? ToolCalls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionToolParam>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericGuardrailAPIInputs" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="model"></param>
        /// <param name="streamHoldbackChars"></param>
        /// <param name="structuredMessages"></param>
        /// <param name="texts"></param>
        /// <param name="toolCalls"></param>
        /// <param name="tools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenericGuardrailAPIInputs(
            global::System.Collections.Generic.IList<string>? images,
            string? model,
            global::System.Collections.Generic.IList<int>? streamHoldbackChars,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionUserMessage, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionAssistantMessage, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionToolMessage, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionSystemMessage, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionFunctionMessage, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionDeveloperMessage>>? structuredMessages,
            global::System.Collections.Generic.IList<string>? texts,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionToolCallChunk>, global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionMessageToolCall>>? toolCalls,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionToolParam>? tools)
        {
            this.Images = images;
            this.Model = model;
            this.StreamHoldbackChars = streamHoldbackChars;
            this.StructuredMessages = structuredMessages;
            this.Texts = texts;
            this.ToolCalls = toolCalls;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericGuardrailAPIInputs" /> class.
        /// </summary>
        public GenericGuardrailAPIInputs()
        {
        }

    }
}