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
    [Table("Product")]
    public class Product
    {
        public Product()
        {
            this.StockProduct = new StockProduct();
        }
        [Key]
        public long ID { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }

        public decimal Amount { get; set; }

        public DateTime CreateDate { get; set; }

        public StockProduct StockProduct { get; set; }
    }
}
