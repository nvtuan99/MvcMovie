using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace MvcMovie.Models{
    [Table("Employees")]
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Employee{
        [Key]
        public string EmployeeID { get; set; }
        [DisplayName("ID Nhân Viên")]
        public string EmployeeName { get; set; }
        [DisplayName("Tên Nhân Viên")]
        public string PhoneNumber { get; set; }
        [DisplayName("Số Điện Thoại")]
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}