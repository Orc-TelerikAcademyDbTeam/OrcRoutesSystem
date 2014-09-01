namespace RoutesSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;

    using RoutesSystem.Data.DBContexts;

    public class SQLiteConfiguration : DbMigrationsConfiguration<SQLiteContext>
    {
        public SQLiteConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "RoutesSystem.Data.DBContexts.SQLiteContext";
        }
    }
}