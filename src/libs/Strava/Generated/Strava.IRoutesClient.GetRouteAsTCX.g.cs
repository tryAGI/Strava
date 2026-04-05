#nullable enable

namespace Strava
{
    public partial interface IRoutesClient
    {
        /// <summary>
        /// Export Route TCX<br/>
        /// Returns a TCX file of the route. Requires read_all scope for private routes.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Strava.ApiException"></exception>
        global::System.Threading.Tasks.Task GetRouteAsTCXAsync(
            long id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}