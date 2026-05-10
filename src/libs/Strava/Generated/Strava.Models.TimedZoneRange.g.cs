#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// A union type representing the time spent in a given zone.
    /// </summary>
    public readonly partial struct TimedZoneRange : global::System.IEquatable<TimedZoneRange>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.ZoneRange? ZoneRange { get; init; }
#else
        public global::Strava.ZoneRange? ZoneRange { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ZoneRange))]
#endif
        public bool IsZoneRange => ZoneRange != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickZoneRange(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.ZoneRange? value)
        {
            value = ZoneRange;
            return IsZoneRange;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Strava.ZoneRange PickZoneRange() => IsZoneRange
            ? ZoneRange!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ZoneRange' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.TimedZoneRangeVariant2? TimedZoneRangeVariant2 { get; init; }
#else
        public global::Strava.TimedZoneRangeVariant2? TimedZoneRangeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimedZoneRangeVariant2))]
#endif
        public bool IsTimedZoneRangeVariant2 => TimedZoneRangeVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTimedZoneRangeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.TimedZoneRangeVariant2? value)
        {
            value = TimedZoneRangeVariant2;
            return IsTimedZoneRangeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Strava.TimedZoneRangeVariant2 PickTimedZoneRangeVariant2() => IsTimedZoneRangeVariant2
            ? TimedZoneRangeVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimedZoneRangeVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimedZoneRange(global::Strava.ZoneRange value) => new TimedZoneRange((global::Strava.ZoneRange?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.ZoneRange?(TimedZoneRange @this) => @this.ZoneRange;

        /// <summary>
        /// 
        /// </summary>
        public TimedZoneRange(global::Strava.ZoneRange? value)
        {
            ZoneRange = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TimedZoneRange FromZoneRange(global::Strava.ZoneRange? value) => new TimedZoneRange(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimedZoneRange(global::Strava.TimedZoneRangeVariant2 value) => new TimedZoneRange((global::Strava.TimedZoneRangeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.TimedZoneRangeVariant2?(TimedZoneRange @this) => @this.TimedZoneRangeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TimedZoneRange(global::Strava.TimedZoneRangeVariant2? value)
        {
            TimedZoneRangeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TimedZoneRange FromTimedZoneRangeVariant2(global::Strava.TimedZoneRangeVariant2? value) => new TimedZoneRange(value);

        /// <summary>
        /// 
        /// </summary>
        public TimedZoneRange(
            global::Strava.ZoneRange? zoneRange,
            global::Strava.TimedZoneRangeVariant2? timedZoneRangeVariant2
            )
        {
            ZoneRange = zoneRange;
            TimedZoneRangeVariant2 = timedZoneRangeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TimedZoneRangeVariant2 as object ??
            ZoneRange as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ZoneRange?.ToString() ??
            TimedZoneRangeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsZoneRange && IsTimedZoneRangeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.ZoneRange, TResult>? zoneRange = null,
            global::System.Func<global::Strava.TimedZoneRangeVariant2, TResult>? timedZoneRangeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsZoneRange && zoneRange != null)
            {
                return zoneRange(ZoneRange!);
            }
            else if (IsTimedZoneRangeVariant2 && timedZoneRangeVariant2 != null)
            {
                return timedZoneRangeVariant2(TimedZoneRangeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.ZoneRange>? zoneRange = null,

            global::System.Action<global::Strava.TimedZoneRangeVariant2>? timedZoneRangeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsZoneRange)
            {
                zoneRange?.Invoke(ZoneRange!);
            }
            else if (IsTimedZoneRangeVariant2)
            {
                timedZoneRangeVariant2?.Invoke(TimedZoneRangeVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Strava.ZoneRange>? zoneRange = null,
            global::System.Action<global::Strava.TimedZoneRangeVariant2>? timedZoneRangeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsZoneRange)
            {
                zoneRange?.Invoke(ZoneRange!);
            }
            else if (IsTimedZoneRangeVariant2)
            {
                timedZoneRangeVariant2?.Invoke(TimedZoneRangeVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ZoneRange,
                typeof(global::Strava.ZoneRange),
                TimedZoneRangeVariant2,
                typeof(global::Strava.TimedZoneRangeVariant2),
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
        public bool Equals(TimedZoneRange other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.ZoneRange?>.Default.Equals(ZoneRange, other.ZoneRange) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.TimedZoneRangeVariant2?>.Default.Equals(TimedZoneRangeVariant2, other.TimedZoneRangeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TimedZoneRange obj1, TimedZoneRange obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TimedZoneRange>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TimedZoneRange obj1, TimedZoneRange obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TimedZoneRange o && Equals(o);
        }
    }
}
