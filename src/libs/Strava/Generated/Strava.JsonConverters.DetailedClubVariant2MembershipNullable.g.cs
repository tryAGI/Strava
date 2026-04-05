#nullable enable

namespace Strava.JsonConverters
{
    /// <inheritdoc />
    public sealed class DetailedClubVariant2MembershipNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Strava.DetailedClubVariant2Membership?>
    {
        /// <inheritdoc />
        public override global::Strava.DetailedClubVariant2Membership? Read(
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
                        return global::Strava.DetailedClubVariant2MembershipExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Strava.DetailedClubVariant2Membership)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Strava.DetailedClubVariant2Membership?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Strava.DetailedClubVariant2Membership? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Strava.DetailedClubVariant2MembershipExtensions.ToValueString(value.Value));
            }
        }
    }
}
