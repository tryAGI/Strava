#nullable enable

namespace Strava.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExplorerSegmentClimbCategoryDescNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Strava.ExplorerSegmentClimbCategoryDesc?>
    {
        /// <inheritdoc />
        public override global::Strava.ExplorerSegmentClimbCategoryDesc? Read(
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
                        return global::Strava.ExplorerSegmentClimbCategoryDescExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Strava.ExplorerSegmentClimbCategoryDesc)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Strava.ExplorerSegmentClimbCategoryDesc?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Strava.ExplorerSegmentClimbCategoryDesc? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Strava.ExplorerSegmentClimbCategoryDescExtensions.ToValueString(value.Value));
            }
        }
    }
}
