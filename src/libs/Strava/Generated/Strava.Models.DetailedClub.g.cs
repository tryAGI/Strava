#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DetailedClub : global::System.IEquatable<DetailedClub>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.SummaryClub? Summary { get; init; }
#else
        public global::Strava.SummaryClub? Summary { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Summary))]
#endif
        public bool IsSummary => Summary != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSummary(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.SummaryClub? value)
        {
            value = Summary;
            return IsSummary;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.DetailedClubVariant2? DetailedClubVariant2 { get; init; }
#else
        public global::Strava.DetailedClubVariant2? DetailedClubVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DetailedClubVariant2))]
#endif
        public bool IsDetailedClubVariant2 => DetailedClubVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDetailedClubVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.DetailedClubVariant2? value)
        {
            value = DetailedClubVariant2;
            return IsDetailedClubVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DetailedClub(global::Strava.SummaryClub value) => new DetailedClub((global::Strava.SummaryClub?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.SummaryClub?(DetailedClub @this) => @this.Summary;

        /// <summary>
        /// 
        /// </summary>
        public DetailedClub(global::Strava.SummaryClub? value)
        {
            Summary = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DetailedClub FromSummary(global::Strava.SummaryClub? value) => new DetailedClub(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DetailedClub(global::Strava.DetailedClubVariant2 value) => new DetailedClub((global::Strava.DetailedClubVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.DetailedClubVariant2?(DetailedClub @this) => @this.DetailedClubVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DetailedClub(global::Strava.DetailedClubVariant2? value)
        {
            DetailedClubVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DetailedClub FromDetailedClubVariant2(global::Strava.DetailedClubVariant2? value) => new DetailedClub(value);

        /// <summary>
        /// 
        /// </summary>
        public DetailedClub(
            global::Strava.SummaryClub? summary,
            global::Strava.DetailedClubVariant2? detailedClubVariant2
            )
        {
            Summary = summary;
            DetailedClubVariant2 = detailedClubVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DetailedClubVariant2 as object ??
            Summary as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Summary?.ToString() ??
            DetailedClubVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSummary && IsDetailedClubVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.SummaryClub?, TResult>? summary = null,
            global::System.Func<global::Strava.DetailedClubVariant2, TResult>? detailedClubVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSummary && summary != null)
            {
                return summary(Summary!);
            }
            else if (IsDetailedClubVariant2 && detailedClubVariant2 != null)
            {
                return detailedClubVariant2(DetailedClubVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.SummaryClub?>? summary = null,

            global::System.Action<global::Strava.DetailedClubVariant2>? detailedClubVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSummary)
            {
                summary?.Invoke(Summary!);
            }
            else if (IsDetailedClubVariant2)
            {
                detailedClubVariant2?.Invoke(DetailedClubVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Strava.SummaryClub?>? summary = null,
            global::System.Action<global::Strava.DetailedClubVariant2>? detailedClubVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSummary)
            {
                summary?.Invoke(Summary!);
            }
            else if (IsDetailedClubVariant2)
            {
                detailedClubVariant2?.Invoke(DetailedClubVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Summary,
                typeof(global::Strava.SummaryClub),
                DetailedClubVariant2,
                typeof(global::Strava.DetailedClubVariant2),
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
        public bool Equals(DetailedClub other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.SummaryClub?>.Default.Equals(Summary, other.Summary) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.DetailedClubVariant2?>.Default.Equals(DetailedClubVariant2, other.DetailedClubVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DetailedClub obj1, DetailedClub obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DetailedClub>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DetailedClub obj1, DetailedClub obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DetailedClub o && Equals(o);
        }
    }
}
