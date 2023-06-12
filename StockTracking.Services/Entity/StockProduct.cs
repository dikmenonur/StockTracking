using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.Core.Entity
{
    [DataContract]
    public class StockProduct
    {
        [DataMember]
        public int ID;

        [DataMember]
        public int ProductId;

        [DataMember]
        public StockType StockType;

        [DataMember]
        public int Quantity;
    }
}
