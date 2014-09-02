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

        //protected override void Seed(RoutesSystemDbContext routeSystemContext)
        //{
        //    this.SeedTown(routeSystemContext);
        //}

        //private void SeedTown(RoutesSystemDbContext routeSystemContext)
        //{
        //    if (routeSystemContext.Towns.Any())
        //    {
        //        return;
        //    }

        //    routeSystemContext.Towns.Add(new Town
        //    {
        //        Name = "Varna"
        //    });
        //}
    }
}