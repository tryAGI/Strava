#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Strava.JsonConverters
{
    /// <inheritdoc />
    public class CadenceStreamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Strava.CadenceStream>
    {
        /// <inheritdoc />
        public override global::Strava.CadenceStream Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Strava.BaseStream? @base = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.BaseStream), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.BaseStream> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.BaseStream).Name}");
                @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Strava.CadenceStreamVariant2? cadenceStreamVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.CadenceStreamVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.CadenceStreamVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.CadenceStreamVariant2).Name}");
                cadenceStreamVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Strava.CadenceStream(
                @base,

                cadenceStreamVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Strava.CadenceStream value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.BaseStream), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.BaseStream?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.BaseStream).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Base!, typeInfo);
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
            if (value.IsCadenceStreamVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.CadenceStreamVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.CadenceStreamVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.CadenceStreamVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.CadenceStreamVariant2!, typeInfo);
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