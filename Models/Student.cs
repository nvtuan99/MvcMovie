using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace MvcMovie.Models{
    [Table("Students")]
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Student{
        [Key]

        [DisplayName("ID Sinh Viên")]
        public string StudentID { get; set; }

        [DisplayName("Tên Sinh Viên")]
        public string StudentName { get; set; }
        
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }
        
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}