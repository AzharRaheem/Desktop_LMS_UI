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
    public partial class Categories : Form
    {
        private int saveUpdate = 0 , cat_id;
        private CategoryBL categoryBll;
        public Categories()
        {
            InitializeComponent();
            categoryBll = new CategoryBL();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            statusDD.selectedIndex = 0;
            populateGridView();
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            saveBtn.Text = "Save";
            saveUpdate = 0;
            enableControls();
            clearControls();
        }

        private void clearControls()
        {
            categoryNameTxtBox.Text = "";
            statusDD.selectedIndex = 0;
        }
        private void enableControls()
        {
            categoryNameTxtBox.Enabled = true;
            statusDD.Enabled = true;
            saveBtn.Enabled = true;
        }
        private void disableControls()
        {
            categoryNameTxtBox.Enabled = false;
            statusDD.Enabled = false;
            saveBtn.Enabled = false;
        }
        private void populateGridView()
        {
            CategoryStatusBaseVM result = categoryBll.getAllCategories();
            if (result.isSuccess)
            {
                categoryGridView.DataSource = result.categories;
            }
            else
            {
                MessageBox.Show(result.message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(categoryNameTxtBox.Text == string.Empty)
            {
                nameErrorLbl.Visible = true;
            }
            else
            {
                nameErrorLbl.Visible = false;
            }
            if (statusDD.selectedIndex != 0)
            {
                statusErrorLbl.Visible = false;
            }
            else
            {
                statusErrorLbl.Visible = true;
            }
            if (!string.IsNullOrWhiteSpace(categoryNameTxtBox.Text) && statusDD.selectedIndex != 0)
            {
                Category category = new Category();
                category.name = categoryNameTxtBox.Text;
                category.status = statusDD.selectedIndex;
                if(saveUpdate == 0)
                {
                    BaseViewModel result = categoryBll.saveCategory(category);
                    if (result.isSuccess)
                    {
                        MessageBox.Show(result.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearControls();
                        disableControls();
                        populateGridView();
                    }
                    else
                    {
                        MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if(saveUpdate == 1)
                {
                    Category cat = new Category();
                    cat.id = cat_id;
                    cat.name = categoryNameTxtBox.Text;
                    cat.status = statusDD.selectedIndex;
                    BaseViewModel result = categoryBll.updateCategory(cat);
                    if (result.isSuccess)
                    {
                        MessageBox.Show(result.message , "Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                        clearControls();
                        disableControls();
                        saveBtn.Text = "Save";
                        populateGridView();
                    }
                    else
                    {
                        MessageBox.Show(result.message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Fields with * are Mandatory." , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void categoryNameTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(categoryNameTxtBox.Text))
            {
                nameErrorLbl.Visible = false;
            }
            else
            {
                nameErrorLbl.Visible = true;
            }            
        }

        private void statusDD_onItemSelected(object sender, EventArgs e)
        {
            if (statusDD.selectedIndex == 0)
            {
                statusErrorLbl.Visible = true;
            }
            else
            {
                statusErrorLbl.Visible = false;
            }
        }

        private void searchTxtBox_OnTextChange(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchTxtBox.text))
            {
                CategoryStatusBaseVM result = categoryBll.getFilteredCategories(searchTxtBox.text);
                if (result.isSuccess)
                {
                    categoryGridView.DataSource = result.categories;
                }
                else
                {
                    MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                populateGridView();
            }
           
        }

        private void categoryGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                cat_id = Convert.ToInt32(categoryGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                categoryNameTxtBox.Text = categoryGridView.Rows[e.RowIndex].Cells["categoryNameGVC"].Value.ToString();
                statusDD.selectedIndex = Convert.ToInt32(categoryGridView.Rows[e.RowIndex].Cells["statusGVC"].Value.ToString());
                saveUpdate = 1;
                saveBtn.Text = "Update";
                enableControls();
            }
        }

        private void categoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if(e.ColumnIndex == 0)
                {
                    cat_id = Convert.ToInt32(categoryGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                    categoryNameTxtBox.Text = categoryGridView.Rows[e.RowIndex].Cells["categoryNameGVC"].Value.ToString();
                    statusDD.selectedIndex = Convert.ToInt32(categoryGridView.Rows[e.RowIndex].Cells["statusGVC"].Value.ToString());
                    saveUpdate = 1;
                    saveBtn.Text = "Update";
                    enableControls();
                }
                if(e.ColumnIndex == 1)
                {
                    DialogResult dr = MessageBox.Show("Do you want to Delete this Category." , "Confirm" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        cat_id = Convert.ToInt32(categoryGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                        BaseViewModel result = categoryBll.deleteCategory(cat_id);
                        if (result.isSuccess)
                        {
                            MessageBox.Show(result.message , "Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                            populateGridView();
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
