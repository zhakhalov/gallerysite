using Gallery.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.DAL.Abstract
{
    public class Repository<T> : IRepository<T> where T : class
    {

        public IEnumerable<T> FindAll()
        {
            Task<IEnumerable<T>> task = this.FindAllAsync();
            task.Wait();
            return task.Result;
        }

        public IEnumerable<T> FindAll(Expression<Func<T, bool>> predicate)
        {
            Task<IEnumerable<T>> task = this.FindAllAsync(predicate);
            task.Wait();
            return task.Result;
        }

        public T FindOne(int id)
        {
            Task<T> task = this.FindOneAsync(id);
            task.Wait();
            return task.Result;
        }

        public T FindOne(Expression<Func<T, bool>> predicate)
        {
            Task<T> task = this.FindOneAsync(predicate);
            task.Wait();
            return task.Result;
        }

        public void Add(T entity)
        {
            Task task = this.AddAsync(entity);
            task.Wait();
        }

        public void Remove(T entity)
        {
            Task task = this.RemoveAsync(entity);
            task.Wait();
        }

        public void Update(T entity)
        {
            Task task = this.UpdateAsync(entity);
            task.Wait();
        }


        public async Task<IEnumerable<T>> FindAllAsync()
        {
            using (var ctx = new GalleryContext())
            {
                return await ctx.Set<T>().ToListAsync();
            }
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate)
        {
            using (var ctx = new GalleryContext())
            {
                return await ctx.Set<T>().Where(predicate).ToListAsync();
            }
        }

        public async Task<T> FindOneAsync(int id)
        {
            using (var ctx = new GalleryContext())
            {
                return await ctx.Set<T>().FindAsync(id);
            }
        }

        public async Task<T> FindOneAsync(Expression<Func<T, bool>> predicate)
        {
            using (var ctx = new GalleryContext())
            {
                return await ctx.Set<T>().FirstAsync(predicate);
            }
        }

        public async Task AddAsync(T entity)
        {
            using (var ctx = new GalleryContext())
            {
                ctx.Set<T>().Add(entity);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task RemoveAsync(T entity)
        {
            using (var ctx = new GalleryContext())
            {
                ctx.Set<T>().Remove(entity);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(T entity)
        {
            using (var ctx = new GalleryContext())
            {
                await ctx.SaveChangesAsync();
            }
        }
    }
}
