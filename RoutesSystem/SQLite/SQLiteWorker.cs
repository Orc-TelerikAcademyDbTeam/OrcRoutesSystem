using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite
{
    using RoutesSystem.Data.DBContexts;
    using RoutesSystem.Model;

    public static class SQLiteWorker
    {
        private static SQLiteContext context = new SQLiteContext();

        public static List<DriverInfo> GetData()
        {
            List<DriverInfo> result;
            using (context)
            {
                result = context.DriversInfo.ToList();
            }

            return result;
        }
    }
}
