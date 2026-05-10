
#nullable enable

namespace Strava
{
    /// <summary>
    /// A set of rolled-up statistics and totals for an athlete
    /// </summary>
    public sealed partial class ActivityStats
    {
        /// <summary>
        /// The longest distance ridden by the athlete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("biggest_ride_distance")]
        public double? BiggestRideDistance { get; set; }

        /// <summary>
        /// The highest climb ridden by the athlete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("biggest_climb_elevation_gain")]
        public double? BiggestClimbElevationGain { get; set; }

        /// <summary>
        /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recent_ride_totals")]
        public global::Strava.ActivityTotal? RecentRideTotals { get; set; }

        /// <summary>
        /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recent_run_totals")]
        public global::Strava.ActivityTotal? RecentRunTotals { get; set; }

        /// <summary>
        /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recent_swim_totals")]
        public global::Strava.ActivityTotal? RecentSwimTotals { get; set; }

        /// <summary>
        /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ytd_ride_totals")]
        public global::Strava.ActivityTotal? YtdRideTotals { get; set; }

        /// <summary>
        /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ytd_run_totals")]
        public global::Strava.ActivityTotal? YtdRunTotals { get; set; }

        /// <summary>
        /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ytd_swim_totals")]
        public global::Strava.ActivityTotal? YtdSwimTotals { get; set; }

        /// <summary>
        /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all_ride_totals")]
        public global::Strava.ActivityTotal? AllRideTotals { get; set; }

        /// <summary>
        /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all_run_totals")]
        public global::Strava.ActivityTotal? AllRunTotals { get; set; }

        /// <summary>
        /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all_swim_totals")]
        public global::Strava.ActivityTotal? AllSwimTotals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityStats" /> class.
        /// </summary>
        /// <param name="biggestRideDistance">
        /// The longest distance ridden by the athlete.
        /// </param>
        /// <param name="biggestClimbElevationGain">
        /// The highest climb ridden by the athlete.
        /// </param>
        /// <param name="recentRideTotals">
        /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
        /// </param>
        /// <param name="recentRunTotals">
        /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
        /// </param>
        /// <param name="recentSwimTotals">
        /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
        /// </param>
        /// <param name="ytdRideTotals">
        /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
        /// </param>
        /// <param name="ytdRunTotals">
        /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
        /// </param>
        /// <param name="ytdSwimTotals">
        /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
        /// </param>
        /// <param name="allRideTotals">
        /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
        /// </param>
        /// <param name="allRunTotals">
        /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
        /// </param>
        /// <param name="allSwimTotals">
        /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityStats(
            double? biggestRideDistance,
            double? biggestClimbElevationGain,
            global::Strava.ActivityTotal? recentRideTotals,
            global::Strava.ActivityTotal? recentRunTotals,
            global::Strava.ActivityTotal? recentSwimTotals,
            global::Strava.ActivityTotal? ytdRideTotals,
            global::Strava.ActivityTotal? ytdRunTotals,
            global::Strava.ActivityTotal? ytdSwimTotals,
            global::Strava.ActivityTotal? allRideTotals,
            global::Strava.ActivityTotal? allRunTotals,
            global::Strava.ActivityTotal? allSwimTotals)
        {
            this.BiggestRideDistance = biggestRideDistance;
            this.BiggestClimbElevationGain = biggestClimbElevationGain;
            this.RecentRideTotals = recentRideTotals;
            this.RecentRunTotals = recentRunTotals;
            this.RecentSwimTotals = recentSwimTotals;
            this.YtdRideTotals = ytdRideTotals;
            this.YtdRunTotals = ytdRunTotals;
            this.YtdSwimTotals = ytdSwimTotals;
            this.AllRideTotals = allRideTotals;
            this.AllRunTotals = allRunTotals;
            this.AllSwimTotals = allSwimTotals;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityStats" /> class.
        /// </summary>
        public ActivityStats()
        {
        }

    }
}