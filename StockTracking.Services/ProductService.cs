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

        public async Task AddAsync(Product product)
        {
            await _productDataSource.AddNewProductAsync(product);
        }

        public async Task<List<Product>> GetProductAll()
        {
            return await _productDataSource.GetAll();
        }

        public async Task<Product> UpdateStockAsync(long id, int quantity)
        {
            return await _productDataSource.UpdateStockAsync(id, quantity);

        }

        public async Task<long> AddNewProductAsync(Product product)
        {
            return await _productDataSource.AddNewProductAsync(product);
        }

        public async Task<long> UpdateNewProductAsync(Product product)
        {
            return await _productDataSource.UpdateNewProductAsync(product);

        }

        public async Task<Product> SellProductAsync(long id, int quantity)
        {
            return await _productDataSource.SellProductAsync(id, quantity);
        }

        public async Task<bool> BulkInsertProductAsync(List<Product> products)
        {
            return await _productDataSource.BulkInsertProductAsync(products);
        }
    }
}
