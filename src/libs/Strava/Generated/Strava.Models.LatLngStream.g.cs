#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LatLngStream : global::System.IEquatable<LatLngStream>
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
#if NET6_0_OR_GREATER
        public global::Strava.LatLngStreamVariant2? LatLngStreamVariant2 { get; init; }
#else
        public global::Strava.LatLngStreamVariant2? LatLngStreamVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LatLngStreamVariant2))]
#endif
        public bool IsLatLngStreamVariant2 => LatLngStreamVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LatLngStream(global::Strava.BaseStream value) => new LatLngStream((global::Strava.BaseStream?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.BaseStream?(LatLngStream @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public LatLngStream(global::Strava.BaseStream? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LatLngStream(global::Strava.LatLngStreamVariant2 value) => new LatLngStream((global::Strava.LatLngStreamVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.LatLngStreamVariant2?(LatLngStream @this) => @this.LatLngStreamVariant2;

        /// <summary>
        /// 
        /// </summary>
        public LatLngStream(global::Strava.LatLngStreamVariant2? value)
        {
            LatLngStreamVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LatLngStream(
            global::Strava.BaseStream? @base,
            global::Strava.LatLngStreamVariant2? latLngStreamVariant2
            )
        {
            Base = @base;
            LatLngStreamVariant2 = latLngStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LatLngStreamVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            LatLngStreamVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsLatLngStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.BaseStream?, TResult>? @base = null,
            global::System.Func<global::Strava.LatLngStreamVariant2?, TResult>? latLngStreamVariant2 = null,
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
            else if (IsLatLngStreamVariant2 && latLngStreamVariant2 != null)
            {
                return latLngStreamVariant2(LatLngStreamVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.BaseStream?>? @base = null,
            global::System.Action<global::Strava.LatLngStreamVariant2?>? latLngStreamVariant2 = null,
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
            else if (IsLatLngStreamVariant2)
            {
                latLngStreamVariant2?.Invoke(LatLngStreamVariant2!);
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
                LatLngStreamVariant2,
                typeof(global::Strava.LatLngStreamVariant2),
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
        public bool Equals(LatLngStream other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.BaseStream?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.LatLngStreamVariant2?>.Default.Equals(LatLngStreamVariant2, other.LatLngStreamVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LatLngStream obj1, LatLngStream obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LatLngStream>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LatLngStream obj1, LatLngStream obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LatLngStream o && Equals(o);
        }
    }
}
