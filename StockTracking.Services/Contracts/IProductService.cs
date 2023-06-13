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
        void Add(Product article);

        [OperationContract]
        Task<Product> GetProductAsync(int id);
    }
}
