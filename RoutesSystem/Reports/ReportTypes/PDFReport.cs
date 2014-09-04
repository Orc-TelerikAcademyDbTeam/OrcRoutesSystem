namespace Reports.ReportTypes
{
    using System.Collections.Generic;
    using System.Linq;

    using Reports.ReportModels;
    using RoutesSystem.Data.DBContexts;

    internal class PdfReport
    {
        /// <summary>
        /// Get collection of the all visited routes with info about the travelledRoutes
        /// </summary>
        /// <returns></returns>
        internal IEnumerable<VisitedRouteInfo> GetVisitedRoutes()
        {
            var dbContext = new SQLServerContext();

            var result =
                dbContext.Routes.Select(
                    route => new VisitedRouteInfo()
                        {
                            StartTownName = route.StartTown.Name,
                            EndTownName = route.EndTown.Name,
                            Distance = route.Distance,
                            VehicleRouteInfo = route.VehicleRoutes.AsQueryable()
                                .Select(vehicleRoute => new VehicleRouteInfo()
                                    {
                                        VehicleFullName = vehicleRoute.Vehicle.Manufacturer.Name + " " +
                                            vehicleRoute.Vehicle.Model.Name,
                                        RouteDate = vehicleRoute.Date,
                                        DriverName = vehicleRoute.Vehicle.Driver.FirstName + " " +
                                            vehicleRoute.Vehicle.Driver.LastName
                                    })
                        }).OrderByDescending(route => (route.VehicleRouteInfo.Count() * route.Distance)).ToArray();

            return result;
        }
    }
}