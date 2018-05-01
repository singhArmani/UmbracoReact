using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace RepositoryContracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        Product FindbyId(int Id);
        void Remove(int Id);
    }
}
