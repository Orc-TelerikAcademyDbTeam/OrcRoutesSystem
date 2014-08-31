using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutesSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;

    using RoutesSystem.Core.DataBaseIteraction;
    using RoutesSystem.Data.DBContexts;

    public class SQLiteConfiguration:DbMigrationsConfiguration<SQLiteContext>
    {
          public SQLiteConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "RoutesSystem.Data.DBContexts.SQLiteContext";
        }
    }
}
