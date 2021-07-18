using LMS_BLL;
using LMS_DomainModel;
using LMS_DomainModel.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_LMS_UI
{
    public partial class Students : Form
    {
        private int saveUpdate = 0 , studentId;
        private string studentImagePath;
        private StudentBL studentBll;
        public Students()
        {
            InitializeComponent();
            studentBll = new StudentBL();
            studentImagePath = null;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(studentNameTxtBox.Text) && !string.IsNullOrWhiteSpace(fatherNameTxtBox.Text) && !string.IsNullOrWhiteSpace(cnicTxtBox.Text) && !string.IsNullOrWhiteSpace(emailTxtBox.Text)
            && !string.IsNullOrWhiteSpace(addressTxtBox.Text) && !string.IsNullOrWhiteSpace(contactTxtBox.Text) && departmentsDD.SelectedIndex != -1)
            {
                Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (emailRegex.Match(emailTxtBox.Text).Success)
                {
                    if (saveUpdate == 0)
                    {
                        Student student = new Student();
                        student.name = studentNameTxtBox.Text;
                        student.fatherName = fatherNameTxtBox.Text;
                        student.dob = dobDateTimePicker.Value;
                        student.cnic = cnicTxtBox.Text;
                        student.email = emailTxtBox.Text;
                        student.address = addressTxtBox.Text;
                        student.contact = contactTxtBox.Text;
                        student.departmentId = Convert.ToInt32(departmentsDD.SelectedValue);
                        student.gender = (maleRB.Checked) ? 0: 1;
                        student.studentImage = studentImagePath;
                        BaseViewModel result = studentBll.SaveStudent(student);
                        if (result.isSuccess)
                        {
                            MessageBox.Show(result.message , "Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                            ClearControls();
                            DisableControls();
                            PopulateGridView();
                        }
                        else
                        {
                            MessageBox.Show(result.message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                        }
                    }
                    if (saveUpdate == 1)
                    {
                        Student student = new Student();
                        student.id = studentId;
                        student.name = studentNameTxtBox.Text;
                        student.fatherName = fatherNameTxtBox.Text;
                        student.dob = dobDateTimePicker.Value;
                        student.cnic = cnicTxtBox.Text;
                        student.email = emailTxtBox.Text;
                        student.address = addressTxtBox.Text;
                        student.contact = contactTxtBox.Text;
                        student.departmentId = Convert.ToInt32(departmentsDD.SelectedValue);
                        student.gender = (maleRB.Checked) ? 0 : 1;
                        student.studentImage = studentImagePath;
                        BaseViewModel result = studentBll.UpdateStudent(student);
                        if (result.isSuccess)
                        {
                            MessageBox.Show(result.message , "Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                            PopulateGridView();
                            ClearControls();
                            DisableControls();
                        }
                        else
                        {
                            MessageBox.Show(result.message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Email Address" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(studentNameTxtBox.Text))
                {
                    studentNameErrorLbl.Visible = false;
                }
                else
                {
                    studentNameErrorLbl.Visible = true;
                }
                if (!string.IsNullOrWhiteSpace(fatherNameTxtBox.Text))
                {
                    fatherNameErrorLbl.Visible = false;
                }
                else
                {
                    fatherNameErrorLbl.Visible = true;
                }
                if (!string.IsNullOrWhiteSpace(emailTxtBox.Text))
                {
                    emailErrorLbl.Visible = false;
                }
                else
                {
                    emailErrorLbl.Visible = true;
                }
                if (!string.IsNullOrWhiteSpace(addressTxtBox.Text))
                {
                    addressErrorLbl.Visible = false;
                }
                else
                {
                    addressErrorLbl.Visible = true;
                }
                if (!string.IsNullOrWhiteSpace(cnicTxtBox.Text))
                {
                    cnicErrorLbl.Visible = false;
                }
                else
                {
                    cnicErrorLbl.Visible = true;
                }
                if (!string.IsNullOrWhiteSpace(contactTxtBox.Text))
                {
                    contactErrorLbl.Visible = false;
                }
                else
                {
                    contactErrorLbl.Visible = true;
                }
                if (departmentsDD.SelectedIndex != -1)
                {
                    departmentErrorLbl.Visible = false;
                }
                else
                {
                    departmentErrorLbl.Visible = true;
                }
                MessageBox.Show("Fields with * are Mandatory." , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
        private void EnableControls()
        {
            studentNameTxtBox.Enabled = true;
            fatherNameTxtBox.Enabled = true;
            dobDateTimePicker.Enabled = true;
            cnicTxtBox.Enabled = true;
            emailTxtBox.Enabled = true;
            addressTxtBox.Enabled = true;
            contactTxtBox.Enabled = true;
            departmentsDD.Enabled = true;
            uploadBtn.Enabled = true;
            saveBtn.Enabled = true;
            maleRB.Enabled = true;
            femaleRB.Enabled = true;
        }
        private void DisableControls()
        {
            studentNameTxtBox.Enabled = false;
            fatherNameTxtBox.Enabled = false;
            dobDateTimePicker.Enabled = false;
            cnicTxtBox.Enabled = false;
            emailTxtBox.Enabled = false;
            addressTxtBox.Enabled = false;
            contactTxtBox.Enabled = false;
            departmentsDD.Enabled = false;
            uploadBtn.Enabled = false;
            saveBtn.Enabled = false;
            maleRB.Enabled = false;
            femaleRB.Enabled = false;
        }
        private void ClearControls()
        {
            studentNameTxtBox.Text = null;
            fatherNameTxtBox.Text = null;
            cnicTxtBox.Text = null;
            emailTxtBox.Text = null;
            addressTxtBox.Text = null;
            contactTxtBox.Text = null;
            departmentsDD.SelectedIndex = -1;
            studentPicBox.Image = null;
            studentId =0;
            saveUpdate = 0;
            studentImagePath = null;
            saveBtn.Text = "Save";
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            EnableControls();
            ClearControls();
        }

        private void studentNameTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(studentNameTxtBox.Text))
            {
                studentNameErrorLbl.Visible = false;
            }
            else
            {
                studentNameErrorLbl.Visible = true;
            }
        }

        private void fatherNameTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fatherNameTxtBox.Text))
            {
                fatherNameErrorLbl.Visible = false;
            }
            else
            {
                fatherNameErrorLbl.Visible = true;
            }
        }

        private void emailTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(emailTxtBox.Text))
            {
                emailErrorLbl.Visible = false;
            }
            else
            {
                emailErrorLbl.Visible = true;
            }
        }

        private void addressTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(addressTxtBox.Text))
            {
                addressErrorLbl.Visible = false;
            }
            else
            {
                addressErrorLbl.Visible = true;
            }
        }


        private void cnicTxtBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cnicTxtBox.Text))
            {
                cnicErrorLbl.Visible = false;
            }
            else
            {
                cnicErrorLbl.Visible = true;
            }
        }

        private void contactTxtBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(contactTxtBox.Text))
            {
                contactErrorLbl.Visible = false;
            }
            else
            {
                contactErrorLbl.Visible = true;
            }
        }

        private void departmentsDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(departmentsDD.SelectedIndex != -1)
            {
                departmentErrorLbl.Visible = false;
            }
            else
            {
                departmentErrorLbl.Visible = true;
            }
        }

        private void Student_Load(object sender, EventArgs e)
        {
            BaseViewModel result = studentBll.GetAllDepartments();
            if (result.isSuccess)
            {
                departmentsDD.DataSource = result.data;
                departmentsDD.ValueMember = "id";
                departmentsDD.DisplayMember = "name";
            }
            departmentsDD.SelectedIndex = -1;
            PopulateGridView();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = studentImageOpenFileDialog.ShowDialog();
            if(dr == DialogResult.OK)
            {
                studentPicBox.Image = new Bitmap(studentImageOpenFileDialog.FileName);
                bool isUploaded = UploadImage(studentImageOpenFileDialog.FileName);
                if (isUploaded)
                {
                    MessageBox.Show("Picture Uploaded Successfully." , "Done" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please try again later." , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }
        }

        private bool UploadImage(string fileName)
        {
            try
            {
                var folderPath = AppDomain.CurrentDomain.BaseDirectory + "Images";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                var imageExtension = fileName.Split('.')[1];
                Guid fileUniqueName = Guid.NewGuid();
                var newImageName = fileUniqueName + "." + imageExtension;
                var newImagePath = folderPath + "\\" + newImageName;
                studentImagePath = newImagePath;
                File.Copy(fileName, newImagePath);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void PopulateGridView()
        {
            StudentDepartmentBaseVM result = studentBll.GetAllStudents();
            if (result.isSuccess)
            {
                studentsGridView.DataSource = result.students;
            }
            else
            {
                MessageBox.Show(result.message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void searchTxtBox_OnTextChange(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchTxtBox.text))
            {
                StudentDepartmentBaseVM result = studentBll.GetFilteredStudents(searchTxtBox.text);
                if (result.isSuccess)
                {
                    studentsGridView.DataSource = result.students;
                }
                else
                {
                    MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                PopulateGridView();
            }
            
        }

        private void studentsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != 01 && e.ColumnIndex != -1)
            {
                studentId = Convert.ToInt32(studentsGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                studentNameTxtBox.Text = studentsGridView.Rows[e.RowIndex].Cells["nameGVC"].Value.ToString();
                fatherNameTxtBox.Text = studentsGridView.Rows[e.RowIndex].Cells["fatherNameGVC"].Value.ToString();
                dobDateTimePicker.Value = Convert.ToDateTime(studentsGridView.Rows[e.RowIndex].Cells["dobGVC"].Value.ToString());
                cnicTxtBox.Text = studentsGridView.Rows[e.RowIndex].Cells["cnicGVC"].Value.ToString();
                emailTxtBox.Text = studentsGridView.Rows[e.RowIndex].Cells["emailGVC"].Value.ToString();
                addressTxtBox.Text = studentsGridView.Rows[e.RowIndex].Cells["addressGVC"].Value.ToString();
                contactTxtBox.Text = studentsGridView.Rows[e.RowIndex].Cells["contactGVC"].Value.ToString();
                departmentsDD.SelectedValue = Convert.ToInt32(studentsGridView.Rows[e.RowIndex].Cells["departmentIdGVC"].Value.ToString());
                if(Convert.ToInt16(studentsGridView.Rows[e.RowIndex].Cells["genderValueGVC"].Value.ToString()) == 0)
                {
                    maleRB.Checked = true;
                }
                else
                {
                    femaleRB.Checked = true;
                }
                if (studentsGridView.Rows[e.RowIndex].Cells["studentImagePathGVC"].Value != null)
                {
                    studentPicBox.Image = new Bitmap(studentsGridView.Rows[e.RowIndex].Cells["studentImagePathGVC"].Value.ToString());
                    studentImagePath = studentsGridView.Rows[e.RowIndex].Cells["studentImagePathGVC"].Value.ToString();
                }
                saveUpdate = 1;
                saveBtn.Text = "Update";
                EnableControls();
            }
        }

        private void studentsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
              if(e.ColumnIndex == 0)
                {
                    studentId = Convert.ToInt32(studentsGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                    studentNameTxtBox.Text = studentsGridView.Rows[e.RowIndex].Cells["nameGVC"].Value.ToString();
                    fatherNameTxtBox.Text = studentsGridView.Rows[e.RowIndex].Cells["fatherNameGVC"].Value.ToString();
                    dobDateTimePicker.Value = Convert.ToDateTime(studentsGridView.Rows[e.RowIndex].Cells["dobGVC"].Value.ToString());
                    cnicTxtBox.Text = studentsGridView.Rows[e.RowIndex].Cells["cnicGVC"].Value.ToString();
                    emailTxtBox.Text = studentsGridView.Rows[e.RowIndex].Cells["emailGVC"].Value.ToString();
                    addressTxtBox.Text = studentsGridView.Rows[e.RowIndex].Cells["addressGVC"].Value.ToString();
                    contactTxtBox.Text = studentsGridView.Rows[e.RowIndex].Cells["contactGVC"].Value.ToString();
                    departmentsDD.SelectedValue = Convert.ToInt32(studentsGridView.Rows[e.RowIndex].Cells["departmentIdGVC"].Value.ToString());
                    if (Convert.ToInt16(studentsGridView.Rows[e.RowIndex].Cells["genderValueGVC"].Value.ToString()) == 0)
                    {
                        maleRB.Checked = true;
                    }
                    else
                    {
                        femaleRB.Checked = true;
                    }
                    if (studentsGridView.Rows[e.RowIndex].Cells["studentImagePathGVC"].Value != null)
                    {
                        studentPicBox.Image = new Bitmap(studentsGridView.Rows[e.RowIndex].Cells["studentImagePathGVC"].Value.ToString());
                        studentImagePath = studentsGridView.Rows[e.RowIndex].Cells["studentImagePathGVC"].Value.ToString();
                    }
                    saveUpdate = 1;
                    saveBtn.Text = "Update";
                    EnableControls();
                }
               if(e.ColumnIndex == 1)
                {
                    DialogResult dr = MessageBox.Show("Do you want to delete this Student?" , "Confirm" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        studentId = Convert.ToInt32(studentsGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                        BaseViewModel result = studentBll.DeleteStudent(studentId);
                        if (result.isSuccess)
                        {
                            MessageBox.Show(result.message , "Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                            PopulateGridView();
                        }
                        else
                        {
                            MessageBox.Show(result.message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
