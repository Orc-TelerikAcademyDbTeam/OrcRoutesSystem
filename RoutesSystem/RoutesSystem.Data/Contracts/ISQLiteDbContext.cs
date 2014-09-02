namespace RoutesSystem.Data.Contracts
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using RoutesSystem.Model.SQLiteModels;

    public interface ISQLiteDbContext : IDatabaseContext
    {
        IDbSet<DriverInfo> DriversInfo { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}