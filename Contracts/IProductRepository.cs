using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;

namespace Contracts
{
    /*Every user class will have its own interface, for additional model specific methods.
    Furthermore, by inheriting from the RepositoryBase class they will have access to all the methods from the RepositoryBase.
        
    This way, we are separating the logic, 
    that is common for all our repository user classes and also specific for every user class itself.
    */
    public interface IProductRepository: IRepositoryBase<Product>
    {
        Product FindbyId(int Id);
        void Remove(int Id);
    }
}
