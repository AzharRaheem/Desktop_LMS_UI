namespace Desktop_LMS_UI
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.contentTLP = new System.Windows.Forms.TableLayoutPanel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.confirmPassErrorLbl = new System.Windows.Forms.Label();
            this.passwordErrorLbl = new System.Windows.Forms.Label();
            this.emailErrorLbl = new System.Windows.Forms.Label();
            this.lnameErrorLbl = new System.Windows.Forms.Label();
            this.fnameErrorLbl = new System.Windows.Forms.Label();
            this.closePicBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.LinkLabel();
            this.linePanel = new System.Windows.Forms.Panel();
            this.signUpTitleLbl = new System.Windows.Forms.Label();
            this.signUpBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.femaleRBtn = new System.Windows.Forms.RadioButton();
            this.maleRBtn = new System.Windows.Forms.RadioButton();
            this.lNameLbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.confirmPasswordLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.confirmPasswordTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwrodTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.emailTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lNameTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.fNameTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contentTLP.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePicBox)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contentTLP
            // 
            this.contentTLP.ColumnCount = 2;
            this.contentTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contentTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 390F));
            this.contentTLP.Controls.Add(this.rightPanel, 1, 0);
            this.contentTLP.Controls.Add(this.leftPanel, 0, 0);
            this.contentTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTLP.Location = new System.Drawing.Point(0, 0);
            this.contentTLP.Name = "contentTLP";
            this.contentTLP.RowCount = 1;
            this.contentTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contentTLP.Size = new System.Drawing.Size(835, 645);
            this.contentTLP.TabIndex = 1;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.rightPanel.Controls.Add(this.confirmPassErrorLbl);
            this.rightPanel.Controls.Add(this.passwordErrorLbl);
            this.rightPanel.Controls.Add(this.emailErrorLbl);
            this.rightPanel.Controls.Add(this.lnameErrorLbl);
            this.rightPanel.Controls.Add(this.fnameErrorLbl);
            this.rightPanel.Controls.Add(this.closePicBox);
            this.rightPanel.Controls.Add(this.label3);
            this.rightPanel.Controls.Add(this.loginLabel);
            this.rightPanel.Controls.Add(this.linePanel);
            this.rightPanel.Controls.Add(this.signUpTitleLbl);
            this.rightPanel.Controls.Add(this.signUpBtn);
            this.rightPanel.Controls.Add(this.femaleRBtn);
            this.rightPanel.Controls.Add(this.maleRBtn);
            this.rightPanel.Controls.Add(this.lNameLbl);
            this.rightPanel.Controls.Add(this.genderLbl);
            this.rightPanel.Controls.Add(this.confirmPasswordLbl);
            this.rightPanel.Controls.Add(this.passwordLbl);
            this.rightPanel.Controls.Add(this.confirmPasswordTxtBox);
            this.rightPanel.Controls.Add(this.emailLabel);
            this.rightPanel.Controls.Add(this.passwrodTxtBox);
            this.rightPanel.Controls.Add(this.fNameLbl);
            this.rightPanel.Controls.Add(this.emailTxtBox);
            this.rightPanel.Controls.Add(this.lNameTxtBox);
            this.rightPanel.Controls.Add(this.fNameTxtBox);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.ForeColor = System.Drawing.Color.White;
            this.rightPanel.Location = new System.Drawing.Point(448, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(384, 639);
            this.rightPanel.TabIndex = 1;
            // 
            // confirmPassErrorLbl
            // 
            this.confirmPassErrorLbl.AutoSize = true;
            this.confirmPassErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.confirmPassErrorLbl.Location = new System.Drawing.Point(161, 347);
            this.confirmPassErrorLbl.Name = "confirmPassErrorLbl";
            this.confirmPassErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.confirmPassErrorLbl.TabIndex = 12;
            this.confirmPassErrorLbl.Text = "*";
            this.confirmPassErrorLbl.Visible = false;
            // 
            // passwordErrorLbl
            // 
            this.passwordErrorLbl.AutoSize = true;
            this.passwordErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.passwordErrorLbl.Location = new System.Drawing.Point(101, 277);
            this.passwordErrorLbl.Name = "passwordErrorLbl";
            this.passwordErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.passwordErrorLbl.TabIndex = 12;
            this.passwordErrorLbl.Text = "*";
            this.passwordErrorLbl.Visible = false;
            // 
            // emailErrorLbl
            // 
            this.emailErrorLbl.AutoSize = true;
            this.emailErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.emailErrorLbl.Location = new System.Drawing.Point(71, 208);
            this.emailErrorLbl.Name = "emailErrorLbl";
            this.emailErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.emailErrorLbl.TabIndex = 12;
            this.emailErrorLbl.Text = "*";
            this.emailErrorLbl.Visible = false;
            // 
            // lnameErrorLbl
            // 
            this.lnameErrorLbl.AutoSize = true;
            this.lnameErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.lnameErrorLbl.Location = new System.Drawing.Point(301, 137);
            this.lnameErrorLbl.Name = "lnameErrorLbl";
            this.lnameErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.lnameErrorLbl.TabIndex = 12;
            this.lnameErrorLbl.Text = "*";
            this.lnameErrorLbl.Visible = false;
            // 
            // fnameErrorLbl
            // 
            this.fnameErrorLbl.AutoSize = true;
            this.fnameErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.fnameErrorLbl.Location = new System.Drawing.Point(108, 137);
            this.fnameErrorLbl.Name = "fnameErrorLbl";
            this.fnameErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.fnameErrorLbl.TabIndex = 12;
            this.fnameErrorLbl.Text = "*";
            this.fnameErrorLbl.Visible = false;
            // 
            // closePicBox
            // 
            this.closePicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePicBox.Image = global::Desktop_LMS_UI.Properties.Resources.delete__1_;
            this.closePicBox.Location = new System.Drawing.Point(346, 4);
            this.closePicBox.Name = "closePicBox";
            this.closePicBox.Size = new System.Drawing.Size(36, 25);
            this.closePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closePicBox.TabIndex = 11;
            this.closePicBox.TabStop = false;
            this.closePicBox.Click += new System.EventHandler(this.onCloseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Already have an account?";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.loginLabel.LinkColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(326, 503);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(45, 18);
            this.loginLabel.TabIndex = 8;
            this.loginLabel.TabStop = true;
            this.loginLabel.Text = "Login";
            this.loginLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.onLinkClick);
            // 
            // linePanel
            // 
            this.linePanel.BackColor = System.Drawing.Color.White;
            this.linePanel.Location = new System.Drawing.Point(43, 113);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(83, 5);
            this.linePanel.TabIndex = 8;
            // 
            // signUpTitleLbl
            // 
            this.signUpTitleLbl.AutoSize = true;
            this.signUpTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpTitleLbl.Location = new System.Drawing.Point(18, 79);
            this.signUpTitleLbl.Name = "signUpTitleLbl";
            this.signUpTitleLbl.Size = new System.Drawing.Size(117, 31);
            this.signUpTitleLbl.TabIndex = 7;
            this.signUpTitleLbl.Text = "Sign Up";
            // 
            // signUpBtn
            // 
            this.signUpBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.signUpBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUpBtn.BackColor = System.Drawing.Color.Orange;
            this.signUpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signUpBtn.BorderRadius = 0;
            this.signUpBtn.ButtonText = "Register";
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtn.DisabledColor = System.Drawing.Color.Gray;
            this.signUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.signUpBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("signUpBtn.Iconimage")));
            this.signUpBtn.Iconimage_right = null;
            this.signUpBtn.Iconimage_right_Selected = null;
            this.signUpBtn.Iconimage_Selected = null;
            this.signUpBtn.IconMarginLeft = 0;
            this.signUpBtn.IconMarginRight = 0;
            this.signUpBtn.IconRightVisible = true;
            this.signUpBtn.IconRightZoom = 0D;
            this.signUpBtn.IconVisible = false;
            this.signUpBtn.IconZoom = 90D;
            this.signUpBtn.IsTab = false;
            this.signUpBtn.Location = new System.Drawing.Point(20, 524);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Normalcolor = System.Drawing.Color.Orange;
            this.signUpBtn.OnHovercolor = System.Drawing.Color.Coral;
            this.signUpBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.signUpBtn.selected = false;
            this.signUpBtn.Size = new System.Drawing.Size(352, 46);
            this.signUpBtn.TabIndex = 9;
            this.signUpBtn.Text = "Register";
            this.signUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUpBtn.Textcolor = System.Drawing.Color.White;
            this.signUpBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.Click += new System.EventHandler(this.onRegisterClick);
            // 
            // femaleRBtn
            // 
            this.femaleRBtn.AutoSize = true;
            this.femaleRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRBtn.Location = new System.Drawing.Point(121, 447);
            this.femaleRBtn.Name = "femaleRBtn";
            this.femaleRBtn.Size = new System.Drawing.Size(78, 20);
            this.femaleRBtn.TabIndex = 7;
            this.femaleRBtn.Text = "Female";
            this.femaleRBtn.UseVisualStyleBackColor = true;
            // 
            // maleRBtn
            // 
            this.maleRBtn.AutoSize = true;
            this.maleRBtn.Checked = true;
            this.maleRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRBtn.Location = new System.Drawing.Point(24, 447);
            this.maleRBtn.Name = "maleRBtn";
            this.maleRBtn.Size = new System.Drawing.Size(60, 20);
            this.maleRBtn.TabIndex = 6;
            this.maleRBtn.TabStop = true;
            this.maleRBtn.Text = "Male";
            this.maleRBtn.UseVisualStyleBackColor = true;
            // 
            // lNameLbl
            // 
            this.lNameLbl.AutoSize = true;
            this.lNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLbl.Location = new System.Drawing.Point(210, 142);
            this.lNameLbl.Name = "lNameLbl";
            this.lNameLbl.Size = new System.Drawing.Size(94, 20);
            this.lNameLbl.TabIndex = 1;
            this.lNameLbl.Text = "Last Name :";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.Location = new System.Drawing.Point(20, 421);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(71, 20);
            this.genderLbl.TabIndex = 1;
            this.genderLbl.Text = "Gender :";
            // 
            // confirmPasswordLbl
            // 
            this.confirmPasswordLbl.AutoSize = true;
            this.confirmPasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLbl.Location = new System.Drawing.Point(20, 351);
            this.confirmPasswordLbl.Name = "confirmPasswordLbl";
            this.confirmPasswordLbl.Size = new System.Drawing.Size(145, 20);
            this.confirmPasswordLbl.TabIndex = 1;
            this.confirmPasswordLbl.Text = "Confirm Password :";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(20, 281);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(86, 20);
            this.passwordLbl.TabIndex = 1;
            this.passwordLbl.Text = "Password :";
            // 
            // confirmPasswordTxtBox
            // 
            this.confirmPasswordTxtBox.BorderColorFocused = System.Drawing.Color.White;
            this.confirmPasswordTxtBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.confirmPasswordTxtBox.BorderColorMouseHover = System.Drawing.Color.White;
            this.confirmPasswordTxtBox.BorderThickness = 3;
            this.confirmPasswordTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPasswordTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.confirmPasswordTxtBox.ForeColor = System.Drawing.Color.White;
            this.confirmPasswordTxtBox.isPassword = true;
            this.confirmPasswordTxtBox.Location = new System.Drawing.Point(20, 372);
            this.confirmPasswordTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.confirmPasswordTxtBox.Name = "confirmPasswordTxtBox";
            this.confirmPasswordTxtBox.Size = new System.Drawing.Size(352, 38);
            this.confirmPasswordTxtBox.TabIndex = 4;
            this.confirmPasswordTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.confirmPasswordTxtBox.OnValueChanged += new System.EventHandler(this.confirmPasswordTxtBox_OnValueChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(20, 213);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(56, 20);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email :";
            // 
            // passwrodTxtBox
            // 
            this.passwrodTxtBox.BorderColorFocused = System.Drawing.Color.White;
            this.passwrodTxtBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.passwrodTxtBox.BorderColorMouseHover = System.Drawing.Color.White;
            this.passwrodTxtBox.BorderThickness = 3;
            this.passwrodTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwrodTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwrodTxtBox.ForeColor = System.Drawing.Color.White;
            this.passwrodTxtBox.isPassword = true;
            this.passwrodTxtBox.Location = new System.Drawing.Point(20, 302);
            this.passwrodTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwrodTxtBox.Name = "passwrodTxtBox";
            this.passwrodTxtBox.Size = new System.Drawing.Size(352, 38);
            this.passwrodTxtBox.TabIndex = 3;
            this.passwrodTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwrodTxtBox.OnValueChanged += new System.EventHandler(this.passwrodTxtBox_OnValueChanged);
            // 
            // fNameLbl
            // 
            this.fNameLbl.AutoSize = true;
            this.fNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLbl.Location = new System.Drawing.Point(20, 142);
            this.fNameLbl.Name = "fNameLbl";
            this.fNameLbl.Size = new System.Drawing.Size(94, 20);
            this.fNameLbl.TabIndex = 1;
            this.fNameLbl.Text = "First Name :";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.BorderColorFocused = System.Drawing.Color.White;
            this.emailTxtBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.emailTxtBox.BorderColorMouseHover = System.Drawing.Color.White;
            this.emailTxtBox.BorderThickness = 3;
            this.emailTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailTxtBox.ForeColor = System.Drawing.Color.White;
            this.emailTxtBox.isPassword = false;
            this.emailTxtBox.Location = new System.Drawing.Point(20, 234);
            this.emailTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(352, 38);
            this.emailTxtBox.TabIndex = 2;
            this.emailTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailTxtBox.OnValueChanged += new System.EventHandler(this.emailTxtBox_OnValueChanged);
            // 
            // lNameTxtBox
            // 
            this.lNameTxtBox.BorderColorFocused = System.Drawing.Color.White;
            this.lNameTxtBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.lNameTxtBox.BorderColorMouseHover = System.Drawing.Color.White;
            this.lNameTxtBox.BorderThickness = 3;
            this.lNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lNameTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lNameTxtBox.ForeColor = System.Drawing.Color.White;
            this.lNameTxtBox.isPassword = false;
            this.lNameTxtBox.Location = new System.Drawing.Point(211, 163);
            this.lNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.lNameTxtBox.Name = "lNameTxtBox";
            this.lNameTxtBox.Size = new System.Drawing.Size(161, 38);
            this.lNameTxtBox.TabIndex = 1;
            this.lNameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lNameTxtBox.OnValueChanged += new System.EventHandler(this.lNameTxtBox_OnValueChanged);
            // 
            // fNameTxtBox
            // 
            this.fNameTxtBox.BorderColorFocused = System.Drawing.Color.White;
            this.fNameTxtBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.fNameTxtBox.BorderColorMouseHover = System.Drawing.Color.White;
            this.fNameTxtBox.BorderThickness = 3;
            this.fNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fNameTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fNameTxtBox.ForeColor = System.Drawing.Color.White;
            this.fNameTxtBox.isPassword = false;
            this.fNameTxtBox.Location = new System.Drawing.Point(20, 163);
            this.fNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.fNameTxtBox.Name = "fNameTxtBox";
            this.fNameTxtBox.Size = new System.Drawing.Size(161, 38);
            this.fNameTxtBox.TabIndex = 0;
            this.fNameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fNameTxtBox.OnValueChanged += new System.EventHandler(this.fNameTxtBox_OnValueChanged);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.appNameLabel);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.pictureBox1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(3, 3);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(439, 639);
            this.leftPanel.TabIndex = 1;
            // 
            // appNameLabel
            // 
            this.appNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Palace Script MT", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.appNameLabel.Location = new System.Drawing.Point(-8, 39);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(400, 74);
            this.appNameLabel.TabIndex = 1;
            this.appNameLabel.Text = "Desktop Library ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palace Script MT", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(118, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Desktop_LMS_UI.Properties.Resources.signUp;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 645);
            this.Controls.Add(this.contentTLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.contentTLP.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePicBox)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel contentTLP;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label lNameLbl;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label confirmPasswordLbl;
        private System.Windows.Forms.Label passwordLbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox confirmPasswordTxtBox;
        private System.Windows.Forms.Label emailLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox passwrodTxtBox;
        private System.Windows.Forms.Label fNameLbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox emailTxtBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox lNameTxtBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox fNameTxtBox;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton femaleRBtn;
        private System.Windows.Forms.RadioButton maleRBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel loginLabel;
        private Bunifu.Framework.UI.BunifuFlatButton signUpBtn;
        private System.Windows.Forms.PictureBox closePicBox;
        private System.Windows.Forms.Label confirmPassErrorLbl;
        private System.Windows.Forms.Label passwordErrorLbl;
        private System.Windows.Forms.Label emailErrorLbl;
        private System.Windows.Forms.Label lnameErrorLbl;
        private System.Windows.Forms.Label fnameErrorLbl;
        public System.Windows.Forms.Label signUpTitleLbl;
        public System.Windows.Forms.Panel linePanel;
    }
}