namespace Desktop_LMS_UI
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.contentTLP = new System.Windows.Forms.TableLayoutPanel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.passwodErrrorLbl = new System.Windows.Forms.Label();
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.closePicBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.signUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.rememberMeCB = new System.Windows.Forms.CheckBox();
            this.loginBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.passwrodTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.emailTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginProfilePB = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTipLogin = new System.Windows.Forms.ToolTip(this.components);
            this.contentTLP.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginProfilePB)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contentTLP
            // 
            this.contentTLP.ColumnCount = 2;
            this.contentTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contentTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 356F));
            this.contentTLP.Controls.Add(this.rightPanel, 1, 0);
            this.contentTLP.Controls.Add(this.leftPanel, 0, 0);
            this.contentTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTLP.Location = new System.Drawing.Point(0, 0);
            this.contentTLP.Name = "contentTLP";
            this.contentTLP.RowCount = 1;
            this.contentTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contentTLP.Size = new System.Drawing.Size(801, 629);
            this.contentTLP.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.rightPanel.Controls.Add(this.passwodErrrorLbl);
            this.rightPanel.Controls.Add(this.emailErrorLabel);
            this.rightPanel.Controls.Add(this.closePicBox);
            this.rightPanel.Controls.Add(this.label2);
            this.rightPanel.Controls.Add(this.signUpLinkLabel);
            this.rightPanel.Controls.Add(this.rememberMeCB);
            this.rightPanel.Controls.Add(this.loginBtn);
            this.rightPanel.Controls.Add(this.passwrodTxtBox);
            this.rightPanel.Controls.Add(this.emailTxtBox);
            this.rightPanel.Controls.Add(this.loginProfilePB);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.ForeColor = System.Drawing.Color.White;
            this.rightPanel.Location = new System.Drawing.Point(448, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(350, 623);
            this.rightPanel.TabIndex = 1;
            // 
            // passwodErrrorLbl
            // 
            this.passwodErrrorLbl.AutoSize = true;
            this.passwodErrrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwodErrrorLbl.ForeColor = System.Drawing.Color.Red;
            this.passwodErrrorLbl.Location = new System.Drawing.Point(212, 406);
            this.passwodErrrorLbl.Name = "passwodErrrorLbl";
            this.passwodErrrorLbl.Size = new System.Drawing.Size(112, 13);
            this.passwodErrrorLbl.TabIndex = 7;
            this.passwodErrrorLbl.Text = "Password is Required.";
            this.passwodErrrorLbl.Visible = false;
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.AutoSize = true;
            this.emailErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.emailErrorLabel.Location = new System.Drawing.Point(232, 321);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(91, 13);
            this.emailErrorLabel.TabIndex = 7;
            this.emailErrorLabel.Text = "Email is Required.";
            this.emailErrorLabel.Visible = false;
            // 
            // closePicBox
            // 
            this.closePicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePicBox.Image = global::Desktop_LMS_UI.Properties.Resources.delete__1_;
            this.closePicBox.Location = new System.Drawing.Point(311, 5);
            this.closePicBox.Name = "closePicBox";
            this.closePicBox.Size = new System.Drawing.Size(36, 25);
            this.closePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closePicBox.TabIndex = 6;
            this.closePicBox.TabStop = false;
            this.closePicBox.Click += new System.EventHandler(this.onCloseClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Don\'t have an account?";
            // 
            // signUpLinkLabel
            // 
            this.signUpLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUpLinkLabel.AutoSize = true;
            this.signUpLinkLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.signUpLinkLabel.LinkColor = System.Drawing.Color.White;
            this.signUpLinkLabel.Location = new System.Drawing.Point(264, 444);
            this.signUpLinkLabel.Name = "signUpLinkLabel";
            this.signUpLinkLabel.Size = new System.Drawing.Size(56, 16);
            this.signUpLinkLabel.TabIndex = 5;
            this.signUpLinkLabel.TabStop = true;
            this.signUpLinkLabel.Text = "Sign Up";
            this.signUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.onLinkClick);
            // 
            // rememberMeCB
            // 
            this.rememberMeCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rememberMeCB.AutoSize = true;
            this.rememberMeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberMeCB.Location = new System.Drawing.Point(207, 422);
            this.rememberMeCB.Name = "rememberMeCB";
            this.rememberMeCB.Size = new System.Drawing.Size(117, 19);
            this.rememberMeCB.TabIndex = 4;
            this.rememberMeCB.Text = "Remember Me?";
            this.rememberMeCB.UseVisualStyleBackColor = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBtn.BackColor = System.Drawing.Color.Orange;
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBtn.BorderRadius = 0;
            this.loginBtn.ButtonText = "Login";
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.DisabledColor = System.Drawing.Color.Gray;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.loginBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("loginBtn.Iconimage")));
            this.loginBtn.Iconimage_right = null;
            this.loginBtn.Iconimage_right_Selected = null;
            this.loginBtn.Iconimage_Selected = null;
            this.loginBtn.IconMarginLeft = 0;
            this.loginBtn.IconMarginRight = 0;
            this.loginBtn.IconRightVisible = true;
            this.loginBtn.IconRightZoom = 0D;
            this.loginBtn.IconVisible = false;
            this.loginBtn.IconZoom = 90D;
            this.loginBtn.IsTab = false;
            this.loginBtn.Location = new System.Drawing.Point(27, 469);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Normalcolor = System.Drawing.Color.Orange;
            this.loginBtn.OnHovercolor = System.Drawing.Color.Coral;
            this.loginBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.loginBtn.selected = false;
            this.loginBtn.Size = new System.Drawing.Size(290, 46);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBtn.Textcolor = System.Drawing.Color.White;
            this.loginBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Click += new System.EventHandler(this.onLoginClick);
            // 
            // passwrodTxtBox
            // 
            this.passwrodTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwrodTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwrodTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwrodTxtBox.ForeColor = System.Drawing.Color.White;
            this.passwrodTxtBox.HintForeColor = System.Drawing.Color.White;
            this.passwrodTxtBox.HintText = "Enter Password";
            this.passwrodTxtBox.isPassword = false;
            this.passwrodTxtBox.LineFocusedColor = System.Drawing.Color.White;
            this.passwrodTxtBox.LineIdleColor = System.Drawing.Color.Silver;
            this.passwrodTxtBox.LineMouseHoverColor = System.Drawing.Color.White;
            this.passwrodTxtBox.LineThickness = 3;
            this.passwrodTxtBox.Location = new System.Drawing.Point(27, 359);
            this.passwrodTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwrodTxtBox.Name = "passwrodTxtBox";
            this.passwrodTxtBox.Size = new System.Drawing.Size(290, 44);
            this.passwrodTxtBox.TabIndex = 3;
            this.passwrodTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipLogin.SetToolTip(this.passwrodTxtBox, "Enter Your Password Here.");
            this.passwrodTxtBox.OnValueChanged += new System.EventHandler(this.passwrodTxtBox_OnValueChanged);
            this.passwrodTxtBox.Enter += new System.EventHandler(this.onFocusEnter);
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTxtBox.HintForeColor = System.Drawing.Color.White;
            this.emailTxtBox.HintText = "Enter Email";
            this.emailTxtBox.isPassword = false;
            this.emailTxtBox.LineFocusedColor = System.Drawing.Color.White;
            this.emailTxtBox.LineIdleColor = System.Drawing.Color.Silver;
            this.emailTxtBox.LineMouseHoverColor = System.Drawing.Color.White;
            this.emailTxtBox.LineThickness = 3;
            this.emailTxtBox.Location = new System.Drawing.Point(27, 273);
            this.emailTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(290, 44);
            this.emailTxtBox.TabIndex = 2;
            this.emailTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipLogin.SetToolTip(this.emailTxtBox, "Enter Your Email Here.\r\n");
            this.emailTxtBox.OnValueChanged += new System.EventHandler(this.emailTxtBox_OnValueChanged);
            // 
            // loginProfilePB
            // 
            this.loginProfilePB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginProfilePB.Image = global::Desktop_LMS_UI.Properties.Resources._2;
            this.loginProfilePB.Location = new System.Drawing.Point(97, 90);
            this.loginProfilePB.Name = "loginProfilePB";
            this.loginProfilePB.Size = new System.Drawing.Size(157, 117);
            this.loginProfilePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginProfilePB.TabIndex = 0;
            this.loginProfilePB.TabStop = false;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.appNameLabel);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.pictureBox1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(3, 3);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(439, 623);
            this.leftPanel.TabIndex = 1;
            // 
            // appNameLabel
            // 
            this.appNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Palace Script MT", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.appNameLabel.Location = new System.Drawing.Point(-8, 7);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(400, 74);
            this.appNameLabel.TabIndex = 0;
            this.appNameLabel.Text = "Desktop Library ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palace Script MT", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(70, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Desktop_LMS_UI.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolTipLogin
            // 
            this.toolTipLogin.AutoPopDelay = 5000;
            this.toolTipLogin.InitialDelay = 200;
            this.toolTipLogin.IsBalloon = true;
            this.toolTipLogin.ReshowDelay = 100;
            this.toolTipLogin.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipLogin.ToolTipTitle = "Information";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 629);
            this.Controls.Add(this.contentTLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.contentTLP.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginProfilePB)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel contentTLP;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.PictureBox loginProfilePB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailTxtBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwrodTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel signUpLinkLabel;
        private System.Windows.Forms.CheckBox rememberMeCB;
        private Bunifu.Framework.UI.BunifuFlatButton loginBtn;
        private System.Windows.Forms.PictureBox closePicBox;
        private System.Windows.Forms.Label passwodErrrorLbl;
        private System.Windows.Forms.Label emailErrorLabel;
        private System.Windows.Forms.ToolTip toolTipLogin;
    }
}

