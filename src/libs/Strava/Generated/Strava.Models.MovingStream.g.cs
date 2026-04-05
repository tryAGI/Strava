#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MovingStream : global::System.IEquatable<MovingStream>
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
        public global::Strava.MovingStreamVariant2? MovingStreamVariant2 { get; init; }
#else
        public global::Strava.MovingStreamVariant2? MovingStreamVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MovingStreamVariant2))]
#endif
        public bool IsMovingStreamVariant2 => MovingStreamVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MovingStream(global::Strava.BaseStream value) => new MovingStream((global::Strava.BaseStream?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.BaseStream?(MovingStream @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public MovingStream(global::Strava.BaseStream? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MovingStream(global::Strava.MovingStreamVariant2 value) => new MovingStream((global::Strava.MovingStreamVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.MovingStreamVariant2?(MovingStream @this) => @this.MovingStreamVariant2;

        /// <summary>
        /// 
        /// </summary>
        public MovingStream(global::Strava.MovingStreamVariant2? value)
        {
            MovingStreamVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MovingStream(
            global::Strava.BaseStream? @base,
            global::Strava.MovingStreamVariant2? movingStreamVariant2
            )
        {
            Base = @base;
            MovingStreamVariant2 = movingStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MovingStreamVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            MovingStreamVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsMovingStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.BaseStream?, TResult>? @base = null,
            global::System.Func<global::Strava.MovingStreamVariant2?, TResult>? movingStreamVariant2 = null,
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
            else if (IsMovingStreamVariant2 && movingStreamVariant2 != null)
            {
                return movingStreamVariant2(MovingStreamVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.BaseStream?>? @base = null,
            global::System.Action<global::Strava.MovingStreamVariant2?>? movingStreamVariant2 = null,
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
            else if (IsMovingStreamVariant2)
            {
                movingStreamVariant2?.Invoke(MovingStreamVariant2!);
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
                MovingStreamVariant2,
                typeof(global::Strava.MovingStreamVariant2),
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
        public bool Equals(MovingStream other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.BaseStream?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.MovingStreamVariant2?>.Default.Equals(MovingStreamVariant2, other.MovingStreamVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MovingStream obj1, MovingStream obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MovingStream>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MovingStream obj1, MovingStream obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MovingStream o && Equals(o);
        }
    }
}
