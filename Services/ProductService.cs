using Entities.Models;
using RepositoryContracts;
using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService : IProductService, IServiceBase<Product>
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(Product entity)
        {
            _productRepository.Add(entity);
        }

        public void Edit(Product entity)
        {
            _productRepository.Edit(entity);
        }

        public IEnumerable<Product> FindAll()
        {
            return _productRepository.FindAll();
        }

        public Product FindbyId(int Id)
        {
            return _productRepository.FindbyId(Id);
        }

        public void Remove(int Id)
        {
            _productRepository.Remove(Id);
        }
    }
}
