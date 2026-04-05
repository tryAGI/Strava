
#nullable enable

namespace Strava
{
    /// <summary>
    /// An enumeration of the sport types an activity may have. Distinct from ActivityType in that it has new types (e.g. MountainBikeRide)
    /// </summary>
    public enum SportType
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
        Badminton,
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
        EMountainBikeRide,
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
        GravelRide,
        /// <summary>
        /// 
        /// </summary>
        Handcycle,
        /// <summary>
        /// 
        /// </summary>
        HighIntensityIntervalTraining,
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
        MountainBikeRide,
        /// <summary>
        /// 
        /// </summary>
        NordicSki,
        /// <summary>
        /// 
        /// </summary>
        Pickleball,
        /// <summary>
        /// 
        /// </summary>
        Pilates,
        /// <summary>
        /// 
        /// </summary>
        Racquetball,
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
        Squash,
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
        TableTennis,
        /// <summary>
        /// 
        /// </summary>
        Tennis,
        /// <summary>
        /// 
        /// </summary>
        TrailRun,
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
        VirtualRow,
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
    public static class SportTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SportType value)
        {
            return value switch
            {
                SportType.AlpineSki => "AlpineSki",
                SportType.BackcountrySki => "BackcountrySki",
                SportType.Badminton => "Badminton",
                SportType.Canoeing => "Canoeing",
                SportType.Crossfit => "Crossfit",
                SportType.EBikeRide => "EBikeRide",
                SportType.EMountainBikeRide => "EMountainBikeRide",
                SportType.Elliptical => "Elliptical",
                SportType.Golf => "Golf",
                SportType.GravelRide => "GravelRide",
                SportType.Handcycle => "Handcycle",
                SportType.HighIntensityIntervalTraining => "HighIntensityIntervalTraining",
                SportType.Hike => "Hike",
                SportType.IceSkate => "IceSkate",
                SportType.InlineSkate => "InlineSkate",
                SportType.Kayaking => "Kayaking",
                SportType.Kitesurf => "Kitesurf",
                SportType.MountainBikeRide => "MountainBikeRide",
                SportType.NordicSki => "NordicSki",
                SportType.Pickleball => "Pickleball",
                SportType.Pilates => "Pilates",
                SportType.Racquetball => "Racquetball",
                SportType.Ride => "Ride",
                SportType.RockClimbing => "RockClimbing",
                SportType.RollerSki => "RollerSki",
                SportType.Rowing => "Rowing",
                SportType.Run => "Run",
                SportType.Sail => "Sail",
                SportType.Skateboard => "Skateboard",
                SportType.Snowboard => "Snowboard",
                SportType.Snowshoe => "Snowshoe",
                SportType.Soccer => "Soccer",
                SportType.Squash => "Squash",
                SportType.StairStepper => "StairStepper",
                SportType.StandUpPaddling => "StandUpPaddling",
                SportType.Surfing => "Surfing",
                SportType.Swim => "Swim",
                SportType.TableTennis => "TableTennis",
                SportType.Tennis => "Tennis",
                SportType.TrailRun => "TrailRun",
                SportType.Velomobile => "Velomobile",
                SportType.VirtualRide => "VirtualRide",
                SportType.VirtualRow => "VirtualRow",
                SportType.VirtualRun => "VirtualRun",
                SportType.Walk => "Walk",
                SportType.WeightTraining => "WeightTraining",
                SportType.Wheelchair => "Wheelchair",
                SportType.Windsurf => "Windsurf",
                SportType.Workout => "Workout",
                SportType.Yoga => "Yoga",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SportType? ToEnum(string value)
        {
            return value switch
            {
                "AlpineSki" => SportType.AlpineSki,
                "BackcountrySki" => SportType.BackcountrySki,
                "Badminton" => SportType.Badminton,
                "Canoeing" => SportType.Canoeing,
                "Crossfit" => SportType.Crossfit,
                "EBikeRide" => SportType.EBikeRide,
                "EMountainBikeRide" => SportType.EMountainBikeRide,
                "Elliptical" => SportType.Elliptical,
                "Golf" => SportType.Golf,
                "GravelRide" => SportType.GravelRide,
                "Handcycle" => SportType.Handcycle,
                "HighIntensityIntervalTraining" => SportType.HighIntensityIntervalTraining,
                "Hike" => SportType.Hike,
                "IceSkate" => SportType.IceSkate,
                "InlineSkate" => SportType.InlineSkate,
                "Kayaking" => SportType.Kayaking,
                "Kitesurf" => SportType.Kitesurf,
                "MountainBikeRide" => SportType.MountainBikeRide,
                "NordicSki" => SportType.NordicSki,
                "Pickleball" => SportType.Pickleball,
                "Pilates" => SportType.Pilates,
                "Racquetball" => SportType.Racquetball,
                "Ride" => SportType.Ride,
                "RockClimbing" => SportType.RockClimbing,
                "RollerSki" => SportType.RollerSki,
                "Rowing" => SportType.Rowing,
                "Run" => SportType.Run,
                "Sail" => SportType.Sail,
                "Skateboard" => SportType.Skateboard,
                "Snowboard" => SportType.Snowboard,
                "Snowshoe" => SportType.Snowshoe,
                "Soccer" => SportType.Soccer,
                "Squash" => SportType.Squash,
                "StairStepper" => SportType.StairStepper,
                "StandUpPaddling" => SportType.StandUpPaddling,
                "Surfing" => SportType.Surfing,
                "Swim" => SportType.Swim,
                "TableTennis" => SportType.TableTennis,
                "Tennis" => SportType.Tennis,
                "TrailRun" => SportType.TrailRun,
                "Velomobile" => SportType.Velomobile,
                "VirtualRide" => SportType.VirtualRide,
                "VirtualRow" => SportType.VirtualRow,
                "VirtualRun" => SportType.VirtualRun,
                "Walk" => SportType.Walk,
                "WeightTraining" => SportType.WeightTraining,
                "Wheelchair" => SportType.Wheelchair,
                "Windsurf" => SportType.Windsurf,
                "Workout" => SportType.Workout,
                "Yoga" => SportType.Yoga,
                _ => null,
            };
        }
    }
}