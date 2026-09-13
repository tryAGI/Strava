
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Strava
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.Fault))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.Error>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.BaseStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.BaseStreamResolution), TypeInfoPropertyName = "BaseStreamResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.BaseStreamSeriesType), TypeInfoPropertyName = "BaseStreamSeriesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DistanceStream), TypeInfoPropertyName = "DistanceStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DistanceStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.TimeStream), TypeInfoPropertyName = "TimeStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.TimeStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.LatLngStream), TypeInfoPropertyName = "LatLngStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.LatLngStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.AltitudeStream), TypeInfoPropertyName = "AltitudeStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.AltitudeStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SmoothVelocityStream), TypeInfoPropertyName = "SmoothVelocityStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SmoothVelocityStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.HeartrateStream), TypeInfoPropertyName = "HeartrateStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.HeartrateStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.CadenceStream), TypeInfoPropertyName = "CadenceStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.CadenceStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.PowerStream), TypeInfoPropertyName = "PowerStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.PowerStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.TemperatureStream), TypeInfoPropertyName = "TemperatureStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.TemperatureStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.MovingStream), TypeInfoPropertyName = "MovingStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.MovingStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SmoothGradeStream), TypeInfoPropertyName = "SmoothGradeStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SmoothGradeStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.StreamSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.GetActivityStreamsKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.GetActivityStreamsKey), TypeInfoPropertyName = "GetActivityStreamsKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.GetSegmentEffortStreamsKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.GetSegmentEffortStreamsKey), TypeInfoPropertyName = "GetSegmentEffortStreamsKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.GetSegmentStreamsKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.GetSegmentStreamsKey), TypeInfoPropertyName = "GetSegmentStreamsKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.BaseStreamResolution?), TypeInfoPropertyName = "NullableBaseStreamResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.BaseStreamSeriesType?), TypeInfoPropertyName = "NullableBaseStreamSeriesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DistanceStream?), TypeInfoPropertyName = "NullableDistanceStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.TimeStream?), TypeInfoPropertyName = "NullableTimeStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.LatLngStream?), TypeInfoPropertyName = "NullableLatLngStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.AltitudeStream?), TypeInfoPropertyName = "NullableAltitudeStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SmoothVelocityStream?), TypeInfoPropertyName = "NullableSmoothVelocityStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.HeartrateStream?), TypeInfoPropertyName = "NullableHeartrateStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.CadenceStream?), TypeInfoPropertyName = "NullableCadenceStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.PowerStream?), TypeInfoPropertyName = "NullablePowerStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.TemperatureStream?), TypeInfoPropertyName = "NullableTemperatureStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.MovingStream?), TypeInfoPropertyName = "NullableMovingStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SmoothGradeStream?), TypeInfoPropertyName = "NullableSmoothGradeStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.GetActivityStreamsKey?), TypeInfoPropertyName = "NullableGetActivityStreamsKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.GetSegmentEffortStreamsKey?), TypeInfoPropertyName = "NullableGetSegmentEffortStreamsKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.GetSegmentStreamsKey?), TypeInfoPropertyName = "NullableGetSegmentStreamsKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.Error>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.GetActivityStreamsKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.GetSegmentEffortStreamsKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.GetSegmentStreamsKey>))]
    internal sealed partial class StreamsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StreamsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static StreamsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private StreamsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Strava.JsonConverters.DistanceStreamJsonConverter());
            options.Converters.Add(new global::Strava.JsonConverters.TimeStreamJsonConverter());
            options.Converters.Add(new global::Strava.JsonConverters.LatLngStreamJsonConverter());
            options.Converters.Add(new global::Strava.JsonConverters.AltitudeStreamJsonConverter());
            options.Converters.Add(new global::Strava.JsonConverters.SmoothVelocityStreamJsonConverter());
            options.Converters.Add(new global::Strava.JsonConverters.HeartrateStreamJsonConverter());
            options.Converters.Add(new global::Strava.JsonConverters.CadenceStreamJsonConverter());
            options.Converters.Add(new global::Strava.JsonConverters.PowerStreamJsonConverter());
            options.Converters.Add(new global::Strava.JsonConverters.TemperatureStreamJsonConverter());
            options.Converters.Add(new global::Strava.JsonConverters.MovingStreamJsonConverter());
            options.Converters.Add(new global::Strava.JsonConverters.SmoothGradeStreamJsonConverter());
            options.Converters.Add(new global::Strava.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Strava.BaseStreamResolution)

                    || typeToConvert == typeof(global::Strava.BaseStreamResolution?)

                    || typeToConvert == typeof(global::Strava.BaseStreamSeriesType)

                    || typeToConvert == typeof(global::Strava.BaseStreamSeriesType?)

                    || typeToConvert == typeof(global::Strava.GetActivityStreamsKey)

                    || typeToConvert == typeof(global::Strava.GetActivityStreamsKey?)

                    || typeToConvert == typeof(global::Strava.GetSegmentEffortStreamsKey)

                    || typeToConvert == typeof(global::Strava.GetSegmentEffortStreamsKey?)

                    || typeToConvert == typeof(global::Strava.GetSegmentStreamsKey)

                    || typeToConvert == typeof(global::Strava.GetSegmentStreamsKey?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Strava.BaseStreamResolution))
                {
                    return new global::Strava.JsonConverters.BaseStreamResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Strava.BaseStreamResolution?))
                {
                    return new global::Strava.JsonConverters.BaseStreamResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Strava.BaseStreamSeriesType))
                {
                    return new global::Strava.JsonConverters.BaseStreamSeriesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Strava.BaseStreamSeriesType?))
                {
                    return new global::Strava.JsonConverters.BaseStreamSeriesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Strava.GetActivityStreamsKey))
                {
                    return new global::Strava.JsonConverters.GetActivityStreamsKeyJsonConverter();
                }

                if (typeToConvert == typeof(global::Strava.GetActivityStreamsKey?))
                {
                    return new global::Strava.JsonConverters.GetActivityStreamsKeyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Strava.GetSegmentEffortStreamsKey))
                {
                    return new global::Strava.JsonConverters.GetSegmentEffortStreamsKeyJsonConverter();
                }

                if (typeToConvert == typeof(global::Strava.GetSegmentEffortStreamsKey?))
                {
                    return new global::Strava.JsonConverters.GetSegmentEffortStreamsKeyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Strava.GetSegmentStreamsKey))
                {
                    return new global::Strava.JsonConverters.GetSegmentStreamsKeyJsonConverter();
                }

                if (typeToConvert == typeof(global::Strava.GetSegmentStreamsKey?))
                {
                    return new global::Strava.JsonConverters.GetSegmentStreamsKeyNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new StreamsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}