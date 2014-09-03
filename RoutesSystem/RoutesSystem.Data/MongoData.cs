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

        public MongoData(string url, string dbName)
        {
            this.context = new MongoDBContext(url, dbName);
            this.repositories = new Dictionary<Type, object>();
        }

        private MongoData(IMongoDBContext context)
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

        public IGenericNoSQLRepository<MongoFuelType> FuelTypes
        {
            get
            {
                return this.GetRepository<MongoFuelType>();
            }
        }

        public IGenericNoSQLRepository<MongoModel> VehicleModels
        {
            get
            {
                return this.GetRepository<MongoModel>();
            }
        }

        public IGenericNoSQLRepository<MongoVehicle> Vehicles
        {
            get
            {
                return this.GetRepository<MongoVehicle>();
            }
        }

        public IGenericNoSQLRepository<MongoDriver> Drivers
        {
            get
            {
                return this.GetRepository<MongoDriver>();
            }
        }

        public IGenericNoSQLRepository<MongoRoute> Routes
        {
            get
            {
                return this.GetRepository<MongoRoute>();
            }
        }

        public IGenericNoSQLRepository<MongoVehicleRoute> VehicleRoutes
        {
            get
            {
                return this.GetRepository<MongoVehicleRoute>();
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
