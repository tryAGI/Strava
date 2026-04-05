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
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("activity_type")) __score0++;
            if (__jsonProps.Contains("athlete_pr_effort")) __score0++;
            if (__jsonProps.Contains("athlete_segment_stats")) __score0++;
            if (__jsonProps.Contains("average_grade")) __score0++;
            if (__jsonProps.Contains("city")) __score0++;
            if (__jsonProps.Contains("climb_category")) __score0++;
            if (__jsonProps.Contains("country")) __score0++;
            if (__jsonProps.Contains("distance")) __score0++;
            if (__jsonProps.Contains("elevation_high")) __score0++;
            if (__jsonProps.Contains("elevation_low")) __score0++;
            if (__jsonProps.Contains("end_latlng")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("maximum_grade")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("private")) __score0++;
            if (__jsonProps.Contains("start_latlng")) __score0++;
            if (__jsonProps.Contains("state")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("athlete_count")) __score1++;
            if (__jsonProps.Contains("created_at")) __score1++;
            if (__jsonProps.Contains("effort_count")) __score1++;
            if (__jsonProps.Contains("hazardous")) __score1++;
            if (__jsonProps.Contains("map")) __score1++;
            if (__jsonProps.Contains("star_count")) __score1++;
            if (__jsonProps.Contains("total_elevation_gain")) __score1++;
            if (__jsonProps.Contains("updated_at")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Strava.SummarySegment? summary = default;
            global::Strava.DetailedSegmentVariant2? detailedSegmentVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
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
                }
                else if (__bestIndex == 1)
                {
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
                }
            }

            if (summary == null && detailedSegmentVariant2 == null)
            {
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

            if (value.IsSummary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummarySegment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummarySegment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummarySegment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Summary!, typeInfo);
            }
            else if (value.IsDetailedSegmentVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.DetailedSegmentVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.DetailedSegmentVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.DetailedSegmentVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DetailedSegmentVariant2!, typeInfo);
            }
        }
    }
}