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

        [StringLength(60, MinimumLength = 3)]
        [DisplayName("Chủ Đề")]
        public string Title { get; set; }
        
        [Display(Name = "Release Date"), DataType(DataType.Date)]
        [DisplayName("Ngày Phát Hành")]
        public DateTime ReleaseDate { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        [DisplayName("Thể Loại")]
        public string Genre { get; set; }
        
        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [DisplayName("Giá")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5)]
        [DisplayName("Đánh Giá")]
        public string Rating { get; set; }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}