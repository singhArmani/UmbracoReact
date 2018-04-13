using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace UmbracoRepository
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext() : base("name=umbracoDbDSN")
        {
            
        }

        public DbSet Products { get; set; }
    }
}
