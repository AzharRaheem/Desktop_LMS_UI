using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DomainModel.ViewModels
{
    public class BookCategoryBaseVM
    {
        public List<BookCategoryVM> books { get; set; }
        public string message  { get; set; }
        public bool isSuccess { get; set; }
    }
}
