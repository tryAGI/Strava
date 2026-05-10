#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SmoothGradeStream : global::System.IEquatable<SmoothGradeStream>
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
        public global::Strava.BaseStream PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.SmoothGradeStreamVariant2? SmoothGradeStreamVariant2 { get; init; }
#else
        public global::Strava.SmoothGradeStreamVariant2? SmoothGradeStreamVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SmoothGradeStreamVariant2))]
#endif
        public bool IsSmoothGradeStreamVariant2 => SmoothGradeStreamVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSmoothGradeStreamVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.SmoothGradeStreamVariant2? value)
        {
            value = SmoothGradeStreamVariant2;
            return IsSmoothGradeStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Strava.SmoothGradeStreamVariant2 PickSmoothGradeStreamVariant2() => IsSmoothGradeStreamVariant2
            ? SmoothGradeStreamVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SmoothGradeStreamVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SmoothGradeStream(global::Strava.BaseStream value) => new SmoothGradeStream((global::Strava.BaseStream?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.BaseStream?(SmoothGradeStream @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SmoothGradeStream(global::Strava.BaseStream? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SmoothGradeStream FromBase(global::Strava.BaseStream? value) => new SmoothGradeStream(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SmoothGradeStream(global::Strava.SmoothGradeStreamVariant2 value) => new SmoothGradeStream((global::Strava.SmoothGradeStreamVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.SmoothGradeStreamVariant2?(SmoothGradeStream @this) => @this.SmoothGradeStreamVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SmoothGradeStream(global::Strava.SmoothGradeStreamVariant2? value)
        {
            SmoothGradeStreamVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SmoothGradeStream FromSmoothGradeStreamVariant2(global::Strava.SmoothGradeStreamVariant2? value) => new SmoothGradeStream(value);

        /// <summary>
        /// 
        /// </summary>
        public SmoothGradeStream(
            global::Strava.BaseStream? @base,
            global::Strava.SmoothGradeStreamVariant2? smoothGradeStreamVariant2
            )
        {
            Base = @base;
            SmoothGradeStreamVariant2 = smoothGradeStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SmoothGradeStreamVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SmoothGradeStreamVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSmoothGradeStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.BaseStream, TResult>? @base = null,
            global::System.Func<global::Strava.SmoothGradeStreamVariant2, TResult>? smoothGradeStreamVariant2 = null,
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
            else if (IsSmoothGradeStreamVariant2 && smoothGradeStreamVariant2 != null)
            {
                return smoothGradeStreamVariant2(SmoothGradeStreamVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.BaseStream>? @base = null,

            global::System.Action<global::Strava.SmoothGradeStreamVariant2>? smoothGradeStreamVariant2 = null,
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
            else if (IsSmoothGradeStreamVariant2)
            {
                smoothGradeStreamVariant2?.Invoke(SmoothGradeStreamVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Strava.BaseStream>? @base = null,
            global::System.Action<global::Strava.SmoothGradeStreamVariant2>? smoothGradeStreamVariant2 = null,
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
            else if (IsSmoothGradeStreamVariant2)
            {
                smoothGradeStreamVariant2?.Invoke(SmoothGradeStreamVariant2!);
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
                SmoothGradeStreamVariant2,
                typeof(global::Strava.SmoothGradeStreamVariant2),
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
        public bool Equals(SmoothGradeStream other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.BaseStream?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.SmoothGradeStreamVariant2?>.Default.Equals(SmoothGradeStreamVariant2, other.SmoothGradeStreamVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SmoothGradeStream obj1, SmoothGradeStream obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SmoothGradeStream>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SmoothGradeStream obj1, SmoothGradeStream obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SmoothGradeStream o && Equals(o);
        }
    }
}
