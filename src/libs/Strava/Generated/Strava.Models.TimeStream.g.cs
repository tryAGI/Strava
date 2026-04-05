#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TimeStream : global::System.IEquatable<TimeStream>
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
        public global::Strava.TimeStreamVariant2? TimeStreamVariant2 { get; init; }
#else
        public global::Strava.TimeStreamVariant2? TimeStreamVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimeStreamVariant2))]
#endif
        public bool IsTimeStreamVariant2 => TimeStreamVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimeStream(global::Strava.BaseStream value) => new TimeStream((global::Strava.BaseStream?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.BaseStream?(TimeStream @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public TimeStream(global::Strava.BaseStream? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimeStream(global::Strava.TimeStreamVariant2 value) => new TimeStream((global::Strava.TimeStreamVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.TimeStreamVariant2?(TimeStream @this) => @this.TimeStreamVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TimeStream(global::Strava.TimeStreamVariant2? value)
        {
            TimeStreamVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TimeStream(
            global::Strava.BaseStream? @base,
            global::Strava.TimeStreamVariant2? timeStreamVariant2
            )
        {
            Base = @base;
            TimeStreamVariant2 = timeStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TimeStreamVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            TimeStreamVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsTimeStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.BaseStream?, TResult>? @base = null,
            global::System.Func<global::Strava.TimeStreamVariant2?, TResult>? timeStreamVariant2 = null,
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
            else if (IsTimeStreamVariant2 && timeStreamVariant2 != null)
            {
                return timeStreamVariant2(TimeStreamVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.BaseStream?>? @base = null,
            global::System.Action<global::Strava.TimeStreamVariant2?>? timeStreamVariant2 = null,
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
            else if (IsTimeStreamVariant2)
            {
                timeStreamVariant2?.Invoke(TimeStreamVariant2!);
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
                TimeStreamVariant2,
                typeof(global::Strava.TimeStreamVariant2),
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
        public bool Equals(TimeStream other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.BaseStream?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.TimeStreamVariant2?>.Default.Equals(TimeStreamVariant2, other.TimeStreamVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TimeStream obj1, TimeStream obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TimeStream>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TimeStream obj1, TimeStream obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TimeStream o && Equals(o);
        }
    }
}
