#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CadenceStream : global::System.IEquatable<CadenceStream>
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
        public global::Strava.CadenceStreamVariant2? CadenceStreamVariant2 { get; init; }
#else
        public global::Strava.CadenceStreamVariant2? CadenceStreamVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CadenceStreamVariant2))]
#endif
        public bool IsCadenceStreamVariant2 => CadenceStreamVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCadenceStreamVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Strava.CadenceStreamVariant2? value)
        {
            value = CadenceStreamVariant2;
            return IsCadenceStreamVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CadenceStream(global::Strava.BaseStream value) => new CadenceStream((global::Strava.BaseStream?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.BaseStream?(CadenceStream @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CadenceStream(global::Strava.BaseStream? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CadenceStream(global::Strava.CadenceStreamVariant2 value) => new CadenceStream((global::Strava.CadenceStreamVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Strava.CadenceStreamVariant2?(CadenceStream @this) => @this.CadenceStreamVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CadenceStream(global::Strava.CadenceStreamVariant2? value)
        {
            CadenceStreamVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CadenceStream(
            global::Strava.BaseStream? @base,
            global::Strava.CadenceStreamVariant2? cadenceStreamVariant2
            )
        {
            Base = @base;
            CadenceStreamVariant2 = cadenceStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CadenceStreamVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CadenceStreamVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCadenceStreamVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Strava.BaseStream, TResult>? @base = null,
            global::System.Func<global::Strava.CadenceStreamVariant2, TResult>? cadenceStreamVariant2 = null,
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
            else if (IsCadenceStreamVariant2 && cadenceStreamVariant2 != null)
            {
                return cadenceStreamVariant2(CadenceStreamVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Strava.BaseStream>? @base = null,

            global::System.Action<global::Strava.CadenceStreamVariant2>? cadenceStreamVariant2 = null,
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
            else if (IsCadenceStreamVariant2)
            {
                cadenceStreamVariant2?.Invoke(CadenceStreamVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Strava.BaseStream>? @base = null,
            global::System.Action<global::Strava.CadenceStreamVariant2>? cadenceStreamVariant2 = null,
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
            else if (IsCadenceStreamVariant2)
            {
                cadenceStreamVariant2?.Invoke(CadenceStreamVariant2!);
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
                CadenceStreamVariant2,
                typeof(global::Strava.CadenceStreamVariant2),
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
        public bool Equals(CadenceStream other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Strava.BaseStream?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Strava.CadenceStreamVariant2?>.Default.Equals(CadenceStreamVariant2, other.CadenceStreamVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CadenceStream obj1, CadenceStream obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CadenceStream>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CadenceStream obj1, CadenceStream obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CadenceStream o && Equals(o);
        }
    }
}
