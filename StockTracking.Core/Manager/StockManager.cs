using StockTracking.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.Core.Manager
{
    public class StockManager : IStockManager
    {
        public bool DeleteProduct(int Cid)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public bool InsertProduct(Product obj)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
