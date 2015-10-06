using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Gallery.DAL.Abstract
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        Task AddAsync(T entity);
        IEnumerable<T> FindAll();
        IEnumerable<T> FindAll(int skip, int take);
        IEnumerable<T> FindAll(Expression<Func<T, bool>> predicate);
        IEnumerable<T> FindAll(Expression<Func<T, bool>> predicate, int skip, int take);
        Task<IEnumerable<T>> FindAllAsync();
        Task<IEnumerable<T>> FindAllAsync(int skip, int take);
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate, int skip, int take);
        T FindOne(int id);
        T FindOne(Expression<Func<T, bool>> predicate);
        Task<T> FindOneAsync(int id);
        Task<T> FindOneAsync(Expression<Func<T, bool>> predicate);
        void Remove(T entity);
        Task RemoveAsync(T entity);
        void Update(T entity);
        Task UpdateAsync(T entity);
    }
}
