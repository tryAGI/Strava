#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SummaryAthlete : global::System.IEquatable<SummaryAthlete>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.MetaAthlete? Meta { get; init; }
#else
        public global::Strava.MetaAthlete? Meta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Meta))]
#endif
        public bool IsMeta => Meta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMeta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.MetaAthlete? value)
        {
            value = Meta;
            return IsMeta;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.SummaryAthleteVariant2? SummaryAthleteVariant2 { get; init; }
#else
        public global::Strava.SummaryAthleteVariant2? SummaryAthleteVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SummaryAthleteVariant2))]
#endif
        public bool IsSummaryAthleteVariant2 => SummaryAthleteVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSummaryAthleteVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.SummaryAthleteVariant2? value)
        {
            value = SummaryAthleteVariant2;
            return IsSummaryAthleteVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SummaryAthlete(global::Strava.MetaAthlete value) => new SummaryAthlete((global::Strava.MetaAthlete?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.MetaAthlete?(SummaryAthlete @this) => @this.Meta;

        /// <summary>
        /// 
        /// </summary>
        public SummaryAthlete(global::Strava.MetaAthlete? value)
        {
            Meta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SummaryAthlete FromMeta(global::Strava.MetaAthlete? value) => new SummaryAthlete(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SummaryAthlete(global::Strava.SummaryAthleteVariant2 value) => new SummaryAthlete((global::Strava.SummaryAthleteVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.SummaryAthleteVariant2?(SummaryAthlete @this) => @this.SummaryAthleteVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SummaryAthlete(global::Strava.SummaryAthleteVariant2? value)
        {
            SummaryAthleteVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SummaryAthlete FromSummaryAthleteVariant2(global::Strava.SummaryAthleteVariant2? value) => new SummaryAthlete(value);

        /// <summary>
        /// 
        /// </summary>
        public SummaryAthlete(
            global::Strava.MetaAthlete? meta,
            global::Strava.SummaryAthleteVariant2? summaryAthleteVariant2
            )
        {
            Meta = meta;
            SummaryAthleteVariant2 = summaryAthleteVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SummaryAthleteVariant2 as object ??
            Meta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Meta?.ToString() ??
            SummaryAthleteVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMeta && IsSummaryAthleteVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.MetaAthlete, TResult>? meta = null,
            global::System.Func<global::Strava.SummaryAthleteVariant2, TResult>? summaryAthleteVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMeta && meta != null)
            {
                return meta(Meta!);
            }
            else if (IsSummaryAthleteVariant2 && summaryAthleteVariant2 != null)
            {
                return summaryAthleteVariant2(SummaryAthleteVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.MetaAthlete>? meta = null,

            global::System.Action<global::Strava.SummaryAthleteVariant2>? summaryAthleteVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMeta)
            {
                meta?.Invoke(Meta!);
            }
            else if (IsSummaryAthleteVariant2)
            {
                summaryAthleteVariant2?.Invoke(SummaryAthleteVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Strava.MetaAthlete>? meta = null,
            global::System.Action<global::Strava.SummaryAthleteVariant2>? summaryAthleteVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMeta)
            {
                meta?.Invoke(Meta!);
            }
            else if (IsSummaryAthleteVariant2)
            {
                summaryAthleteVariant2?.Invoke(SummaryAthleteVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Meta,
                typeof(global::Strava.MetaAthlete),
                SummaryAthleteVariant2,
                typeof(global::Strava.SummaryAthleteVariant2),
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
        public bool Equals(SummaryAthlete other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.MetaAthlete?>.Default.Equals(Meta, other.Meta) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.SummaryAthleteVariant2?>.Default.Equals(SummaryAthleteVariant2, other.SummaryAthleteVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SummaryAthlete obj1, SummaryAthlete obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SummaryAthlete>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SummaryAthlete obj1, SummaryAthlete obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SummaryAthlete o && Equals(o);
        }
    }
}
