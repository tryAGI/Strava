#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Strava.JsonConverters
{
    /// <inheritdoc />
    public class DistanceStreamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Strava.DistanceStream>
    {
        /// <inheritdoc />
        public override global::Strava.DistanceStream Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("original_size")) __score0++;
            if (__jsonProps.Contains("resolution")) __score0++;
            if (__jsonProps.Contains("series_type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Strava.BaseStream? @base = default;
            global::Strava.DistanceStreamVariant2? distanceStreamVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
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
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.DistanceStreamVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.DistanceStreamVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.DistanceStreamVariant2).Name}");
                        distanceStreamVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && distanceStreamVariant2 == null)
            {
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

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.DistanceStreamVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.DistanceStreamVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.DistanceStreamVariant2).Name}");
                    distanceStreamVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Strava.DistanceStream(
                @base,

                distanceStreamVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Strava.DistanceStream value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.BaseStream), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.BaseStream?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.BaseStream).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base!, typeInfo);
            }
            else if (value.IsDistanceStreamVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.DistanceStreamVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.DistanceStreamVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.DistanceStreamVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DistanceStreamVariant2!, typeInfo);
            }
        }
    }
}