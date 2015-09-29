using Gallery.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.DAL.Abstract
{
    public class Repository<T> : IRepository<T> where T : class
    {

        public IEnumerable<T> GetAll()
        {
            Task<IEnumerable<T>> task = this.GetAllAsync();
            task.Wait();
            return task.Result;
        }

        public T GetById(int id)
        {
            Task<T> task = this.GetByIdAsync(id);
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


        public async Task<IEnumerable<T>> GetAllAsync()
        {
            using (var ctx = new GalleryContext())
            {
                return await ctx.Set<T>().ToListAsync();
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            using (var ctx = new GalleryContext())
            {
                return await ctx.Set<T>().FindAsync(id);
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
