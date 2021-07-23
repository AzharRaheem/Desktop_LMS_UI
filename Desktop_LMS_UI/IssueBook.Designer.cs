namespace Desktop_LMS_UI
{
    partial class IssueBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookNameLbl = new System.Windows.Forms.Label();
            this.issueDateTimePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.returnDateTimePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.saveBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.issueNewBookBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bookDD = new System.Windows.Forms.ComboBox();
            this.studentDD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librarianIdGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librarianGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.fineDD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookDDErrorLbl = new System.Windows.Forms.Label();
            this.issueDateDTErrorLbl = new System.Windows.Forms.Label();
            this.returnDateDTErrorLbl = new System.Windows.Forms.Label();
            this.studentDDErrorLbl = new System.Windows.Forms.Label();
            this.fineDDErrorLbl = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Issue Book";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.panel1);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(827, 46);
            this.topPanel.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(115, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 5);
            this.panel1.TabIndex = 1;
            // 
            // bookNameLbl
            // 
            this.bookNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookNameLbl.AutoSize = true;
            this.bookNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameLbl.Location = new System.Drawing.Point(339, 76);
            this.bookNameLbl.Name = "bookNameLbl";
            this.bookNameLbl.Size = new System.Drawing.Size(81, 16);
            this.bookNameLbl.TabIndex = 32;
            this.bookNameLbl.Text = "Issue Date : ";
            // 
            // issueDateTimePicker
            // 
            this.issueDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.issueDateTimePicker.BackColor = System.Drawing.Color.Gray;
            this.issueDateTimePicker.BorderRadius = 0;
            this.issueDateTimePicker.Enabled = false;
            this.issueDateTimePicker.ForeColor = System.Drawing.Color.White;
            this.issueDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.issueDateTimePicker.FormatCustom = null;
            this.issueDateTimePicker.Location = new System.Drawing.Point(342, 97);
            this.issueDateTimePicker.Name = "issueDateTimePicker";
            this.issueDateTimePicker.Size = new System.Drawing.Size(269, 35);
            this.issueDateTimePicker.TabIndex = 33;
            this.issueDateTimePicker.Value = new System.DateTime(2021, 6, 17, 21, 35, 4, 782);
            this.issueDateTimePicker.onValueChanged += new System.EventHandler(this.issueDateTimePicker_onValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Book Title : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Return Date : ";
            // 
            // returnDateTimePicker
            // 
            this.returnDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnDateTimePicker.BackColor = System.Drawing.Color.Gray;
            this.returnDateTimePicker.BorderRadius = 0;
            this.returnDateTimePicker.Enabled = false;
            this.returnDateTimePicker.ForeColor = System.Drawing.Color.White;
            this.returnDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.returnDateTimePicker.FormatCustom = null;
            this.returnDateTimePicker.Location = new System.Drawing.Point(14, 164);
            this.returnDateTimePicker.Name = "returnDateTimePicker";
            this.returnDateTimePicker.Size = new System.Drawing.Size(269, 36);
            this.returnDateTimePicker.TabIndex = 33;
            this.returnDateTimePicker.Value = new System.DateTime(2021, 6, 17, 21, 35, 4, 782);
            this.returnDateTimePicker.onValueChanged += new System.EventHandler(this.returnDateTimePicker_onValueChanged);
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
            this.saveBtn.Location = new System.Drawing.Point(496, 222);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.saveBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.saveBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.saveBtn.selected = false;
            this.saveBtn.Size = new System.Drawing.Size(114, 40);
            this.saveBtn.TabIndex = 38;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBtn.Textcolor = System.Drawing.Color.White;
            this.saveBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // issueNewBookBtn
            // 
            this.issueNewBookBtn.Activecolor = System.Drawing.Color.SteelBlue;
            this.issueNewBookBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.issueNewBookBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.issueNewBookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.issueNewBookBtn.BorderRadius = 5;
            this.issueNewBookBtn.ButtonText = "Issue New Book";
            this.issueNewBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueNewBookBtn.DisabledColor = System.Drawing.Color.Gray;
            this.issueNewBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueNewBookBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.issueNewBookBtn.Iconimage = global::Desktop_LMS_UI.Properties.Resources.plus;
            this.issueNewBookBtn.Iconimage_right = null;
            this.issueNewBookBtn.Iconimage_right_Selected = null;
            this.issueNewBookBtn.Iconimage_Selected = null;
            this.issueNewBookBtn.IconMarginLeft = 0;
            this.issueNewBookBtn.IconMarginRight = 0;
            this.issueNewBookBtn.IconRightVisible = true;
            this.issueNewBookBtn.IconRightZoom = 0D;
            this.issueNewBookBtn.IconVisible = true;
            this.issueNewBookBtn.IconZoom = 45D;
            this.issueNewBookBtn.IsTab = false;
            this.issueNewBookBtn.Location = new System.Drawing.Point(660, 57);
            this.issueNewBookBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.issueNewBookBtn.Name = "issueNewBookBtn";
            this.issueNewBookBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.issueNewBookBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.issueNewBookBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.issueNewBookBtn.selected = false;
            this.issueNewBookBtn.Size = new System.Drawing.Size(156, 35);
            this.issueNewBookBtn.TabIndex = 41;
            this.issueNewBookBtn.Text = "Issue New Book";
            this.issueNewBookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issueNewBookBtn.Textcolor = System.Drawing.Color.White;
            this.issueNewBookBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueNewBookBtn.Click += new System.EventHandler(this.issueNewBookBtn_Click);
            // 
            // bookDD
            // 
            this.bookDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookDD.BackColor = System.Drawing.Color.Gray;
            this.bookDD.Enabled = false;
            this.bookDD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bookDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.bookDD.ForeColor = System.Drawing.Color.White;
            this.bookDD.FormattingEnabled = true;
            this.bookDD.Location = new System.Drawing.Point(14, 99);
            this.bookDD.Name = "bookDD";
            this.bookDD.Size = new System.Drawing.Size(269, 33);
            this.bookDD.TabIndex = 42;
            this.bookDD.SelectedIndexChanged += new System.EventHandler(this.bookDD_SelectedIndexChanged);
            // 
            // studentDD
            // 
            this.studentDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentDD.BackColor = System.Drawing.Color.Gray;
            this.studentDD.Enabled = false;
            this.studentDD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.studentDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.studentDD.ForeColor = System.Drawing.Color.White;
            this.studentDD.FormattingEnabled = true;
            this.studentDD.Location = new System.Drawing.Point(341, 164);
            this.studentDD.Name = "studentDD";
            this.studentDD.Size = new System.Drawing.Size(269, 33);
            this.studentDD.TabIndex = 46;
            this.studentDD.SelectedIndexChanged += new System.EventHandler(this.studentDD_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Student : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGVC,
            this.studentGVC,
            this.bookTitleGVC,
            this.librarianIdGVC,
            this.librarianGVC,
            this.issueDateGVC,
            this.returnDateGVC});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(827, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // idGVC
            // 
            this.idGVC.HeaderText = "id";
            this.idGVC.Name = "idGVC";
            this.idGVC.ReadOnly = true;
            this.idGVC.Visible = false;
            // 
            // studentGVC
            // 
            this.studentGVC.HeaderText = "Student Name";
            this.studentGVC.Name = "studentGVC";
            this.studentGVC.ReadOnly = true;
            // 
            // bookTitleGVC
            // 
            this.bookTitleGVC.HeaderText = "Book Title";
            this.bookTitleGVC.Name = "bookTitleGVC";
            this.bookTitleGVC.ReadOnly = true;
            // 
            // librarianIdGVC
            // 
            this.librarianIdGVC.HeaderText = "Librarian Id";
            this.librarianIdGVC.Name = "librarianIdGVC";
            this.librarianIdGVC.ReadOnly = true;
            this.librarianIdGVC.Visible = false;
            // 
            // librarianGVC
            // 
            this.librarianGVC.HeaderText = "Librarian";
            this.librarianGVC.Name = "librarianGVC";
            this.librarianGVC.ReadOnly = true;
            // 
            // issueDateGVC
            // 
            this.issueDateGVC.HeaderText = "Issue Date";
            this.issueDateGVC.Name = "issueDateGVC";
            this.issueDateGVC.ReadOnly = true;
            // 
            // returnDateGVC
            // 
            this.returnDateGVC.HeaderText = "Return Date";
            this.returnDateGVC.Name = "returnDateGVC";
            this.returnDateGVC.ReadOnly = true;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.dataGridView1);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 317);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(827, 360);
            this.bottomPanel.TabIndex = 36;
            // 
            // fineDD
            // 
            this.fineDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fineDD.BackColor = System.Drawing.Color.Gray;
            this.fineDD.Enabled = false;
            this.fineDD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fineDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.fineDD.ForeColor = System.Drawing.Color.White;
            this.fineDD.FormattingEnabled = true;
            this.fineDD.Location = new System.Drawing.Point(14, 229);
            this.fineDD.Name = "fineDD";
            this.fineDD.Size = new System.Drawing.Size(269, 33);
            this.fineDD.TabIndex = 48;
            this.fineDD.SelectedIndexChanged += new System.EventHandler(this.fineDD_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Fine :";
            // 
            // bookDDErrorLbl
            // 
            this.bookDDErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookDDErrorLbl.AutoSize = true;
            this.bookDDErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDDErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.bookDDErrorLbl.Location = new System.Drawing.Point(85, 73);
            this.bookDDErrorLbl.Name = "bookDDErrorLbl";
            this.bookDDErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.bookDDErrorLbl.TabIndex = 53;
            this.bookDDErrorLbl.Text = "*";
            this.bookDDErrorLbl.Visible = false;
            // 
            // issueDateDTErrorLbl
            // 
            this.issueDateDTErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.issueDateDTErrorLbl.AutoSize = true;
            this.issueDateDTErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueDateDTErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.issueDateDTErrorLbl.Location = new System.Drawing.Point(416, 73);
            this.issueDateDTErrorLbl.Name = "issueDateDTErrorLbl";
            this.issueDateDTErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.issueDateDTErrorLbl.TabIndex = 54;
            this.issueDateDTErrorLbl.Text = "*";
            this.issueDateDTErrorLbl.Visible = false;
            // 
            // returnDateDTErrorLbl
            // 
            this.returnDateDTErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnDateDTErrorLbl.AutoSize = true;
            this.returnDateDTErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateDTErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.returnDateDTErrorLbl.Location = new System.Drawing.Point(94, 139);
            this.returnDateDTErrorLbl.Name = "returnDateDTErrorLbl";
            this.returnDateDTErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.returnDateDTErrorLbl.TabIndex = 55;
            this.returnDateDTErrorLbl.Text = "*";
            this.returnDateDTErrorLbl.Visible = false;
            // 
            // studentDDErrorLbl
            // 
            this.studentDDErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentDDErrorLbl.AutoSize = true;
            this.studentDDErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDDErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.studentDDErrorLbl.Location = new System.Drawing.Point(396, 139);
            this.studentDDErrorLbl.Name = "studentDDErrorLbl";
            this.studentDDErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.studentDDErrorLbl.TabIndex = 56;
            this.studentDDErrorLbl.Text = "*";
            this.studentDDErrorLbl.Visible = false;
            // 
            // fineDDErrorLbl
            // 
            this.fineDDErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fineDDErrorLbl.AutoSize = true;
            this.fineDDErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fineDDErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.fineDDErrorLbl.Location = new System.Drawing.Point(51, 206);
            this.fineDDErrorLbl.Name = "fineDDErrorLbl";
            this.fineDDErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.fineDDErrorLbl.TabIndex = 57;
            this.fineDDErrorLbl.Text = "*";
            this.fineDDErrorLbl.Visible = false;
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 677);
            this.Controls.Add(this.fineDD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentDD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bookDD);
            this.Controls.Add(this.issueNewBookBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.returnDateTimePicker);
            this.Controls.Add(this.issueDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookNameLbl);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bookDDErrorLbl);
            this.Controls.Add(this.issueDateDTErrorLbl);
            this.Controls.Add(this.returnDateDTErrorLbl);
            this.Controls.Add(this.studentDDErrorLbl);
            this.Controls.Add(this.fineDDErrorLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueBook";
            this.Text = "IssueBook";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bookNameLbl;
        private Bunifu.Framework.UI.BunifuDatepicker issueDateTimePicker;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton saveBtn;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker returnDateTimePicker;
        private Bunifu.Framework.UI.BunifuFlatButton issueNewBookBtn;
        private System.Windows.Forms.ComboBox bookDD;
        private System.Windows.Forms.ComboBox studentDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.ComboBox fineDD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn librarianIdGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn librarianGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateGVC;
        private System.Windows.Forms.Label bookDDErrorLbl;
        private System.Windows.Forms.Label issueDateDTErrorLbl;
        private System.Windows.Forms.Label returnDateDTErrorLbl;
        private System.Windows.Forms.Label studentDDErrorLbl;
        private System.Windows.Forms.Label fineDDErrorLbl;
    }
}