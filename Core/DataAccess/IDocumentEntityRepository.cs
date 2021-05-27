using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IDocumentEntityRepository<T>
    {
        void Add(T entity);
        Task AddAsyc(T entity);
        void AddMany(IEnumerable<T> entities);
        Task AddManyAsync(IEnumerable<T> entities);

        void Delete(ObjectId id);
        void Delete(T record);
        Task DeleteAsync(ObjectId id);
        Task DeleteAsync(T record);

        T GetById(ObjectId id);
        Task<T> GetByIdAsync(ObjectId id);
        IQueryable<T> GetList(Expression<Func<T, bool>> predicate = null);
        Task<IQueryable<T>> GetListAsync(Expression<Func<T, bool>> predicate = null);

        void Update(ObjectId id, T record);
        void Update(T record, Expression<Func<T, bool>> predicate);
        Task UpdateAsync(ObjectId id, T record);
        Task UpdateAsync(T record, Expression<Func<T, bool>> predicate);

        bool Any(Expression<Func<T, bool>> predicate = null);
    }
}
