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
    [Table("StockProduct")]
    public class StockProduct
    {
        [DataMember]
        [Key]
        public long ID { get; set; }

        [DataMember]
        public long ProductId { get; set; }

        [DataMember]
        public StockType StockType { get; set; }

        [DataMember]
        public int Quantity { get; set; }
    }
}
