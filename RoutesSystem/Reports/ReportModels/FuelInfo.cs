﻿namespace Reports.ReportModels
{
    public class FuelInfo
    {
        public int FuelId { get; set; }

        public int VehicleId { get; set; }

        public decimal Price { get; set; }

        public decimal Spent { get; set; }

        public decimal Total { get; set; }
    }
}
