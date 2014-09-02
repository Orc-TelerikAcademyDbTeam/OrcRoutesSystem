namespace SQLite
{
    using System.Collections.Generic;
    using System.Linq;

    using RoutesSystem.Data;
    using RoutesSystem.Model.SQLiteModels;

    public static class SQLiteWorker
    {
        private static SQLiteData data = new SQLiteData();

        public static List<DriverInfo> GetDriverRouteData()
        {
            List<DriverInfo> result;

            result = data.DriversInfo.All().ToList();

            return result;
        }
    }
}