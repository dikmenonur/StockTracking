using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.Core.Entity
{
    [DataContract]
    [Table("Customer")]
    public class Customer
    {
        [DataMember]
        [Key]
        public long CustomerID;

        [DataMember]
        public string CustomerName;

        [DataMember]
        public string Address;

        [DataMember]
        public string EmailId;
    }
}
