namespace RoutesSystem.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq.Expressions;

    using RoutesSystem.Data.Contracts;

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private IRoutesSystemDbContext context;
        private IDbSet<T> set;

        public GenericRepository(IRoutesSystemDbContext routeSystemContext)
        {
            this.context = routeSystemContext;
            this.set = routeSystemContext.Set<T>();
        }

        public IQueryable<T> All()
        {
            return this.context.Set<T>();
        }

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> conditions)
        {
            return this.All().Where(conditions);
        }

        public void Add(T entity)
        {
            var entry = AttachIfDetached(entity);
            entry.State = EntityState.Added;
        }

        public void Update(T entity)
        {
            var entry = AttachIfDetached(entity);
            entry.State = EntityState.Modified;
        }

        public T Delete(T entity)
        {
            var entry = AttachIfDetached(entity);
            entry.State = EntityState.Deleted;
            return entity;
        }

        public void Detach(T entity)
        {
            var entry = this.context.Entry(entity);
            entry.State = EntityState.Detached;
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        private DbEntityEntry AttachIfDetached(T entity)
        {
            var entry = this.context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.set.Attach(entity);
            }

            return entry;
        }
    }
}
