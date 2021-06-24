namespace BookManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage ="Id không dc Trùng")]
        [Range(1,2,ErrorMessage ="ID từ 1 đến 2")]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(110,ErrorMessage ="Không quá 110 Ký Tự")]
        [Required(ErrorMessage = "Tiêu Đề không được trùng")]
        public string Title { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        [Required(ErrorMessage = "Description không Được Trùng")]
        public string Description { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(35,ErrorMessage="không quá 35 ký t?")]
        [Required(ErrorMessage = "Tác Giả Không Được trùng !")]
        public string Author { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        [Required(ErrorMessage = "Hình Ảnh Không Được Trùng Lập")]
        public string Images { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Giá không Được Trùng")]
        [Range(1000, 1000000, ErrorMessage = "Giá từ 1000 Đến 1000000")]
        public int Price { get; set; }
        public Book() { }
    }
}
