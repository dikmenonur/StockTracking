using StockTracking.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.Core.Repositories
{
    public interface IProductDataSource
    {
        Task<Product> GetById(long id);
        Task<List<Product>> GetAll();
        Task<Product> UpdateStockAsync(long id, int quantity);
        Task<long> AddNewProductAsync(Product product);
        Task<long> UpdateNewProductAsync(Product product);
        Task<Product> SellProductAsync(long id, int quantity);
        Task<bool> BulkInsertProductAsync(List<Product> products);

    }
}
