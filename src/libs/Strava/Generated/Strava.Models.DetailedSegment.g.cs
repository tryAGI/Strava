#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DetailedSegment : global::System.IEquatable<DetailedSegment>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.SummarySegment? Summary { get; init; }
#else
        public global::Strava.SummarySegment? Summary { get; }
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
            out global::Strava.SummarySegment? value)
        {
            value = Summary;
            return IsSummary;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Strava.SummarySegment PickSummary() => IsSummary
            ? Summary!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Summary' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.DetailedSegmentVariant2? DetailedSegmentVariant2 { get; init; }
#else
        public global::Strava.DetailedSegmentVariant2? DetailedSegmentVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DetailedSegmentVariant2))]
#endif
        public bool IsDetailedSegmentVariant2 => DetailedSegmentVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDetailedSegmentVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.DetailedSegmentVariant2? value)
        {
            value = DetailedSegmentVariant2;
            return IsDetailedSegmentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Strava.DetailedSegmentVariant2 PickDetailedSegmentVariant2() => IsDetailedSegmentVariant2
            ? DetailedSegmentVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DetailedSegmentVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DetailedSegment(global::Strava.SummarySegment value) => new DetailedSegment((global::Strava.SummarySegment?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.SummarySegment?(DetailedSegment @this) => @this.Summary;

        /// <summary>
        /// 
        /// </summary>
        public DetailedSegment(global::Strava.SummarySegment? value)
        {
            Summary = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DetailedSegment FromSummary(global::Strava.SummarySegment? value) => new DetailedSegment(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DetailedSegment(global::Strava.DetailedSegmentVariant2 value) => new DetailedSegment((global::Strava.DetailedSegmentVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.DetailedSegmentVariant2?(DetailedSegment @this) => @this.DetailedSegmentVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DetailedSegment(global::Strava.DetailedSegmentVariant2? value)
        {
            DetailedSegmentVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DetailedSegment FromDetailedSegmentVariant2(global::Strava.DetailedSegmentVariant2? value) => new DetailedSegment(value);

        /// <summary>
        /// 
        /// </summary>
        public DetailedSegment(
            global::Strava.SummarySegment? summary,
            global::Strava.DetailedSegmentVariant2? detailedSegmentVariant2
            )
        {
            Summary = summary;
            DetailedSegmentVariant2 = detailedSegmentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DetailedSegmentVariant2 as object ??
            Summary as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Summary?.ToString() ??
            DetailedSegmentVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSummary && IsDetailedSegmentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.SummarySegment, TResult>? summary = null,
            global::System.Func<global::Strava.DetailedSegmentVariant2, TResult>? detailedSegmentVariant2 = null,
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
            else if (IsDetailedSegmentVariant2 && detailedSegmentVariant2 != null)
            {
                return detailedSegmentVariant2(DetailedSegmentVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.SummarySegment>? summary = null,

            global::System.Action<global::Strava.DetailedSegmentVariant2>? detailedSegmentVariant2 = null,
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
            else if (IsDetailedSegmentVariant2)
            {
                detailedSegmentVariant2?.Invoke(DetailedSegmentVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Strava.SummarySegment>? summary = null,
            global::System.Action<global::Strava.DetailedSegmentVariant2>? detailedSegmentVariant2 = null,
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
            else if (IsDetailedSegmentVariant2)
            {
                detailedSegmentVariant2?.Invoke(DetailedSegmentVariant2!);
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
                typeof(global::Strava.SummarySegment),
                DetailedSegmentVariant2,
                typeof(global::Strava.DetailedSegmentVariant2),
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
        public bool Equals(DetailedSegment other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.SummarySegment?>.Default.Equals(Summary, other.Summary) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.DetailedSegmentVariant2?>.Default.Equals(DetailedSegmentVariant2, other.DetailedSegmentVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DetailedSegment obj1, DetailedSegment obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DetailedSegment>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DetailedSegment obj1, DetailedSegment obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DetailedSegment o && Equals(o);
        }
    }
}
