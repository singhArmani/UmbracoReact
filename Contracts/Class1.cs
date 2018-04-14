using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> FindAll();
        void Add(T entity);
        void Edit(T entity);
    }
}
