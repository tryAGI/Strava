#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AltitudeStream : global::System.IEquatable<AltitudeStream>
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
        public global::Strava.AltitudeStreamVariant2? AltitudeStreamVariant2 { get; init; }
#else
        public global::Strava.AltitudeStreamVariant2? AltitudeStreamVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AltitudeStreamVariant2))]
#endif
        public bool IsAltitudeStreamVariant2 => AltitudeStreamVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAltitudeStreamVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.AltitudeStreamVariant2? value)
        {
            value = AltitudeStreamVariant2;
            return IsAltitudeStreamVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AltitudeStream(global::Strava.BaseStream value) => new AltitudeStream((global::Strava.BaseStream?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.BaseStream?(AltitudeStream @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public AltitudeStream(global::Strava.BaseStream? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AltitudeStream FromBase(global::Strava.BaseStream? value) => new AltitudeStream(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AltitudeStream(global::Strava.AltitudeStreamVariant2 value) => new AltitudeStream((global::Strava.AltitudeStreamVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.AltitudeStreamVariant2?(AltitudeStream @this) => @this.AltitudeStreamVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AltitudeStream(global::Strava.AltitudeStreamVariant2? value)
        {
            AltitudeStreamVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AltitudeStream FromAltitudeStreamVariant2(global::Strava.AltitudeStreamVariant2? value) => new AltitudeStream(value);

        /// <summary>
        /// 
        /// </summary>
        public AltitudeStream(
            global::Strava.BaseStream? @base,
            global::Strava.AltitudeStreamVariant2? altitudeStreamVariant2
            )
        {
            Base = @base;
            AltitudeStreamVariant2 = altitudeStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AltitudeStreamVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            AltitudeStreamVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsAltitudeStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.BaseStream, TResult>? @base = null,
            global::System.Func<global::Strava.AltitudeStreamVariant2, TResult>? altitudeStreamVariant2 = null,
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
            else if (IsAltitudeStreamVariant2 && altitudeStreamVariant2 != null)
            {
                return altitudeStreamVariant2(AltitudeStreamVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.BaseStream>? @base = null,

            global::System.Action<global::Strava.AltitudeStreamVariant2>? altitudeStreamVariant2 = null,
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
            else if (IsAltitudeStreamVariant2)
            {
                altitudeStreamVariant2?.Invoke(AltitudeStreamVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Strava.BaseStream>? @base = null,
            global::System.Action<global::Strava.AltitudeStreamVariant2>? altitudeStreamVariant2 = null,
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
            else if (IsAltitudeStreamVariant2)
            {
                altitudeStreamVariant2?.Invoke(AltitudeStreamVariant2!);
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
                AltitudeStreamVariant2,
                typeof(global::Strava.AltitudeStreamVariant2),
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
        public bool Equals(AltitudeStream other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.BaseStream?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.AltitudeStreamVariant2?>.Default.Equals(AltitudeStreamVariant2, other.AltitudeStreamVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AltitudeStream obj1, AltitudeStream obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AltitudeStream>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AltitudeStream obj1, AltitudeStream obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AltitudeStream o && Equals(o);
        }
    }
}
