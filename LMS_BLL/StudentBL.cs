using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel.ViewModels;
using LMS_DAL;
using LMS_DomainModel;

namespace LMS_BLL
{
    public class StudentBL
    {
        StudentRepo studentRepo;
        public StudentBL()
        {
            studentRepo = new StudentRepo();
        }
        public BaseViewModel GetAllDepartments()
        {
            return studentRepo.GetAllDepartmentsFromDB();
        }

        public BaseViewModel SaveStudent(Student student)
        {
            return studentRepo.SaveStudentInDB(student);
        }

        public StudentDepartmentBaseVM GetAllStudents()
        {
            return studentRepo.GetAllStudentsFromDB();
        }

        public StudentDepartmentBaseVM GetFilteredStudents(string search)
        {
            return studentRepo.GetFilteredStudentsFromDB(search);
        }

        public BaseViewModel DeleteStudent(int studentId)
        {
            return studentRepo.DeleteStudentFromDB(studentId);
        }

        public BaseViewModel UpdateStudent(Student student)
        {
            return studentRepo.UpdateStudentInDB(student);
        }
    }
}




