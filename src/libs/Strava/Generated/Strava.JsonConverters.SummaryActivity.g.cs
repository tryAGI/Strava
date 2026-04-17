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
            if (__jsonProps.Contains("id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("achievement_count")) __score1++;
            if (__jsonProps.Contains("athlete")) __score1++;
            if (__jsonProps.Contains("athlete.id")) __score1++;
            if (__jsonProps.Contains("athlete_count")) __score1++;
            if (__jsonProps.Contains("average_speed")) __score1++;
            if (__jsonProps.Contains("average_watts")) __score1++;
            if (__jsonProps.Contains("comment_count")) __score1++;
            if (__jsonProps.Contains("commute")) __score1++;
            if (__jsonProps.Contains("device_name")) __score1++;
            if (__jsonProps.Contains("device_watts")) __score1++;
            if (__jsonProps.Contains("distance")) __score1++;
            if (__jsonProps.Contains("elapsed_time")) __score1++;
            if (__jsonProps.Contains("elev_high")) __score1++;
            if (__jsonProps.Contains("elev_low")) __score1++;
            if (__jsonProps.Contains("end_latlng")) __score1++;
            if (__jsonProps.Contains("external_id")) __score1++;
            if (__jsonProps.Contains("flagged")) __score1++;
            if (__jsonProps.Contains("gear_id")) __score1++;
            if (__jsonProps.Contains("has_kudoed")) __score1++;
            if (__jsonProps.Contains("hide_from_home")) __score1++;
            if (__jsonProps.Contains("kilojoules")) __score1++;
            if (__jsonProps.Contains("kudos_count")) __score1++;
            if (__jsonProps.Contains("manual")) __score1++;
            if (__jsonProps.Contains("map")) __score1++;
            if (__jsonProps.Contains("map.id")) __score1++;
            if (__jsonProps.Contains("map.polyline")) __score1++;
            if (__jsonProps.Contains("map.summary_polyline")) __score1++;
            if (__jsonProps.Contains("max_speed")) __score1++;
            if (__jsonProps.Contains("max_watts")) __score1++;
            if (__jsonProps.Contains("moving_time")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("photo_count")) __score1++;
            if (__jsonProps.Contains("private")) __score1++;
            if (__jsonProps.Contains("sport_type")) __score1++;
            if (__jsonProps.Contains("start_date")) __score1++;
            if (__jsonProps.Contains("start_date_local")) __score1++;
            if (__jsonProps.Contains("start_latlng")) __score1++;
            if (__jsonProps.Contains("timezone")) __score1++;
            if (__jsonProps.Contains("total_elevation_gain")) __score1++;
            if (__jsonProps.Contains("total_photo_count")) __score1++;
            if (__jsonProps.Contains("trainer")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("upload_id")) __score1++;
            if (__jsonProps.Contains("upload_id_str")) __score1++;
            if (__jsonProps.Contains("weighted_average_watts")) __score1++;
            if (__jsonProps.Contains("workout_type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Strava.MetaActivity? meta = default;
            global::Strava.SummaryActivityVariant2? summaryActivityVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
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
                }
                else if (__bestIndex == 1)
                {
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
                }
            }

            if (meta == null && summaryActivityVariant2 == null)
            {
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

            if (value.IsMeta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.MetaActivity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.MetaActivity?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.MetaActivity).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Meta!, typeInfo);
            }
            else if (value.IsSummaryActivityVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Strava.SummaryActivityVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Strava.SummaryActivityVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Strava.SummaryActivityVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SummaryActivityVariant2!, typeInfo);
            }
        }
    }
}