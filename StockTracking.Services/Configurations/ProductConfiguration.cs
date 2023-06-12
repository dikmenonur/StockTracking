using StockTracking.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.Core.Configurations
{
    internal class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration() {
            HasKey(a => a.ID);
            Property(a => a.Name).IsRequired().HasMaxLength(100);
            Property(a => a.Code).IsRequired();

            Ignore(a => a.StockProduct);
        }
    }
}
