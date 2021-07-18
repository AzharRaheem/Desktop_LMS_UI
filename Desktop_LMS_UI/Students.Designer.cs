namespace Desktop_LMS_UI
{
    partial class Students
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.topPanel = new System.Windows.Forms.Panel();
            this.linePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.publisherlbl = new System.Windows.Forms.Label();
            this.barcodeLbl = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.addressTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bookPriceLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bookNameLbl = new System.Windows.Forms.Label();
            this.studentNameTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.maleRB = new System.Windows.Forms.RadioButton();
            this.femaleRB = new System.Windows.Forms.RadioButton();
            this.cnicTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.contactTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.studentsGridView = new System.Windows.Forms.DataGridView();
            this.idGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentImagePathGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentImgBoxGVC = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnicGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIdGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderValueGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderTextGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editActionGVC = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteActionGVC = new System.Windows.Forms.DataGridViewImageColumn();
            this.searchTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.saveBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.studentPicBox = new System.Windows.Forms.PictureBox();
            this.addNewBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fatherNameTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.departmentsDD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uploadBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.studentNameErrorLbl = new System.Windows.Forms.Label();
            this.contactErrorLbl = new System.Windows.Forms.Label();
            this.departmentErrorLbl = new System.Windows.Forms.Label();
            this.addressErrorLbl = new System.Windows.Forms.Label();
            this.emailErrorLbl = new System.Windows.Forms.Label();
            this.cnicErrorLbl = new System.Windows.Forms.Label();
            this.fatherNameErrorLbl = new System.Windows.Forms.Label();
            this.dobDateTimePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.studentImageOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.linePanel);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(809, 46);
            this.topPanel.TabIndex = 13;
            // 
            // linePanel
            // 
            this.linePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linePanel.Location = new System.Drawing.Point(108, 27);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(684, 5);
            this.linePanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Gender : ";
            // 
            // publisherlbl
            // 
            this.publisherlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.publisherlbl.AutoSize = true;
            this.publisherlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherlbl.Location = new System.Drawing.Point(322, 148);
            this.publisherlbl.Name = "publisherlbl";
            this.publisherlbl.Size = new System.Drawing.Size(45, 16);
            this.publisherlbl.TabIndex = 24;
            this.publisherlbl.Text = "CNIC :";
            // 
            // barcodeLbl
            // 
            this.barcodeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barcodeLbl.AutoSize = true;
            this.barcodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeLbl.Location = new System.Drawing.Point(324, 207);
            this.barcodeLbl.Name = "barcodeLbl";
            this.barcodeLbl.Size = new System.Drawing.Size(68, 16);
            this.barcodeLbl.TabIndex = 25;
            this.barcodeLbl.Text = "Address : ";
            // 
            // categoryLbl
            // 
            this.categoryLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.Location = new System.Drawing.Point(322, 81);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(95, 16);
            this.categoryLbl.TabIndex = 26;
            this.categoryLbl.Text = "Father Name : ";
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTxtBox.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.addressTxtBox.BorderColorIdle = System.Drawing.Color.DimGray;
            this.addressTxtBox.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.addressTxtBox.BorderThickness = 3;
            this.addressTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTxtBox.Enabled = false;
            this.addressTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.addressTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addressTxtBox.isPassword = false;
            this.addressTxtBox.Location = new System.Drawing.Point(324, 227);
            this.addressTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(273, 40);
            this.addressTxtBox.TabIndex = 4;
            this.addressTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addressTxtBox.OnValueChanged += new System.EventHandler(this.addressTxtBox_OnValueChanged);
            // 
            // bookPriceLbl
            // 
            this.bookPriceLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookPriceLbl.AutoSize = true;
            this.bookPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookPriceLbl.Location = new System.Drawing.Point(10, 273);
            this.bookPriceLbl.Name = "bookPriceLbl";
            this.bookPriceLbl.Size = new System.Drawing.Size(62, 16);
            this.bookPriceLbl.TabIndex = 27;
            this.bookPriceLbl.Text = "Contact : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "DOB : ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Email : ";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTxtBox.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.emailTxtBox.BorderColorIdle = System.Drawing.Color.DimGray;
            this.emailTxtBox.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.emailTxtBox.BorderThickness = 3;
            this.emailTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxtBox.Enabled = false;
            this.emailTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTxtBox.isPassword = false;
            this.emailTxtBox.Location = new System.Drawing.Point(10, 227);
            this.emailTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(278, 40);
            this.emailTxtBox.TabIndex = 3;
            this.emailTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailTxtBox.OnValueChanged += new System.EventHandler(this.emailTxtBox_OnValueChanged);
            // 
            // bookNameLbl
            // 
            this.bookNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookNameLbl.AutoSize = true;
            this.bookNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameLbl.Location = new System.Drawing.Point(8, 81);
            this.bookNameLbl.Name = "bookNameLbl";
            this.bookNameLbl.Size = new System.Drawing.Size(102, 16);
            this.bookNameLbl.TabIndex = 30;
            this.bookNameLbl.Text = "Student Name : ";
            // 
            // studentNameTxtBox
            // 
            this.studentNameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentNameTxtBox.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.studentNameTxtBox.BorderColorIdle = System.Drawing.Color.DimGray;
            this.studentNameTxtBox.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.studentNameTxtBox.BorderThickness = 3;
            this.studentNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentNameTxtBox.Enabled = false;
            this.studentNameTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.studentNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.studentNameTxtBox.isPassword = false;
            this.studentNameTxtBox.Location = new System.Drawing.Point(10, 99);
            this.studentNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.studentNameTxtBox.Name = "studentNameTxtBox";
            this.studentNameTxtBox.Size = new System.Drawing.Size(278, 40);
            this.studentNameTxtBox.TabIndex = 0;
            this.studentNameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.studentNameTxtBox.OnValueChanged += new System.EventHandler(this.studentNameTxtBox_OnValueChanged);
            // 
            // maleRB
            // 
            this.maleRB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maleRB.AutoSize = true;
            this.maleRB.Checked = true;
            this.maleRB.Enabled = false;
            this.maleRB.Location = new System.Drawing.Point(16, 357);
            this.maleRB.Name = "maleRB";
            this.maleRB.Size = new System.Drawing.Size(48, 17);
            this.maleRB.TabIndex = 8;
            this.maleRB.TabStop = true;
            this.maleRB.Text = "Male";
            this.maleRB.UseVisualStyleBackColor = true;
            // 
            // femaleRB
            // 
            this.femaleRB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.femaleRB.AutoSize = true;
            this.femaleRB.Enabled = false;
            this.femaleRB.Location = new System.Drawing.Point(97, 357);
            this.femaleRB.Name = "femaleRB";
            this.femaleRB.Size = new System.Drawing.Size(62, 17);
            this.femaleRB.TabIndex = 9;
            this.femaleRB.Text = "Female ";
            this.femaleRB.UseVisualStyleBackColor = true;
            // 
            // cnicTxtBox
            // 
            this.cnicTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cnicTxtBox.BackColor = System.Drawing.Color.Gray;
            this.cnicTxtBox.Enabled = false;
            this.cnicTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cnicTxtBox.ForeColor = System.Drawing.Color.White;
            this.cnicTxtBox.Location = new System.Drawing.Point(326, 168);
            this.cnicTxtBox.Mask = "00000-0000000-0";
            this.cnicTxtBox.Name = "cnicTxtBox";
            this.cnicTxtBox.Size = new System.Drawing.Size(270, 29);
            this.cnicTxtBox.TabIndex = 2;
            this.cnicTxtBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cnicTxtBox_MaskInputRejected);
            // 
            // contactTxtBox
            // 
            this.contactTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactTxtBox.BackColor = System.Drawing.Color.Gray;
            this.contactTxtBox.Enabled = false;
            this.contactTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.contactTxtBox.ForeColor = System.Drawing.Color.White;
            this.contactTxtBox.Location = new System.Drawing.Point(13, 296);
            this.contactTxtBox.Mask = "0000-0000000";
            this.contactTxtBox.Name = "contactTxtBox";
            this.contactTxtBox.Size = new System.Drawing.Size(275, 29);
            this.contactTxtBox.TabIndex = 6;
            this.contactTxtBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.contactTxtBox_MaskInputRejected);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.studentsGridView);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 446);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(809, 233);
            this.bottomPanel.TabIndex = 38;
            // 
            // studentsGridView
            // 
            this.studentsGridView.AllowUserToAddRows = false;
            this.studentsGridView.AllowUserToDeleteRows = false;
            this.studentsGridView.AllowUserToResizeColumns = false;
            this.studentsGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studentsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentsGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGVC,
            this.studentImagePathGVC,
            this.studentImgBoxGVC,
            this.nameGVC,
            this.fatherNameGVC,
            this.dobGVC,
            this.cnicGVC,
            this.emailGVC,
            this.addressGVC,
            this.contactGVC,
            this.departmentIdGVC,
            this.departmentNameGVC,
            this.genderValueGVC,
            this.genderTextGVC,
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
            this.studentsGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.studentsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsGridView.EnableHeadersVisualStyles = false;
            this.studentsGridView.Location = new System.Drawing.Point(0, 0);
            this.studentsGridView.Name = "studentsGridView";
            this.studentsGridView.ReadOnly = true;
            this.studentsGridView.RowHeadersVisible = false;
            this.studentsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.studentsGridView.RowTemplate.Height = 28;
            this.studentsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsGridView.Size = new System.Drawing.Size(809, 233);
            this.studentsGridView.TabIndex = 26;
            this.studentsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsGridView_CellContentClick);
            this.studentsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsGridView_CellDoubleClick);
            // 
            // idGVC
            // 
            this.idGVC.DataPropertyName = "id";
            this.idGVC.HeaderText = "Id";
            this.idGVC.Name = "idGVC";
            this.idGVC.ReadOnly = true;
            this.idGVC.Visible = false;
            // 
            // studentImagePathGVC
            // 
            this.studentImagePathGVC.DataPropertyName = "studentImagePath";
            this.studentImagePathGVC.HeaderText = "Profile Image Path";
            this.studentImagePathGVC.Name = "studentImagePathGVC";
            this.studentImagePathGVC.ReadOnly = true;
            this.studentImagePathGVC.Visible = false;
            // 
            // studentImgBoxGVC
            // 
            this.studentImgBoxGVC.DataPropertyName = "studentImage";
            this.studentImgBoxGVC.FillWeight = 59.39875F;
            this.studentImgBoxGVC.HeaderText = "Profile";
            this.studentImgBoxGVC.Image = global::Desktop_LMS_UI.Properties.Resources.profile;
            this.studentImgBoxGVC.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.studentImgBoxGVC.Name = "studentImgBoxGVC";
            this.studentImgBoxGVC.ReadOnly = true;
            this.studentImgBoxGVC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.studentImgBoxGVC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // nameGVC
            // 
            this.nameGVC.DataPropertyName = "name";
            this.nameGVC.FillWeight = 134.3639F;
            this.nameGVC.HeaderText = "Student Name";
            this.nameGVC.Name = "nameGVC";
            this.nameGVC.ReadOnly = true;
            // 
            // fatherNameGVC
            // 
            this.fatherNameGVC.DataPropertyName = "fatherName";
            this.fatherNameGVC.FillWeight = 134.3639F;
            this.fatherNameGVC.HeaderText = "Father\'s Name";
            this.fatherNameGVC.Name = "fatherNameGVC";
            this.fatherNameGVC.ReadOnly = true;
            // 
            // dobGVC
            // 
            this.dobGVC.DataPropertyName = "dob";
            this.dobGVC.FillWeight = 100.5822F;
            this.dobGVC.HeaderText = "DOB";
            this.dobGVC.Name = "dobGVC";
            this.dobGVC.ReadOnly = true;
            // 
            // cnicGVC
            // 
            this.cnicGVC.DataPropertyName = "cnic";
            this.cnicGVC.FillWeight = 100.5822F;
            this.cnicGVC.HeaderText = "CNIC";
            this.cnicGVC.Name = "cnicGVC";
            this.cnicGVC.ReadOnly = true;
            // 
            // emailGVC
            // 
            this.emailGVC.DataPropertyName = "email";
            this.emailGVC.FillWeight = 134.3639F;
            this.emailGVC.HeaderText = "Email";
            this.emailGVC.Name = "emailGVC";
            this.emailGVC.ReadOnly = true;
            // 
            // addressGVC
            // 
            this.addressGVC.DataPropertyName = "address";
            this.addressGVC.FillWeight = 100.5822F;
            this.addressGVC.HeaderText = "Address";
            this.addressGVC.Name = "addressGVC";
            this.addressGVC.ReadOnly = true;
            // 
            // contactGVC
            // 
            this.contactGVC.DataPropertyName = "contact";
            this.contactGVC.FillWeight = 100.5822F;
            this.contactGVC.HeaderText = "Contact";
            this.contactGVC.Name = "contactGVC";
            this.contactGVC.ReadOnly = true;
            // 
            // departmentIdGVC
            // 
            this.departmentIdGVC.DataPropertyName = "departmentId";
            this.departmentIdGVC.HeaderText = "Department ID";
            this.departmentIdGVC.Name = "departmentIdGVC";
            this.departmentIdGVC.ReadOnly = true;
            this.departmentIdGVC.Visible = false;
            // 
            // departmentNameGVC
            // 
            this.departmentNameGVC.DataPropertyName = "departmentName";
            this.departmentNameGVC.FillWeight = 100.5822F;
            this.departmentNameGVC.HeaderText = "Department";
            this.departmentNameGVC.Name = "departmentNameGVC";
            this.departmentNameGVC.ReadOnly = true;
            // 
            // genderValueGVC
            // 
            this.genderValueGVC.DataPropertyName = "genderValue";
            this.genderValueGVC.HeaderText = "Gender Value";
            this.genderValueGVC.Name = "genderValueGVC";
            this.genderValueGVC.ReadOnly = true;
            this.genderValueGVC.Visible = false;
            // 
            // genderTextGVC
            // 
            this.genderTextGVC.DataPropertyName = "genderText";
            this.genderTextGVC.FillWeight = 63.25433F;
            this.genderTextGVC.HeaderText = "Gender";
            this.genderTextGVC.Name = "genderTextGVC";
            this.genderTextGVC.ReadOnly = true;
            // 
            // editActionGVC
            // 
            this.editActionGVC.FillWeight = 45.71498F;
            this.editActionGVC.HeaderText = "Edit";
            this.editActionGVC.Image = ((System.Drawing.Image)(resources.GetObject("editActionGVC.Image")));
            this.editActionGVC.Name = "editActionGVC";
            this.editActionGVC.ReadOnly = true;
            // 
            // deleteActionGVC
            // 
            this.deleteActionGVC.FillWeight = 58.45696F;
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
            this.searchTxtBox.Location = new System.Drawing.Point(572, 410);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(220, 30);
            this.searchTxtBox.TabIndex = 11;
            this.searchTxtBox.text = "";
            this.searchTxtBox.OnTextChange += new System.EventHandler(this.searchTxtBox_OnTextChange);
            // 
            // saveBtn
            // 
            this.saveBtn.Activecolor = System.Drawing.Color.SteelBlue;
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.BorderRadius = 5;
            this.saveBtn.ButtonText = "Save";
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.DisabledColor = System.Drawing.Color.Gray;
            this.saveBtn.Enabled = false;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.saveBtn.Iconimage = global::Desktop_LMS_UI.Properties.Resources.plus;
            this.saveBtn.Iconimage_right = null;
            this.saveBtn.Iconimage_right_Selected = null;
            this.saveBtn.Iconimage_Selected = null;
            this.saveBtn.IconMarginLeft = 0;
            this.saveBtn.IconMarginRight = 0;
            this.saveBtn.IconRightVisible = true;
            this.saveBtn.IconRightZoom = 0D;
            this.saveBtn.IconVisible = false;
            this.saveBtn.IconZoom = 45D;
            this.saveBtn.IsTab = false;
            this.saveBtn.Location = new System.Drawing.Point(465, 335);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.saveBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.saveBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.saveBtn.selected = false;
            this.saveBtn.Size = new System.Drawing.Size(136, 40);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBtn.Textcolor = System.Drawing.Color.White;
            this.saveBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // studentPicBox
            // 
            this.studentPicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentPicBox.Location = new System.Drawing.Point(609, 101);
            this.studentPicBox.Name = "studentPicBox";
            this.studentPicBox.Size = new System.Drawing.Size(88, 95);
            this.studentPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studentPicBox.TabIndex = 35;
            this.studentPicBox.TabStop = false;
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
            this.addNewBtn.Iconimage = global::Desktop_LMS_UI.Properties.Resources.plus;
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
            this.addNewBtn.Location = new System.Drawing.Point(688, 52);
            this.addNewBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.addNewBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.addNewBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addNewBtn.selected = false;
            this.addNewBtn.Size = new System.Drawing.Size(104, 33);
            this.addNewBtn.TabIndex = 14;
            this.addNewBtn.Text = "Add New";
            this.addNewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewBtn.Textcolor = System.Drawing.Color.White;
            this.addNewBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // fatherNameTxtBox
            // 
            this.fatherNameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fatherNameTxtBox.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.fatherNameTxtBox.BorderColorIdle = System.Drawing.Color.DimGray;
            this.fatherNameTxtBox.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.fatherNameTxtBox.BorderThickness = 3;
            this.fatherNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fatherNameTxtBox.Enabled = false;
            this.fatherNameTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fatherNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fatherNameTxtBox.isPassword = false;
            this.fatherNameTxtBox.Location = new System.Drawing.Point(323, 98);
            this.fatherNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.fatherNameTxtBox.Name = "fatherNameTxtBox";
            this.fatherNameTxtBox.Size = new System.Drawing.Size(278, 40);
            this.fatherNameTxtBox.TabIndex = 15;
            this.fatherNameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fatherNameTxtBox.OnValueChanged += new System.EventHandler(this.fatherNameTxtBox_OnValueChanged);
            // 
            // departmentsDD
            // 
            this.departmentsDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.departmentsDD.BackColor = System.Drawing.Color.Gray;
            this.departmentsDD.Enabled = false;
            this.departmentsDD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.departmentsDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentsDD.ForeColor = System.Drawing.Color.White;
            this.departmentsDD.FormattingEnabled = true;
            this.departmentsDD.Location = new System.Drawing.Point(327, 293);
            this.departmentsDD.Name = "departmentsDD";
            this.departmentsDD.Size = new System.Drawing.Size(274, 32);
            this.departmentsDD.TabIndex = 7;
            this.departmentsDD.SelectedIndexChanged += new System.EventHandler(this.departmentsDD_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Department :";
            // 
            // uploadBtn
            // 
            this.uploadBtn.Activecolor = System.Drawing.Color.SteelBlue;
            this.uploadBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uploadBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.uploadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uploadBtn.BorderRadius = 0;
            this.uploadBtn.ButtonText = "Browse..";
            this.uploadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadBtn.DisabledColor = System.Drawing.Color.Gray;
            this.uploadBtn.Enabled = false;
            this.uploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.uploadBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("uploadBtn.Iconimage")));
            this.uploadBtn.Iconimage_right = null;
            this.uploadBtn.Iconimage_right_Selected = null;
            this.uploadBtn.Iconimage_Selected = null;
            this.uploadBtn.IconMarginLeft = 0;
            this.uploadBtn.IconMarginRight = 0;
            this.uploadBtn.IconRightVisible = true;
            this.uploadBtn.IconRightZoom = 0D;
            this.uploadBtn.IconVisible = false;
            this.uploadBtn.IconZoom = 90D;
            this.uploadBtn.IsTab = false;
            this.uploadBtn.Location = new System.Drawing.Point(609, 199);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.uploadBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.uploadBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.uploadBtn.selected = false;
            this.uploadBtn.Size = new System.Drawing.Size(88, 33);
            this.uploadBtn.TabIndex = 5;
            this.uploadBtn.Text = "Browse..";
            this.uploadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uploadBtn.Textcolor = System.Drawing.Color.White;
            this.uploadBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // studentNameErrorLbl
            // 
            this.studentNameErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentNameErrorLbl.AutoSize = true;
            this.studentNameErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.studentNameErrorLbl.Location = new System.Drawing.Point(103, 76);
            this.studentNameErrorLbl.Name = "studentNameErrorLbl";
            this.studentNameErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.studentNameErrorLbl.TabIndex = 54;
            this.studentNameErrorLbl.Text = "*";
            this.studentNameErrorLbl.Visible = false;
            // 
            // contactErrorLbl
            // 
            this.contactErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactErrorLbl.AutoSize = true;
            this.contactErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.contactErrorLbl.Location = new System.Drawing.Point(65, 270);
            this.contactErrorLbl.Name = "contactErrorLbl";
            this.contactErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.contactErrorLbl.TabIndex = 55;
            this.contactErrorLbl.Text = "*";
            this.contactErrorLbl.Visible = false;
            // 
            // departmentErrorLbl
            // 
            this.departmentErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.departmentErrorLbl.AutoSize = true;
            this.departmentErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.departmentErrorLbl.Location = new System.Drawing.Point(404, 269);
            this.departmentErrorLbl.Name = "departmentErrorLbl";
            this.departmentErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.departmentErrorLbl.TabIndex = 56;
            this.departmentErrorLbl.Text = "*";
            this.departmentErrorLbl.Visible = false;
            // 
            // addressErrorLbl
            // 
            this.addressErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressErrorLbl.AutoSize = true;
            this.addressErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.addressErrorLbl.Location = new System.Drawing.Point(386, 205);
            this.addressErrorLbl.Name = "addressErrorLbl";
            this.addressErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.addressErrorLbl.TabIndex = 57;
            this.addressErrorLbl.Text = "*";
            this.addressErrorLbl.Visible = false;
            // 
            // emailErrorLbl
            // 
            this.emailErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailErrorLbl.AutoSize = true;
            this.emailErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.emailErrorLbl.Location = new System.Drawing.Point(55, 205);
            this.emailErrorLbl.Name = "emailErrorLbl";
            this.emailErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.emailErrorLbl.TabIndex = 58;
            this.emailErrorLbl.Text = "*";
            this.emailErrorLbl.Visible = false;
            // 
            // cnicErrorLbl
            // 
            this.cnicErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cnicErrorLbl.AutoSize = true;
            this.cnicErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnicErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.cnicErrorLbl.Location = new System.Drawing.Point(361, 143);
            this.cnicErrorLbl.Name = "cnicErrorLbl";
            this.cnicErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.cnicErrorLbl.TabIndex = 60;
            this.cnicErrorLbl.Text = "*";
            this.cnicErrorLbl.Visible = false;
            // 
            // fatherNameErrorLbl
            // 
            this.fatherNameErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fatherNameErrorLbl.AutoSize = true;
            this.fatherNameErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatherNameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.fatherNameErrorLbl.Location = new System.Drawing.Point(412, 75);
            this.fatherNameErrorLbl.Name = "fatherNameErrorLbl";
            this.fatherNameErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.fatherNameErrorLbl.TabIndex = 61;
            this.fatherNameErrorLbl.Text = "*";
            this.fatherNameErrorLbl.Visible = false;
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dobDateTimePicker.BackColor = System.Drawing.Color.Gray;
            this.dobDateTimePicker.BorderRadius = 0;
            this.dobDateTimePicker.Enabled = false;
            this.dobDateTimePicker.ForeColor = System.Drawing.Color.White;
            this.dobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDateTimePicker.FormatCustom = "dd-mmm-yyyy";
            this.dobDateTimePicker.Location = new System.Drawing.Point(10, 168);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(278, 33);
            this.dobDateTimePicker.TabIndex = 1;
            this.dobDateTimePicker.Value = new System.DateTime(2021, 6, 18, 0, 0, 0, 0);
            // 
            // studentImageOpenFileDialog
            // 
            this.studentImageOpenFileDialog.FileName = "Select Image.";
            this.studentImageOpenFileDialog.Filter = "(*.png; *.jpg; *.jpeg;) | *.png; *.jpg; *.jpeg;";
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 679);
            this.Controls.Add(this.contactErrorLbl);
            this.Controls.Add(this.studentNameErrorLbl);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.departmentsDD);
            this.Controls.Add(this.dobDateTimePicker);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.studentPicBox);
            this.Controls.Add(this.contactTxtBox);
            this.Controls.Add(this.cnicTxtBox);
            this.Controls.Add(this.femaleRB);
            this.Controls.Add(this.maleRB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.publisherlbl);
            this.Controls.Add(this.barcodeLbl);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.bookPriceLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.bookNameLbl);
            this.Controls.Add(this.fatherNameTxtBox);
            this.Controls.Add(this.studentNameTxtBox);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.departmentErrorLbl);
            this.Controls.Add(this.addressErrorLbl);
            this.Controls.Add(this.emailErrorLbl);
            this.Controls.Add(this.cnicErrorLbl);
            this.Controls.Add(this.fatherNameErrorLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Students";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton addNewBtn;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel linePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label publisherlbl;
        private System.Windows.Forms.Label barcodeLbl;
        private System.Windows.Forms.Label categoryLbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox addressTxtBox;
        private System.Windows.Forms.Label bookPriceLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox emailTxtBox;
        private System.Windows.Forms.Label bookNameLbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox studentNameTxtBox;
        private System.Windows.Forms.RadioButton maleRB;
        private System.Windows.Forms.RadioButton femaleRB;
        private System.Windows.Forms.MaskedTextBox cnicTxtBox;
        private System.Windows.Forms.MaskedTextBox contactTxtBox;
        private System.Windows.Forms.PictureBox studentPicBox;
        private Bunifu.Framework.UI.BunifuFlatButton saveBtn;
        private System.Windows.Forms.Panel bottomPanel;
        private Bunifu.Framework.UI.BunifuTextbox searchTxtBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox fatherNameTxtBox;
        private System.Windows.Forms.ComboBox departmentsDD;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton uploadBtn;
        private System.Windows.Forms.Label studentNameErrorLbl;
        private System.Windows.Forms.Label contactErrorLbl;
        private System.Windows.Forms.Label departmentErrorLbl;
        private System.Windows.Forms.Label addressErrorLbl;
        private System.Windows.Forms.Label emailErrorLbl;
        private System.Windows.Forms.Label cnicErrorLbl;
        private System.Windows.Forms.Label fatherNameErrorLbl;
        private Bunifu.Framework.UI.BunifuDatepicker dobDateTimePicker;
        private System.Windows.Forms.OpenFileDialog studentImageOpenFileDialog;
        private System.Windows.Forms.DataGridView studentsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentImagePathGVC;
        private System.Windows.Forms.DataGridViewImageColumn studentImgBoxGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnicGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIdGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderValueGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderTextGVC;
        private System.Windows.Forms.DataGridViewImageColumn editActionGVC;
        private System.Windows.Forms.DataGridViewImageColumn deleteActionGVC;
    }
}