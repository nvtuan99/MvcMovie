using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace MvcMovie.Models{
    [Table("Products")]
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Product{
        [Key]
        public string ProductID { get; set; }
        [DisplayName("ID Sản Phẩm")]
        public string ProductName { get; set; }
        [DisplayName("Tên Sản phẩm")]
        public decimal UnitPrice { get; set; }
        [DisplayName("Đơn Giá")]
        public string Quantily { get; set; }
        [DisplayName("Số Lượng")]
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}