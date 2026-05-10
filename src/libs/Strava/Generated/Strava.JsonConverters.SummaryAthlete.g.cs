#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Strava.JsonConverters
{
    /// <inheritdoc />
    public class SummaryAthleteJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Strava.SummaryAthlete>
    {
        /// <inheritdoc />
        public override global::Strava.SummaryAthlete Read(
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
            if (__jsonProps.Contains("id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("city")) __score1++;
            if (__jsonProps.Contains("country")) __score1++;
            if (__jsonProps.Contains("created_at")) __score1++;
            if (__jsonProps.Contains("firstname")) __score1++;
            if (__jsonProps.Contains("lastname")) __score1++;
            if (__jsonProps.Contains("premium")) __score1++;
            if (__jsonProps.Contains("profile")) __score1++;
            if (__jsonProps.Contains("profile_medium")) __score1++;
            if (__jsonProps.Contains("resource_state")) __score1++;
            if (__jsonProps.Contains("sex")) __score1++;
            if (__jsonProps.Contains("state")) __score1++;
            if (__jsonProps.Contains("summit")) __score1++;
            if (__jsonProps.Contains("updated_at")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Strava.MetaAthlete? meta = default;
            global::Strava.SummaryAthleteVariant2? summaryAthleteVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.MetaAthlete), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.MetaAthlete> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.MetaAthlete).Name}");
                        meta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummaryAthleteVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummaryAthleteVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummaryAthleteVariant2).Name}");
                        summaryAthleteVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (meta == null && summaryAthleteVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.MetaAthlete), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.MetaAthlete> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.MetaAthlete).Name}");
                    meta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (meta == null && summaryAthleteVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummaryAthleteVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummaryAthleteVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummaryAthleteVariant2).Name}");
                    summaryAthleteVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Strava.SummaryAthlete(
                meta,

                summaryAthleteVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Strava.SummaryAthlete value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMeta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.MetaAthlete), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.MetaAthlete?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.MetaAthlete).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Meta!, typeInfo);
            }
            else if (value.IsSummaryAthleteVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummaryAthleteVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummaryAthleteVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummaryAthleteVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SummaryAthleteVariant2!, typeInfo);
            }
        }
    }
}