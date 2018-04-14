using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Entities;
using Entities.Models;

namespace Repository
{
    public class ProductIntializerDB: DropCreateDatabaseIfModelChanges<RepositoryContext>
    {
        protected override void Seed(RepositoryContext context)
        {
            context.Products.Add(new Product { Id = 1, Name = "Rice", instock = true });
            context.Products.Add(new Product { Id = 2, Name = "Sugar", instock = false });
            context.Products.Add(new Product { Id = 3, Name = "Flour", instock = true });
            context.Products.Add(new Product { Id = 4, Name = "Eggs", instock = false });
        }
    }
}
