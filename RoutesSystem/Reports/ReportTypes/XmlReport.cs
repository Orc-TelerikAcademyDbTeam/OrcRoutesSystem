namespace Reports.ReportTypes
{
    using System.Collections.Generic;
    using System.Linq;

    using Reports.ReportModels;

    using RoutesSystem.Data.DBContexts;

    public class XmlReport
    {
        /// <summary>
        /// Get collection of cost of fuel for the visited routes
        /// </summary>
        /// <returns></returns>
        internal IEnumerable<FuelInfo> FuelSpent()
        {
            var dbContext = new SQLServerContext();

            var result = 
                dbContext.FuelInfo.Select(
                    record => 
                    new FuelInfo()
                    {
                        FuelId = record.ID,
                        VehicleId = record.VehicleId,
                        Price = record.Price,
                        Spent = record.Spent,
                        Total = record.Total
                    }
                ).ToArray();
            return result;
        }
    }
}