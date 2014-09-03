namespace Reports.ReportTypes
{
    using System.Collections.Generic;
    using System.Linq;
    using Reports.ReportModels;
    using RoutesSystem.Data.DBContexts;

    public class JSONReport
    {
        /// <summary>
        /// Get collection of the all vehicles and information about them.
        /// </summary>
        /// <returns></returns>
        /// 
        internal IEnumerable<VehicleInformation> GetVehicleInformation()
        {
            var dbContext = new SQLServerContext();

            var result =
                dbContext.Vehicles.Select(
                    vehicle =>
                    new VehicleInformation()
                    {
                        VehicleID = vehicle.Id,
                        VehicleType = vehicle.Type.Name,
                        Manufactorer = vehicle.Manufacturer.Name,
                        VehicleModel = vehicle.Model.Name,
                        FuelType = vehicle.FuelType.Name,
                        DriverFirstName = vehicle.Driver.FirstName,
                        DriverLastName = vehicle.Driver.LastName
                    }).ToArray();

            return result;
        }
    }
}