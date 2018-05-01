using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using Entities.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository;
using RepositoryContracts;

namespace UnitTests
{
    [TestClass]
    public class ProductRepositoryTest
    {
        private Mock<IProductRepository> _mockproductRepository;
        private IProductRepository _productRepository;
        [TestInitialize]
        public void TestSetup()
        {
            _mockproductRepository = new Mock<IProductRepository>();
            _mockproductRepository.Setup(x => x.FindAll()).Returns(new List<Product>() { new Product { Id = 1, instock = true, Name = "Default", Price = 1.5 } });
            _productRepository = _mockproductRepository.Object;
        }

        [TestMethod]
        public void IsRepositoryInitalizeWithValidNumberOfData()
        {
           
            var results = _productRepository.FindAll();
            Assert.IsNotNull(results);

            //var numOfRecords = results.ToList().Count;
            //Assert.AreEqual(1, numOfRecords);
        }

        //[TestMethod]
        //public void isRepositoryAddProduct()
        //{
        //    Product productToInsert = new Product
        //    {
        //        Id = 5,
        //        instock = true,
        //        Name = "Salt",
        //    };

        //    _productRepository.Add(productToInsert);
        //    var result = _productRepository.FindAll();
        //    var numberOfRecords = result.ToList().Count;
        //    Assert.AreEqual(5, numberOfRecords);
        //}
    }

}
