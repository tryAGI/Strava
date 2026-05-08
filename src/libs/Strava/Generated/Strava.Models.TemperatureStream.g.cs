#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TemperatureStream : global::System.IEquatable<TemperatureStream>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.BaseStream? Base { get; init; }
#else
        public global::Strava.BaseStream? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.BaseStream? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.TemperatureStreamVariant2? TemperatureStreamVariant2 { get; init; }
#else
        public global::Strava.TemperatureStreamVariant2? TemperatureStreamVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TemperatureStreamVariant2))]
#endif
        public bool IsTemperatureStreamVariant2 => TemperatureStreamVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTemperatureStreamVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.TemperatureStreamVariant2? value)
        {
            value = TemperatureStreamVariant2;
            return IsTemperatureStreamVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemperatureStream(global::Strava.BaseStream value) => new TemperatureStream((global::Strava.BaseStream?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.BaseStream?(TemperatureStream @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public TemperatureStream(global::Strava.BaseStream? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemperatureStream(global::Strava.TemperatureStreamVariant2 value) => new TemperatureStream((global::Strava.TemperatureStreamVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.TemperatureStreamVariant2?(TemperatureStream @this) => @this.TemperatureStreamVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TemperatureStream(global::Strava.TemperatureStreamVariant2? value)
        {
            TemperatureStreamVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TemperatureStream(
            global::Strava.BaseStream? @base,
            global::Strava.TemperatureStreamVariant2? temperatureStreamVariant2
            )
        {
            Base = @base;
            TemperatureStreamVariant2 = temperatureStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TemperatureStreamVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            TemperatureStreamVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsTemperatureStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.BaseStream, TResult>? @base = null,
            global::System.Func<global::Strava.TemperatureStreamVariant2, TResult>? temperatureStreamVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsTemperatureStreamVariant2 && temperatureStreamVariant2 != null)
            {
                return temperatureStreamVariant2(TemperatureStreamVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.BaseStream>? @base = null,

            global::System.Action<global::Strava.TemperatureStreamVariant2>? temperatureStreamVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsTemperatureStreamVariant2)
            {
                temperatureStreamVariant2?.Invoke(TemperatureStreamVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Strava.BaseStream>? @base = null,
            global::System.Action<global::Strava.TemperatureStreamVariant2>? temperatureStreamVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsTemperatureStreamVariant2)
            {
                temperatureStreamVariant2?.Invoke(TemperatureStreamVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Strava.BaseStream),
                TemperatureStreamVariant2,
                typeof(global::Strava.TemperatureStreamVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(TemperatureStream other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.BaseStream?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.TemperatureStreamVariant2?>.Default.Equals(TemperatureStreamVariant2, other.TemperatureStreamVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TemperatureStream obj1, TemperatureStream obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TemperatureStream>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TemperatureStream obj1, TemperatureStream obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TemperatureStream o && Equals(o);
        }
    }
}
