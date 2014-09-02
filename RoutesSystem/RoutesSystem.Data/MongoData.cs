using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutesSystem.Data
{
    using RoutesSystem.Data.Contracts;
    using RoutesSystem.Data.DBContexts;
    using RoutesSystem.Data.Repositories;
    using RoutesSystem.Model;
    using RoutesSystem.Model.MongoDBModels;
    using RoutesSystem.Model.SQLServerModels;

    public class MongoData
    {
        private IMongoDBContext context;
        private IDictionary<Type, object> repositories;

        public MongoData()
            : this(new MongoDBContext())
        {
        }

        public MongoData(IMongoDBContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IGenericNoSQLRepository<MongoManufacturer> Manufacturers
        {
            get
            {
                return this.GetRepository<MongoManufacturer>();
            }
        }

        public IGenericNoSQLRepository<MongoTown> Towns
        {
            get
            {
                return this.GetRepository<MongoTown>();
            }
        }

        public IGenericNoSQLRepository<MongoVehicleType> VehicleTypes
        {
            get
            {
                return this.GetRepository<MongoVehicleType>();
            }
        } 

        private IGenericNoSQLRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);
            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var typeOfRepository = typeof(GenericNoSQLRepository<T>);
                var newRepository = Activator.CreateInstance(typeOfRepository, this.context);
                this.repositories.Add(typeOfModel, newRepository);
            }

            return (IGenericNoSQLRepository<T>)this.repositories[typeOfModel];
        }
    }
}
