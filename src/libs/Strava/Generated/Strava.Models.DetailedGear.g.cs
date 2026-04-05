#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DetailedGear : global::System.IEquatable<DetailedGear>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.SummaryGear? Summary { get; init; }
#else
        public global::Strava.SummaryGear? Summary { get; }
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
        public global::Strava.DetailedGearVariant2? DetailedGearVariant2 { get; init; }
#else
        public global::Strava.DetailedGearVariant2? DetailedGearVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DetailedGearVariant2))]
#endif
        public bool IsDetailedGearVariant2 => DetailedGearVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DetailedGear(global::Strava.SummaryGear value) => new DetailedGear((global::Strava.SummaryGear?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.SummaryGear?(DetailedGear @this) => @this.Summary;

        /// <summary>
        /// 
        /// </summary>
        public DetailedGear(global::Strava.SummaryGear? value)
        {
            Summary = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DetailedGear(global::Strava.DetailedGearVariant2 value) => new DetailedGear((global::Strava.DetailedGearVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.DetailedGearVariant2?(DetailedGear @this) => @this.DetailedGearVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DetailedGear(global::Strava.DetailedGearVariant2? value)
        {
            DetailedGearVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DetailedGear(
            global::Strava.SummaryGear? summary,
            global::Strava.DetailedGearVariant2? detailedGearVariant2
            )
        {
            Summary = summary;
            DetailedGearVariant2 = detailedGearVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DetailedGearVariant2 as object ??
            Summary as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Summary?.ToString() ??
            DetailedGearVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSummary && IsDetailedGearVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.SummaryGear?, TResult>? summary = null,
            global::System.Func<global::Strava.DetailedGearVariant2?, TResult>? detailedGearVariant2 = null,
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
            else if (IsDetailedGearVariant2 && detailedGearVariant2 != null)
            {
                return detailedGearVariant2(DetailedGearVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.SummaryGear?>? summary = null,
            global::System.Action<global::Strava.DetailedGearVariant2?>? detailedGearVariant2 = null,
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
            else if (IsDetailedGearVariant2)
            {
                detailedGearVariant2?.Invoke(DetailedGearVariant2!);
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
                typeof(global::Strava.SummaryGear),
                DetailedGearVariant2,
                typeof(global::Strava.DetailedGearVariant2),
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
        public bool Equals(DetailedGear other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.SummaryGear?>.Default.Equals(Summary, other.Summary) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.DetailedGearVariant2?>.Default.Equals(DetailedGearVariant2, other.DetailedGearVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DetailedGear obj1, DetailedGear obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DetailedGear>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DetailedGear obj1, DetailedGear obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DetailedGear o && Equals(o);
        }
    }
}
