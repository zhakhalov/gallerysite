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
            using(var ctx = new GalleryContext())
            {
                return ctx.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (var ctx = new GalleryContext())
            {
                return ctx.Set<T>().Find(id);
            }
        }

        public void Add(T entity)
        {
            using (var ctx = new GalleryContext())
            {
                ctx.Set<T>().Add(entity);
                ctx.SaveChanges();
            }
        }

        public void Remove(int id)
        {
            using (var ctx = new GalleryContext())
            {
                var entity = ctx.Set<T>().Find(id);
                ctx.Set<T>().Remove(entity);
                ctx.SaveChanges();
            }

        }

        public void Update(T entity)
        {
            using (var ctx = new GalleryContext())
            {
                ctx.SaveChanges();
            }
        }
    }
}
