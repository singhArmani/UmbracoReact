using System;
using System.Collections.Generic;
using UmbracoContracts;

namespace UmbracoRepository
{
    // abstract class
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext { get; set; }

        public RepositoryBase(RepositoryContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }

        public void Create(T entity)
        {
            this.RepositoryContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
        }

        public IEnumerable<T> FindAll()
        {
            return this.RepositoryContext.Set<T>();
        }

        public void Save()
        {
            this.RepositoryContext.SaveChanges();
        }

    }
}
