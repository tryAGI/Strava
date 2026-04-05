#nullable enable

namespace Strava
{
    public partial interface IRoutesClient
    {
        /// <summary>
        /// List Athlete Routes<br/>
        /// Returns a list of the routes created by the authenticated athlete. Private routes are filtered out unless requested by a token with read_all scope.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Strava.Route>> GetRoutesByAthleteIdAsync(
            string id,
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}