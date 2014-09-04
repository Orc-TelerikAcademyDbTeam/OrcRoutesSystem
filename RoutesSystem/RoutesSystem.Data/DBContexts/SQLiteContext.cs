namespace RoutesSystem.Data.DBContexts
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using RoutesSystem.Data.Contracts;

    using RoutesSystem.Model.SQLiteModels;

    public class SQLiteContext : DbContext, ISQLiteDbContext
    {
        public SQLiteContext()
            : base("SQLiteDriversInfo")
        {
            // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SQLiteContext>());
        }

        public IDbSet<DriverInfo> DriversInfo { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public void SaveChanges()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
