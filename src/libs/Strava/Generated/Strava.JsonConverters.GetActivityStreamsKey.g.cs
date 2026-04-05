#nullable enable

namespace Strava.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetActivityStreamsKeyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Strava.GetActivityStreamsKey>
    {
        /// <inheritdoc />
        public override global::Strava.GetActivityStreamsKey Read(
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
                        return global::Strava.GetActivityStreamsKeyExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Strava.GetActivityStreamsKey)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Strava.GetActivityStreamsKey);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Strava.GetActivityStreamsKey value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Strava.GetActivityStreamsKeyExtensions.ToValueString(value));
        }
    }
}
