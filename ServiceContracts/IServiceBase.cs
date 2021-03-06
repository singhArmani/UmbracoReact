﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public interface IServiceBase<T>
    {
        IEnumerable<T> FindAll();
        void Add(T entity);
        void Edit(T entity);
    }
}
