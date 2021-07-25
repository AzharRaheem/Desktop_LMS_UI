using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DomainModel.ViewModels
{
    public class IssueBookBaseVM
    {
        public bool isSuccess { get; set; }
        public string message { get; set; }
        public List<IssueBookVM> issueBooks { get; set; }
    }
}
