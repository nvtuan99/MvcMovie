using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace MvcMovie.Models{
    [Table("Products")]
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Product{
        [Key]

        [DisplayName("ID Sản Phẩm")]
        public string ProductID { get; set; }
        
        [DisplayName("Tên Sản phẩm")]
        public string ProductName { get; set; }
        
        [DisplayName("Đơn Giá")]
        public decimal UnitPrice { get; set; }
        
        [DisplayName("Số Lượng")]
        public string Quantily { get; set; }
        
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}