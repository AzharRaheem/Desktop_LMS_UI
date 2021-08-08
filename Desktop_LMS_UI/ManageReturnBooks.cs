using LMS_BLL;
using LMS_DomainModel;
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
        private UserLoginVM loggedUser;
        ReturnBookBL returnBooksBll;
        public ManageReturnBooks()
        {
            InitializeComponent();
            returnBooksBll = new ReturnBookBL();
        }
        public ManageReturnBooks(UserLoginVM loggedInUser)
        {
            InitializeComponent();
            returnBooksBll = new ReturnBookBL();
            loggedUser = loggedInUser;
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
            PopulateGridView();
        }
        private void PopulateGridView()
        {
            ReturnBookBaseVM result = returnBooksBll.GetAllReturnedBooksRecord();
            if (result.isSuccess)
            {
                ReturnedBooksGridView.DataSource = result.allReturnedBooks;
            }
            else
            {
                MessageBox.Show(result.message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void returnSaveBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to return this book?" , "Confirm" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                ReturnBook returnBook = new ReturnBook();
                IssueBook issueBookDetail = returnBooksBll.isIssuedBook(Convert.ToInt32(bookDD.SelectedValue), Convert.ToInt32(studentDD.SelectedValue));
                if(issueBookDetail != null)
                {
                    if (issueBookDetail.returnDate.Date == returnDateTimePicker.Value.Date || returnDateTimePicker.Value.Date <= issueBookDetail.returnDate.Date)
                    {
                        returnBook.bookId = Convert.ToInt32(bookDD.SelectedValue);
                        returnBook.librarianId = loggedUser.id;
                        returnBook.studentId = Convert.ToInt32(studentDD.SelectedValue);
                        returnBook.deliveryStatus = "On-Time";
                        returnBook.returnDate = returnDateTimePicker.Value.Date;
                        returnBook.fine = 0;
                    }
                    else
                    {
                        returnBook.bookId = Convert.ToInt32(bookDD.SelectedValue);
                        returnBook.librarianId = loggedUser.id;
                        returnBook.studentId = Convert.ToInt32(studentDD.SelectedValue);
                        returnBook.deliveryStatus = "Late";
                        returnBook.returnDate = returnDateTimePicker.Value.Date;
                        TimeSpan dueDuration = DateTime.Today.Date.Subtract(issueBookDetail.returnDate.Date);
                        var days = dueDuration.Days;
                        float fineValue = returnBooksBll.GetFineValue(issueBookDetail.fineId);
                        returnBook.fine = fineValue * days;
                        MessageBox.Show("Please Submit the fine of RS: "+returnBook.fine+" before return the book." , "Fine Payment" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                    }
                    BaseViewModel result = returnBooksBll.SaveReturnBook(returnBook);
                    if (result.isSuccess)
                    {
                        MessageBox.Show(result.message , "Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                        PopulateGridView();
                        ClearAllControls();
                    }
                    else
                    {
                        MessageBox.Show(result.message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sorry! No Record found." , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }
        }

        private void ReturnedBooksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DialogResult dr = MessageBox.Show("Do you want to delete this record?" , "Confirm" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    int returnRecordId = Convert.ToInt32(ReturnedBooksGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                    BaseViewModel result = returnBooksBll.DeleteReturnedBookRecord(returnRecordId);
                    if (result.isSuccess)
                    {
                        MessageBox.Show(result.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PopulateGridView();
                    }
                    else
                    {
                        MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
