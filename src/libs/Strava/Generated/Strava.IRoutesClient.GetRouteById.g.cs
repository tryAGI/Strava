#nullable enable

namespace Strava
{
    public partial interface IRoutesClient
    {
        /// <summary>
        /// Get Route<br/>
        /// Returns a route using its identifier. Requires read_all scope for private routes.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Strava.Route> GetRouteByIdAsync(
            long id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}