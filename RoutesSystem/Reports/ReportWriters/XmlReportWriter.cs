namespace Reports.ReportWriters
{
    using System.Xml;

    using RoutesSystem.Core.Reports;

    using Reports.ReportTypes;

    public class XmlReportWriter
    {
        public void CreateReport()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create("d:\\Report.xml", settings))
            {
                writer.WriteStartDocument();
                writer.WriteComment("Report drivers visited routes");
                writer.WriteStartElement("Routes");
                    //writer.WriteStartElement("Route");
                    //    writer.WriteAttributeString("Start","zzz");
                    //    writer.WriteAttributeString("End","xxx");
                    //writer.WriteEndElement();
                
                var report = new XmlReport();
                var inputData = report.GetVisitedRoutes();
                
                foreach (var item in inputData)
                {
                    foreach (var detail in item.VehicleRouteInfo)
                    {
                        writer.WriteStartElement("Route");
                        writer.WriteAttributeString("Start", item.StartTownName);
                        writer.WriteAttributeString("End", item.EndTownName);
                        writer.WriteAttributeString("Date", detail.RouteDate.Date.Day.ToString());
                        writer.WriteEndElement();
                    }
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
        }
    }
}