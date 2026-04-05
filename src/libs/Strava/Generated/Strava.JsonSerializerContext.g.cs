
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Strava
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Strava.JsonConverters.ActivityTypeJsonConverter),

            typeof(global::Strava.JsonConverters.ActivityTypeNullableJsonConverter),

            typeof(global::Strava.JsonConverters.DetailedAthleteVariant2MeasurementPreferenceJsonConverter),

            typeof(global::Strava.JsonConverters.DetailedAthleteVariant2MeasurementPreferenceNullableJsonConverter),

            typeof(global::Strava.JsonConverters.SummaryAthleteVariant2SexJsonConverter),

            typeof(global::Strava.JsonConverters.SummaryAthleteVariant2SexNullableJsonConverter),

            typeof(global::Strava.JsonConverters.DetailedClubVariant2MembershipJsonConverter),

            typeof(global::Strava.JsonConverters.DetailedClubVariant2MembershipNullableJsonConverter),

            typeof(global::Strava.JsonConverters.SummaryClubVariant2SportTypeJsonConverter),

            typeof(global::Strava.JsonConverters.SummaryClubVariant2SportTypeNullableJsonConverter),

            typeof(global::Strava.JsonConverters.MembershipApplicationMembershipJsonConverter),

            typeof(global::Strava.JsonConverters.MembershipApplicationMembershipNullableJsonConverter),

            typeof(global::Strava.JsonConverters.SummarySegmentActivityTypeJsonConverter),

            typeof(global::Strava.JsonConverters.SummarySegmentActivityTypeNullableJsonConverter),

            typeof(global::Strava.JsonConverters.ExplorerSegmentClimbCategoryDescJsonConverter),

            typeof(global::Strava.JsonConverters.ExplorerSegmentClimbCategoryDescNullableJsonConverter),

            typeof(global::Strava.JsonConverters.SportTypeJsonConverter),

            typeof(global::Strava.JsonConverters.SportTypeNullableJsonConverter),

            typeof(global::Strava.JsonConverters.StreamTypeJsonConverter),

            typeof(global::Strava.JsonConverters.StreamTypeNullableJsonConverter),

            typeof(global::Strava.JsonConverters.BaseStreamResolutionJsonConverter),

            typeof(global::Strava.JsonConverters.BaseStreamResolutionNullableJsonConverter),

            typeof(global::Strava.JsonConverters.BaseStreamSeriesTypeJsonConverter),

            typeof(global::Strava.JsonConverters.BaseStreamSeriesTypeNullableJsonConverter),

            typeof(global::Strava.JsonConverters.ActivityZoneTypeJsonConverter),

            typeof(global::Strava.JsonConverters.ActivityZoneTypeNullableJsonConverter),

            typeof(global::Strava.JsonConverters.CreateUploadRequestDataTypeJsonConverter),

            typeof(global::Strava.JsonConverters.CreateUploadRequestDataTypeNullableJsonConverter),

            typeof(global::Strava.JsonConverters.ExploreSegmentsActivityTypeJsonConverter),

            typeof(global::Strava.JsonConverters.ExploreSegmentsActivityTypeNullableJsonConverter),

            typeof(global::Strava.JsonConverters.GetActivityStreamsKeyJsonConverter),

            typeof(global::Strava.JsonConverters.GetActivityStreamsKeyNullableJsonConverter),

            typeof(global::Strava.JsonConverters.GetSegmentEffortStreamsKeyJsonConverter),

            typeof(global::Strava.JsonConverters.GetSegmentEffortStreamsKeyNullableJsonConverter),

            typeof(global::Strava.JsonConverters.GetSegmentStreamsKeyJsonConverter),

            typeof(global::Strava.JsonConverters.GetSegmentStreamsKeyNullableJsonConverter),

            typeof(global::Strava.JsonConverters.DetailedActivityJsonConverter),

            typeof(global::Strava.JsonConverters.SummaryActivityJsonConverter),

            typeof(global::Strava.JsonConverters.DetailedAthleteJsonConverter),

            typeof(global::Strava.JsonConverters.SummaryAthleteJsonConverter),

            typeof(global::Strava.JsonConverters.DetailedClubJsonConverter),

            typeof(global::Strava.JsonConverters.SummaryClubJsonConverter),

            typeof(global::Strava.JsonConverters.DetailedGearJsonConverter),

            typeof(global::Strava.JsonConverters.DetailedSegmentJsonConverter),

            typeof(global::Strava.JsonConverters.DetailedSegmentEffortJsonConverter),

            typeof(global::Strava.JsonConverters.DistanceStreamJsonConverter),

            typeof(global::Strava.JsonConverters.TimeStreamJsonConverter),

            typeof(global::Strava.JsonConverters.LatLngStreamJsonConverter),

            typeof(global::Strava.JsonConverters.AltitudeStreamJsonConverter),

            typeof(global::Strava.JsonConverters.SmoothVelocityStreamJsonConverter),

            typeof(global::Strava.JsonConverters.HeartrateStreamJsonConverter),

            typeof(global::Strava.JsonConverters.CadenceStreamJsonConverter),

            typeof(global::Strava.JsonConverters.PowerStreamJsonConverter),

            typeof(global::Strava.JsonConverters.TemperatureStreamJsonConverter),

            typeof(global::Strava.JsonConverters.MovingStreamJsonConverter),

            typeof(global::Strava.JsonConverters.SmoothGradeStreamJsonConverter),

            typeof(global::Strava.JsonConverters.TimedZoneRangeJsonConverter),

            typeof(global::Strava.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DetailedActivity), TypeInfoPropertyName = "DetailedActivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SummaryActivity), TypeInfoPropertyName = "SummaryActivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DetailedActivityVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.PhotosSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SummaryGear))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.DetailedSegmentEffort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DetailedSegmentEffort), TypeInfoPropertyName = "DetailedSegmentEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.Split>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.Split))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.Lap>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.Lap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.MetaActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SummaryActivityVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.MetaAthlete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.ActivityType), TypeInfoPropertyName = "ActivityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SportType), TypeInfoPropertyName = "SportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.PolylineMap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.UpdatableActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.ClubActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.ActivityStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.ActivityTotal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DetailedAthlete), TypeInfoPropertyName = "DetailedAthlete2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SummaryAthlete), TypeInfoPropertyName = "SummaryAthlete2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DetailedAthleteVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DetailedAthleteVariant2MeasurementPreference), TypeInfoPropertyName = "DetailedAthleteVariant2MeasurementPreference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.SummaryClub>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SummaryClub), TypeInfoPropertyName = "SummaryClub2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.SummaryGear>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SummaryAthleteVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SummaryAthleteVariant2Sex), TypeInfoPropertyName = "SummaryAthleteVariant2Sex2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.ClubAthlete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DetailedClub), TypeInfoPropertyName = "DetailedClub2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DetailedClubVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DetailedClubVariant2Membership), TypeInfoPropertyName = "DetailedClubVariant2Membership2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.MetaClub))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SummaryClubVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SummaryClubVariant2SportType), TypeInfoPropertyName = "SummaryClubVariant2SportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.ActivityType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.ClubAnnouncement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.MembershipApplication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.MembershipApplicationMembership), TypeInfoPropertyName = "MembershipApplicationMembership2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.Comment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.Fault))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.Error>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DetailedGear), TypeInfoPropertyName = "DetailedGear2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DetailedGearVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.PhotosSummaryPrimary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.Route))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.SummarySegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SummarySegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.Waypoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.Waypoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DetailedSegment), TypeInfoPropertyName = "DetailedSegment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DetailedSegmentVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SummarySegmentActivityType), TypeInfoPropertyName = "SummarySegmentActivityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SummaryPRSegmentEffort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SummarySegmentEffort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.ExplorerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.ExplorerSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.ExplorerSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.ExplorerSegmentClimbCategoryDesc), TypeInfoPropertyName = "ExplorerSegmentClimbCategoryDesc2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DetailedSegmentEffortVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.StreamType), TypeInfoPropertyName = "StreamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.BaseStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.BaseStreamResolution), TypeInfoPropertyName = "BaseStreamResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.BaseStreamSeriesType), TypeInfoPropertyName = "BaseStreamSeriesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DistanceStream), TypeInfoPropertyName = "DistanceStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.DistanceStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.TimeStream), TypeInfoPropertyName = "TimeStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.TimeStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.LatLngStream), TypeInfoPropertyName = "LatLngStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.LatLngStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.AltitudeStream), TypeInfoPropertyName = "AltitudeStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.AltitudeStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SmoothVelocityStream), TypeInfoPropertyName = "SmoothVelocityStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SmoothVelocityStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.HeartrateStream), TypeInfoPropertyName = "HeartrateStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.HeartrateStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.CadenceStream), TypeInfoPropertyName = "CadenceStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.CadenceStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.PowerStream), TypeInfoPropertyName = "PowerStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.PowerStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.TemperatureStream), TypeInfoPropertyName = "TemperatureStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.TemperatureStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.MovingStream), TypeInfoPropertyName = "MovingStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.MovingStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SmoothGradeStream), TypeInfoPropertyName = "SmoothGradeStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.SmoothGradeStreamVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.StreamSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.Upload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.Zones))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.HeartRateZoneRanges))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.PowerZoneRanges))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.ZoneRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.ZoneRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.TimedZoneRange), TypeInfoPropertyName = "TimedZoneRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.TimedZoneRangeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.TimedZoneRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.ActivityZone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.ActivityZoneType), TypeInfoPropertyName = "ActivityZoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.StarSegmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.CreateActivityRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.CreateUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.CreateUploadRequestDataType), TypeInfoPropertyName = "CreateUploadRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.ExploreSegmentsActivityType), TypeInfoPropertyName = "ExploreSegmentsActivityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.GetActivityStreamsKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.GetActivityStreamsKey), TypeInfoPropertyName = "GetActivityStreamsKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.GetSegmentEffortStreamsKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.GetSegmentEffortStreamsKey), TypeInfoPropertyName = "GetSegmentEffortStreamsKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.GetSegmentStreamsKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Strava.GetSegmentStreamsKey), TypeInfoPropertyName = "GetSegmentStreamsKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.SummaryActivity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.ActivityZone>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.SummaryAthlete>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.ClubAthlete>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.ClubActivity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Strava.Route>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.DetailedSegmentEffort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.Split>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.Lap>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.SummaryClub>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.SummaryGear>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.ActivityType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.Error>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.SummarySegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.Waypoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.ExplorerSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.ZoneRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.TimedZoneRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.GetActivityStreamsKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.GetSegmentEffortStreamsKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.GetSegmentStreamsKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.SummaryActivity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.ActivityZone>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.SummaryAthlete>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.ClubAthlete>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.ClubActivity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Strava.Route>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}