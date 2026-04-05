
#nullable enable

namespace Strava
{
    /// <summary>
    /// An enumeration of the types an activity may have. Note that this enumeration does not include new sport types (e.g. MountainBikeRide, EMountainBikeRide), activities with these sport types will have the corresponding activity type (e.g. Ride for MountainBikeRide, EBikeRide for EMountainBikeRide)
    /// </summary>
    public enum ActivityType
    {
        /// <summary>
        /// 
        /// </summary>
        AlpineSki,
        /// <summary>
        /// 
        /// </summary>
        BackcountrySki,
        /// <summary>
        /// 
        /// </summary>
        Canoeing,
        /// <summary>
        /// 
        /// </summary>
        Crossfit,
        /// <summary>
        /// 
        /// </summary>
        EBikeRide,
        /// <summary>
        /// 
        /// </summary>
        Elliptical,
        /// <summary>
        /// 
        /// </summary>
        Golf,
        /// <summary>
        /// 
        /// </summary>
        Handcycle,
        /// <summary>
        /// 
        /// </summary>
        Hike,
        /// <summary>
        /// 
        /// </summary>
        IceSkate,
        /// <summary>
        /// 
        /// </summary>
        InlineSkate,
        /// <summary>
        /// 
        /// </summary>
        Kayaking,
        /// <summary>
        /// 
        /// </summary>
        Kitesurf,
        /// <summary>
        /// 
        /// </summary>
        NordicSki,
        /// <summary>
        /// 
        /// </summary>
        Ride,
        /// <summary>
        /// 
        /// </summary>
        RockClimbing,
        /// <summary>
        /// 
        /// </summary>
        RollerSki,
        /// <summary>
        /// 
        /// </summary>
        Rowing,
        /// <summary>
        /// 
        /// </summary>
        Run,
        /// <summary>
        /// 
        /// </summary>
        Sail,
        /// <summary>
        /// 
        /// </summary>
        Skateboard,
        /// <summary>
        /// 
        /// </summary>
        Snowboard,
        /// <summary>
        /// 
        /// </summary>
        Snowshoe,
        /// <summary>
        /// 
        /// </summary>
        Soccer,
        /// <summary>
        /// 
        /// </summary>
        StairStepper,
        /// <summary>
        /// 
        /// </summary>
        StandUpPaddling,
        /// <summary>
        /// 
        /// </summary>
        Surfing,
        /// <summary>
        /// 
        /// </summary>
        Swim,
        /// <summary>
        /// 
        /// </summary>
        Velomobile,
        /// <summary>
        /// 
        /// </summary>
        VirtualRide,
        /// <summary>
        /// 
        /// </summary>
        VirtualRun,
        /// <summary>
        /// 
        /// </summary>
        Walk,
        /// <summary>
        /// 
        /// </summary>
        WeightTraining,
        /// <summary>
        /// 
        /// </summary>
        Wheelchair,
        /// <summary>
        /// 
        /// </summary>
        Windsurf,
        /// <summary>
        /// 
        /// </summary>
        Workout,
        /// <summary>
        /// 
        /// </summary>
        Yoga,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActivityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActivityType value)
        {
            return value switch
            {
                ActivityType.AlpineSki => "AlpineSki",
                ActivityType.BackcountrySki => "BackcountrySki",
                ActivityType.Canoeing => "Canoeing",
                ActivityType.Crossfit => "Crossfit",
                ActivityType.EBikeRide => "EBikeRide",
                ActivityType.Elliptical => "Elliptical",
                ActivityType.Golf => "Golf",
                ActivityType.Handcycle => "Handcycle",
                ActivityType.Hike => "Hike",
                ActivityType.IceSkate => "IceSkate",
                ActivityType.InlineSkate => "InlineSkate",
                ActivityType.Kayaking => "Kayaking",
                ActivityType.Kitesurf => "Kitesurf",
                ActivityType.NordicSki => "NordicSki",
                ActivityType.Ride => "Ride",
                ActivityType.RockClimbing => "RockClimbing",
                ActivityType.RollerSki => "RollerSki",
                ActivityType.Rowing => "Rowing",
                ActivityType.Run => "Run",
                ActivityType.Sail => "Sail",
                ActivityType.Skateboard => "Skateboard",
                ActivityType.Snowboard => "Snowboard",
                ActivityType.Snowshoe => "Snowshoe",
                ActivityType.Soccer => "Soccer",
                ActivityType.StairStepper => "StairStepper",
                ActivityType.StandUpPaddling => "StandUpPaddling",
                ActivityType.Surfing => "Surfing",
                ActivityType.Swim => "Swim",
                ActivityType.Velomobile => "Velomobile",
                ActivityType.VirtualRide => "VirtualRide",
                ActivityType.VirtualRun => "VirtualRun",
                ActivityType.Walk => "Walk",
                ActivityType.WeightTraining => "WeightTraining",
                ActivityType.Wheelchair => "Wheelchair",
                ActivityType.Windsurf => "Windsurf",
                ActivityType.Workout => "Workout",
                ActivityType.Yoga => "Yoga",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActivityType? ToEnum(string value)
        {
            return value switch
            {
                "AlpineSki" => ActivityType.AlpineSki,
                "BackcountrySki" => ActivityType.BackcountrySki,
                "Canoeing" => ActivityType.Canoeing,
                "Crossfit" => ActivityType.Crossfit,
                "EBikeRide" => ActivityType.EBikeRide,
                "Elliptical" => ActivityType.Elliptical,
                "Golf" => ActivityType.Golf,
                "Handcycle" => ActivityType.Handcycle,
                "Hike" => ActivityType.Hike,
                "IceSkate" => ActivityType.IceSkate,
                "InlineSkate" => ActivityType.InlineSkate,
                "Kayaking" => ActivityType.Kayaking,
                "Kitesurf" => ActivityType.Kitesurf,
                "NordicSki" => ActivityType.NordicSki,
                "Ride" => ActivityType.Ride,
                "RockClimbing" => ActivityType.RockClimbing,
                "RollerSki" => ActivityType.RollerSki,
                "Rowing" => ActivityType.Rowing,
                "Run" => ActivityType.Run,
                "Sail" => ActivityType.Sail,
                "Skateboard" => ActivityType.Skateboard,
                "Snowboard" => ActivityType.Snowboard,
                "Snowshoe" => ActivityType.Snowshoe,
                "Soccer" => ActivityType.Soccer,
                "StairStepper" => ActivityType.StairStepper,
                "StandUpPaddling" => ActivityType.StandUpPaddling,
                "Surfing" => ActivityType.Surfing,
                "Swim" => ActivityType.Swim,
                "Velomobile" => ActivityType.Velomobile,
                "VirtualRide" => ActivityType.VirtualRide,
                "VirtualRun" => ActivityType.VirtualRun,
                "Walk" => ActivityType.Walk,
                "WeightTraining" => ActivityType.WeightTraining,
                "Wheelchair" => ActivityType.Wheelchair,
                "Windsurf" => ActivityType.Windsurf,
                "Workout" => ActivityType.Workout,
                "Yoga" => ActivityType.Yoga,
                _ => null,
            };
        }
    }
}