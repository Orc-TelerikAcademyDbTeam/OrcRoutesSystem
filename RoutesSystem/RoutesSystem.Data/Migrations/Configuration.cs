namespace RoutesSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using RoutesSystem.Model;

    public sealed class Configuration : DbMigrationsConfiguration<RoutesSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "RoutesSystem.Data.RoutesSystemDbContext";
        }
    }
}
