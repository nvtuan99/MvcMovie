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
        public int Id { get; set; }
        [DisplayName("ID")]
        public string Title { get; set; }
        [DisplayName("Chủ Đề")]

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [DisplayName("Ngày Phát Hành")]
        public string Genre { get; set; }
        [DisplayName("Thể Loại")]
        public decimal Price { get; set; }
        [DisplayName("Giá")]
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}