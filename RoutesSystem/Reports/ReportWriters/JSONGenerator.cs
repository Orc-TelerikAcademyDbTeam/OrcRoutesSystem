namespace Reports.ReportWriters
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using Newtonsoft.Json;

    using Reports.ReportModels;

    internal class JSONGenerator
    {
        private const string DEFAULT_FILE_NAME = "VehicleInformationReport";
        private const string JSON_EXTENSION = ".json";
        private const string JSON_FILE_PATH = "..\\..\\..\\Json-Reports\\";

        private string fileName;
        private string path;

        internal JSONGenerator(string path = null, string fileName = null)
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
                this.path = JSON_FILE_PATH;
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
                string jsonResult;

                foreach (var vehicle in vehicleCollection)
                {
                    // create JSON object
                    jsonResult = JsonConvert.SerializeObject(vehicle, Formatting.Indented);

                    var filePath = this.path + "\\" + vehicle.VehicleID + JSON_EXTENSION;

                    // create *.json file for JSON object
                    System.IO.File.WriteAllText(filePath, jsonResult);

                    // insert data form JSON object into MySQL
                    MySQL.EntryPoint.InsertRow(vehicle.VehicleID, vehicle.VehicleType, vehicle.Manufactorer, vehicle.VehicleModel, vehicle.FuelType, vehicle.DriverFirstName, vehicle.DriverLastName);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
