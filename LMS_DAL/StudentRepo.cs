using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel;
using LMS_DomainModel.ViewModels;
using System.Drawing;

namespace LMS_DAL
{
    public class StudentRepo
    {
        LMSDbContext db;
        public StudentRepo()
        {
            db = new LMSDbContext();
        }

        public BaseViewModel GetAllDepartmentsFromDB()
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                result.data = db.Departments.ToList();
                result.isSuccess = true;
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }
        public StudentDepartmentBaseVM GetFilteredStudentsFromDB(string search)
        {
            StudentDepartmentBaseVM result = new StudentDepartmentBaseVM();
            try
            {
                var allStudents = db.Students.Where(s => s.name.ToLower().Contains(search.ToLower()) || s.fatherName.ToLower().Contains(search.ToLower()) || s.email.ToLower().Contains(search.ToLower()));
                result.students = new List<StudentDepartmentVM>();
                foreach (var stud in allStudents)
                {
                    StudentDepartmentVM student = new StudentDepartmentVM();
                    student.id = stud.id;
                    student.name = stud.name;
                    student.fatherName = stud.fatherName;
                    student.dob = stud.dob;
                    student.cnic = stud.cnic;
                    student.email = stud.email;
                    student.address = stud.address;
                    student.contact = stud.contact;
                    student.departmentId = stud.departmentId;
                    student.departmentName = stud.department.name;
                    student.genderValue = stud.gender;
                    student.genderText = (stud.gender == 0) ? "Male" : "Female";
                    student.studentImagePath = stud.studentImage;
                    if (stud.studentImage != null)
                    {
                        student.studentImage = new Bitmap(stud.studentImage);
                    }
                    else
                    {
                        student.studentImage = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "Images\\studentProfile.png");
                    }
                    result.students.Add(student);
                }
                result.isSuccess = true;
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }

        public BaseViewModel UpdateStudentInDB(Student student)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                var studentRecord = db.Students.Where(s => s.id == student.id).FirstOrDefault();
                studentRecord.id = student.id;
                studentRecord.name = student.name;
                studentRecord.fatherName = student.fatherName;
                studentRecord.dob = student.dob;
                studentRecord.cnic = student.cnic;
                studentRecord.email = student.email;
                studentRecord.address = student.address;
                studentRecord.contact = student.contact;
                studentRecord.departmentId = student.departmentId;
                studentRecord.gender = student.gender;
                studentRecord.studentImage = student.studentImage;
                db.SaveChanges();
                result.isSuccess = true;
                result.message = "Student Updated Successfully.";
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }

        public BaseViewModel DeleteStudentFromDB(int studentId)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                var student = db.Students.Where(s => s.id == studentId).FirstOrDefault();
                db.Students.Remove(student);
                db.SaveChanges();
                result.isSuccess = true;
                result.message = "Student Deleted Successfully.";
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }

        public StudentDepartmentBaseVM GetAllStudentsFromDB()
        {
            StudentDepartmentBaseVM result = new StudentDepartmentBaseVM();
            try
            {
                var allStudents = db.Students.ToList();
                result.students = new List<StudentDepartmentVM>();
                foreach (var stud in allStudents)
                {
                    StudentDepartmentVM student = new StudentDepartmentVM();
                    student.id = stud.id;
                    student.name = stud.name;
                    student.fatherName = stud.fatherName;
                    student.dob = stud.dob;
                    student.cnic = stud.cnic;
                    student.email = stud.email;
                    student.address = stud.address;
                    student.contact = stud.contact;
                    student.departmentId = stud.departmentId;
                    student.departmentName = stud.department.name;
                    student.genderValue = stud.gender;
                    student.genderText = (stud.gender == 0) ? "Male" : "Female";
                    student.studentImagePath = stud.studentImage;
                    if(stud.studentImage != null)
                    {
                        student.studentImage = new Bitmap(stud.studentImage);
                    }
                    else
                    {
                        student.studentImage = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "Images\\studentDummyProfile.png");
                    }
                    result.students.Add(student);
                }
                result.isSuccess = true;
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }

        public BaseViewModel SaveStudentInDB(Student student)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                db.Students.Add(student);
                db.SaveChanges();
                result.isSuccess = true;
                result.message = "Student Added Successfully";
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }
    }
}
