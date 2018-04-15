using System.Data.Entity;
using Entities.Models;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext() : base("name=umbracoDbDSN")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
