#nullable enable

namespace Strava
{
    public partial interface IGearsClient
    {
        /// <summary>
        /// Get Equipment<br/>
        /// Returns an equipment using its identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.DetailedGear> GetGearByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}