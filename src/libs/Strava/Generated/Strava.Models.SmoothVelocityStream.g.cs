#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SmoothVelocityStream : global::System.IEquatable<SmoothVelocityStream>
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
        public global::Strava.SmoothVelocityStreamVariant2? SmoothVelocityStreamVariant2 { get; init; }
#else
        public global::Strava.SmoothVelocityStreamVariant2? SmoothVelocityStreamVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SmoothVelocityStreamVariant2))]
#endif
        public bool IsSmoothVelocityStreamVariant2 => SmoothVelocityStreamVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSmoothVelocityStreamVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.SmoothVelocityStreamVariant2? value)
        {
            value = SmoothVelocityStreamVariant2;
            return IsSmoothVelocityStreamVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SmoothVelocityStream(global::Strava.BaseStream value) => new SmoothVelocityStream((global::Strava.BaseStream?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.BaseStream?(SmoothVelocityStream @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SmoothVelocityStream(global::Strava.BaseStream? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SmoothVelocityStream(global::Strava.SmoothVelocityStreamVariant2 value) => new SmoothVelocityStream((global::Strava.SmoothVelocityStreamVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.SmoothVelocityStreamVariant2?(SmoothVelocityStream @this) => @this.SmoothVelocityStreamVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SmoothVelocityStream(global::Strava.SmoothVelocityStreamVariant2? value)
        {
            SmoothVelocityStreamVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SmoothVelocityStream(
            global::Strava.BaseStream? @base,
            global::Strava.SmoothVelocityStreamVariant2? smoothVelocityStreamVariant2
            )
        {
            Base = @base;
            SmoothVelocityStreamVariant2 = smoothVelocityStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SmoothVelocityStreamVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SmoothVelocityStreamVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSmoothVelocityStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.BaseStream, TResult>? @base = null,
            global::System.Func<global::Strava.SmoothVelocityStreamVariant2, TResult>? smoothVelocityStreamVariant2 = null,
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
            else if (IsSmoothVelocityStreamVariant2 && smoothVelocityStreamVariant2 != null)
            {
                return smoothVelocityStreamVariant2(SmoothVelocityStreamVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.BaseStream>? @base = null,

            global::System.Action<global::Strava.SmoothVelocityStreamVariant2>? smoothVelocityStreamVariant2 = null,
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
            else if (IsSmoothVelocityStreamVariant2)
            {
                smoothVelocityStreamVariant2?.Invoke(SmoothVelocityStreamVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Strava.BaseStream>? @base = null,
            global::System.Action<global::Strava.SmoothVelocityStreamVariant2>? smoothVelocityStreamVariant2 = null,
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
            else if (IsSmoothVelocityStreamVariant2)
            {
                smoothVelocityStreamVariant2?.Invoke(SmoothVelocityStreamVariant2!);
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
                SmoothVelocityStreamVariant2,
                typeof(global::Strava.SmoothVelocityStreamVariant2),
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
        public bool Equals(SmoothVelocityStream other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.BaseStream?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.SmoothVelocityStreamVariant2?>.Default.Equals(SmoothVelocityStreamVariant2, other.SmoothVelocityStreamVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SmoothVelocityStream obj1, SmoothVelocityStream obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SmoothVelocityStream>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SmoothVelocityStream obj1, SmoothVelocityStream obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SmoothVelocityStream o && Equals(o);
        }
    }
}
