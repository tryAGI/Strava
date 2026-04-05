#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace tryAGI.Strava;

/// <summary>
/// MEAI AIFunction tool extensions for StravaClient.
/// </summary>
[System.CLSCompliant(false)]
public static class StravaClientExtensions
{
    /// <summary>
    /// Returns all Strava tools as a list of AIFunction instances.
    /// </summary>
    public static IList<AIFunction> AsTools(this global::Strava.StravaClient client)
    {
        return
        [
            client.AsGetAthleteProfileTool(),
            client.AsGetAthleteStatsTool(),
            client.AsGetActivitiesTool(),
            client.AsGetActivityTool(),
            client.AsGetSegmentTool(),
        ];
    }

    /// <summary>
    /// Creates an AIFunction tool that gets the authenticated athlete's profile.
    /// </summary>
    public static AIFunction AsGetAthleteProfileTool(this global::Strava.StravaClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Athletes.GetLoggedInAthleteAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var summary = response.Summary?.SummaryAthleteVariant2;
                var detail = response.DetailedAthleteVariant2;
                return new
                {
                    Id = response.Summary?.Meta?.Id,
                    summary?.Firstname,
                    summary?.Lastname,
                    summary?.City,
                    summary?.State,
                    summary?.Country,
                    summary?.Premium,
                    detail?.FollowerCount,
                    detail?.FriendCount,
                    detail?.Weight,
                };
            },
            name: "Strava_GetAthleteProfile",
            description: "Get the authenticated Strava athlete's profile including name, location, and follower/friend counts.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets athlete statistics (totals for rides, runs, swims).
    /// </summary>
    public static AIFunction AsGetAthleteStatsTool(this global::Strava.StravaClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The athlete ID to get stats for")] long athleteId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Athletes.GetStatsAsync(
                    id: athleteId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.BiggestRideDistance,
                    response.BiggestClimbElevationGain,
                    RecentRides = response.RecentRideTotals != null ? new
                    {
                        response.RecentRideTotals.Count,
                        response.RecentRideTotals.Distance,
                        response.RecentRideTotals.MovingTime,
                        response.RecentRideTotals.ElevationGain,
                    } : null,
                    RecentRuns = response.RecentRunTotals != null ? new
                    {
                        response.RecentRunTotals.Count,
                        response.RecentRunTotals.Distance,
                        response.RecentRunTotals.MovingTime,
                        response.RecentRunTotals.ElevationGain,
                    } : null,
                    RecentSwims = response.RecentSwimTotals != null ? new
                    {
                        response.RecentSwimTotals.Count,
                        response.RecentSwimTotals.Distance,
                        response.RecentSwimTotals.MovingTime,
                    } : null,
                    AllTimeRides = response.AllRideTotals != null ? new
                    {
                        response.AllRideTotals.Count,
                        response.AllRideTotals.Distance,
                        response.AllRideTotals.MovingTime,
                        response.AllRideTotals.ElevationGain,
                    } : null,
                    AllTimeRuns = response.AllRunTotals != null ? new
                    {
                        response.AllRunTotals.Count,
                        response.AllRunTotals.Distance,
                        response.AllRunTotals.MovingTime,
                        response.AllRunTotals.ElevationGain,
                    } : null,
                    AllTimeSwims = response.AllSwimTotals != null ? new
                    {
                        response.AllSwimTotals.Count,
                        response.AllSwimTotals.Distance,
                        response.AllSwimTotals.MovingTime,
                    } : null,
                };
            },
            name: "Strava_GetAthleteStats",
            description: "Get an athlete's activity statistics including recent and all-time totals for rides, runs, and swims, plus biggest ride distance and climb elevation gain.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists the authenticated athlete's activities.
    /// </summary>
    public static AIFunction AsGetActivitiesTool(this global::Strava.StravaClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Page number for pagination (optional)")] int? page,
                   [Description("Number of items per page, default 30 (optional)")] int? perPage,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Activities.GetLoggedInAthleteActivitiesAsync(
                    page: page,
                    perPage: perPage,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response.Select(a =>
                {
                    var props = a.SummaryActivityVariant2;
                    return new
                    {
                        Id = a.Meta?.Id,
                        props?.Name,
                        props?.Type,
                        props?.SportType,
                        props?.Distance,
                        props?.MovingTime,
                        props?.ElapsedTime,
                        props?.TotalElevationGain,
                        props?.StartDate,
                        props?.AverageSpeed,
                        props?.MaxSpeed,
                    };
                }).ToList();
            },
            name: "Strava_GetActivities",
            description: "List the authenticated athlete's recent activities with distance, time, elevation, and speed data. Supports pagination.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets a specific activity by ID.
    /// </summary>
    public static AIFunction AsGetActivityTool(this global::Strava.StravaClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The activity ID")] long activityId,
                   [Description("Whether to include all segment efforts (optional)")] bool? includeAllEfforts,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Activities.GetActivityByIdAsync(
                    id: activityId,
                    includeAllEfforts: includeAllEfforts,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var summary = response.Summary?.SummaryActivityVariant2;
                var detail = response.DetailedActivityVariant2;
                return new
                {
                    Id = response.Summary?.Meta?.Id,
                    summary?.Name,
                    detail?.Description,
                    summary?.Type,
                    summary?.SportType,
                    summary?.Distance,
                    summary?.MovingTime,
                    summary?.ElapsedTime,
                    summary?.TotalElevationGain,
                    summary?.StartDate,
                    summary?.AverageSpeed,
                    summary?.MaxSpeed,
                    detail?.Calories,
                    detail?.DeviceName,
                };
            },
            name: "Strava_GetActivity",
            description: "Get detailed information about a specific Strava activity including distance, time, elevation, speed, and calories.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets a specific segment by ID.
    /// </summary>
    public static AIFunction AsGetSegmentTool(this global::Strava.StravaClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The segment ID")] long segmentId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Segments.GetSegmentByIdAsync(
                    id: segmentId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var summary = response.Summary;
                var detail = response.DetailedSegmentVariant2;
                return new
                {
                    summary?.Id,
                    summary?.Name,
                    summary?.ActivityType,
                    summary?.Distance,
                    summary?.AverageGrade,
                    summary?.MaximumGrade,
                    summary?.ElevationHigh,
                    summary?.ElevationLow,
                    summary?.ClimbCategory,
                    summary?.City,
                    summary?.State,
                    summary?.Country,
                    detail?.TotalElevationGain,
                    detail?.AthleteCount,
                    detail?.EffortCount,
                    detail?.StarCount,
                };
            },
            name: "Strava_GetSegment",
            description: "Get detailed information about a Strava segment including distance, grade, elevation, climb category, and popularity stats.");
    }
}
