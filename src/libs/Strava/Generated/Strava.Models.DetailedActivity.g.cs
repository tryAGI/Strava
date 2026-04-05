#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DetailedActivity : global::System.IEquatable<DetailedActivity>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.SummaryActivity? Summary { get; init; }
#else
        public global::Strava.SummaryActivity? Summary { get; }
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
        public global::Strava.DetailedActivityVariant2? DetailedActivityVariant2 { get; init; }
#else
        public global::Strava.DetailedActivityVariant2? DetailedActivityVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DetailedActivityVariant2))]
#endif
        public bool IsDetailedActivityVariant2 => DetailedActivityVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DetailedActivity(global::Strava.SummaryActivity value) => new DetailedActivity((global::Strava.SummaryActivity?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.SummaryActivity?(DetailedActivity @this) => @this.Summary;

        /// <summary>
        /// 
        /// </summary>
        public DetailedActivity(global::Strava.SummaryActivity? value)
        {
            Summary = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DetailedActivity(global::Strava.DetailedActivityVariant2 value) => new DetailedActivity((global::Strava.DetailedActivityVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.DetailedActivityVariant2?(DetailedActivity @this) => @this.DetailedActivityVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DetailedActivity(global::Strava.DetailedActivityVariant2? value)
        {
            DetailedActivityVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DetailedActivity(
            global::Strava.SummaryActivity? summary,
            global::Strava.DetailedActivityVariant2? detailedActivityVariant2
            )
        {
            Summary = summary;
            DetailedActivityVariant2 = detailedActivityVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DetailedActivityVariant2 as object ??
            Summary as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Summary?.ToString() ??
            DetailedActivityVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSummary && IsDetailedActivityVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.SummaryActivity?, TResult>? summary = null,
            global::System.Func<global::Strava.DetailedActivityVariant2?, TResult>? detailedActivityVariant2 = null,
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
            else if (IsDetailedActivityVariant2 && detailedActivityVariant2 != null)
            {
                return detailedActivityVariant2(DetailedActivityVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.SummaryActivity?>? summary = null,
            global::System.Action<global::Strava.DetailedActivityVariant2?>? detailedActivityVariant2 = null,
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
            else if (IsDetailedActivityVariant2)
            {
                detailedActivityVariant2?.Invoke(DetailedActivityVariant2!);
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
                typeof(global::Strava.SummaryActivity),
                DetailedActivityVariant2,
                typeof(global::Strava.DetailedActivityVariant2),
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
        public bool Equals(DetailedActivity other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.SummaryActivity?>.Default.Equals(Summary, other.Summary) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.DetailedActivityVariant2?>.Default.Equals(DetailedActivityVariant2, other.DetailedActivityVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DetailedActivity obj1, DetailedActivity obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DetailedActivity>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DetailedActivity obj1, DetailedActivity obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DetailedActivity o && Equals(o);
        }
    }
}
