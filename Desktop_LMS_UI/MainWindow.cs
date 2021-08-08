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
    public partial class MainWindow : Form
    {
        private UserLoginVM loggedInUser;
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(UserLoginVM loginUser)
        {
            InitializeComponent();
            loggedInUser = loginUser;
            loginUserRoleLbl.Text = loginUser.roleName;
            loginUserNameLbl.Text = loginUser.loginUserFirstName + " " + loginUser.loginUserLastName;
            if(loginUser.profileImagePath != null)
            {
                loginUserProfilePicBox.Image = new Bitmap(loginUser.profileImagePath);
            }
        }

        private void onLogoutClick(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            openChildForm(dash);
            if(loginUserRoleLbl.Text != "Admin")
            {
                manageUsersBtn.Enabled = false;
                manageRolesBtn.Enabled = false;
            }
        }
        Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(childForm);
            childForm.Show();
        }

        private void manageCategoryBtn_Click(object sender, EventArgs e)
        {
            Categories cat = new Categories();
            openChildForm(cat);
        }

        private void manageBooksBtn_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            openChildForm(books);
        }

        private void manageStudentsBtn_Click(object sender, EventArgs e)
        {
            Students student = new Students();
            openChildForm(student);
        }

        private void issueBookBtn_Click(object sender, EventArgs e)
        {
            ManageIssueBook issueBook = new ManageIssueBook(loggedInUser);
            openChildForm(issueBook);
        }

        private void returnBookBtn_Click(object sender, EventArgs e)
        {
            ManageReturnBooks returnBook = new ManageReturnBooks(loggedInUser);
            openChildForm(returnBook);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            openChildForm(dashboard);
        }

        private void manageRolesBtn_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles();
            openChildForm(roles);
        }

        private void manageUsersBtn_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            openChildForm(users);
        }

        private void manageDepartmentsBtn_Click(object sender, EventArgs e)
        {
            Departments departments = new Departments();
            openChildForm(departments);
        }

        private void dailyReportBtn_Click(object sender, EventArgs e)
        {
            ManageDailyReports dailyReports = new ManageDailyReports();
            openChildForm(dailyReports);
        }

        private void manageFineBtn_Click(object sender, EventArgs e)
        {
            ManageFine manageFines = new ManageFine();
            openChildForm(manageFines);
        }
    }
}
