using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SkateShop.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string Price { get; set; }
        public string Discount { get; set; }
        
    }
}
