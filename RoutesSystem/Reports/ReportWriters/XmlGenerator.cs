namespace Reports.ReportWriters
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml;

    using Reports.ReportModels;

    internal class XmlGenerator
    {
        private const string DEFAULT_FILE_NAME = "FuelConsumptionReport";

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

        internal void Generate(IEnumerable<FuelInfo> inputData)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create(string.Format(@"{0}\{1}.xml", this.path, this.fileName), settings))
            {
                writer.WriteStartDocument();
                writer.WriteComment("Fuel consumption report");
                writer.WriteStartElement("Routes");

                foreach (var item in inputData)
                {
                    writer.WriteStartElement("Routes");
                    writer.WriteAttributeString("VehicleId", item.VehicleId.ToString());
                    writer.WriteAttributeString("FuelId", item.FuelId.ToString());
                    writer.WriteAttributeString("Price", item.Price.ToString());
                    writer.WriteAttributeString("Spent", item.Spent.ToString());
                    writer.WriteAttributeString("Total", item.Total.ToString());
                    writer.WriteEndElement();
                }

                var groupedCosts = inputData.GroupBy(x => x.VehicleId).Select(
                        k => new
                        {
                            Vehicle = inputData.Where(x => x.VehicleId == k.Key).Select(x => x.VehicleId).First(),
                            TotalCost = inputData.Where(x => x.VehicleId == k.Key).Select(x => k.Sum(y => y.Total)).First()
                        }).ToList();

                foreach (var item in groupedCosts)
                {
                    writer.WriteStartElement("TotalCostPerVehicle");
                    writer.WriteAttributeString("VehicleId", item.Vehicle.ToString());
                    writer.WriteAttributeString("FuelId", item.TotalCost.ToString());
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
        }
    }
}