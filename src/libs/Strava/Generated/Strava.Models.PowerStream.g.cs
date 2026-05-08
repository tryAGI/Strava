#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PowerStream : global::System.IEquatable<PowerStream>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.BaseStream? Base { get; init; }
#else
        public global::Strava.BaseStream? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.BaseStream? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Strava.PowerStreamVariant2? PowerStreamVariant2 { get; init; }
#else
        public global::Strava.PowerStreamVariant2? PowerStreamVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PowerStreamVariant2))]
#endif
        public bool IsPowerStreamVariant2 => PowerStreamVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPowerStreamVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.PowerStreamVariant2? value)
        {
            value = PowerStreamVariant2;
            return IsPowerStreamVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PowerStream(global::Strava.BaseStream value) => new PowerStream((global::Strava.BaseStream?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.BaseStream?(PowerStream @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public PowerStream(global::Strava.BaseStream? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PowerStream(global::Strava.PowerStreamVariant2 value) => new PowerStream((global::Strava.PowerStreamVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.PowerStreamVariant2?(PowerStream @this) => @this.PowerStreamVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PowerStream(global::Strava.PowerStreamVariant2? value)
        {
            PowerStreamVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PowerStream(
            global::Strava.BaseStream? @base,
            global::Strava.PowerStreamVariant2? powerStreamVariant2
            )
        {
            Base = @base;
            PowerStreamVariant2 = powerStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PowerStreamVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            PowerStreamVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsPowerStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.BaseStream, TResult>? @base = null,
            global::System.Func<global::Strava.PowerStreamVariant2, TResult>? powerStreamVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsPowerStreamVariant2 && powerStreamVariant2 != null)
            {
                return powerStreamVariant2(PowerStreamVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.BaseStream>? @base = null,

            global::System.Action<global::Strava.PowerStreamVariant2>? powerStreamVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsPowerStreamVariant2)
            {
                powerStreamVariant2?.Invoke(PowerStreamVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Strava.BaseStream>? @base = null,
            global::System.Action<global::Strava.PowerStreamVariant2>? powerStreamVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsPowerStreamVariant2)
            {
                powerStreamVariant2?.Invoke(PowerStreamVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Strava.BaseStream),
                PowerStreamVariant2,
                typeof(global::Strava.PowerStreamVariant2),
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
        public bool Equals(PowerStream other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.BaseStream?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.PowerStreamVariant2?>.Default.Equals(PowerStreamVariant2, other.PowerStreamVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PowerStream obj1, PowerStream obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PowerStream>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PowerStream obj1, PowerStream obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PowerStream o && Equals(o);
        }
    }
}
