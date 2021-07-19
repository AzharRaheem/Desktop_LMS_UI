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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_LMS_UI
{
    public partial class ManageFine : Form
    {
        private int saveUpdate = 0;
        private int fineId = 0;
        private FineBL fineBll;
        public ManageFine()
        {
            InitializeComponent();
            fineBll = new FineBL();
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            ClearAllControls();
            EnableControls();
        }
        private void ClearAllControls()
        {
            fineTxtBox.Text = null;
            saveBtn.Text = "Save";
            fineId = 0;
            saveUpdate = 0;
        }
        private void EnableControls()
        {
            fineTxtBox.Enabled = true;
            saveBtn.Enabled = true;
        }
        private void DisableControls()
        {
            fineTxtBox.Enabled = false;
            saveBtn.Enabled = false;
        }

        private void fineTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fineTxtBox.Text))
            {
                FineErrorLbl.Visible = false;
            }
            else
            {
                FineErrorLbl.Visible = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(fineTxtBox.Text))
            {
                Regex regex = new Regex(@"^[1-9]\d*(\.\d+)?$");
                if (regex.Match(fineTxtBox.Text).Success)
                {
                    if (saveUpdate == 0)
                    {
                        Fine fine = new Fine();
                        fine.fine = Convert.ToSingle(fineTxtBox.Text);
                        BaseViewModel result = fineBll.SaveFine(fine);
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
                        Fine fine = new Fine();
                        fine.id = fineId;
                        fine.fine = Convert.ToSingle(fineTxtBox.Text);
                        BaseViewModel result = fineBll.UpdateFineRecord(fine);
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
                    MessageBox.Show("Please Enter Correct Value for Fine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                FineErrorLbl.Visible = true;
            }
        }

        private void ManageFine_Load(object sender, EventArgs e)
        {
            PopulateGridView();
            ClearAllControls();
        }
        private void PopulateGridView()
        {
            BaseViewModel result = fineBll.GetAllFinesList();
            if (result.isSuccess)
            {
                FinesGridView.DataSource = result.data;
            }
            else
            {
                MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FinesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 0)
                {
                    fineId = Convert.ToInt32(FinesGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                    fineTxtBox.Text = FinesGridView.Rows[e.RowIndex].Cells["fineValueGVC"].Value.ToString();
                    saveUpdate = 1;
                    saveBtn.Text = "Update";
                    EnableControls();
                }
                if (e.ColumnIndex == 1)
                {
                    DialogResult dr = MessageBox.Show("Do you want to delete this Fine?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        fineId = Convert.ToInt32(FinesGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                        BaseViewModel result = fineBll.DeleteFineValue(fineId);
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
                }
            }
        }

        private void FinesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                fineId = Convert.ToInt32(FinesGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                fineTxtBox.Text = FinesGridView.Rows[e.RowIndex].Cells["fineValueGVC"].Value.ToString();
                saveUpdate = 1;
                saveBtn.Text = "Update";
                EnableControls();
            }
        }
    }
}
