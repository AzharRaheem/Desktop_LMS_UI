using LMS_BLL;
using LMS_DomainModel;
using LMS_DomainModel.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_LMS_UI
{
    public partial class Users : Form
    {
        private UserBL userBll;
        private int user_id;
        RoleBL rolesBl;
        User user;
        string userProfilePath = null;
        public Users()
        {
            InitializeComponent();
            userBll = new UserBL();
            rolesBl = new RoleBL();
            user = new User();
        }
        
        private void Users_Load(object sender, EventArgs e)
        {
            PopulateGridView();
            BaseViewModel result = rolesBl.getAllRoles();
            if(result.isSuccess)
            {
                rolesDD.DataSource = result.data;
                rolesDD.ValueMember = "id";
                rolesDD.DisplayMember = "name";
            }
            rolesDD.SelectedIndex = -1;
        }
        private void PopulateGridView()
        {
            UserRoleBaseVM result = userBll.getAllUsers();
            if(result.isSuccess)
            {
                usersGridView.DataSource = result.users;
            }
            else
            {
                MessageBox.Show(result.message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void EnableControls()
        {
            fNameTxtBox.Enabled = true;
            lNameTxtBox.Enabled = true;
            emailTxtBox.Enabled = true;
            rolesDD.Enabled = true;
            pictureUploadBtn.Enabled = true;
            updateBtn.Enabled = true;
        }
        private void DisableControls()
        {
            fNameTxtBox.Enabled = false;
            lNameTxtBox.Enabled = false;
            emailTxtBox.Enabled = false;
            rolesDD.Enabled = false;
            pictureUploadBtn.Enabled = false;
            updateBtn.Enabled = false;
        }
        private void ClearAllFields()
        {
            fNameTxtBox.Text = "";
            lNameTxtBox.Text = "";
            emailTxtBox.Text = "";
            rolesDD.SelectedIndex = -1;
            userProfilePicBox.Image = null;
            userProfilePath = null;
        }
        private void addNewBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.signUpTitleLbl.Text = "Registration";
            register.linePanel.Width = 140;
            register.ShowDialog();
            PopulateGridView();
        }

        private void pictureUploadBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = userProfileOpenFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                var image = new Bitmap(userProfileOpenFileDialog.FileName);
                userProfilePicBox.Image = image;
                bool isSuccess = SaveImage(userProfileOpenFileDialog.FileName);
                if (isSuccess)
                {
                    MessageBox.Show("Picture Uploaded Successfully." , "Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sorry! Picture not Uploaded Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool SaveImage(string picturePath)
        {
            var folderPath = AppDomain.CurrentDomain.BaseDirectory + "Images";
            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            var imagePath = picturePath;
            var imageNameString = imagePath.Split('.');
            var extension = imageNameString[1];
            Guid uniqueId = Guid.NewGuid();
            var newImage = uniqueId + "." + extension;
            var fullImagePath = folderPath + "\\" + newImage;
            userProfilePath = fullImagePath;
            File.Copy(picturePath, fullImagePath);

            return true;
        }

        private void fNameTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fNameTxtBox.Text))
            {
                fnameErrorLbl.Visible = true;
            }
            else
            {
                fnameErrorLbl.Visible = false;
            }
        }

        private void lNameTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lNameTxtBox.Text))
            {
                lnameErrorLbl.Visible = true;
            }
            else
            {
                lnameErrorLbl.Visible = false;
            }
        }

        private void emailTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTxtBox.Text))
            {
                emailErrorLbl.Visible = true;
            }
            else
            {
                emailErrorLbl.Visible = false;
            }
        }

        private void usersGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                user_id = Convert.ToInt32(usersGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                fNameTxtBox.Text = usersGridView.Rows[e.RowIndex].Cells["fnameGVC"].Value.ToString();
                lNameTxtBox.Text = usersGridView.Rows[e.RowIndex].Cells["lNameGVC"].Value.ToString();
                emailTxtBox.Text = usersGridView.Rows[e.RowIndex].Cells["emailGVC"].Value.ToString();
                rolesDD.SelectedValue = Convert.ToInt32(usersGridView.Rows[e.RowIndex].Cells["roleIdGVC"].Value.ToString());
                if (usersGridView.Rows[e.RowIndex].Cells["profileImagePathGVC"].Value != null)
                {
                    userProfilePicBox.Image = new Bitmap(usersGridView.Rows[e.RowIndex].Cells["profileImagePathGVC"].Value.ToString());
                    userProfilePath = usersGridView.Rows[e.RowIndex].Cells["profileImagePathGVC"].Value.ToString();
                }
                if (usersGridView.Rows[e.RowIndex].Cells["genderGVC"].Value.ToString() == "Male")
                {
                    maleRBtn.Checked = true;
                }
                else
                {
                    femaleRBtn.Checked = true;
                }
                user.id = user_id;
                user.password = usersGridView.Rows[e.RowIndex].Cells["passwordGVC"].Value.ToString();
                EnableControls();
            }
        }

        private void usersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if(e.ColumnIndex == 1)
                {
                    DialogResult dr = MessageBox.Show("Do you want to delete this User?" , "Confirm" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        user_id = Convert.ToInt32(usersGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                        BaseViewModel result = userBll.DeleteUser(user_id);
                        if(result.isSuccess)
                        {
                            MessageBox.Show(result.message , "Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                            PopulateGridView();
                        }
                        else
                        {
                            MessageBox.Show(result.message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                        }
                    }
                }
                if(e.ColumnIndex == 0)
                {
                    user_id = Convert.ToInt32(usersGridView.Rows[e.RowIndex].Cells["idGVC"].Value.ToString());
                    fNameTxtBox.Text = usersGridView.Rows[e.RowIndex].Cells["fnameGVC"].Value.ToString();
                    lNameTxtBox.Text = usersGridView.Rows[e.RowIndex].Cells["lNameGVC"].Value.ToString();
                    emailTxtBox.Text = usersGridView.Rows[e.RowIndex].Cells["emailGVC"].Value.ToString();
                    rolesDD.SelectedValue = Convert.ToInt32(usersGridView.Rows[e.RowIndex].Cells["roleIdGVC"].Value.ToString());
                    if (usersGridView.Rows[e.RowIndex].Cells["profileImagePathGVC"].Value != null)
                    {
                        userProfilePicBox.Image = new Bitmap(usersGridView.Rows[e.RowIndex].Cells["profileImagePathGVC"].Value.ToString());
                        userProfilePath = usersGridView.Rows[e.RowIndex].Cells["profileImagePathGVC"].Value.ToString();
                    }
                    else
                    {
                        userProfilePicBox.Image = null;
                    }
                    if (usersGridView.Rows[e.RowIndex].Cells["genderGVC"].Value.ToString() == "Male")
                    {
                        maleRBtn.Checked = true;
                    }
                    else
                    {
                        femaleRBtn.Checked = true;
                    }
                    user.id = user_id;
                    user.password = usersGridView.Rows[e.RowIndex].Cells["passwordGVC"].Value.ToString();
                    EnableControls();
                }
            }
        }

        private void rolesDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rolesDD.SelectedIndex != -1)
            {
                roleErrorLbl.Visible = false;
            }
            else
            {
                roleErrorLbl.Visible = true;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
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
            if (rolesDD.SelectedIndex == -1)
            {
                roleErrorLbl.Visible = true;
            }
            if (!fnameErrorLbl.Visible && !lnameErrorLbl.Visible && !emailErrorLbl.Visible && !roleErrorLbl.Visible)
            {
                user.firstName = fNameTxtBox.Text;
                user.lastName = lNameTxtBox.Text;
                user.email = emailTxtBox.Text;
                user.gender = (maleRBtn.Checked) ? 1 : 0;
                if(userProfilePath != null)
                {
                    user.profileImagePath = userProfilePath;
                }
                user.roleId = Convert.ToInt32(rolesDD.SelectedValue);
                BaseViewModel result = userBll.UpdateUser(user);
                if(result.isSuccess)
                {
                    MessageBox.Show(result.message , "Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                    PopulateGridView();
                    ClearAllFields();
                    DisableControls();
                }
                else
                {
                    MessageBox.Show(result.message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The Fields with * are Mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchTxtBox_OnTextChange(object sender, EventArgs e)
        {
            UserRoleBaseVM result = userBll.getFilterUser(searchTxtBox.text);
            if (result.isSuccess)
            {
                usersGridView.DataSource = result.users;
            }
            else
            {
                MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
