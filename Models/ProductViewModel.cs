using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SkateShop.Models
{
    public class ProductViewModel
    {
        [Key]
        public int ProductId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Tên sản phẩm")]
        public string ProductName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Đơn giá")]

        public string Price { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Ngày Order")]

        public DateTime OrderDate { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [DisplayName("Giảm giá")]
        public string Discount { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Địa chỉ giao hàng")]
        public string ShipAddress { get; set; }
        public string ImageProduct { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
