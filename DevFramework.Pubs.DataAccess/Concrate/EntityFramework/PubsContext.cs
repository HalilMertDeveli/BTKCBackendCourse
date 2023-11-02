using DevFramework.Pubs.DataAccess.Concrate.EntityFramework.Mappings;
using DevFramework.Pubs.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Pubs.DataAccess.Concrate.EntityFramework
{
    public class PubsContext:DbContext
    {
        public PubsContext()
        {
            Database.SetInitializer<PubsContext>(null);
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //if there is another thing add there 
            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}
