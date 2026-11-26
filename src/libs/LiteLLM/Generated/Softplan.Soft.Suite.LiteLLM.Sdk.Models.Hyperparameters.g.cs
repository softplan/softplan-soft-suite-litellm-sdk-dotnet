
#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Hyperparameters
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<string, int?, object>))]
        public global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, int?, object>? BatchSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate_multiplier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<string, double?, object>))]
        public global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, double?, object>? LearningRateMultiplier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_epochs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<string, int?, object>))]
        public global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, int?, object>? NEpochs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Hyperparameters" /> class.
        /// </summary>
        /// <param name="batchSize"></param>
        /// <param name="learningRateMultiplier"></param>
        /// <param name="nEpochs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Hyperparameters(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, int?, object>? batchSize,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, double?, object>? learningRateMultiplier,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AnyOf<string, int?, object>? nEpochs)
        {
            this.BatchSize = batchSize;
            this.LearningRateMultiplier = learningRateMultiplier;
            this.NEpochs = nEpochs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hyperparameters" /> class.
        /// </summary>
        public Hyperparameters()
        {
        }

    }
}