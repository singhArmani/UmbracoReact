using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Linq;

namespace Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        private RepositoryContext _productContext;
        public ProductRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _productContext = repositoryContext;
        }

        public Product FindbyId(int Id)
        {
            var result = (from r in _productContext.Products where r.Id == Id select r).FirstOrDefault();
            return result;
        }

        public void Remove(int Id)
        {
            Product p = _productContext.Products.Find(Id);
            _productContext.Products.Remove(p);
            _productContext.SaveChanges();
        }
    }
}
