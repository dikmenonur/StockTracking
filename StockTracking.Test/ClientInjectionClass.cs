using StockTracking.Core.Entity;
using StockTracking.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.Test
{
    internal class ClientInjectionClass 
    {
        public IProductService _productProxy;
        public ClientInjectionClass(IProductService productProxy)
        {
            this._productProxy = productProxy;
        }

      
        #region Methods

        public async Task<List<Product>> GetProductAsync()
        {
            return await _productProxy.GetProductAll();
        }

        #endregion
    }
}
