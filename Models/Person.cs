using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace MvcMovie.Models{
    [Table("People")]
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Person{
        [Key]

        [DisplayName("ID Người Dùng")]
        public string PersonID { get; set; }
        
        [DisplayName("Tên Người Dùng")]
        public string PersonName { get; set; }
        
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}