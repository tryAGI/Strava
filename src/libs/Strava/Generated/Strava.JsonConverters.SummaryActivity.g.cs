#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Strava.JsonConverters
{
    /// <inheritdoc />
    public class SummaryActivityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Strava.SummaryActivity>
    {
        /// <inheritdoc />
        public override global::Strava.SummaryActivity Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Strava.MetaActivity? meta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.MetaActivity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.MetaActivity> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.MetaActivity).Name}");
                meta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Strava.SummaryActivityVariant2? summaryActivityVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummaryActivityVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummaryActivityVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummaryActivityVariant2).Name}");
                summaryActivityVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Strava.SummaryActivity(
                meta,

                summaryActivityVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Strava.SummaryActivity value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsMeta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.MetaActivity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.MetaActivity?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.MetaActivity).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Meta!, typeInfo);
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
            if (value.IsSummaryActivityVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummaryActivityVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummaryActivityVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummaryActivityVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.SummaryActivityVariant2!, typeInfo);
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