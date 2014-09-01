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

        //protected override void Seed(RoutesSystemDbContext context)
        //{
        //    this.SeedTown(context);
        //}

        //private void SeedTown(RoutesSystemDbContext context)
        //{
        //    if (context.Towns.Any())
        //    {
        //        return;
        //    }

        //    context.Towns.Add(new Town
        //    {
        //        Name = "Varna"
        //    });
        //}
    }
}