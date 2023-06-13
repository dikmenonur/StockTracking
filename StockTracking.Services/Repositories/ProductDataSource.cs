using StockTracking.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.Core.Repositories
{
    public class ProductDataSource : IProductDataSource
    {
        private readonly ProductDbContext _productDbContext;
        public ProductDataSource(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }

        public Task<Product> GetById(long id)
        {
            return _productDbContext.Products.FirstOrDefaultAsync(t => t.ID == id);
        }
    }
}
