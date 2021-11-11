using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace MvcMovie.Models{
    [Table("Students")]
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Student{
        [Key]
        public string StudentID { get; set; }
        [DisplayName("ID Sinh Viên")]
        public string StudentName { get; set; }
        [DisplayName("Tên Sinh Viên")]
        public string Address { get; set; }
        [DisplayName("Địa chỉ")]
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}