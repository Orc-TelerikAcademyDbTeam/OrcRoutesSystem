namespace Reports.ReportModels
{
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
