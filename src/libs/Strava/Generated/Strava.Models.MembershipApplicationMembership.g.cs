
#nullable enable

namespace Strava
{
    /// <summary>
    /// The membership status of this application
    /// </summary>
    public enum MembershipApplicationMembership
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
    public static class MembershipApplicationMembershipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MembershipApplicationMembership value)
        {
            return value switch
            {
                MembershipApplicationMembership.Member => "member",
                MembershipApplicationMembership.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MembershipApplicationMembership? ToEnum(string value)
        {
            return value switch
            {
                "member" => MembershipApplicationMembership.Member,
                "pending" => MembershipApplicationMembership.Pending,
                _ => null,
            };
        }
    }
}