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
    public partial class ManageIssueBook : Form
    {
        private IssueBookBL issueBookBll;
        private UserLoginVM loggedInlibrarian;
        private int saveUpdate , issuedBookId;
        public ManageIssueBook()
        {
            InitializeComponent();
            issueBookBll = new IssueBookBL();
        }
        public ManageIssueBook(UserLoginVM loginUser)
        {
            InitializeComponent();
            issueBookBll = new IssueBookBL();
            loggedInlibrarian = loginUser;
        }

        private void issueNewBookBtn_Click(object sender, EventArgs e)
        {
            ClearAllControls();
            EnableControls();
        }
        private void EnableControls()
        {
            bookDD.Enabled = true;
            studentDD.Enabled = true;
            issueDateTimePicker.Enabled = true;
            returnDateTimePicker.Enabled = true;
            fineDD.Enabled = true;
            saveBtn.Enabled = true;
        }
        private void DisableControls()
        {
            bookDD.Enabled = false;
            studentDD.Enabled = false;
            issueDateTimePicker.Enabled = false;
            returnDateTimePicker.Enabled = false;
            fineDD.Enabled = false;
            saveBtn.Enabled = false;
        }
        private void ClearAllControls()
        {
            fineDD.SelectedIndex = -1;
            studentDD.SelectedIndex = -1;
            bookDD.SelectedIndex = -1;
            issueDateTimePicker.Value = DateTime.Now.Date;
            returnDateTimePicker.Value = DateTime.Now.Date;
            saveUpdate = 0;
            issuedBookId = 0;
            saveBtn.Text = "Save";
            HideVisibility();
        }
        private void HideVisibility()
        {
            bookDDErrorLbl.Visible = false;
            studentDDErrorLbl.Visible = false;
            fineDDErrorLbl.Visible = false;
            issueDateDTErrorLbl.Visible = false;
            returnDateDTErrorLbl.Visible = false;
                
        }

        private void PopulateGridView()
        {
            IssueBookBaseVM result = issueBookBll.GetAllIssuedBooks();
            if (result.isSuccess)
            {
                issueBooksGridView.DataSource = result.issueBooks;
            }
            else
            {
                MessageBox.Show(result.message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
       
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(bookDD.SelectedIndex != -1 && studentDD.SelectedIndex != -1 && fineDD.SelectedIndex != -1 && !(returnDateTimePicker.Value.Date <= issueDateTimePicker.Value.Date) && !(issueDateTimePicker.Value.Date > DateTime.Today.Date))
            {
                if (saveUpdate == 0)
                {
                    IssueBook issueBook = new IssueBook();
                    issueBook.studentId = Convert.ToInt32(studentDD.SelectedValue);
                    issueBook.bookId = Convert.ToInt32(bookDD.SelectedValue);
                    issueBook.librarianId = loggedInlibrarian.id;
                    issueBook.issueDate = issueDateTimePicker.Value.Date;
                    issueBook.returnDate = returnDateTimePicker.Value.Date;
                    issueBook.fineId = Convert.ToInt32(fineDD.SelectedValue);
                    BaseViewModel result = issueBookBll.SaveIssueBook(issueBook);
                    if (result.isSuccess)
                    {
                        MessageBox.Show(result.message , "Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                        ClearAllControls();
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
                    IssueBook issueBook = new IssueBook();
                    issueBook.id = issuedBookId;
                    issueBook.studentId = Convert.ToInt32(studentDD.SelectedValue);
                    issueBook.bookId = Convert.ToInt32(bookDD.SelectedValue);
                    issueBook.librarianId = loggedInlibrarian.id;
                    issueBook.issueDate = issueDateTimePicker.Value.Date;
                    issueBook.returnDate = returnDateTimePicker.Value.Date;
                    issueBook.fineId = Convert.ToInt32(fineDD.SelectedValue);
                    BaseViewModel result = issueBookBll.UpdateRecord(issueBook);
                    if (result.isSuccess)
                    {
                        MessageBox.Show(result.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAllControls();
                        DisableControls();
                        PopulateGridView();
                    }
                    else
                    {
                        MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (bookDD.SelectedIndex != -1)
                {
                    bookDDErrorLbl.Visible = false;
                }
                else
                {
                    bookDDErrorLbl.Visible = true;
                }
                if (studentDD.SelectedIndex != -1)
                {
                    studentDDErrorLbl.Visible = false;
                }
                else
                {
                    studentDDErrorLbl.Visible = true;
                }
                if (fineDD.SelectedIndex != -1)
                {
                    fineDDErrorLbl.Visible = false;
                }
                else
                {
                    fineDDErrorLbl.Visible = true;
                }
                if (returnDateTimePicker.Value.Date <= issueDateTimePicker.Value.Date)
                {
                    returnDateDTErrorLbl.Visible = true;
                    MessageBox.Show("Please Enter Correct Return Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    returnDateDTErrorLbl.Visible = false;
                }
                if (issueDateTimePicker.Value.Date > DateTime.Today.Date)
                {
                    issueDateDTErrorLbl.Visible = true;
                    MessageBox.Show("Please Enter Correct Issue Date." , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
                else
                {
                    issueDateDTErrorLbl.Visible = false;
                }
                MessageBox.Show("Fields with * are Mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bookDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(bookDD.SelectedIndex != -1)
            {
                bookDDErrorLbl.Visible = false;
            }
            else
            {
                bookDDErrorLbl.Visible = true;
            }
        }

        private void studentDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentDD.SelectedIndex != -1)
            {
                studentDDErrorLbl.Visible = false;
            }
            else
            {
                studentDDErrorLbl.Visible = true;
            }
        }

        private void fineDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fineDD.SelectedIndex != -1)
            {
                fineDDErrorLbl.Visible = false;
            }
            else
            {
                fineDDErrorLbl.Visible = true;
            }
        }

        private void returnDateTimePicker_onValueChanged(object sender, EventArgs e)
        {
            if(returnDateTimePicker.Value.Date <= issueDateTimePicker.Value.Date)
            {
                returnDateDTErrorLbl.Visible = true;
            }
            else
            {
                returnDateDTErrorLbl.Visible = false;
            }
        }

        private void issueDateTimePicker_onValueChanged(object sender, EventArgs e)
        {
            if(issueDateTimePicker.Value.Date > DateTime.Today.Date)
            {
                issueDateDTErrorLbl.Visible = true;
            }
            else
            {
                issueDateDTErrorLbl.Visible = false;
            }
        }
        private void PopulateDropDowns()
        {
            BaseViewModel books = issueBookBll.GetAllBooks();
            if (books.isSuccess)
            {
                bookDD.DataSource = books.data;
                bookDD.ValueMember = "id";
                bookDD.DisplayMember = "bookName";
            }
            else
            {
                MessageBox.Show(books.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BaseViewModel students = issueBookBll.GetAllStudents();
            if (students.isSuccess)
            {
                studentDD.DataSource = students.data;
                studentDD.ValueMember = "id";
                studentDD.DisplayMember = "name";
            }
            else
            {
                MessageBox.Show(students.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BaseViewModel fines = issueBookBll.GetAllFines();
            if (fines.isSuccess)
            {
                fineDD.DataSource = fines.data;
                fineDD.ValueMember = "id";
                fineDD.DisplayMember = "fine";
            }
            else
            {
                MessageBox.Show(fines.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageIssueBook_Load(object sender, EventArgs e)
        {
            PopulateDropDowns();
            ClearAllControls();
            PopulateGridView();
        }

        private void issueBooksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if(e.ColumnIndex == 0)
                {
                    issuedBookId = Convert.ToInt32(issueBooksGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                    bookDD.SelectedValue = Convert.ToInt32(issueBooksGridView.Rows[e.RowIndex].Cells["bookIdGVC"].Value.ToString());
                    issueDateTimePicker.Value = Convert.ToDateTime(issueBooksGridView.Rows[e.RowIndex].Cells["issueDateGVC"].Value.ToString());
                    returnDateTimePicker.Value = Convert.ToDateTime(issueBooksGridView.Rows[e.RowIndex].Cells["returnDateGVC"].Value.ToString());
                    studentDD.SelectedValue = Convert.ToInt32(issueBooksGridView.Rows[e.RowIndex].Cells["studentIdGVC"].Value.ToString());
                    fineDD.SelectedValue = Convert.ToInt32(issueBooksGridView.Rows[e.RowIndex].Cells["fineIdGVC"].Value.ToString());
                    EnableControls();
                    saveBtn.Text = "Update";
                    saveUpdate = 1;
                }
                if(e.ColumnIndex == 1)
                {
                    issuedBookId = Convert.ToInt32(issueBooksGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                    DialogResult dr = MessageBox.Show("Do you want to delete this Record?" , "Confirm" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        BaseViewModel result = issueBookBll.DeleteRecord(issuedBookId);
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

        private void issueBooksGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                issuedBookId = Convert.ToInt32(issueBooksGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                bookDD.SelectedValue = Convert.ToInt32(issueBooksGridView.Rows[e.RowIndex].Cells["bookIdGVC"].Value.ToString());
                issueDateTimePicker.Value = Convert.ToDateTime(issueBooksGridView.Rows[e.RowIndex].Cells["issueDateGVC"].Value.ToString());
                returnDateTimePicker.Value = Convert.ToDateTime(issueBooksGridView.Rows[e.RowIndex].Cells["returnDateGVC"].Value.ToString());
                studentDD.SelectedValue = Convert.ToInt32(issueBooksGridView.Rows[e.RowIndex].Cells["studentIdGVC"].Value.ToString());
                fineDD.SelectedValue = Convert.ToInt32(issueBooksGridView.Rows[e.RowIndex].Cells["fineIdGVC"].Value.ToString());
                EnableControls();
                saveBtn.Text = "Update";
                saveUpdate = 1;
            }
        }
    }
}
