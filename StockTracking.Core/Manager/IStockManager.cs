using StockTracking.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.Core.Manager
{
    [ServiceContract]
    interface IStockManager
    {
        [OperationContract]
        bool InsertProduct(Product obj);

        [OperationContract]
        List<Customer> GetAllProduct();

        [OperationContract]
        bool DeleteProduct(int Cid);

        [OperationContract]
        bool UpdateProduct(Customer obj);
    }
}
