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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void deliveryDD_onItemSelected(object sender, EventArgs e)
        {

        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            returnDateTimePicker.Enabled = true;
            studentNameDD.Enabled = true;
            bookTitleDD.Enabled = true;
            deliveryDD.Enabled = true;
        }
    }
}
