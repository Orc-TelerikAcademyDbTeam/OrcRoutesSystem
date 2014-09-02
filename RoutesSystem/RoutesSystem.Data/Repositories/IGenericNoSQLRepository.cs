using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutesSystem.Data.Repositories
{
    using System.Linq.Expressions;

    using MongoDB.Driver;

    public interface IGenericNoSQLRepository<T> where T:class 
    {
        IQueryable<T> All();

        IQueryable<T> SearchFor(Expression<Func<T, bool>> conditions);

        void Insert(T entity);

        void Update(IMongoQuery query, IMongoUpdate update);

        T FindOne();

        T Delete(IMongoQuery query);
    }
}
