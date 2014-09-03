namespace Reports.ReportWriters
{
    using Reports.ReportModels;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml;

    internal class XmlGenerator
    {
        //Should be different report
        private const string DEFAULT_FILE_NAME = "AggregateRouteReport";

        private string fileName;
        private string path;

        public XmlGenerator(string path = null, string fileName = null)
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

        internal void Generate(IEnumerable<VisitedRouteInfo> inputData)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create(string.Format(@"{0}\{1}.xml", this.path, this.fileName), settings))
            {
                writer.WriteStartDocument();
                writer.WriteComment("Report drivers visited routes");
                writer.WriteStartElement("Routes");

                foreach (var item in inputData)
                {
                    foreach (var detail in item.VehicleRouteInfo)
                    {
                        writer.WriteStartElement("Route");
                        writer.WriteAttributeString("Start", item.StartTownName);
                        writer.WriteAttributeString("End", item.EndTownName);
                        writer.WriteAttributeString("Driver", detail.DriverName);
                        writer.WriteAttributeString("Date", detail.RouteDate.Date.ToString());
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