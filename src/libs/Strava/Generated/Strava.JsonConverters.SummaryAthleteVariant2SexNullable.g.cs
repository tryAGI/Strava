#nullable enable

namespace Strava.JsonConverters
{
    /// <inheritdoc />
    public sealed class SummaryAthleteVariant2SexNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Strava.SummaryAthleteVariant2Sex?>
    {
        /// <inheritdoc />
        public override global::Strava.SummaryAthleteVariant2Sex? Read(
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
                        return global::Strava.SummaryAthleteVariant2SexExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Strava.SummaryAthleteVariant2Sex)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Strava.SummaryAthleteVariant2Sex?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Strava.SummaryAthleteVariant2Sex? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Strava.SummaryAthleteVariant2SexExtensions.ToValueString(value.Value));
            }
        }
    }
}
