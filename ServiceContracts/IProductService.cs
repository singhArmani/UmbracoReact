using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public interface IProductService: IServiceBase<Product>
    {
        Product FindbyId(int Id);
        void Remove(int Id);
    }
}
