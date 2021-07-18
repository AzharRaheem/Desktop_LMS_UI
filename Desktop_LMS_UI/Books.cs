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
    public partial class Books : Form
    {
        private BookBL bookBll;
        private int saveUpdate = 0 , bookId;
        private string imagePath = null;

        public Books()
        {
            InitializeComponent();
            bookBll = new BookBL();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            BaseViewModel result = bookBll.getAllCategories();
            if(result.isSuccess)
            {
                categoryDD.DataSource = result.data;
                categoryDD.ValueMember = "id";
                categoryDD.DisplayMember = "name";
            }
            else
            {
                MessageBox.Show(result.message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            ClearAllControls();
            PopulateGridView();
        }
        private void EnableControls()
        {
            bookNameTxtBox.Enabled = true;
            categoryDD.Enabled = true;
            authorNameTxtBox.Enabled = true;
            publisherTxtBox.Enabled = true;
            barcodeTxtBox.Enabled = true;
            editionTxtBox.Enabled = true;
            priceTxtBox.Enabled = true;
            isbnTxtBox.Enabled = true;
            saveBtn.Enabled = true;
            uploadBtn.Enabled = true;
        }
        private void DisableControls()
        {
            bookNameTxtBox.Enabled = false;
            categoryDD.Enabled = false;
            authorNameTxtBox.Enabled = false;
            publisherTxtBox.Enabled = false;
            barcodeTxtBox.Enabled = false;
            editionTxtBox.Enabled = false;
            priceTxtBox.Enabled = false;
            isbnTxtBox.Enabled = false;
            saveBtn.Enabled = false;
            uploadBtn.Enabled = false;
        }
        private void ClearAllControls()
        {
            bookNameTxtBox.Text = "";
            categoryDD.SelectedIndex = -1;
            authorNameTxtBox.Text = "";
            publisherTxtBox.Text = "";
            barcodeTxtBox.Text = "";
            editionTxtBox.Text = "";
            priceTxtBox.Text = "";
            isbnTxtBox.Text = "";
            bookPicBox.Image = null;
            imagePath = null;
            saveUpdate = 0;
        }
        private void addNewBtn_Click(object sender, EventArgs e)
        {
            EnableControls();
            ClearAllControls();
            saveBtn.Text = "Save";
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = bookPictureOpenFileDialog.ShowDialog();
            if(dr == DialogResult.OK)
            {
                var image = bookPictureOpenFileDialog.FileName;
                bool result = saveImage(image);
                if (result)
                {
                    bookPicBox.Image = new Bitmap(image);
                    MessageBox.Show("Book Cover Uploaded Successfully." , "Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sorry! Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool saveImage(string image)
        {
            var folderPath = AppDomain.CurrentDomain.BaseDirectory + "Images";
            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            var currentImagePath = image;
            var extension = currentImagePath.Split('.')[1];
            Guid uniqueName = Guid.NewGuid();
            var newImageName = uniqueName + "." + extension;
            var newImagePath = folderPath + "\\" + newImageName;
            imagePath = newImagePath;
            File.Copy(currentImagePath, newImagePath);
            return true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(bookNameTxtBox.Text) && categoryDD.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(authorNameTxtBox.Text) && !string.IsNullOrWhiteSpace(publisherTxtBox.Text) &&
                     !string.IsNullOrWhiteSpace(priceTxtBox.Text) && !string.IsNullOrWhiteSpace(barcodeTxtBox.Text) && !string.IsNullOrWhiteSpace(editionTxtBox.Text) && !string.IsNullOrWhiteSpace(isbnTxtBox.Text))
            {
                Regex regex = new Regex(@"^[1-9]\d*(\.\d+)?$");
                if (regex.Match(priceTxtBox.Text).Success)
                {
                    if (saveUpdate == 0)
                    {
                        Book book = new Book();
                        book.bookName = bookNameTxtBox.Text;
                        book.categoryid = Convert.ToInt32(categoryDD.SelectedValue);
                        book.authorName = authorNameTxtBox.Text;
                        book.publisherName = publisherTxtBox.Text;
                        book.price = Convert.ToSingle(priceTxtBox.Text);
                        book.barcode = barcodeTxtBox.Text;
                        book.bookEdition = editionTxtBox.Text;
                        book.book_ISBN = isbnTxtBox.Text;
                        book.bookImagePath = imagePath;
                        BaseViewModel result = bookBll.SaveBook(book);
                        if (result.isSuccess)
                        {
                            MessageBox.Show(result.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PopulateGridView();
                            ClearAllControls();
                            DisableControls();
                        }
                        else
                        {
                            MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (saveUpdate == 1)
                    {
                        Book book = new Book();
                        book.id = bookId;
                        book.bookName = bookNameTxtBox.Text;
                        book.categoryid = Convert.ToInt32(categoryDD.SelectedValue);
                        book.authorName = authorNameTxtBox.Text;
                        book.publisherName = publisherTxtBox.Text;
                        book.price = Convert.ToSingle(priceTxtBox.Text);
                        book.barcode = barcodeTxtBox.Text;
                        book.bookEdition = editionTxtBox.Text;
                        book.book_ISBN = isbnTxtBox.Text;
                        book.bookImagePath = imagePath;
                        BaseViewModel result = bookBll.UpdateBook(book);
                        if (result.isSuccess)
                        {
                            MessageBox.Show(result.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PopulateGridView();
                            ClearAllControls();
                            DisableControls();
                            saveBtn.Text = "Save";
                        }
                        else
                        {
                            MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Price." , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(bookNameTxtBox.Text))
                {
                    booknameErrorLbl.Visible = false;
                }
                else
                {
                    booknameErrorLbl.Visible = true;
                }
                if (!string.IsNullOrWhiteSpace(authorNameTxtBox.Text))
                {
                    authorNameErrorLbl.Visible = false;
                }
                else
                {
                    authorNameErrorLbl.Visible = true;
                }
                if (!string.IsNullOrWhiteSpace(publisherTxtBox.Text))
                {
                    publisherErrorLbl.Visible = false;
                }
                else
                {
                    publisherErrorLbl.Visible = true;
                }
                if (!string.IsNullOrWhiteSpace(editionTxtBox.Text))
                {
                    editionVolumeErrorLbl.Visible = false;
                }
                else
                {
                    editionVolumeErrorLbl.Visible = true;
                }
                if (!string.IsNullOrWhiteSpace(barcodeTxtBox.Text))
                {
                    barcodeErrorLbl.Visible = false;
                }
                else
                {
                    barcodeErrorLbl.Visible = true;
                }
                if (!string.IsNullOrWhiteSpace(priceTxtBox.Text))
                {
                    priceErrorLbl.Visible = false;
                }
                else
                {
                    priceErrorLbl.Visible = true;
                }
                if (!string.IsNullOrWhiteSpace(isbnTxtBox.Text))
                {
                    isbnErrorLbl.Visible = false;
                }
                else
                {
                    isbnErrorLbl.Visible = true;
                }
                if (categoryDD.SelectedIndex != -1)
                {
                    categoryDDErrorLbl.Visible = false;
                }
                else
                {
                    categoryDDErrorLbl.Visible = true;
                }
                MessageBox.Show("Fields with * are Mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bookNameTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(bookNameTxtBox.Text))
            {
                booknameErrorLbl.Visible = false;
            }
            else
            {
                booknameErrorLbl.Visible = true;
            }
        }

        private void authorNameTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(authorNameTxtBox.Text))
            {
                authorNameErrorLbl.Visible = false;
            }
            else
            {
                authorNameErrorLbl.Visible = true;
            }
        }

        private void publisherTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(publisherTxtBox.Text))
            {
                publisherErrorLbl.Visible = false;
            }
            else
            {
                publisherErrorLbl.Visible = true;
            }
        }

        private void editionTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(editionTxtBox.Text))
            {
                editionVolumeErrorLbl.Visible = false;
            }
            else
            {
                editionVolumeErrorLbl.Visible = true;
            }
        }

        private void barcodeTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(barcodeTxtBox.Text))
            {
                barcodeErrorLbl.Visible = false;
            }
            else
            {
                barcodeErrorLbl.Visible = true;
            }
        }

        private void priceTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(priceTxtBox.Text))
            {
                priceErrorLbl.Visible = false;
            }
            else
            {
                priceErrorLbl.Visible = true;
            }
        }

        private void isbnTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(isbnTxtBox.Text))
            {
                isbnErrorLbl.Visible = false;
            }
            else
            {
                isbnErrorLbl.Visible = true;
            }
        }

        private void categoryDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(categoryDD.SelectedIndex != -1)
            {
                categoryDDErrorLbl.Visible = false;
            }
            else
            {
                categoryDDErrorLbl.Visible = true;
            }
        }

        private void PopulateGridView()
        {
            BookCategoryBaseVM result = bookBll.getAllBooks();
            if (result.isSuccess)
            {
                booksGridView.DataSource = result.books;
            }
            else
            {
                MessageBox.Show(result.message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void booksGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                bookId = Convert.ToInt32(booksGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                bookNameTxtBox.Text = booksGridView.Rows[e.RowIndex].Cells["bookNameGVC"].Value.ToString();
                categoryDD.SelectedValue = Convert.ToInt32(booksGridView.Rows[e.RowIndex].Cells["categoryIdGVC"].Value.ToString());
                authorNameTxtBox.Text = booksGridView.Rows[e.RowIndex].Cells["authorNameGVC"].Value.ToString();
                publisherTxtBox.Text = booksGridView.Rows[e.RowIndex].Cells["publisherGVC"].Value.ToString();
                editionTxtBox.Text = booksGridView.Rows[e.RowIndex].Cells["editionGVC"].Value.ToString();
                barcodeTxtBox.Text = booksGridView.Rows[e.RowIndex].Cells["barcodeGVC"].Value.ToString();
                priceTxtBox.Text = booksGridView.Rows[e.RowIndex].Cells["priceGVC"].Value.ToString();
                isbnTxtBox.Text = booksGridView.Rows[e.RowIndex].Cells["isbnGVC"].Value.ToString();
                if(booksGridView.Rows[e.RowIndex].Cells["bookImagePathGVC"].Value != null)
                {
                    bookPicBox.Image = new Bitmap(booksGridView.Rows[e.RowIndex].Cells["bookImagePathGVC"].Value.ToString());
                    imagePath = booksGridView.Rows[e.RowIndex].Cells["bookImagePathGVC"].Value.ToString();
                }
                else
                {
                    bookPicBox.Image = null;
                }
                saveBtn.Text = "Update";
                saveUpdate = 1;
                EnableControls();
            }
        }

        private void searchTxtBox_OnTextChange(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchTxtBox.text))
            {
                BookCategoryBaseVM result = bookBll.GetFilteredBooks(searchTxtBox.text);
                if (result.isSuccess)
                {
                    booksGridView.DataSource = result.books;
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

        private void booksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                bookId = Convert.ToInt32(booksGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                bookNameTxtBox.Text = booksGridView.Rows[e.RowIndex].Cells["bookNameGVC"].Value.ToString();
                categoryDD.SelectedValue = Convert.ToInt32(booksGridView.Rows[e.RowIndex].Cells["categoryIdGVC"].Value.ToString());
                authorNameTxtBox.Text = booksGridView.Rows[e.RowIndex].Cells["authorNameGVC"].Value.ToString();
                publisherTxtBox.Text = booksGridView.Rows[e.RowIndex].Cells["publisherGVC"].Value.ToString();
                editionTxtBox.Text = booksGridView.Rows[e.RowIndex].Cells["editionGVC"].Value.ToString();
                barcodeTxtBox.Text = booksGridView.Rows[e.RowIndex].Cells["barcodeGVC"].Value.ToString();
                priceTxtBox.Text = booksGridView.Rows[e.RowIndex].Cells["priceGVC"].Value.ToString();
                isbnTxtBox.Text = booksGridView.Rows[e.RowIndex].Cells["isbnGVC"].Value.ToString();
                if (booksGridView.Rows[e.RowIndex].Cells["bookImagePathGVC"].Value != null)
                {
                    bookPicBox.Image = new Bitmap(booksGridView.Rows[e.RowIndex].Cells["bookImagePathGVC"].Value.ToString());
                    imagePath = booksGridView.Rows[e.RowIndex].Cells["bookImagePathGVC"].Value.ToString();
                }
                else
                {
                    bookPicBox.Image = null;
                }
                saveBtn.Text = "Update";
                saveUpdate = 1;
                EnableControls();
            }
            if(e.ColumnIndex == 1)
            {
                DialogResult dr =  MessageBox.Show("Do you want to delete this Book?" , "Confirm" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    bookId = Convert.ToInt32(booksGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                    BaseViewModel result = bookBll.DeleteBook(bookId);
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
            }
        }
    }
}
