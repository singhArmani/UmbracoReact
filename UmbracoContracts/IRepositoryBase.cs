using System;
using System.Collections.Generic;

namespace UmbracoContracts
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> FindAll();
        void Create(T entity);
        void Delete(T entity);
        void Save();
    }
}
