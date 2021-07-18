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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBook));
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookNameLbl = new System.Windows.Forms.Label();
            this.issueDateTimePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.statusDD = new Bunifu.Framework.UI.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.bookTitleDD = new Bunifu.Framework.UI.BunifuDropdown();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librarianGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librarianIdGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.returnDateDD = new Bunifu.Framework.UI.BunifuDatepicker();
            this.searchTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.deletePicBox = new System.Windows.Forms.PictureBox();
            this.saveBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.issueNewBookBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePicBox)).BeginInit();
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
            this.bookNameLbl.Location = new System.Drawing.Point(18, 76);
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
            this.issueDateTimePicker.ForeColor = System.Drawing.Color.White;
            this.issueDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.issueDateTimePicker.FormatCustom = null;
            this.issueDateTimePicker.Location = new System.Drawing.Point(21, 97);
            this.issueDateTimePicker.Name = "issueDateTimePicker";
            this.issueDateTimePicker.Size = new System.Drawing.Size(269, 36);
            this.issueDateTimePicker.TabIndex = 33;
            this.issueDateTimePicker.Value = new System.DateTime(2021, 6, 17, 21, 35, 4, 782);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Status : ";
            // 
            // statusDD
            // 
            this.statusDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusDD.BackColor = System.Drawing.Color.Gray;
            this.statusDD.BorderRadius = 3;
            this.statusDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDD.ForeColor = System.Drawing.Color.White;
            this.statusDD.Items = new string[] {
        "Pending",
        "Issued"};
            this.statusDD.Location = new System.Drawing.Point(319, 179);
            this.statusDD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusDD.Name = "statusDD";
            this.statusDD.NomalColor = System.Drawing.Color.Gray;
            this.statusDD.onHoverColor = System.Drawing.Color.SteelBlue;
            this.statusDD.selectedIndex = -1;
            this.statusDD.Size = new System.Drawing.Size(274, 38);
            this.statusDD.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Book Title : ";
            // 
            // bookTitleDD
            // 
            this.bookTitleDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookTitleDD.BackColor = System.Drawing.Color.Gray;
            this.bookTitleDD.BorderRadius = 3;
            this.bookTitleDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleDD.ForeColor = System.Drawing.Color.White;
            this.bookTitleDD.Items = new string[0];
            this.bookTitleDD.Location = new System.Drawing.Point(19, 179);
            this.bookTitleDD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookTitleDD.Name = "bookTitleDD";
            this.bookTitleDD.NomalColor = System.Drawing.Color.Gray;
            this.bookTitleDD.onHoverColor = System.Drawing.Color.SteelBlue;
            this.bookTitleDD.selectedIndex = -1;
            this.bookTitleDD.Size = new System.Drawing.Size(269, 38);
            this.bookTitleDD.TabIndex = 35;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.dataGridView1);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 337);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(827, 340);
            this.bottomPanel.TabIndex = 36;
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
            this.librarianGVC,
            this.issueDateGVC,
            this.durationGVC,
            this.bookTitleGVC,
            this.statusGVC,
            this.librarianIdGVC});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(827, 340);
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
            // durationGVC
            // 
            this.durationGVC.HeaderText = "Duration";
            this.durationGVC.Name = "durationGVC";
            this.durationGVC.ReadOnly = true;
            // 
            // bookTitleGVC
            // 
            this.bookTitleGVC.HeaderText = "Book Title";
            this.bookTitleGVC.Name = "bookTitleGVC";
            this.bookTitleGVC.ReadOnly = true;
            // 
            // statusGVC
            // 
            this.statusGVC.HeaderText = "Status";
            this.statusGVC.Name = "statusGVC";
            this.statusGVC.ReadOnly = true;
            // 
            // librarianIdGVC
            // 
            this.librarianIdGVC.HeaderText = "Librarian Id";
            this.librarianIdGVC.Name = "librarianIdGVC";
            this.librarianIdGVC.ReadOnly = true;
            this.librarianIdGVC.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Return Date : ";
            // 
            // returnDateDD
            // 
            this.returnDateDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnDateDD.BackColor = System.Drawing.Color.Gray;
            this.returnDateDD.BorderRadius = 0;
            this.returnDateDD.ForeColor = System.Drawing.Color.White;
            this.returnDateDD.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.returnDateDD.FormatCustom = null;
            this.returnDateDD.Location = new System.Drawing.Point(319, 97);
            this.returnDateDD.Name = "returnDateDD";
            this.returnDateDD.Size = new System.Drawing.Size(275, 36);
            this.returnDateDD.TabIndex = 33;
            this.returnDateDD.Value = new System.DateTime(2021, 6, 17, 21, 35, 4, 782);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTxtBox.BackColor = System.Drawing.Color.SteelBlue;
            this.searchTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTxtBox.BackgroundImage")));
            this.searchTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchTxtBox.ForeColor = System.Drawing.Color.White;
            this.searchTxtBox.Icon = ((System.Drawing.Image)(resources.GetObject("searchTxtBox.Icon")));
            this.searchTxtBox.Location = new System.Drawing.Point(597, 301);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(220, 30);
            this.searchTxtBox.TabIndex = 40;
            this.searchTxtBox.text = "";
            // 
            // deletePicBox
            // 
            this.deletePicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletePicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletePicBox.Image = global::Desktop_LMS_UI.Properties.Resources.delete;
            this.deletePicBox.Location = new System.Drawing.Point(544, 225);
            this.deletePicBox.Name = "deletePicBox";
            this.deletePicBox.Size = new System.Drawing.Size(50, 39);
            this.deletePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deletePicBox.TabIndex = 39;
            this.deletePicBox.TabStop = false;
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
            this.saveBtn.Location = new System.Drawing.Point(437, 224);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.saveBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.saveBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.saveBtn.selected = false;
            this.saveBtn.Size = new System.Drawing.Size(104, 40);
            this.saveBtn.TabIndex = 38;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBtn.Textcolor = System.Drawing.Color.White;
            this.saveBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 677);
            this.Controls.Add(this.issueNewBookBtn);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.deletePicBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.bookTitleDD);
            this.Controls.Add(this.statusDD);
            this.Controls.Add(this.returnDateDD);
            this.Controls.Add(this.issueDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookNameLbl);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueBook";
            this.Text = "IssueBook";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bookNameLbl;
        private Bunifu.Framework.UI.BunifuDatepicker issueDateTimePicker;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDropdown statusDD;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDropdown bookTitleDD;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.PictureBox deletePicBox;
        private Bunifu.Framework.UI.BunifuFlatButton saveBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn librarianGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn librarianIdGVC;
        private Bunifu.Framework.UI.BunifuTextbox searchTxtBox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker returnDateDD;
        private Bunifu.Framework.UI.BunifuFlatButton issueNewBookBtn;
    }
}