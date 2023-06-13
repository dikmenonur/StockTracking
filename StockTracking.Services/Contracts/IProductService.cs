using StockTracking.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.Services.Contracts
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        Task AddAsync(Product article);

        [OperationContract]
        Task<Product> GetProductAsync(int id);
        
        [OperationContract]
        Task<List<Product>> GetProductAll();

        [OperationContract]
        Task<Product> UpdateStockAsync(long id, int quantity);

        [OperationContract]
        Task<long> AddNewProductAsync(Product product);

        [OperationContract]
        Task<long> UpdateNewProductAsync(Product product);
        
        [OperationContract] 
        Task<Product> SellProductAsync(long id, int quantity);
        
        [OperationContract] 
        Task<bool> BulkInsertProductAsync(List<Product> products);
    }
}
