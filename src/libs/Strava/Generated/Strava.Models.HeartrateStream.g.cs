#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct HeartrateStream : global::System.IEquatable<HeartrateStream>
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
        public global::Strava.HeartrateStreamVariant2? HeartrateStreamVariant2 { get; init; }
#else
        public global::Strava.HeartrateStreamVariant2? HeartrateStreamVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HeartrateStreamVariant2))]
#endif
        public bool IsHeartrateStreamVariant2 => HeartrateStreamVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHeartrateStreamVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.HeartrateStreamVariant2? value)
        {
            value = HeartrateStreamVariant2;
            return IsHeartrateStreamVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator HeartrateStream(global::Strava.BaseStream value) => new HeartrateStream((global::Strava.BaseStream?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.BaseStream?(HeartrateStream @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public HeartrateStream(global::Strava.BaseStream? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static HeartrateStream FromBase(global::Strava.BaseStream? value) => new HeartrateStream(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator HeartrateStream(global::Strava.HeartrateStreamVariant2 value) => new HeartrateStream((global::Strava.HeartrateStreamVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.HeartrateStreamVariant2?(HeartrateStream @this) => @this.HeartrateStreamVariant2;

        /// <summary>
        /// 
        /// </summary>
        public HeartrateStream(global::Strava.HeartrateStreamVariant2? value)
        {
            HeartrateStreamVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static HeartrateStream FromHeartrateStreamVariant2(global::Strava.HeartrateStreamVariant2? value) => new HeartrateStream(value);

        /// <summary>
        /// 
        /// </summary>
        public HeartrateStream(
            global::Strava.BaseStream? @base,
            global::Strava.HeartrateStreamVariant2? heartrateStreamVariant2
            )
        {
            Base = @base;
            HeartrateStreamVariant2 = heartrateStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            HeartrateStreamVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            HeartrateStreamVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsHeartrateStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.BaseStream, TResult>? @base = null,
            global::System.Func<global::Strava.HeartrateStreamVariant2, TResult>? heartrateStreamVariant2 = null,
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
            else if (IsHeartrateStreamVariant2 && heartrateStreamVariant2 != null)
            {
                return heartrateStreamVariant2(HeartrateStreamVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.BaseStream>? @base = null,

            global::System.Action<global::Strava.HeartrateStreamVariant2>? heartrateStreamVariant2 = null,
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
            else if (IsHeartrateStreamVariant2)
            {
                heartrateStreamVariant2?.Invoke(HeartrateStreamVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Strava.BaseStream>? @base = null,
            global::System.Action<global::Strava.HeartrateStreamVariant2>? heartrateStreamVariant2 = null,
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
            else if (IsHeartrateStreamVariant2)
            {
                heartrateStreamVariant2?.Invoke(HeartrateStreamVariant2!);
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
                HeartrateStreamVariant2,
                typeof(global::Strava.HeartrateStreamVariant2),
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
        public bool Equals(HeartrateStream other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.BaseStream?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.HeartrateStreamVariant2?>.Default.Equals(HeartrateStreamVariant2, other.HeartrateStreamVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(HeartrateStream obj1, HeartrateStream obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<HeartrateStream>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(HeartrateStream obj1, HeartrateStream obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is HeartrateStream o && Equals(o);
        }
    }
}
