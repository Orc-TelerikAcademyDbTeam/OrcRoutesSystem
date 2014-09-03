namespace RoutesSystem.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using RoutesSystem.Data.Contracts;
    using RoutesSystem.Data.DBContexts;
    using RoutesSystem.Data.Repositories;
    using RoutesSystem.Model;
    using RoutesSystem.Model.SQLServerModels;

    public class RouteSystemData
    {
        private IRoutesSystemDbContext context;
        private IDictionary<Type, object> repositories;

        public RouteSystemData()
            : this(new SQLServerContext())
        {
        }

        public RouteSystemData(IRoutesSystemDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IGenericRepository<Driver> Drivers
        {
            get
            {
                return this.GetRepository<Driver>();
            }
        }

        public IGenericRepository<Manufacturer> Manufacturers
        {
            get
            {
                return this.GetRepository<Manufacturer>();
            }
        }

        public IGenericRepository<Town> Towns
        {
            get
            {
                return this.GetRepository<Town>();
            }
        }

        public IGenericRepository<VehicleType> VehicleTypes
        {
            get
            {
                return this.GetRepository<VehicleType>();
            }
        }

        public IGenericRepository<FuelInfo> FuelInfo
        {
            get
            {
                return this.GetRepository<FuelInfo>();
            }
        }

        public IGenericRepository<FuelType> Fueltypes
        {
            get
            {
                return this.GetRepository<FuelType>();
            }
        }

        public IGenericRepository<Vehicle> Vehicles
        {
            get
            {
                return this.GetRepository<Vehicle>();
            }
        }

        public IGenericRepository<Model> Models
        {
            get
            {
                return this.GetRepository<Model>();
            }
        }

        public IGenericRepository<Route> Routes
        {
            get
            {
                return this.GetRepository<Route>();
            }
        }

        public IGenericRepository<CarEntry> VehicleExpenseInfo
        {
            get
            {
                return this.GetRepository<CarEntry>();
            }
        }

        public IGenericRepository<CarExpenses> VehicleExpenses
        {
            get
            {
                return this.GetRepository<CarExpenses>();
            }
        }

        public IGenericRepository<VehicleRoute> VehicleRoutes
        {
            get
            {
                return this.GetRepository<VehicleRoute>();
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
