namespace MySQL
{
    using System.Collections.Generic;
    using System.Linq;
    using Telerik.OpenAccess;

    public class EntryPoint
    {
        public static void Start()
        {
            UpdateDatabase();
        }

        public static void InsertRow(int id, string type, string manufactorer, string model, string fuel, string driverFirstName, string driverLastName)
        {
            using (FluentModel dbContext = new FluentModel())
            {
                VehicleInformation newRecord = new VehicleInformation();
                newRecord.VehicleID = id;
                newRecord.VehicleType = type;
                newRecord.Manufactorer = manufactorer;
                newRecord.VehicleModel = model;
                newRecord.FuelType = fuel;
                newRecord.DriverFirstName = driverFirstName;
                newRecord.DriverLastName = driverLastName;

                dbContext.Add(newRecord);
                dbContext.SaveChanges();
            }
        }

        public static IList<VehicleInformation> GetAllVehicleInformation()
        {
            using (FluentModel dbContext = new FluentModel())
            {
                return dbContext.GetAll<VehicleInformation>().ToList();
            }
        }

        private static void UpdateDatabase()
        {
            using (var context = new MySQL.FluentModel())
            {
                var schemaHandler = context.GetSchemaHandler();
                EnsureDB(schemaHandler);
            }
        }

        private static void EnsureDB(ISchemaHandler schemaHandler)
        {
            string script = null;
            if (schemaHandler.DatabaseExists())
            {
                script = schemaHandler.CreateUpdateDDLScript(null);
            }
            else
            {
                schemaHandler.CreateDatabase();
                script = schemaHandler.CreateDDLScript();
            }

            if (!string.IsNullOrEmpty(script))
            {
                schemaHandler.ExecuteDDLScript(script);
            }
        }
    }
}