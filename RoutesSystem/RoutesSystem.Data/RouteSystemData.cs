﻿namespace RoutesSystem.Data
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

        private IGenericRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);
            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var typeOfRepository = typeof(GenericRepository<T>);
                var newRepository = Activator.CreateInstance(typeOfRepository, this.context);
                this.repositories.Add(typeOfModel, newRepository);
            }

            return (IGenericRepository<T>)this.repositories[typeOfModel];
        }
    }
}