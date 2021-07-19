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
    public partial class ManageFine : Form
    {
        public ManageFine()
        {
            InitializeComponent();
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
    }
}
