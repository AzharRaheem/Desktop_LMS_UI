namespace Desktop_LMS_UI
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.emailErrorLbl = new System.Windows.Forms.Label();
            this.lnameErrorLbl = new System.Windows.Forms.Label();
            this.fnameErrorLbl = new System.Windows.Forms.Label();
            this.femaleRBtn = new System.Windows.Forms.RadioButton();
            this.maleRBtn = new System.Windows.Forms.RadioButton();
            this.lNameLbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.emailTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lNameTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.fNameTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.roleErrorLbl = new System.Windows.Forms.Label();
            this.updateBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.userProfilePicBox = new System.Windows.Forms.PictureBox();
            this.addNewBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.idGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileImagePathGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileImgBoxGVC = new System.Windows.Forms.DataGridViewImageColumn();
            this.fnameGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderIntGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIdGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editActionGVC = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteActionGVC = new System.Windows.Forms.DataGridViewImageColumn();
            this.searchTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.userProfileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.rolesDD = new System.Windows.Forms.ComboBox();
            this.pictureUploadBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePicBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.panel1);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(843, 46);
            this.topPanel.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(67, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 5);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Users";
            // 
            // emailErrorLbl
            // 
            this.emailErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailErrorLbl.AutoSize = true;
            this.emailErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.emailErrorLbl.Location = new System.Drawing.Point(57, 166);
            this.emailErrorLbl.Name = "emailErrorLbl";
            this.emailErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.emailErrorLbl.TabIndex = 34;
            this.emailErrorLbl.Text = "*";
            this.emailErrorLbl.Visible = false;
            // 
            // lnameErrorLbl
            // 
            this.lnameErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnameErrorLbl.AutoSize = true;
            this.lnameErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.lnameErrorLbl.Location = new System.Drawing.Point(403, 90);
            this.lnameErrorLbl.Name = "lnameErrorLbl";
            this.lnameErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.lnameErrorLbl.TabIndex = 33;
            this.lnameErrorLbl.Text = "*";
            this.lnameErrorLbl.Visible = false;
            // 
            // fnameErrorLbl
            // 
            this.fnameErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fnameErrorLbl.AutoSize = true;
            this.fnameErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.fnameErrorLbl.Location = new System.Drawing.Point(94, 90);
            this.fnameErrorLbl.Name = "fnameErrorLbl";
            this.fnameErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.fnameErrorLbl.TabIndex = 32;
            this.fnameErrorLbl.Text = "*";
            this.fnameErrorLbl.Visible = false;
            // 
            // femaleRBtn
            // 
            this.femaleRBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.femaleRBtn.AutoSize = true;
            this.femaleRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRBtn.Location = new System.Drawing.Point(107, 276);
            this.femaleRBtn.Name = "femaleRBtn";
            this.femaleRBtn.Size = new System.Drawing.Size(78, 20);
            this.femaleRBtn.TabIndex = 6;
            this.femaleRBtn.Text = "Female";
            this.femaleRBtn.UseVisualStyleBackColor = true;
            // 
            // maleRBtn
            // 
            this.maleRBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maleRBtn.AutoSize = true;
            this.maleRBtn.Checked = true;
            this.maleRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRBtn.Location = new System.Drawing.Point(10, 276);
            this.maleRBtn.Name = "maleRBtn";
            this.maleRBtn.Size = new System.Drawing.Size(60, 20);
            this.maleRBtn.TabIndex = 5;
            this.maleRBtn.TabStop = true;
            this.maleRBtn.Text = "Male";
            this.maleRBtn.UseVisualStyleBackColor = true;
            // 
            // lNameLbl
            // 
            this.lNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNameLbl.AutoSize = true;
            this.lNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLbl.Location = new System.Drawing.Point(312, 95);
            this.lNameLbl.Name = "lNameLbl";
            this.lNameLbl.Size = new System.Drawing.Size(94, 20);
            this.lNameLbl.TabIndex = 24;
            this.lNameLbl.Text = "Last Name :";
            // 
            // genderLbl
            // 
            this.genderLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.Location = new System.Drawing.Point(6, 247);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(71, 20);
            this.genderLbl.TabIndex = 23;
            this.genderLbl.Text = "Gender :";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(6, 171);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(56, 20);
            this.emailLabel.TabIndex = 19;
            this.emailLabel.Text = "Email :";
            // 
            // fNameLbl
            // 
            this.fNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fNameLbl.AutoSize = true;
            this.fNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLbl.Location = new System.Drawing.Point(6, 95);
            this.fNameLbl.Name = "fNameLbl";
            this.fNameLbl.Size = new System.Drawing.Size(94, 20);
            this.fNameLbl.TabIndex = 18;
            this.fNameLbl.Text = "First Name :";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTxtBox.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.emailTxtBox.BorderColorIdle = System.Drawing.Color.Gray;
            this.emailTxtBox.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.emailTxtBox.BorderThickness = 3;
            this.emailTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxtBox.Enabled = false;
            this.emailTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailTxtBox.ForeColor = System.Drawing.Color.Black;
            this.emailTxtBox.isPassword = false;
            this.emailTxtBox.Location = new System.Drawing.Point(6, 192);
            this.emailTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(282, 38);
            this.emailTxtBox.TabIndex = 2;
            this.emailTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailTxtBox.OnValueChanged += new System.EventHandler(this.emailTxtBox_OnValueChanged);
            // 
            // lNameTxtBox
            // 
            this.lNameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNameTxtBox.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.lNameTxtBox.BorderColorIdle = System.Drawing.Color.Gray;
            this.lNameTxtBox.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.lNameTxtBox.BorderThickness = 3;
            this.lNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lNameTxtBox.Enabled = false;
            this.lNameTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lNameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.lNameTxtBox.isPassword = false;
            this.lNameTxtBox.Location = new System.Drawing.Point(313, 116);
            this.lNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.lNameTxtBox.Name = "lNameTxtBox";
            this.lNameTxtBox.Size = new System.Drawing.Size(284, 38);
            this.lNameTxtBox.TabIndex = 1;
            this.lNameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lNameTxtBox.OnValueChanged += new System.EventHandler(this.lNameTxtBox_OnValueChanged);
            // 
            // fNameTxtBox
            // 
            this.fNameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fNameTxtBox.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.fNameTxtBox.BorderColorIdle = System.Drawing.Color.Gray;
            this.fNameTxtBox.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.fNameTxtBox.BorderThickness = 3;
            this.fNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fNameTxtBox.Enabled = false;
            this.fNameTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fNameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.fNameTxtBox.isPassword = false;
            this.fNameTxtBox.Location = new System.Drawing.Point(6, 116);
            this.fNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.fNameTxtBox.Name = "fNameTxtBox";
            this.fNameTxtBox.Size = new System.Drawing.Size(282, 38);
            this.fNameTxtBox.TabIndex = 0;
            this.fNameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fNameTxtBox.OnValueChanged += new System.EventHandler(this.fNameTxtBox_OnValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Role :";
            // 
            // roleErrorLbl
            // 
            this.roleErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleErrorLbl.AutoSize = true;
            this.roleErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.roleErrorLbl.Location = new System.Drawing.Point(362, 166);
            this.roleErrorLbl.Name = "roleErrorLbl";
            this.roleErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.roleErrorLbl.TabIndex = 37;
            this.roleErrorLbl.Text = "*";
            this.roleErrorLbl.Visible = false;
            // 
            // updateBtn
            // 
            this.updateBtn.Activecolor = System.Drawing.Color.SteelBlue;
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBtn.BorderRadius = 5;
            this.updateBtn.ButtonText = "Update";
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.DisabledColor = System.Drawing.Color.Gray;
            this.updateBtn.Enabled = false;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updateBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("updateBtn.Iconimage")));
            this.updateBtn.Iconimage_right = null;
            this.updateBtn.Iconimage_right_Selected = null;
            this.updateBtn.Iconimage_Selected = null;
            this.updateBtn.IconMarginLeft = 0;
            this.updateBtn.IconMarginRight = 0;
            this.updateBtn.IconRightVisible = true;
            this.updateBtn.IconRightZoom = 0D;
            this.updateBtn.IconVisible = false;
            this.updateBtn.IconZoom = 45D;
            this.updateBtn.IsTab = false;
            this.updateBtn.Location = new System.Drawing.Point(492, 263);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.updateBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.updateBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updateBtn.selected = false;
            this.updateBtn.Size = new System.Drawing.Size(104, 40);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update";
            this.updateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateBtn.Textcolor = System.Drawing.Color.White;
            this.updateBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // userProfilePicBox
            // 
            this.userProfilePicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userProfilePicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userProfilePicBox.Location = new System.Drawing.Point(607, 97);
            this.userProfilePicBox.Name = "userProfilePicBox";
            this.userProfilePicBox.Size = new System.Drawing.Size(88, 95);
            this.userProfilePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userProfilePicBox.TabIndex = 45;
            this.userProfilePicBox.TabStop = false;
            // 
            // addNewBtn
            // 
            this.addNewBtn.Activecolor = System.Drawing.Color.SteelBlue;
            this.addNewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.addNewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addNewBtn.BorderRadius = 5;
            this.addNewBtn.ButtonText = "Add New";
            this.addNewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addNewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addNewBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("addNewBtn.Iconimage")));
            this.addNewBtn.Iconimage_right = null;
            this.addNewBtn.Iconimage_right_Selected = null;
            this.addNewBtn.Iconimage_Selected = null;
            this.addNewBtn.IconMarginLeft = 0;
            this.addNewBtn.IconMarginRight = 0;
            this.addNewBtn.IconRightVisible = true;
            this.addNewBtn.IconRightZoom = 0D;
            this.addNewBtn.IconVisible = true;
            this.addNewBtn.IconZoom = 45D;
            this.addNewBtn.IsTab = false;
            this.addNewBtn.Location = new System.Drawing.Point(729, 52);
            this.addNewBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.addNewBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.addNewBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addNewBtn.selected = false;
            this.addNewBtn.Size = new System.Drawing.Size(104, 33);
            this.addNewBtn.TabIndex = 46;
            this.addNewBtn.Text = "Add New";
            this.addNewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewBtn.Textcolor = System.Drawing.Color.White;
            this.addNewBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.usersGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 295);
            this.panel2.TabIndex = 48;
            // 
            // usersGridView
            // 
            this.usersGridView.AllowUserToAddRows = false;
            this.usersGridView.AllowUserToDeleteRows = false;
            this.usersGridView.AllowUserToResizeColumns = false;
            this.usersGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGVC,
            this.profileImagePathGVC,
            this.profileImgBoxGVC,
            this.fnameGVC,
            this.lNameGVC,
            this.emailGVC,
            this.passwordGVC,
            this.genderIntGVC,
            this.genderGVC,
            this.roleNameGVC,
            this.roleIdGVC,
            this.editActionGVC,
            this.deleteActionGVC});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.usersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersGridView.EnableHeadersVisualStyles = false;
            this.usersGridView.Location = new System.Drawing.Point(0, 0);
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.ReadOnly = true;
            this.usersGridView.RowHeadersVisible = false;
            this.usersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.usersGridView.RowTemplate.Height = 28;
            this.usersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersGridView.Size = new System.Drawing.Size(843, 295);
            this.usersGridView.TabIndex = 25;
            this.usersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGridView_CellContentClick);
            this.usersGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGridView_CellDoubleClick);
            // 
            // idGVC
            // 
            this.idGVC.DataPropertyName = "id";
            this.idGVC.HeaderText = "Id";
            this.idGVC.Name = "idGVC";
            this.idGVC.ReadOnly = true;
            this.idGVC.Visible = false;
            // 
            // profileImagePathGVC
            // 
            this.profileImagePathGVC.DataPropertyName = "profileImagePath";
            this.profileImagePathGVC.HeaderText = "Profile Image Path";
            this.profileImagePathGVC.Name = "profileImagePathGVC";
            this.profileImagePathGVC.ReadOnly = true;
            this.profileImagePathGVC.Visible = false;
            // 
            // profileImgBoxGVC
            // 
            this.profileImgBoxGVC.DataPropertyName = "profileImage";
            this.profileImgBoxGVC.FillWeight = 40.60914F;
            this.profileImgBoxGVC.HeaderText = "Profile";
            this.profileImgBoxGVC.Image = global::Desktop_LMS_UI.Properties.Resources.profile;
            this.profileImgBoxGVC.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.profileImgBoxGVC.Name = "profileImgBoxGVC";
            this.profileImgBoxGVC.ReadOnly = true;
            this.profileImgBoxGVC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.profileImgBoxGVC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // fnameGVC
            // 
            this.fnameGVC.DataPropertyName = "firstName";
            this.fnameGVC.FillWeight = 133.5862F;
            this.fnameGVC.HeaderText = "First Name";
            this.fnameGVC.Name = "fnameGVC";
            this.fnameGVC.ReadOnly = true;
            // 
            // lNameGVC
            // 
            this.lNameGVC.DataPropertyName = "lastName";
            this.lNameGVC.FillWeight = 133.5862F;
            this.lNameGVC.HeaderText = "Last Name";
            this.lNameGVC.Name = "lNameGVC";
            this.lNameGVC.ReadOnly = true;
            // 
            // emailGVC
            // 
            this.emailGVC.DataPropertyName = "email";
            this.emailGVC.FillWeight = 133.5862F;
            this.emailGVC.HeaderText = "Email";
            this.emailGVC.Name = "emailGVC";
            this.emailGVC.ReadOnly = true;
            // 
            // passwordGVC
            // 
            this.passwordGVC.DataPropertyName = "password";
            this.passwordGVC.HeaderText = "Password";
            this.passwordGVC.Name = "passwordGVC";
            this.passwordGVC.ReadOnly = true;
            this.passwordGVC.Visible = false;
            // 
            // genderIntGVC
            // 
            this.genderIntGVC.DataPropertyName = "gender";
            this.genderIntGVC.HeaderText = "Gender Int Value";
            this.genderIntGVC.Name = "genderIntGVC";
            this.genderIntGVC.ReadOnly = true;
            this.genderIntGVC.Visible = false;
            // 
            // genderGVC
            // 
            this.genderGVC.DataPropertyName = "genderString";
            this.genderGVC.FillWeight = 133.5862F;
            this.genderGVC.HeaderText = "Gender";
            this.genderGVC.Name = "genderGVC";
            this.genderGVC.ReadOnly = true;
            // 
            // roleNameGVC
            // 
            this.roleNameGVC.DataPropertyName = "roleName";
            this.roleNameGVC.FillWeight = 133.5862F;
            this.roleNameGVC.HeaderText = "Role";
            this.roleNameGVC.Name = "roleNameGVC";
            this.roleNameGVC.ReadOnly = true;
            // 
            // roleIdGVC
            // 
            this.roleIdGVC.DataPropertyName = "roleId";
            this.roleIdGVC.HeaderText = "Role ID";
            this.roleIdGVC.Name = "roleIdGVC";
            this.roleIdGVC.ReadOnly = true;
            this.roleIdGVC.Visible = false;
            // 
            // editActionGVC
            // 
            this.editActionGVC.FillWeight = 45.45039F;
            this.editActionGVC.HeaderText = "Edit";
            this.editActionGVC.Image = ((System.Drawing.Image)(resources.GetObject("editActionGVC.Image")));
            this.editActionGVC.Name = "editActionGVC";
            this.editActionGVC.ReadOnly = true;
            // 
            // deleteActionGVC
            // 
            this.deleteActionGVC.FillWeight = 46.00936F;
            this.deleteActionGVC.HeaderText = "Delete";
            this.deleteActionGVC.Image = ((System.Drawing.Image)(resources.GetObject("deleteActionGVC.Image")));
            this.deleteActionGVC.Name = "deleteActionGVC";
            this.deleteActionGVC.ReadOnly = true;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTxtBox.BackColor = System.Drawing.Color.SteelBlue;
            this.searchTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTxtBox.BackgroundImage")));
            this.searchTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchTxtBox.ForeColor = System.Drawing.Color.White;
            this.searchTxtBox.Icon = ((System.Drawing.Image)(resources.GetObject("searchTxtBox.Icon")));
            this.searchTxtBox.Location = new System.Drawing.Point(613, 343);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(220, 30);
            this.searchTxtBox.TabIndex = 48;
            this.searchTxtBox.text = "";
            this.searchTxtBox.OnTextChange += new System.EventHandler(this.searchTxtBox_OnTextChange);
            // 
            // userProfileOpenFileDialog
            // 
            this.userProfileOpenFileDialog.FileName = "Select Profile Image";
            this.userProfileOpenFileDialog.Filter = "(*.jpeg; *.png; *.jpg;) | *.jpeg; *.png; *.jpg;";
            // 
            // rolesDD
            // 
            this.rolesDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rolesDD.BackColor = System.Drawing.Color.Gray;
            this.rolesDD.Enabled = false;
            this.rolesDD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rolesDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolesDD.ForeColor = System.Drawing.Color.White;
            this.rolesDD.FormattingEnabled = true;
            this.rolesDD.Location = new System.Drawing.Point(313, 194);
            this.rolesDD.Name = "rolesDD";
            this.rolesDD.Size = new System.Drawing.Size(283, 32);
            this.rolesDD.TabIndex = 3;
            this.rolesDD.SelectedIndexChanged += new System.EventHandler(this.rolesDD_SelectedIndexChanged);
            // 
            // pictureUploadBtn
            // 
            this.pictureUploadBtn.Activecolor = System.Drawing.Color.SteelBlue;
            this.pictureUploadBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureUploadBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureUploadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureUploadBtn.BorderRadius = 0;
            this.pictureUploadBtn.ButtonText = "Browse..";
            this.pictureUploadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureUploadBtn.DisabledColor = System.Drawing.Color.Gray;
            this.pictureUploadBtn.Enabled = false;
            this.pictureUploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureUploadBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.pictureUploadBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("pictureUploadBtn.Iconimage")));
            this.pictureUploadBtn.Iconimage_right = null;
            this.pictureUploadBtn.Iconimage_right_Selected = null;
            this.pictureUploadBtn.Iconimage_Selected = null;
            this.pictureUploadBtn.IconMarginLeft = 0;
            this.pictureUploadBtn.IconMarginRight = 0;
            this.pictureUploadBtn.IconRightVisible = true;
            this.pictureUploadBtn.IconRightZoom = 0D;
            this.pictureUploadBtn.IconVisible = false;
            this.pictureUploadBtn.IconZoom = 90D;
            this.pictureUploadBtn.IsTab = false;
            this.pictureUploadBtn.Location = new System.Drawing.Point(608, 194);
            this.pictureUploadBtn.Name = "pictureUploadBtn";
            this.pictureUploadBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.pictureUploadBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.pictureUploadBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.pictureUploadBtn.selected = false;
            this.pictureUploadBtn.Size = new System.Drawing.Size(88, 33);
            this.pictureUploadBtn.TabIndex = 4;
            this.pictureUploadBtn.Text = "Browse..";
            this.pictureUploadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pictureUploadBtn.Textcolor = System.Drawing.Color.White;
            this.pictureUploadBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureUploadBtn.Click += new System.EventHandler(this.pictureUploadBtn_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 674);
            this.Controls.Add(this.rolesDD);
            this.Controls.Add(this.pictureUploadBtn);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.userProfilePicBox);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.roleErrorLbl);
            this.Controls.Add(this.emailErrorLbl);
            this.Controls.Add(this.lnameErrorLbl);
            this.Controls.Add(this.fnameErrorLbl);
            this.Controls.Add(this.femaleRBtn);
            this.Controls.Add(this.maleRBtn);
            this.Controls.Add(this.lNameLbl);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.fNameLbl);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.lNameTxtBox);
            this.Controls.Add(this.fNameTxtBox);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePicBox)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emailErrorLbl;
        private System.Windows.Forms.Label lnameErrorLbl;
        private System.Windows.Forms.Label fnameErrorLbl;
        private System.Windows.Forms.RadioButton femaleRBtn;
        private System.Windows.Forms.RadioButton maleRBtn;
        private System.Windows.Forms.Label lNameLbl;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label fNameLbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox emailTxtBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox lNameTxtBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox fNameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label roleErrorLbl;
        private Bunifu.Framework.UI.BunifuFlatButton updateBtn;
        private System.Windows.Forms.PictureBox userProfilePicBox;
        private Bunifu.Framework.UI.BunifuFlatButton addNewBtn;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTextbox searchTxtBox;
        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.OpenFileDialog userProfileOpenFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileImagePathGVC;
        private System.Windows.Forms.DataGridViewImageColumn profileImgBoxGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderIntGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIdGVC;
        private System.Windows.Forms.DataGridViewImageColumn editActionGVC;
        private System.Windows.Forms.DataGridViewImageColumn deleteActionGVC;
        private System.Windows.Forms.ComboBox rolesDD;
        private Bunifu.Framework.UI.BunifuFlatButton pictureUploadBtn;
    }
}