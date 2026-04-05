#nullable enable

namespace Strava
{
    public partial interface IClubsClient
    {
        /// <summary>
        /// List Club Administrators<br/>
        /// Returns a list of the administrators of a given club.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Strava.SummaryAthlete>> GetClubAdminsByIdAsync(
            long id,
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}