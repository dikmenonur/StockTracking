using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.Core.Entity
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int CustomerID;

        [DataMember]
        public string CustomerName;

        [DataMember]
        public string Address;

        [DataMember]
        public string EmailId;
    }
}
