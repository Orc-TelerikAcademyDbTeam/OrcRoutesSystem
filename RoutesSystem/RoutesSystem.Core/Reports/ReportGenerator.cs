namespace RoutesSystem.Core.Reports
{
    using System.Linq;
    using RoutesSystem.Data;
    using System;

    using RoutesSystem.Data.DBContexts;

    public class ReportGenerator
    {
        private readonly IReportFileType fileType;

        public ReportGenerator(IReportFileType fileType)
        {
            this.fileType = fileType;
        }

        public void Generate(ReportType reportType)
        {
            IReportData report = GetReport(reportType);
            this.fileType.CreateReport(report);
        }

        private IReportData GetReport(ReportType reportType)
        {
            IReportData report;

            switch (reportType)
            {
                case ReportType.DriversVehicles:
                    report = DriversVehiclesInfo();
                    break;
                default:
                    throw new ArgumentException("Report type not exist!");
            }

            return report;
        }

        //Example for one report. Need to implements DTOs
        private IReportData DriversVehiclesInfo()
        {
            using(RoutesSystemDbContext dbContext = new RoutesSystemDbContext())
            {
                var driversVehicle = dbContext.Vehicles.Select(x => new
                {
                    VehicleType = x.Type.Name,
                    DriverName = x.Driver.FirstName + " "+ x.Driver.LastName
                }).ToArray();

                //driversVehicle
            }

            return null;
        }
    }
}