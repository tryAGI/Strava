#nullable enable

namespace Strava.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetSegmentEffortStreamsKeyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Strava.GetSegmentEffortStreamsKey>
    {
        /// <inheritdoc />
        public override global::Strava.GetSegmentEffortStreamsKey Read(
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
                        return global::Strava.GetSegmentEffortStreamsKeyExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Strava.GetSegmentEffortStreamsKey)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Strava.GetSegmentEffortStreamsKey);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Strava.GetSegmentEffortStreamsKey value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Strava.GetSegmentEffortStreamsKeyExtensions.ToValueString(value));
        }
    }
}
