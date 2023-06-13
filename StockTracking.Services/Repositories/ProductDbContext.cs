using StockTracking.Core.Configurations;
using StockTracking.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
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
        public DbSet<Product> Product { get; set; }
        public DbSet<StockProduct> StockProduct { get; set; }
        public DbSet<SellProduct> SellProducts { get; set; }


        /// <summary>
        /// Note : Create Entity DB Context and Model
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<StockProduct>().ToTable("StockProduct");
            modelBuilder.Entity<SellProduct>().ToTable("SellProduct")
                .HasIndex(p => new { p.SellNumber, p.ID })
                .IsUnique();
        }
    }
}
