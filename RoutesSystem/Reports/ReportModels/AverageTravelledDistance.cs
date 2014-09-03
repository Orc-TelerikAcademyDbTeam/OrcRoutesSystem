namespace Reports.ReportModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AverageTravelledDistance
    {
        public string DriverFirstName { get; set; }

        public string DriverLastName { get; set; }

        public string StartTown { get; set; }

        public string EndTown { get; set; }

        public string VehicleManufacturer { get; set; }

        public string VehicleModel { get; set; }

        public int TravelledRoutesCount { get; set; }

        public decimal TravelledDistance { get; set; }

        public int AverageDistance
        {
            get
            {
                return (int)(this.TravelledDistance / this.TravelledRoutesCount);
            }
        }
    }
}
