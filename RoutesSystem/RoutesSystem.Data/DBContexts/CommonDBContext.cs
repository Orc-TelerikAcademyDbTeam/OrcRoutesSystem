namespace RoutesSystem.Core.DataBaseIteraction
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using RoutesSystem.Data.Contracts;

    public class CommonDBContext : IDatabaseContext
    {
        public CommonDBContext(IDatabaseContext context)
        { 
        }

        public IDbSet<T> Set<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public DbEntityEntry<T> Entry<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
