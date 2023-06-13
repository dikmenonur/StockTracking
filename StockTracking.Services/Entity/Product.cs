using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.Core.Entity
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public long ID;

        [DataMember]
        public string Code;

        [DataMember]
        public string Name;

        [DataMember]
        public string Desc;

        [DataMember]
        public decimal Amount;

        [DataMember]
        public StockProduct StockProduct;
    }
}
