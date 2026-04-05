#nullable enable

namespace Strava
{
    public partial interface IClubsClient
    {
        /// <summary>
        /// Get Club<br/>
        /// Returns a given a club using its identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.DetailedClub> GetClubByIdAsync(
            long id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}