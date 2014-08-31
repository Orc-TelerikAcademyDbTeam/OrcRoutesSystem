using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutesSystem.Core.DataBaseIteraction
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using RoutesSystem.Data.Contracts;

    public class SQLServerContext : IDatabaseContext
    {
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
