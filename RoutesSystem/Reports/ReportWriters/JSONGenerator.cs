namespace Reports.ReportWriters
{
    using Newtonsoft.Json;
    using Reports.ReportModels;
    using System;
    using System.Collections.Generic;
    using System.IO;

    internal class JSONGenerator
    {
        private const string DEFAULT_FILE_NAME = "VehicleInformationReport";

        private string fileName;
        private string path;

        internal JSONGenerator(string fileName = null, string path = null)
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
                this.path = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
            }
            else
            {
                this.path = path;
            }
        }

        internal void Generate(IEnumerable<VehicleInformation> vehicleCollection)
        {
            try
            {
                string jsonResult = JsonConvert.SerializeObject(vehicleCollection, Formatting.Indented);

                System.IO.File.WriteAllText(this.path + this.fileName + ".josn", jsonResult);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
