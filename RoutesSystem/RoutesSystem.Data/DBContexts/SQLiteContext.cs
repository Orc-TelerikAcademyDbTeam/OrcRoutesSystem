namespace RoutesSystem.Data.DBContexts
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using RoutesSystem.Data.Contracts;
    using RoutesSystem.Data.Migrations;
    using RoutesSystem.Model;
    using System.Data.SQLite;

    using RoutesSystem.Model.SQLiteModels;
    using RoutesSystem.Model.SQLServerModels;

    //using System.Data.SQLite.Linq;

    public class SQLiteContext : DbContext, ISQLiteDbContext
    {
        public SQLiteContext()
            : base("SQLiteDriversInfo")
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SQLiteContext>());
        }
        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        public IDbSet<DriverInfo> DriversInfo { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
