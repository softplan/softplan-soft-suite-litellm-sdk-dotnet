
#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponseLiteLLMManagedVectorStore
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store")]
        public global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMManagedVectorStoresTable? VectorStore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseLiteLLMManagedVectorStore" /> class.
        /// </summary>
        /// <param name="vectorStore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseLiteLLMManagedVectorStore(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.LiteLLMManagedVectorStoresTable? vectorStore)
        {
            this.VectorStore = vectorStore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseLiteLLMManagedVectorStore" /> class.
        /// </summary>
        public ResponseLiteLLMManagedVectorStore()
        {
        }

    }
}