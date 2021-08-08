using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DomainModel.ViewModels
{
    public class ReturnBookBaseVM
    {
        public List<ReturnBookVM> allReturnedBooks { get; set; }
        public bool isSuccess { get; set; }
        public string message { get; set; }
    }
}
