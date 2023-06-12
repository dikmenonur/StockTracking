using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.Core.Entity
{
    public enum StockType
    {
        None = 0,
        StockIn = 1,
        StockOut = 2,
        OutOfSales= 3,
    }
}
