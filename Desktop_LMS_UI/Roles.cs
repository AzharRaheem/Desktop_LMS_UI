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
    public partial class Roles : Form
    {
        RoleBL roleBll;
        int id , saveUpdate;
        public Roles()
        {
            InitializeComponent();
            roleBll = new RoleBL();
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            enableControls();
            clearControls();
            saveBtn.Text = "Save";
            saveUpdate = 0;
        }

        private void onRoleTxtBoxValueChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(roleNameTxtBox.Text))
            {
                roleNameErrorLbl.Visible = false;
            }
            else
            {
                roleNameErrorLbl.Visible = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(roleNameTxtBox.Text == string.Empty)
            {
                roleNameErrorLbl.Visible = true;
                MessageBox.Show("The Fields with * are Mandatory." , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else
            {
                if(saveUpdate == 0)
                {
                    Role role = new Role();
                    role.name = roleNameTxtBox.Text;
                    BaseViewModel result = roleBll.saveRole(role);
                    if (result.isSuccess)
                    {
                        MessageBox.Show(result.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearControls();
                        populateGridView();
                        disableControls();
                    }
                    else
                    {
                        MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearControls();
                    }
                }
                if(saveUpdate == 1)
                {
                    Role role = new Role();
                    role.id = id;
                    role.name = roleNameTxtBox.Text;
                    BaseViewModel result = roleBll.updateRole(role);
                    if (result.isSuccess)
                    {
                        MessageBox.Show(result.message , "Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                        clearControls();
                        populateGridView();
                        disableControls();
                    }
                    else
                    {
                        MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                
            }
        }
        private void Roles_Load(object sender, EventArgs e)
        {
            populateGridView();
        }

        private void clearControls()
        {
            roleNameTxtBox.Text = "";
        }
        private void populateGridView()
        {
            BaseViewModel result = roleBll.getAllRoles();
            if(result.isSuccess)
            {
                rolesGridView.DataSource = result.data;
            }
            else
            {
                MessageBox.Show(result.message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
        private void enableControls()
        {
            saveBtn.Enabled = true;
            roleNameTxtBox.Enabled = true;
        }
        private void disableControls()
        {
            saveBtn.Enabled = false;
            roleNameTxtBox.Enabled = false;
        }

        private void rolesGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                id = Convert.ToInt32(rolesGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                roleNameTxtBox.Text = rolesGridView.Rows[e.RowIndex].Cells["roleNameGVC"].Value.ToString();
                saveUpdate = 1;
                saveBtn.Text = "Update";
                enableControls();
            }
        }

        private void searchTxtBox_OnTextChange(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchTxtBox.text))
            {
                BaseViewModel result = roleBll.getFilteredRecords(searchTxtBox.text);
                if (result.isSuccess)
                {
                    rolesGridView.DataSource = result.data;
                }
            }
            else
            {
                populateGridView();
            }
           
        }

        private void rolesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if(e.ColumnIndex == 0)
                {
                    id = Convert.ToInt32(rolesGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                    roleNameTxtBox.Text = rolesGridView.Rows[e.RowIndex].Cells["roleNameGVC"].Value.ToString();
                    saveUpdate = 1;
                    saveBtn.Text = "Update";
                    enableControls();
                }
                if(e.ColumnIndex == 1)
                {
                    DialogResult dr = MessageBox.Show("Do you want to Delete this Role?" , "Confirm" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        id = Convert.ToInt32(rolesGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                        BaseViewModel result = roleBll.deleteRole(id);
                        if (result.isSuccess)
                        {
                            MessageBox.Show(result.message , "Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                            populateGridView();
                            clearControls();
                            disableControls();
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
}
