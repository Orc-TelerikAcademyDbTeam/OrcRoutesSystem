namespace RoutesSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;

    using RoutesSystem.Data.DBContexts;

    public sealed class SQLServerConfiguration : DbMigrationsConfiguration<SQLServerContext>
    {
        public SQLServerConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "RoutesSystem.Data.DBContexts.RoutesSystemDbContext";
        }
    }
}