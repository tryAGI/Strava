
#nullable enable

namespace Strava
{
    /// <summary>
    /// The description for the category of the climb
    /// </summary>
    public enum ExplorerSegmentClimbCategoryDesc
    {
        /// <summary>
        /// 
        /// </summary>
        x1,
        /// <summary>
        /// 
        /// </summary>
        x2,
        /// <summary>
        /// 
        /// </summary>
        x3,
        /// <summary>
        /// 
        /// </summary>
        x4,
        /// <summary>
        /// 
        /// </summary>
        Hc,
        /// <summary>
        /// 
        /// </summary>
        Nc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExplorerSegmentClimbCategoryDescExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExplorerSegmentClimbCategoryDesc value)
        {
            return value switch
            {
                ExplorerSegmentClimbCategoryDesc.x1 => "1",
                ExplorerSegmentClimbCategoryDesc.x2 => "2",
                ExplorerSegmentClimbCategoryDesc.x3 => "3",
                ExplorerSegmentClimbCategoryDesc.x4 => "4",
                ExplorerSegmentClimbCategoryDesc.Hc => "HC",
                ExplorerSegmentClimbCategoryDesc.Nc => "NC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExplorerSegmentClimbCategoryDesc? ToEnum(string value)
        {
            return value switch
            {
                "1" => ExplorerSegmentClimbCategoryDesc.x1,
                "2" => ExplorerSegmentClimbCategoryDesc.x2,
                "3" => ExplorerSegmentClimbCategoryDesc.x3,
                "4" => ExplorerSegmentClimbCategoryDesc.x4,
                "HC" => ExplorerSegmentClimbCategoryDesc.Hc,
                "NC" => ExplorerSegmentClimbCategoryDesc.Nc,
                _ => null,
            };
        }
    }
}