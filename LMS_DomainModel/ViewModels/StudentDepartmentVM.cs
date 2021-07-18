using System;

namespace LMS_DomainModel.ViewModels
{
    public class StudentDepartmentVM
    {
        public int id { get; set; }
        public string studentImagePath { get; set; }
        public object studentImage { get; set; }
        public string name { get; set; }
        public string fatherName { get; set; }
        public DateTime dob { get; set; }
        public string cnic { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string contact { get; set; }
        public int departmentId { get; set; }
        public string departmentName { get; set; }
        public int genderValue { get; set; }
        public string genderText { get; set; }
    }
}
