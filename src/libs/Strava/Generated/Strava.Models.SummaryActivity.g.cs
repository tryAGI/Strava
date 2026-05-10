#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SummaryActivity : global::System.IEquatable<SummaryActivity>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.MetaActivity? Meta { get; init; }
#else
        public global::Strava.MetaActivity? Meta { get; }
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
            out global::Strava.MetaActivity? value)
        {
            value = Meta;
            return IsMeta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Strava.MetaActivity PickMeta() => IsMeta
            ? Meta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Meta' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.SummaryActivityVariant2? SummaryActivityVariant2 { get; init; }
#else
        public global::Strava.SummaryActivityVariant2? SummaryActivityVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SummaryActivityVariant2))]
#endif
        public bool IsSummaryActivityVariant2 => SummaryActivityVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSummaryActivityVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.SummaryActivityVariant2? value)
        {
            value = SummaryActivityVariant2;
            return IsSummaryActivityVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Strava.SummaryActivityVariant2 PickSummaryActivityVariant2() => IsSummaryActivityVariant2
            ? SummaryActivityVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SummaryActivityVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SummaryActivity(global::Strava.MetaActivity value) => new SummaryActivity((global::Strava.MetaActivity?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.MetaActivity?(SummaryActivity @this) => @this.Meta;

        /// <summary>
        /// 
        /// </summary>
        public SummaryActivity(global::Strava.MetaActivity? value)
        {
            Meta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SummaryActivity FromMeta(global::Strava.MetaActivity? value) => new SummaryActivity(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SummaryActivity(global::Strava.SummaryActivityVariant2 value) => new SummaryActivity((global::Strava.SummaryActivityVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.SummaryActivityVariant2?(SummaryActivity @this) => @this.SummaryActivityVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SummaryActivity(global::Strava.SummaryActivityVariant2? value)
        {
            SummaryActivityVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SummaryActivity FromSummaryActivityVariant2(global::Strava.SummaryActivityVariant2? value) => new SummaryActivity(value);

        /// <summary>
        /// 
        /// </summary>
        public SummaryActivity(
            global::Strava.MetaActivity? meta,
            global::Strava.SummaryActivityVariant2? summaryActivityVariant2
            )
        {
            Meta = meta;
            SummaryActivityVariant2 = summaryActivityVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SummaryActivityVariant2 as object ??
            Meta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Meta?.ToString() ??
            SummaryActivityVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMeta && IsSummaryActivityVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.MetaActivity, TResult>? meta = null,
            global::System.Func<global::Strava.SummaryActivityVariant2, TResult>? summaryActivityVariant2 = null,
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
            else if (IsSummaryActivityVariant2 && summaryActivityVariant2 != null)
            {
                return summaryActivityVariant2(SummaryActivityVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.MetaActivity>? meta = null,

            global::System.Action<global::Strava.SummaryActivityVariant2>? summaryActivityVariant2 = null,
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
            else if (IsSummaryActivityVariant2)
            {
                summaryActivityVariant2?.Invoke(SummaryActivityVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Strava.MetaActivity>? meta = null,
            global::System.Action<global::Strava.SummaryActivityVariant2>? summaryActivityVariant2 = null,
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
            else if (IsSummaryActivityVariant2)
            {
                summaryActivityVariant2?.Invoke(SummaryActivityVariant2!);
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
                typeof(global::Strava.MetaActivity),
                SummaryActivityVariant2,
                typeof(global::Strava.SummaryActivityVariant2),
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
        public bool Equals(SummaryActivity other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.MetaActivity?>.Default.Equals(Meta, other.Meta) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.SummaryActivityVariant2?>.Default.Equals(SummaryActivityVariant2, other.SummaryActivityVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SummaryActivity obj1, SummaryActivity obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SummaryActivity>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SummaryActivity obj1, SummaryActivity obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SummaryActivity o && Equals(o);
        }
    }
}
