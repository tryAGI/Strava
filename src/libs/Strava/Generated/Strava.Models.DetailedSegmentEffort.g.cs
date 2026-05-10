#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DetailedSegmentEffort : global::System.IEquatable<DetailedSegmentEffort>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.SummarySegmentEffort? Summary { get; init; }
#else
        public global::Strava.SummarySegmentEffort? Summary { get; }
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
            out global::Strava.SummarySegmentEffort? value)
        {
            value = Summary;
            return IsSummary;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Strava.SummarySegmentEffort PickSummary() => IsSummary
            ? Summary!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Summary' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.DetailedSegmentEffortVariant2? DetailedSegmentEffortVariant2 { get; init; }
#else
        public global::Strava.DetailedSegmentEffortVariant2? DetailedSegmentEffortVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DetailedSegmentEffortVariant2))]
#endif
        public bool IsDetailedSegmentEffortVariant2 => DetailedSegmentEffortVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDetailedSegmentEffortVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.DetailedSegmentEffortVariant2? value)
        {
            value = DetailedSegmentEffortVariant2;
            return IsDetailedSegmentEffortVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Strava.DetailedSegmentEffortVariant2 PickDetailedSegmentEffortVariant2() => IsDetailedSegmentEffortVariant2
            ? DetailedSegmentEffortVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DetailedSegmentEffortVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DetailedSegmentEffort(global::Strava.SummarySegmentEffort value) => new DetailedSegmentEffort((global::Strava.SummarySegmentEffort?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.SummarySegmentEffort?(DetailedSegmentEffort @this) => @this.Summary;

        /// <summary>
        /// 
        /// </summary>
        public DetailedSegmentEffort(global::Strava.SummarySegmentEffort? value)
        {
            Summary = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DetailedSegmentEffort FromSummary(global::Strava.SummarySegmentEffort? value) => new DetailedSegmentEffort(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DetailedSegmentEffort(global::Strava.DetailedSegmentEffortVariant2 value) => new DetailedSegmentEffort((global::Strava.DetailedSegmentEffortVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.DetailedSegmentEffortVariant2?(DetailedSegmentEffort @this) => @this.DetailedSegmentEffortVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DetailedSegmentEffort(global::Strava.DetailedSegmentEffortVariant2? value)
        {
            DetailedSegmentEffortVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DetailedSegmentEffort FromDetailedSegmentEffortVariant2(global::Strava.DetailedSegmentEffortVariant2? value) => new DetailedSegmentEffort(value);

        /// <summary>
        /// 
        /// </summary>
        public DetailedSegmentEffort(
            global::Strava.SummarySegmentEffort? summary,
            global::Strava.DetailedSegmentEffortVariant2? detailedSegmentEffortVariant2
            )
        {
            Summary = summary;
            DetailedSegmentEffortVariant2 = detailedSegmentEffortVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DetailedSegmentEffortVariant2 as object ??
            Summary as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Summary?.ToString() ??
            DetailedSegmentEffortVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSummary && IsDetailedSegmentEffortVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.SummarySegmentEffort, TResult>? summary = null,
            global::System.Func<global::Strava.DetailedSegmentEffortVariant2, TResult>? detailedSegmentEffortVariant2 = null,
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
            else if (IsDetailedSegmentEffortVariant2 && detailedSegmentEffortVariant2 != null)
            {
                return detailedSegmentEffortVariant2(DetailedSegmentEffortVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.SummarySegmentEffort>? summary = null,

            global::System.Action<global::Strava.DetailedSegmentEffortVariant2>? detailedSegmentEffortVariant2 = null,
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
            else if (IsDetailedSegmentEffortVariant2)
            {
                detailedSegmentEffortVariant2?.Invoke(DetailedSegmentEffortVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Strava.SummarySegmentEffort>? summary = null,
            global::System.Action<global::Strava.DetailedSegmentEffortVariant2>? detailedSegmentEffortVariant2 = null,
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
            else if (IsDetailedSegmentEffortVariant2)
            {
                detailedSegmentEffortVariant2?.Invoke(DetailedSegmentEffortVariant2!);
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
                typeof(global::Strava.SummarySegmentEffort),
                DetailedSegmentEffortVariant2,
                typeof(global::Strava.DetailedSegmentEffortVariant2),
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
        public bool Equals(DetailedSegmentEffort other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.SummarySegmentEffort?>.Default.Equals(Summary, other.Summary) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.DetailedSegmentEffortVariant2?>.Default.Equals(DetailedSegmentEffortVariant2, other.DetailedSegmentEffortVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DetailedSegmentEffort obj1, DetailedSegmentEffort obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DetailedSegmentEffort>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DetailedSegmentEffort obj1, DetailedSegmentEffort obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DetailedSegmentEffort o && Equals(o);
        }
    }
}
