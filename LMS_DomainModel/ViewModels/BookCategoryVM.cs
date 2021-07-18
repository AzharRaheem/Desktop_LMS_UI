using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DomainModel.ViewModels
{
    public class BookCategoryVM
    {
        public int id { get; set; }
        public string bookImagePath { get; set; }
        public object bookImage { get; set; }
        public string bookTitle { get; set; }
        public int categoryId { get; set; }
        public string category { get; set; }
        public string authorName { get; set; }
        public string publisher { get; set; }
        public string bookEdition { get; set; }
        public string barcode { get; set; }
        public float price { get; set; }
        public string bookISBN { get; set; }
    }
}
