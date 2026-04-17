#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Strava.JsonConverters
{
    /// <inheritdoc />
    public class DetailedSegmentEffortJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Strava.DetailedSegmentEffort>
    {
        /// <inheritdoc />
        public override global::Strava.DetailedSegmentEffort Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("activity_id")) __score0++;
            if (__jsonProps.Contains("distance")) __score0++;
            if (__jsonProps.Contains("elapsed_time")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("is_kom")) __score0++;
            if (__jsonProps.Contains("start_date")) __score0++;
            if (__jsonProps.Contains("start_date_local")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("activity")) __score1++;
            if (__jsonProps.Contains("activity.id")) __score1++;
            if (__jsonProps.Contains("athlete")) __score1++;
            if (__jsonProps.Contains("athlete.id")) __score1++;
            if (__jsonProps.Contains("average_cadence")) __score1++;
            if (__jsonProps.Contains("average_heartrate")) __score1++;
            if (__jsonProps.Contains("average_watts")) __score1++;
            if (__jsonProps.Contains("device_watts")) __score1++;
            if (__jsonProps.Contains("end_index")) __score1++;
            if (__jsonProps.Contains("hidden")) __score1++;
            if (__jsonProps.Contains("kom_rank")) __score1++;
            if (__jsonProps.Contains("max_heartrate")) __score1++;
            if (__jsonProps.Contains("moving_time")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("pr_rank")) __score1++;
            if (__jsonProps.Contains("segment")) __score1++;
            if (__jsonProps.Contains("segment.activity_type")) __score1++;
            if (__jsonProps.Contains("segment.athlete_pr_effort")) __score1++;
            if (__jsonProps.Contains("segment.athlete_segment_stats")) __score1++;
            if (__jsonProps.Contains("segment.average_grade")) __score1++;
            if (__jsonProps.Contains("segment.city")) __score1++;
            if (__jsonProps.Contains("segment.climb_category")) __score1++;
            if (__jsonProps.Contains("segment.country")) __score1++;
            if (__jsonProps.Contains("segment.distance")) __score1++;
            if (__jsonProps.Contains("segment.elevation_high")) __score1++;
            if (__jsonProps.Contains("segment.elevation_low")) __score1++;
            if (__jsonProps.Contains("segment.end_latlng")) __score1++;
            if (__jsonProps.Contains("segment.id")) __score1++;
            if (__jsonProps.Contains("segment.maximum_grade")) __score1++;
            if (__jsonProps.Contains("segment.name")) __score1++;
            if (__jsonProps.Contains("segment.private")) __score1++;
            if (__jsonProps.Contains("segment.start_latlng")) __score1++;
            if (__jsonProps.Contains("segment.state")) __score1++;
            if (__jsonProps.Contains("start_index")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Strava.SummarySegmentEffort? summary = default;
            global::Strava.DetailedSegmentEffortVariant2? detailedSegmentEffortVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummarySegmentEffort), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummarySegmentEffort> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummarySegmentEffort).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.DetailedSegmentEffortVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.DetailedSegmentEffortVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.DetailedSegmentEffortVariant2).Name}");
                        detailedSegmentEffortVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (summary == null && detailedSegmentEffortVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummarySegmentEffort), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummarySegmentEffort> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummarySegmentEffort).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.DetailedSegmentEffortVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.DetailedSegmentEffortVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.DetailedSegmentEffortVariant2).Name}");
                    detailedSegmentEffortVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Strava.DetailedSegmentEffort(
                summary,

                detailedSegmentEffortVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Strava.DetailedSegmentEffort value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSummary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummarySegmentEffort), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummarySegmentEffort?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummarySegmentEffort).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Summary!, typeInfo);
            }
            else if (value.IsDetailedSegmentEffortVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.DetailedSegmentEffortVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.DetailedSegmentEffortVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.DetailedSegmentEffortVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DetailedSegmentEffortVariant2!, typeInfo);
            }
        }
    }
}