
#nullable enable

namespace Strava
{
    /// <summary>
    /// The membership status of the logged-in athlete.
    /// </summary>
    public enum DetailedClubVariant2Membership
    {
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetailedClubVariant2MembershipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetailedClubVariant2Membership value)
        {
            return value switch
            {
                DetailedClubVariant2Membership.Member => "member",
                DetailedClubVariant2Membership.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetailedClubVariant2Membership? ToEnum(string value)
        {
            return value switch
            {
                "member" => DetailedClubVariant2Membership.Member,
                "pending" => DetailedClubVariant2Membership.Pending,
                _ => null,
            };
        }
    }
}