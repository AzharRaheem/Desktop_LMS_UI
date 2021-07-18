using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DomainModel.ViewModels
{
    public class CategoryStatusVM
    {
        public int id { get; set; }
        public string name { get; set; }
        public int statusIndex { get; set; }
        public string statusValue { get; set; }
    }
}
