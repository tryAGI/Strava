#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Strava.JsonConverters
{
    /// <inheritdoc />
    public class DetailedAthleteJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Strava.DetailedAthlete>
    {
        /// <inheritdoc />
        public override global::Strava.DetailedAthlete Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("bikes")) __score1++;
            if (__jsonProps.Contains("clubs")) __score1++;
            if (__jsonProps.Contains("follower_count")) __score1++;
            if (__jsonProps.Contains("friend_count")) __score1++;
            if (__jsonProps.Contains("ftp")) __score1++;
            if (__jsonProps.Contains("measurement_preference")) __score1++;
            if (__jsonProps.Contains("shoes")) __score1++;
            if (__jsonProps.Contains("weight")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Strava.SummaryAthlete? summary = default;
            global::Strava.DetailedAthleteVariant2? detailedAthleteVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummaryAthlete), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummaryAthlete> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummaryAthlete).Name}");
                        summary = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.DetailedAthleteVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.DetailedAthleteVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.DetailedAthleteVariant2).Name}");
                        detailedAthleteVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (summary == null && detailedAthleteVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummaryAthlete), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummaryAthlete> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummaryAthlete).Name}");
                    summary = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.DetailedAthleteVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.DetailedAthleteVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.DetailedAthleteVariant2).Name}");
                    detailedAthleteVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Strava.DetailedAthlete(
                summary,

                detailedAthleteVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Strava.DetailedAthlete value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSummary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummaryAthlete), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummaryAthlete> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummaryAthlete).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Summary!.Value, typeInfo);
            }
            else if (value.IsDetailedAthleteVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.DetailedAthleteVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.DetailedAthleteVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.DetailedAthleteVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DetailedAthleteVariant2!, typeInfo);
            }
        }
    }
}