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
                writer.WriteAttributeString("Starttown", "Endtown");

                var report = new XmlReport();
                var inputData = report.GetVisitedRoutes();
                foreach (var item in inputData)
                {
                    System.Console.WriteLine(item.StartTownName, item.EndTownName);
                }

                //writer.WriteStartElement("x", "root", "123");
                //writer.WriteStartElement("item");
                //writer.WriteAttributeString("xmlns", "x", null, "abc");
                //writer.WriteEndElement();
                //writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
        }
    }
}