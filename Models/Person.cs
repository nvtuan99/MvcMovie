using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace MvcMovie.Models{
    [Table("Persons")]
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Person{
        [Key]
        public string PersonID { get; set; }
        [DisplayName("ID Người Dùng")]
        public string PersonName { get; set; }
        [DisplayName("Tên Người Dùng")]
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}