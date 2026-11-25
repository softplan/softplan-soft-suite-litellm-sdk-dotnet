#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateMCPServerRequestTransportJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Softplan.Soft.Suite.LiteLLM.Sdk.UpdateMCPServerRequestTransport>
    {
        /// <inheritdoc />
        public override global::Softplan.Soft.Suite.LiteLLM.Sdk.UpdateMCPServerRequestTransport Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Softplan.Soft.Suite.LiteLLM.Sdk.UpdateMCPServerRequestTransportExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Softplan.Soft.Suite.LiteLLM.Sdk.UpdateMCPServerRequestTransport)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Softplan.Soft.Suite.LiteLLM.Sdk.UpdateMCPServerRequestTransport);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.UpdateMCPServerRequestTransport value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Softplan.Soft.Suite.LiteLLM.Sdk.UpdateMCPServerRequestTransportExtensions.ToValueString(value));
        }
    }
}
