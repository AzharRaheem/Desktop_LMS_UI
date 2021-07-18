using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LMS_DomainModel
{
    public class Book
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string bookName { get; set; }
        [Required]
        [ForeignKey("category")]
        public int categoryid { get; set; }
        public Category category { get; set; }
        [Required]
        [StringLength(50)]
        public string authorName { get; set; }
        [Required]
        [StringLength(50)]
        public string publisherName { get; set; }
        [Required]
        [StringLength(50)]
        public string bookEdition { get; set; }
        [Required]
        [StringLength(50)]
        public string barcode { get; set; }
        [Required]
        public float price { get; set; }
        [Required]
        [StringLength(50)]
        public string book_ISBN { get; set; }
        [StringLength(600)]
        public string bookImagePath { get; set; }
    }
}
