namespace RoutesSystem.PDFReports
{
    using RoutesSystem.Data.DBContexts;
    using System.Collections.Generic;
    using System.Linq;

    public class Report
    {
        /// <summary>
        /// Get collection of the all visited routes with info about the drivers
        /// </summary>
        /// <returns></returns>
        internal IEnumerable<VisitedRouteInfo> GetVisitedRoutes()
        {
            var dbContext = new SQLServerContext();

            var result = dbContext.Routes
                .Select(route => new VisitedRouteInfo()
                {
                    StartTownName = route.StartTown.Name,
                    EndTownName = route.EndTown.Name,
                    VehicleRouteInfo = route.VehicleRoutes
                        .AsQueryable()
                        .Select(vehicleRoute => new VehicleRouteInfo()
                        {
                            RouteDate = vehicleRoute.Date,
                            DriverName = vehicleRoute.Vehicle.Driver.FirstName + " " + vehicleRoute.Vehicle.Driver.LastName,
                        })
                }).ToArray();

            return result;
        }
    }
}