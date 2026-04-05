
#nullable enable

namespace Strava
{
    /// <summary>
    /// The format of the uploaded file.
    /// </summary>
    public enum CreateUploadRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Fit,
        /// <summary>
        /// 
        /// </summary>
        FitGz,
        /// <summary>
        /// 
        /// </summary>
        Gpx,
        /// <summary>
        /// 
        /// </summary>
        GpxGz,
        /// <summary>
        /// 
        /// </summary>
        Tcx,
        /// <summary>
        /// 
        /// </summary>
        TcxGz,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateUploadRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateUploadRequestDataType value)
        {
            return value switch
            {
                CreateUploadRequestDataType.Fit => "fit",
                CreateUploadRequestDataType.FitGz => "fit.gz",
                CreateUploadRequestDataType.Gpx => "gpx",
                CreateUploadRequestDataType.GpxGz => "gpx.gz",
                CreateUploadRequestDataType.Tcx => "tcx",
                CreateUploadRequestDataType.TcxGz => "tcx.gz",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateUploadRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "fit" => CreateUploadRequestDataType.Fit,
                "fit.gz" => CreateUploadRequestDataType.FitGz,
                "gpx" => CreateUploadRequestDataType.Gpx,
                "gpx.gz" => CreateUploadRequestDataType.GpxGz,
                "tcx" => CreateUploadRequestDataType.Tcx,
                "tcx.gz" => CreateUploadRequestDataType.TcxGz,
                _ => null,
            };
        }
    }
}