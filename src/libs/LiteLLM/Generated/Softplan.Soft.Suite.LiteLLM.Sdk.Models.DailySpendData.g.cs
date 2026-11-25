
#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DailySpendData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.LiteLLM.Sdk.SpendMetrics Metrics { get; set; }

        /// <summary>
        /// Breakdown of spend by different dimensions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breakdown")]
        public global::Softplan.Soft.Suite.LiteLLM.Sdk.BreakdownMetrics? Breakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailySpendData" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="metrics"></param>
        /// <param name="breakdown">
        /// Breakdown of spend by different dimensions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DailySpendData(
            global::System.DateTime date,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.SpendMetrics metrics,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.BreakdownMetrics? breakdown)
        {
            this.Date = date;
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
            this.Breakdown = breakdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailySpendData" /> class.
        /// </summary>
        public DailySpendData()
        {
        }

    }
}