using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace MvcMovie.Models
{
    [Table("Movies")]
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Movie
    {
        [Key]

        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Chủ Đề")]
        public string Title { get; set; }
        
        [DisplayName("Ngày Phát Hành")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        
        [DisplayName("Thể Loại")]
        public string Genre { get; set; }
        
        [DisplayName("Giá")]
        public decimal Price { get; set; }
        
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}