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
    }
}
