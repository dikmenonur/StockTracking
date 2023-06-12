using StockTracking.Core.Configurations;
using StockTracking.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.Core.Repositories
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext()
           : base("ProductDbContext")
        {

        }

        /// <summary>
        /// Note : DBSet - Table
        /// </summary>
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<StockProduct> StockProducts { get; set; }
        
        /// <summary>
        /// Note : Create Entity DB Context and Model
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new ProductConfiguration());
        }
    }
}
