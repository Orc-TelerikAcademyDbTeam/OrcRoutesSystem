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
                writer.WriteComment("Report drivers' visited routes");
                writer.WriteStartElement("Routes");
                writer.WriteAttributeString("Start town", "End town", "Vehicle route info");

                var report = new XmlReport();
                foreach (var item in report.GetVisitedRoutes())
                {
                     writer.WriteElementString(item.StartTownName, item.EndTownName, item.VehicleRouteInfo.ToString());
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
        }
    }
}