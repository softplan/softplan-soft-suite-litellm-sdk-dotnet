
#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchPromptRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_params")]
        public global::Softplan.Soft.Suite.LiteLLM.Sdk.PromptLiteLLMParams? LitellmParams { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_info")]
        public global::Softplan.Soft.Suite.LiteLLM.Sdk.PromptInfo? PromptInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchPromptRequest" /> class.
        /// </summary>
        /// <param name="litellmParams"></param>
        /// <param name="promptInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchPromptRequest(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.PromptLiteLLMParams? litellmParams,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.PromptInfo? promptInfo)
        {
            this.LitellmParams = litellmParams;
            this.PromptInfo = promptInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchPromptRequest" /> class.
        /// </summary>
        public PatchPromptRequest()
        {
        }

    }
}