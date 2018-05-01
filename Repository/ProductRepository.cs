using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using Entities.Models;
using System.Text;
using System.Threading.Tasks;
using RepositoryContracts;

namespace Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {

        public Product FindbyId(int Id)
        {
            var result = (from r in this.context.Products where r.Id == Id select r).FirstOrDefault();
            return result;
        }

        public void Remove(int Id)
        {
            Product p = this.context.Products.Find(Id);
            this.context.Products.Remove(p);
            this.context.SaveChanges();
        }
    }
}
