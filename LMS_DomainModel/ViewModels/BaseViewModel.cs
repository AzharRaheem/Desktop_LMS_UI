using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DomainModel.ViewModels
{
    public class BaseViewModel
    {
        public bool isSuccess { get; set; }
        public string message { get; set; }
        public object data { get; set; }
    }
}
