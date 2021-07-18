using LMS_BLL;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void onFocusEnter(object sender, EventArgs e)
        {
            passwrodTxtBox.isPassword = true;
        }

        private void onCloseClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void onLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            this.Hide();
            reg.Show();
        }

        private void onLoginClick(object sender, EventArgs e)
        {
            Regex rg = new Regex("^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$");
            if (!rg.Match(emailTxtBox.Text).Success)
            {
                MessageBox.Show("Email is not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailErrorLabel.Visible = true;
            }
            if (!emailErrorLabel.Visible && !passwodErrrorLbl.Visible)
            {
                UserBL userBll = new UserBL();
                UserLoginVM loginUser = userBll.getLoginUser(emailTxtBox.Text, passwrodTxtBox.Text);
                if (loginUser.isSuccess)
                {
                    MainWindow home = new MainWindow(loginUser);
                    this.Hide();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Email and Password." , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
                
            }
            else
            {
                if (passwrodTxtBox.Text == string.Empty)
                {
                    passwodErrrorLbl.Visible = true;
                }
                if (emailTxtBox.Text == string.Empty)
                {
                    emailErrorLabel.Visible = true;
                }
            }
        }

        private void emailTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(emailTxtBox.Text))
            {
                emailErrorLabel.Visible = false;
            }
            else
            {
                emailErrorLabel.Visible = true;
            }
        }

        private void passwrodTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(passwrodTxtBox.Text))
            {
                passwodErrrorLbl.Visible = false;
            }
            else
            {
                passwodErrrorLbl.Visible = true;
            }
        }
    }
}
