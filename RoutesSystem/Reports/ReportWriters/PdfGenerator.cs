namespace Reports.ReportWriters
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using iTextSharp.text;
    using iTextSharp.text.pdf;

    using Reports.ReportModels;

    internal class PdfGenerator
    {
        private const string DEFAULT_FILE_NAME = "RouteReport";

        private string fileName;
        private string path;

        internal PdfGenerator(string fileName = null, string path = null)
        {
            if (fileName == null)
            {
                fileName = DEFAULT_FILE_NAME;
            }
            else
            {
                this.fileName = fileName;
            }

            if (path == null)
            {
                this.path = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
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
                using (FileStream fs = new FileStream(string.Format("{0}{1}.pdf", this.path, this.fileName), FileMode.Create, FileAccess.Write, FileShare.None))
                using (Document doc = new Document())
                using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
                {
                    doc.Open();

                    var header = string.Format("Start Town  End Town   Driver Name    Date");
                    var headerParagraph = new Paragraph(header);
                    doc.Add(headerParagraph);
                    foreach (var route in routesCollection)
                    {
                        foreach (var vehicleRoute in route.VehicleRouteInfo)
                        {
                            var content = string.Format("{0}  {1}  {2}  {3}", route.StartTownName, route.EndTownName, vehicleRoute.DriverName, vehicleRoute.RouteDate);
                            var paragraph = new Paragraph(content);
                            doc.Add(paragraph);
                        }
                    }
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
    }
}