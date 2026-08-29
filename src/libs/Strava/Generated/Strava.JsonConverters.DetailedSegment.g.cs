#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Strava.JsonConverters
{
    /// <inheritdoc />
    public class DetailedSegmentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Strava.DetailedSegment>
    {
        /// <inheritdoc />
        public override global::Strava.DetailedSegment Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Strava.SummarySegment? summary = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummarySegment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummarySegment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummarySegment).Name}");
                summary = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Strava.DetailedSegmentVariant2? detailedSegmentVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.DetailedSegmentVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.DetailedSegmentVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.DetailedSegmentVariant2).Name}");
                detailedSegmentVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Strava.DetailedSegment(
                summary,

                detailedSegmentVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Strava.DetailedSegment value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsSummary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummarySegment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummarySegment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummarySegment).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Summary!, typeInfo);
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
            if (value.IsDetailedSegmentVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.DetailedSegmentVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.DetailedSegmentVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.DetailedSegmentVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.DetailedSegmentVariant2!, typeInfo);
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