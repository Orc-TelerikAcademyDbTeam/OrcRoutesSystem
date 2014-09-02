using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutesSystem.Data
{
    using System.IO;

    using RoutesSystem.Data.Contracts;
    using RoutesSystem.Data.DBContexts;
    using RoutesSystem.Data.Repositories;
    using RoutesSystem.Model.SQLiteModels;
    using RoutesSystem.Model.SQLServerModels;

    public class SQLiteData
    {
        private ISQLiteDbContext context;
        private IDictionary<Type, object> repositories;

        public SQLiteData()
            : this(new SQLiteContext())
        {
        }

        public SQLiteData(ISQLiteDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IGenericRepository<DriverInfo> DriversInfo
        {
            get
            {
                return this.GetRepository<DriverInfo>();
            }
        } 

        private IGenericRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);
            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var typeOfRepository = typeof(GenericSQLRepository<T>);
                var newRepository = Activator.CreateInstance(typeOfRepository, this.context);
                this.repositories.Add(typeOfModel, newRepository);
            }

            return (IGenericRepository<T>)this.repositories[typeOfModel];
        }
    }
}
