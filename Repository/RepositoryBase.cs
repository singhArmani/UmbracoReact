using System;
using System.Collections.Generic;
using Contracts;
using Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext context = new RepositoryContext();

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Edit(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public IEnumerable<T> FindAll()
        {
            return context.Set<T>();
        }
    }
}
