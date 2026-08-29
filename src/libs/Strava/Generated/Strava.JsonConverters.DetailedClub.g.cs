#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Strava.JsonConverters
{
    /// <inheritdoc />
    public class DetailedClubJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Strava.DetailedClub>
    {
        /// <inheritdoc />
        public override global::Strava.DetailedClub Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Strava.SummaryClub? summary = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummaryClub), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummaryClub> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummaryClub).Name}");
                summary = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Strava.DetailedClubVariant2? detailedClubVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.DetailedClubVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.DetailedClubVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.DetailedClubVariant2).Name}");
                detailedClubVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Strava.DetailedClub(
                summary,

                detailedClubVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Strava.DetailedClub value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsSummary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummaryClub), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummaryClub> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummaryClub).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Summary!.Value, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsDetailedClubVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.DetailedClubVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.DetailedClubVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.DetailedClubVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.DetailedClubVariant2!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}