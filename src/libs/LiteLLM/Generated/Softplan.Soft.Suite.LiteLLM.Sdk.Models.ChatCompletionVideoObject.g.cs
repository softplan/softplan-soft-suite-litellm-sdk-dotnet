
#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionVideoObject
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"video_url"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "video_url";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<string, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionVideoUrlObject>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionVideoUrlObject> VideoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionVideoObject" /> class.
        /// </summary>
        /// <param name="videoUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionVideoObject(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, global::Softplan.Soft.Suite.LiteLLM.Sdk.ChatCompletionVideoUrlObject> videoUrl,
            string type = "video_url")
        {
            this.Type = type;
            this.VideoUrl = videoUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionVideoObject" /> class.
        /// </summary>
        public ChatCompletionVideoObject()
        {
        }

    }
}