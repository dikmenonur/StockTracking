using StockTracking.Core.Entity;
using StockTracking.Core.Repositories;
using StockTracking.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductDataSource _productDataSource;

        public ProductService(IProductDataSource productDataSource)
        {
            _productDataSource = productDataSource;
        }

        public Task<Product> GetProductAsync(int id)
        {
            return _productDataSource.GetById(id);
        }

        public void Add(Product article)
        {
        }
    }
}
