#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DistanceStream : global::System.IEquatable<DistanceStream>
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
        public global::Strava.DistanceStreamVariant2? DistanceStreamVariant2 { get; init; }
#else
        public global::Strava.DistanceStreamVariant2? DistanceStreamVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DistanceStreamVariant2))]
#endif
        public bool IsDistanceStreamVariant2 => DistanceStreamVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDistanceStreamVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.DistanceStreamVariant2? value)
        {
            value = DistanceStreamVariant2;
            return IsDistanceStreamVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DistanceStream(global::Strava.BaseStream value) => new DistanceStream((global::Strava.BaseStream?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.BaseStream?(DistanceStream @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public DistanceStream(global::Strava.BaseStream? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DistanceStream FromBase(global::Strava.BaseStream? value) => new DistanceStream(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DistanceStream(global::Strava.DistanceStreamVariant2 value) => new DistanceStream((global::Strava.DistanceStreamVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.DistanceStreamVariant2?(DistanceStream @this) => @this.DistanceStreamVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DistanceStream(global::Strava.DistanceStreamVariant2? value)
        {
            DistanceStreamVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DistanceStream FromDistanceStreamVariant2(global::Strava.DistanceStreamVariant2? value) => new DistanceStream(value);

        /// <summary>
        /// 
        /// </summary>
        public DistanceStream(
            global::Strava.BaseStream? @base,
            global::Strava.DistanceStreamVariant2? distanceStreamVariant2
            )
        {
            Base = @base;
            DistanceStreamVariant2 = distanceStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DistanceStreamVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            DistanceStreamVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsDistanceStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.BaseStream, TResult>? @base = null,
            global::System.Func<global::Strava.DistanceStreamVariant2, TResult>? distanceStreamVariant2 = null,
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
            else if (IsDistanceStreamVariant2 && distanceStreamVariant2 != null)
            {
                return distanceStreamVariant2(DistanceStreamVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.BaseStream>? @base = null,

            global::System.Action<global::Strava.DistanceStreamVariant2>? distanceStreamVariant2 = null,
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
            else if (IsDistanceStreamVariant2)
            {
                distanceStreamVariant2?.Invoke(DistanceStreamVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Strava.BaseStream>? @base = null,
            global::System.Action<global::Strava.DistanceStreamVariant2>? distanceStreamVariant2 = null,
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
            else if (IsDistanceStreamVariant2)
            {
                distanceStreamVariant2?.Invoke(DistanceStreamVariant2!);
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
                DistanceStreamVariant2,
                typeof(global::Strava.DistanceStreamVariant2),
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
        public bool Equals(DistanceStream other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.BaseStream?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.DistanceStreamVariant2?>.Default.Equals(DistanceStreamVariant2, other.DistanceStreamVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DistanceStream obj1, DistanceStream obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DistanceStream>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DistanceStream obj1, DistanceStream obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DistanceStream o && Equals(o);
        }
    }
}
