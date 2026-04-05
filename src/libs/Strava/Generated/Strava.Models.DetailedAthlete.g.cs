#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DetailedAthlete : global::System.IEquatable<DetailedAthlete>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.SummaryAthlete? Summary { get; init; }
#else
        public global::Strava.SummaryAthlete? Summary { get; }
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
#if NET6_0_OR_GREATER
        public global::Strava.DetailedAthleteVariant2? DetailedAthleteVariant2 { get; init; }
#else
        public global::Strava.DetailedAthleteVariant2? DetailedAthleteVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DetailedAthleteVariant2))]
#endif
        public bool IsDetailedAthleteVariant2 => DetailedAthleteVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DetailedAthlete(global::Strava.SummaryAthlete value) => new DetailedAthlete((global::Strava.SummaryAthlete?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.SummaryAthlete?(DetailedAthlete @this) => @this.Summary;

        /// <summary>
        /// 
        /// </summary>
        public DetailedAthlete(global::Strava.SummaryAthlete? value)
        {
            Summary = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DetailedAthlete(global::Strava.DetailedAthleteVariant2 value) => new DetailedAthlete((global::Strava.DetailedAthleteVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.DetailedAthleteVariant2?(DetailedAthlete @this) => @this.DetailedAthleteVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DetailedAthlete(global::Strava.DetailedAthleteVariant2? value)
        {
            DetailedAthleteVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DetailedAthlete(
            global::Strava.SummaryAthlete? summary,
            global::Strava.DetailedAthleteVariant2? detailedAthleteVariant2
            )
        {
            Summary = summary;
            DetailedAthleteVariant2 = detailedAthleteVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DetailedAthleteVariant2 as object ??
            Summary as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Summary?.ToString() ??
            DetailedAthleteVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSummary && IsDetailedAthleteVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.SummaryAthlete?, TResult>? summary = null,
            global::System.Func<global::Strava.DetailedAthleteVariant2?, TResult>? detailedAthleteVariant2 = null,
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
            else if (IsDetailedAthleteVariant2 && detailedAthleteVariant2 != null)
            {
                return detailedAthleteVariant2(DetailedAthleteVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.SummaryAthlete?>? summary = null,
            global::System.Action<global::Strava.DetailedAthleteVariant2?>? detailedAthleteVariant2 = null,
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
            else if (IsDetailedAthleteVariant2)
            {
                detailedAthleteVariant2?.Invoke(DetailedAthleteVariant2!);
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
                typeof(global::Strava.SummaryAthlete),
                DetailedAthleteVariant2,
                typeof(global::Strava.DetailedAthleteVariant2),
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
        public bool Equals(DetailedAthlete other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.SummaryAthlete?>.Default.Equals(Summary, other.Summary) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.DetailedAthleteVariant2?>.Default.Equals(DetailedAthleteVariant2, other.DetailedAthleteVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DetailedAthlete obj1, DetailedAthlete obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DetailedAthlete>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DetailedAthlete obj1, DetailedAthlete obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DetailedAthlete o && Equals(o);
        }
    }
}
