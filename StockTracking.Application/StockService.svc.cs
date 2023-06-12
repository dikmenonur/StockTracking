using StockTracking.Core.Entity;
using StockTracking.Core.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StockTracking.Application
{
    public class StockService : IStockManager
    {
        private readonly IStockManager _stockManager;
        public StockService(IStockManager stockManager)
        {
            _stockManager = stockManager;

        }

        public bool DeleteProduct(int Cid)
        {
          return this._stockManager.DeleteProduct(Cid);
        }

        public List<Customer> GetAllProduct()
        {
            return this._stockManager.GetAllProduct();
        }

        public bool InsertProduct(Product obj)
        {
            return this._stockManager.InsertProduct(obj);
        }

        public bool UpdateProduct(Product obj)
        {
            return this._stockManager.UpdateProduct(obj);
        }
    }
}
