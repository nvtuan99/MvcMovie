using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace MvcMovie.Models{
    [Table("Employees")]
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Employee{
        [Key]

        [DisplayName("ID Nhân Viên")]
        public string EmployeeID { get; set; }

        [DisplayName("Tên Nhân Viên")]
        public string EmployeeName { get; set; }
        
        [DisplayName("Số Điện Thoại")]
        public string PhoneNumber { get; set; }
        
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}