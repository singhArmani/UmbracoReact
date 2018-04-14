using System.Data.Entity;
using Entities.Models;

// this is a middleware class to talk with database 
namespace Entities
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext() : base("name=umbracoDbDSN")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
