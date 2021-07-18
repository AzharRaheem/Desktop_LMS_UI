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
    public partial class Departments : Form
    {
        private int saveUpdate = 0 , deptId = 0;
        DepartmentBL departmentBll;
        public Departments()
        {
            InitializeComponent();
            departmentBll = new DepartmentBL();
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            EnableControls();
            ClearAllControls();
        }
        private void EnableControls()
        {
            deptNameTxtBox.Enabled = true;
            saveBtn.Enabled = true;
        }
        private void DisableControls()
        {
            deptNameTxtBox.Enabled = false;
            saveBtn.Enabled = false;
        }
        private void ClearAllControls()
        {
            saveUpdate = 0;
            deptNameTxtBox.Text = "";
            deptId = 0;
            saveBtn.Text = "Save";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(deptNameTxtBox.Text))
            {
                if (saveUpdate == 0)
                {
                    Department department = new Department();
                    department.name = deptNameTxtBox.Text;
                    BaseViewModel result = departmentBll.SaveDepartment(department);
                    if (result.isSuccess)
                    {
                        PopulateGridView();
                        MessageBox.Show(result.message , "Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
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
                    Department department = new Department();
                    department.id = deptId;
                    department.name = deptNameTxtBox.Text;
                    BaseViewModel result = departmentBll.UpdateDepartment(department);
                    if (result.isSuccess)
                    {
                        MessageBox.Show(result.message , "Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                        PopulateGridView();
                        ClearAllControls();
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
                deptNameErrorLbl.Visible = true;
                MessageBox.Show("Fields with * are Mandatory." , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void deptNameTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(deptNameTxtBox.Text))
            {
                deptNameErrorLbl.Visible = false;
            }
            else
            {
                deptNameErrorLbl.Visible = true;
            }
        }
        private void PopulateGridView()
        {
            BaseViewModel result = departmentBll.GetAllDepartments();
            if (result.isSuccess)
            {
                departmentsGridView.DataSource = result.data;
            }
            else
            {
                MessageBox.Show(result.message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void Departments_Load(object sender, EventArgs e)
        {
            ClearAllControls();
            DisableControls();
            PopulateGridView();
        }

        private void departmentsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            deptId = Convert.ToInt32(departmentsGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
            deptNameTxtBox.Text = departmentsGridView.Rows[e.RowIndex].Cells["departmentNameGVC"].Value.ToString();
            EnableControls();
            saveUpdate = 1;
            saveBtn.Text = "Update";
        }

        private void departmentsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                if(e.ColumnIndex == 0)
                {
                    deptId = Convert.ToInt32(departmentsGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                    deptNameTxtBox.Text = departmentsGridView.Rows[e.RowIndex].Cells["departmentNameGVC"].Value.ToString();
                    EnableControls();
                    saveUpdate = 1;
                    saveBtn.Text = "Update";
                }
                if(e.ColumnIndex == 1)
                {
                    DialogResult dr = MessageBox.Show("Do you want to Delete this Department" , "Confirm" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        deptId = Convert.ToInt32(departmentsGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                        BaseViewModel result = departmentBll.DeleteDepartment(deptId);
                        if (result.isSuccess)
                        {
                            MessageBox.Show(result.message , "Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                            PopulateGridView();
                            ClearAllControls();
                            DisableControls();
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
