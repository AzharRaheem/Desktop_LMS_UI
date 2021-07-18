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
    public partial class Register : Form
    {
        private UserBL userBl;
        public Register()
        {
            InitializeComponent();
            userBl = new UserBL();
        }

        private void onLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void onCloseClick(object sender, EventArgs e)
        {
            if(signUpTitleLbl.Text != "Sign Up")
            {
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }

        private void fNameTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(fNameTxtBox.Text))
            {
                fnameErrorLbl.Visible = false;
            }
            else
            {
                fnameErrorLbl.Visible = true;
            }
        }

        private void lNameTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lNameTxtBox.Text))
            {
                lnameErrorLbl.Visible = false;
            }
            else
            {
                lnameErrorLbl.Visible = true;
            }
        }

        private void emailTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(emailTxtBox.Text))
            {
                emailErrorLbl.Visible = false;
            }
            else
            {
                emailErrorLbl.Visible = true;
            }
        }

        private void passwrodTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(passwrodTxtBox.Text))
            {
                passwordErrorLbl.Visible = false;
            }
            else
            {
                passwordErrorLbl.Visible = true;
            }
        }

        private void confirmPasswordTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(confirmPasswordTxtBox.Text))
            {
                confirmPassErrorLbl.Visible = false;
            }
            else
            {
                confirmPassErrorLbl.Visible = true;
            }
        }

        private void onRegisterClick(object sender, EventArgs e)
        {
            if (fieldValidation())
            {
                BaseViewModel checkUserPresence = userBl.isUserPresent(emailTxtBox.Text);
                if (!checkUserPresence.isSuccess)
                {
                    User user = new User();
                    user.firstName = fNameTxtBox.Text;
                    user.lastName = lNameTxtBox.Text;
                    user.email = emailTxtBox.Text;
                    user.password = confirmPasswordTxtBox.Text;
                    user.gender = (maleRBtn.Checked) ? 1 : 0;
                    BaseViewModel result = userBl.saveUser(user);
                    if (result.isSuccess)
                    {
                        if(signUpTitleLbl.Text == "Sign Up")
                        {
                            Login login = new Login();
                            this.Hide();
                            login.Show();
                        }
                        else
                        {
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sorry! User already exist in the System.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            else
            {
                MessageBox.Show("The fields with * are Mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkEmailValidation(string email)
        {
            Regex rg = new Regex("^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$");
            if (!rg.Match(email).Success)
            {
                emailErrorLbl.Visible = true;
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool fieldValidation()
        {
            if (fNameTxtBox.Text == string.Empty)
            {
                fnameErrorLbl.Visible = true;
            }
            if (lNameTxtBox.Text == string.Empty)
            {
                lnameErrorLbl.Visible = true;
            }
            if (emailTxtBox.Text == string.Empty)
            {
                emailErrorLbl.Visible = true;
            }
            if (passwrodTxtBox.Text == string.Empty)
            {
                passwordErrorLbl.Visible = true;
            }
            if (confirmPasswordTxtBox.Text == string.Empty)
            {
                confirmPassErrorLbl.Visible = true;
            }            if (passwrodTxtBox.Text != confirmPasswordTxtBox.Text)
            {
                MessageBox.Show("Password and Confirm Password not Matched.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bool isValidEmail = checkEmailValidation(emailTxtBox.Text);
            if (!isValidEmail)
            {
                MessageBox.Show("Email is not correct.\nEnter a valid email Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!fnameErrorLbl.Visible && !lnameErrorLbl.Visible && !emailErrorLbl.Visible && !passwordErrorLbl.Visible && !confirmPassErrorLbl.Visible && isValidEmail)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
