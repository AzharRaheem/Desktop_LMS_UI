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
    public partial class Dashboard : Form
    {
        DashboardBL dashboardBll;
        public Dashboard()
        {
            InitializeComponent();
            booksProgressBar.Value = 20;
            issueBooksProgressbar.Value = 10;
            returnBooksProgressBar.Value = 30;
            dashboardBll = new DashboardBL();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DashboardCounts dashboardCounts = dashboardBll.getAllCounts();
            if (dashboardCounts.isSuccess)
            {
                roleCountLbl.Text = dashboardCounts.rolesCount.ToString();
                userCountLbl.Text = dashboardCounts.usersCount.ToString();
                booksCountLbl.Text = dashboardCounts.booksCount.ToString();
                studentsCountLbl.Text = dashboardCounts.studentsCount.ToString();
                issueBooksCount.Text = dashboardCounts.issueBooksCount.ToString();
            }
            else
            {
                MessageBox.Show(dashboardCounts.message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }

        }
    }
}
