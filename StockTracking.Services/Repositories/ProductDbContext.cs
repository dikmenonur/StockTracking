using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    }
}
