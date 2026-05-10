#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SummaryClub : global::System.IEquatable<SummaryClub>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.MetaClub? Meta { get; init; }
#else
        public global::Strava.MetaClub? Meta { get; }
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
            out global::Strava.MetaClub? value)
        {
            value = Meta;
            return IsMeta;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.SummaryClubVariant2? SummaryClubVariant2 { get; init; }
#else
        public global::Strava.SummaryClubVariant2? SummaryClubVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SummaryClubVariant2))]
#endif
        public bool IsSummaryClubVariant2 => SummaryClubVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSummaryClubVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.SummaryClubVariant2? value)
        {
            value = SummaryClubVariant2;
            return IsSummaryClubVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SummaryClub(global::Strava.MetaClub value) => new SummaryClub((global::Strava.MetaClub?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.MetaClub?(SummaryClub @this) => @this.Meta;

        /// <summary>
        /// 
        /// </summary>
        public SummaryClub(global::Strava.MetaClub? value)
        {
            Meta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SummaryClub FromMeta(global::Strava.MetaClub? value) => new SummaryClub(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SummaryClub(global::Strava.SummaryClubVariant2 value) => new SummaryClub((global::Strava.SummaryClubVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.SummaryClubVariant2?(SummaryClub @this) => @this.SummaryClubVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SummaryClub(global::Strava.SummaryClubVariant2? value)
        {
            SummaryClubVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SummaryClub FromSummaryClubVariant2(global::Strava.SummaryClubVariant2? value) => new SummaryClub(value);

        /// <summary>
        /// 
        /// </summary>
        public SummaryClub(
            global::Strava.MetaClub? meta,
            global::Strava.SummaryClubVariant2? summaryClubVariant2
            )
        {
            Meta = meta;
            SummaryClubVariant2 = summaryClubVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SummaryClubVariant2 as object ??
            Meta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Meta?.ToString() ??
            SummaryClubVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMeta && IsSummaryClubVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.MetaClub, TResult>? meta = null,
            global::System.Func<global::Strava.SummaryClubVariant2, TResult>? summaryClubVariant2 = null,
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
            else if (IsSummaryClubVariant2 && summaryClubVariant2 != null)
            {
                return summaryClubVariant2(SummaryClubVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.MetaClub>? meta = null,

            global::System.Action<global::Strava.SummaryClubVariant2>? summaryClubVariant2 = null,
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
            else if (IsSummaryClubVariant2)
            {
                summaryClubVariant2?.Invoke(SummaryClubVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Strava.MetaClub>? meta = null,
            global::System.Action<global::Strava.SummaryClubVariant2>? summaryClubVariant2 = null,
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
            else if (IsSummaryClubVariant2)
            {
                summaryClubVariant2?.Invoke(SummaryClubVariant2!);
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
                typeof(global::Strava.MetaClub),
                SummaryClubVariant2,
                typeof(global::Strava.SummaryClubVariant2),
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
        public bool Equals(SummaryClub other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.MetaClub?>.Default.Equals(Meta, other.Meta) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.SummaryClubVariant2?>.Default.Equals(SummaryClubVariant2, other.SummaryClubVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SummaryClub obj1, SummaryClub obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SummaryClub>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SummaryClub obj1, SummaryClub obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SummaryClub o && Equals(o);
        }
    }
}
