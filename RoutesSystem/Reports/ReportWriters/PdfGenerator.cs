namespace Reports.ReportWriters
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using iTextSharp.text;
    using iTextSharp.text.pdf;

    using Reports.ReportModels;

    internal class PdfGenerator
    {
        private const string DEFAULT_FILE_NAME = "AggregateRouteReport";
        private const string TABLE_TITLE = "Aggregate Route Report";
        private const string COLUMN_DRIVER_TITLE = "Driver Name";
        private const string COLUMN_VEHICLE_TITLE = "Vehicle";
        private const string COLUMN_DATE_TITLE = "Date";
        private const string AGGREGATE_MESSAGE = "Total travelledRoutes: {0} Total passed: {1} km.";
        private const string ROUTE_MESSAGE = "Route: {0} - {1}";
        private const int COLSPAN_MERGE_ALL_CELLS = 3;

        private string fileName;
        private string path;

        internal PdfGenerator(string path = null, string fileName = null)
        {
            if (fileName == null)
            {
                this.fileName = DEFAULT_FILE_NAME;
            }
            else
            {
                this.fileName = fileName;
            }

            if (path == null)
            {
                this.path = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
            }
            else
            {
                this.path = path;
            }
        }

        internal void Generate(IEnumerable<VisitedRouteInfo> routesCollection)
        {
            try
            {
                using (FileStream fs = new FileStream(string.Format(@"{0}\{1}.pdf", this.path, this.fileName),
                    FileMode.Create, FileAccess.Write, FileShare.None))
                using (Document doc = new Document())
                using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
                {
                    doc.Open();
                    PdfPTable table = new PdfPTable(3);
                    AppendTitle(table);
                    foreach (var route in routesCollection)
                    {
                        AppendHeader(table, route);
                        foreach (var vehicleRoute in route.VehicleRouteInfo)
                        {
                            AppendRow(vehicleRoute, table);
                        }

                        AppendAggregateRow(route, table);
                    }

                    doc.Add(table);
                    doc.Close();
                }
            }
            catch (DocumentException documentExcep)
            {
                throw documentExcep;
            }
            catch (IOException ioExcep)
            {
                throw ioExcep;
            }
        }

        private void AppendTitle(PdfPTable table)
        {
            this.AddCellToTable(TABLE_TITLE, table, null, COLSPAN_MERGE_ALL_CELLS, PdfPCell.ALIGN_CENTER);
        }

        private void AppendHeader(PdfPTable table, VisitedRouteInfo route)
        {
            this.AddCellToTable(string.Format(ROUTE_MESSAGE, route.StartTownName, route.EndTownName),
                table, BaseColor.GRAY, COLSPAN_MERGE_ALL_CELLS);

            this.AddCellToTable(COLUMN_DRIVER_TITLE, table, BaseColor.LIGHT_GRAY, null, PdfPCell.ALIGN_CENTER);
            this.AddCellToTable(COLUMN_VEHICLE_TITLE, table, BaseColor.LIGHT_GRAY, null, PdfPCell.ALIGN_CENTER);
            this.AddCellToTable(COLUMN_DATE_TITLE, table, BaseColor.LIGHT_GRAY, null, PdfPCell.ALIGN_CENTER);
        }

        private void AppendRow(VehicleRouteInfo vehicleRoute, PdfPTable table)
        {
            this.AddCellToTable(vehicleRoute.DriverName, table);
            this.AddCellToTable(vehicleRoute.VehicleFullName, table);
            this.AddCellToTable(vehicleRoute.RouteDate.ToString("dd.MM.yyyy"), table, null, null, PdfPCell.ALIGN_RIGHT);
        }

        private void AppendAggregateRow(VisitedRouteInfo route, PdfPTable table)
        {
            var driversCount = route.VehicleRouteInfo.Count();
            var totalDistance = route.Distance * driversCount;
            this.AddCellToTable(string.Format(AGGREGATE_MESSAGE,
                driversCount, totalDistance), table, null, COLSPAN_MERGE_ALL_CELLS, PdfPCell.ALIGN_RIGHT);
        }

        private void AddCellToTable(string value, PdfPTable table)
        {
            AddCellToTable(value, table, null, null);
        }

        private void AddCellToTable(string value, PdfPTable table, BaseColor color = null,
            int? colspan = null, int? alignment = null)
        {
            var cell = new PdfPCell(new Paragraph(value));
            if (color != null)
            {
                cell.BackgroundColor = color;
            }
            if (colspan != null)
            {
                cell.Colspan = (int)colspan;
            }
            if (alignment != null)
            {
                cell.HorizontalAlignment = (int)alignment;
            }

            table.AddCell(cell);
        }
    }
}