#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk.JsonConverters
{
    /// <inheritdoc />
    public sealed class CoordinationRedisSettingsFieldSectionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Softplan.Soft.Suite.LiteLLM.Sdk.CoordinationRedisSettingsFieldSection?>
    {
        /// <inheritdoc />
        public override global::Softplan.Soft.Suite.LiteLLM.Sdk.CoordinationRedisSettingsFieldSection? Read(
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
                        return global::Softplan.Soft.Suite.LiteLLM.Sdk.CoordinationRedisSettingsFieldSectionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Softplan.Soft.Suite.LiteLLM.Sdk.CoordinationRedisSettingsFieldSection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Softplan.Soft.Suite.LiteLLM.Sdk.CoordinationRedisSettingsFieldSection?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.CoordinationRedisSettingsFieldSection? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Softplan.Soft.Suite.LiteLLM.Sdk.CoordinationRedisSettingsFieldSectionExtensions.ToValueString(value.Value));
            }
        }
    }
}
