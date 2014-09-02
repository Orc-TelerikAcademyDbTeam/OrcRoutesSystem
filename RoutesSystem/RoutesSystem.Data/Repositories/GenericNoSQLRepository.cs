namespace RoutesSystem.Data.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    using MongoDB.Driver;
    using MongoDB.Driver.Linq;

    using RoutesSystem.Data.Contracts;
    using RoutesSystem.Data.DBContexts;

    internal class GenericNoSQLRepository<T> : IGenericNoSQLRepository<T>
        where T : class
    {
        private IMongoDBContext context;

        private MongoCollection set;

        public GenericNoSQLRepository(IMongoDBContext context)
        {
            this.context = context;
            this.set = context.Set<T>();
        }

        public GenericNoSQLRepository()
            : this(new MongoDBContext())
        {
        }

        public IQueryable<T> All()
        {
            return this.context.Set<T>().AsQueryable<T>();
        }

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> conditions)
        {
            return this.All().Where(conditions);
        }

        public void Insert(T entity)
        {
            this.set.Insert(entity);
        }

        public void Update(IMongoQuery query, IMongoUpdate update)
        {
            this.set.Update(query, update);
        }

        public T FindOne()
        {
            return this.set.FindOneAs<T>();
        }

        public T Delete(IMongoQuery query)
        {
            var entry = this.set.FindOneAs<T>(query);
            this.set.Remove(query);
            return entry;
        }
    }
}