using LMS_BLL;
using LMS_DomainModel.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_LMS_UI
{
    public partial class ManageReturnBooks : Form
    {
        ReturnBookBL returnBooksBll;
        public ManageReturnBooks()
        {
            InitializeComponent();
            returnBooksBll = new ReturnBookBL();
        }
       
        private void EnableControls()
        {
            bookDD.Enabled = true;
            studentDD.Enabled = true;
            returnDateTimePicker.Enabled = true;
            returnSaveBtn.Enabled = true;
        }
        private void DisableControls()
        {
            bookDD.Enabled = false;
            studentDD.Enabled = false;
            returnDateTimePicker.Enabled = false;
            returnSaveBtn.Enabled = false;
        }
        private void PopulateDropDown()
        {
            BaseViewModel students = returnBooksBll.GetAllStudents();
            if (students.isSuccess)
            {
                studentDD.DataSource = students.data;
                studentDD.ValueMember = "id";
                studentDD.DisplayMember = "name";
            }
            else
            {
                MessageBox.Show(students.message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            BaseViewModel books = returnBooksBll.GetAllBooks();
            if (books.isSuccess)
            {
                bookDD.DataSource = books.data;
                bookDD.ValueMember = "id";
                bookDD.DisplayMember = "bookName";
            }
            else
            {
                MessageBox.Show(students.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearAllControls()
        {
            studentDD.SelectedIndex = -1;
            bookDD.SelectedIndex = -1;
            returnDateTimePicker.Value = DateTime.Today.Date;
            HideErrorLabels();
        }

        private void HideErrorLabels()
        {
            studentDDErrorLbl.Visible = false;
            bookDDErrorLbl.Visible = false;
        }

        private void addNewReturnBookBtn_Click(object sender, EventArgs e)
        {
            EnableControls();
            ClearAllControls();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            PopulateDropDown();
            ClearAllControls();
        }

        private void returnSaveBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(returnDateTimePicker.Value.ToString());
        }
    }
}
