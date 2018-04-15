using System;
using System.Linq;
using Entities;
using Entities.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;

namespace UnitTests
{
    [TestClass]
    public class ProductRepositoryTest
    {
        ProductRepository Repo;
        [TestInitialize]
        public void TestSetup()
        {
            ProductIntializerDB db = new ProductIntializerDB();
            System.Data.Entity.Database.SetInitializer(db);

            Repo = new ProductRepository();
        }

        [TestMethod]
        public void IsRepositoryInitalizeWithValidNumberOfData()
        {
           
            var results = Repo.FindAll();
            Assert.IsNotNull(results);

            var numOfRecords = results.ToList().Count;
            Assert.AreEqual(4, numOfRecords);
        }

        [TestMethod]
        public void isRepositoryAddProduct()
        {
            Product productToInsert = new Product
            {
                Id = 5,
                instock = true,
                Name = "Salt",
            };

            Repo.Add(productToInsert);
            var result = Repo.FindAll();
            var numberOfRecords = result.ToList().Count;
            Assert.AreEqual(5, numberOfRecords);
        }
    }

}
