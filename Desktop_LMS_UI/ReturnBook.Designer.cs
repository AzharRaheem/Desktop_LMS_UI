namespace Desktop_LMS_UI
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.returnDateTimePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.bookTitleDD = new Bunifu.Framework.UI.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deliveryDD = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.studentNameDD = new Bunifu.Framework.UI.BunifuDropdown();
            this.idGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentidGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librarianIdGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librarianNameGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIdGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryStatusGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addNewBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.deletePicBox = new System.Windows.Forms.PictureBox();
            this.saveBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.topPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.panel1);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(797, 46);
            this.topPanel.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(135, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 5);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Return Book";
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
            this.returnDateTimePicker.Location = new System.Drawing.Point(9, 101);
            this.returnDateTimePicker.Name = "returnDateTimePicker";
            this.returnDateTimePicker.Size = new System.Drawing.Size(275, 36);
            this.returnDateTimePicker.TabIndex = 35;
            this.returnDateTimePicker.Value = new System.DateTime(2021, 6, 17, 21, 35, 4, 782);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Return Date : ";
            // 
            // bookTitleDD
            // 
            this.bookTitleDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookTitleDD.BackColor = System.Drawing.Color.Gray;
            this.bookTitleDD.BorderRadius = 3;
            this.bookTitleDD.Enabled = false;
            this.bookTitleDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleDD.ForeColor = System.Drawing.Color.White;
            this.bookTitleDD.Items = new string[0];
            this.bookTitleDD.Location = new System.Drawing.Point(302, 100);
            this.bookTitleDD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookTitleDD.Name = "bookTitleDD";
            this.bookTitleDD.NomalColor = System.Drawing.Color.Gray;
            this.bookTitleDD.onHoverColor = System.Drawing.Color.SteelBlue;
            this.bookTitleDD.selectedIndex = -1;
            this.bookTitleDD.Size = new System.Drawing.Size(269, 38);
            this.bookTitleDD.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Book Title : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Delivery : ";
            // 
            // deliveryDD
            // 
            this.deliveryDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deliveryDD.BackColor = System.Drawing.Color.Gray;
            this.deliveryDD.BorderRadius = 3;
            this.deliveryDD.Enabled = false;
            this.deliveryDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryDD.ForeColor = System.Drawing.Color.White;
            this.deliveryDD.Items = new string[] {
        "On Time",
        "Late"};
            this.deliveryDD.Location = new System.Drawing.Point(301, 170);
            this.deliveryDD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deliveryDD.Name = "deliveryDD";
            this.deliveryDD.NomalColor = System.Drawing.Color.Gray;
            this.deliveryDD.onHoverColor = System.Drawing.Color.SteelBlue;
            this.deliveryDD.selectedIndex = -1;
            this.deliveryDD.Size = new System.Drawing.Size(270, 39);
            this.deliveryDD.TabIndex = 37;
            this.deliveryDD.onItemSelected += new System.EventHandler(this.deliveryDD_onItemSelected);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 346);
            this.panel2.TabIndex = 43;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGVC,
            this.issueDateGVC,
            this.studentidGVC,
            this.studentNameGVC,
            this.librarianIdGVC,
            this.librarianNameGVC,
            this.bookIdGVC,
            this.bookNameGVC,
            this.returnDateGVC,
            this.deliveryStatusGVC,
            this.fineGVC});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(797, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Student Name : ";
            // 
            // studentNameDD
            // 
            this.studentNameDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentNameDD.BackColor = System.Drawing.Color.Gray;
            this.studentNameDD.BorderRadius = 3;
            this.studentNameDD.Enabled = false;
            this.studentNameDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameDD.ForeColor = System.Drawing.Color.White;
            this.studentNameDD.Items = new string[0];
            this.studentNameDD.Location = new System.Drawing.Point(8, 168);
            this.studentNameDD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentNameDD.Name = "studentNameDD";
            this.studentNameDD.NomalColor = System.Drawing.Color.Gray;
            this.studentNameDD.onHoverColor = System.Drawing.Color.SteelBlue;
            this.studentNameDD.selectedIndex = -1;
            this.studentNameDD.Size = new System.Drawing.Size(276, 38);
            this.studentNameDD.TabIndex = 37;
            // 
            // idGVC
            // 
            this.idGVC.HeaderText = "id";
            this.idGVC.Name = "idGVC";
            this.idGVC.ReadOnly = true;
            this.idGVC.Visible = false;
            // 
            // issueDateGVC
            // 
            this.issueDateGVC.HeaderText = "Issue Date";
            this.issueDateGVC.Name = "issueDateGVC";
            this.issueDateGVC.ReadOnly = true;
            this.issueDateGVC.Visible = false;
            // 
            // studentidGVC
            // 
            this.studentidGVC.HeaderText = "StudentID";
            this.studentidGVC.Name = "studentidGVC";
            this.studentidGVC.ReadOnly = true;
            this.studentidGVC.Visible = false;
            // 
            // studentNameGVC
            // 
            this.studentNameGVC.HeaderText = "Student Name";
            this.studentNameGVC.Name = "studentNameGVC";
            this.studentNameGVC.ReadOnly = true;
            // 
            // librarianIdGVC
            // 
            this.librarianIdGVC.HeaderText = "Librarian Id";
            this.librarianIdGVC.Name = "librarianIdGVC";
            this.librarianIdGVC.ReadOnly = true;
            this.librarianIdGVC.Visible = false;
            // 
            // librarianNameGVC
            // 
            this.librarianNameGVC.HeaderText = "Librarian Name";
            this.librarianNameGVC.Name = "librarianNameGVC";
            this.librarianNameGVC.ReadOnly = true;
            // 
            // bookIdGVC
            // 
            this.bookIdGVC.HeaderText = "Book Id";
            this.bookIdGVC.Name = "bookIdGVC";
            this.bookIdGVC.ReadOnly = true;
            this.bookIdGVC.Visible = false;
            // 
            // bookNameGVC
            // 
            this.bookNameGVC.HeaderText = "Book Name";
            this.bookNameGVC.Name = "bookNameGVC";
            this.bookNameGVC.ReadOnly = true;
            // 
            // returnDateGVC
            // 
            this.returnDateGVC.HeaderText = "Return Date";
            this.returnDateGVC.Name = "returnDateGVC";
            this.returnDateGVC.ReadOnly = true;
            // 
            // deliveryStatusGVC
            // 
            this.deliveryStatusGVC.HeaderText = "Delivery Status";
            this.deliveryStatusGVC.Name = "deliveryStatusGVC";
            this.deliveryStatusGVC.ReadOnly = true;
            // 
            // fineGVC
            // 
            this.fineGVC.HeaderText = "Fine";
            this.fineGVC.Name = "fineGVC";
            this.fineGVC.ReadOnly = true;
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
            this.addNewBtn.Location = new System.Drawing.Point(683, 52);
            this.addNewBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.addNewBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.addNewBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addNewBtn.selected = false;
            this.addNewBtn.Size = new System.Drawing.Size(104, 33);
            this.addNewBtn.TabIndex = 44;
            this.addNewBtn.Text = "Add New";
            this.addNewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewBtn.Textcolor = System.Drawing.Color.White;
            this.addNewBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTxtBox.BackColor = System.Drawing.Color.SteelBlue;
            this.searchTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTxtBox.BackgroundImage")));
            this.searchTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchTxtBox.ForeColor = System.Drawing.Color.White;
            this.searchTxtBox.Icon = ((System.Drawing.Image)(resources.GetObject("searchTxtBox.Icon")));
            this.searchTxtBox.Location = new System.Drawing.Point(567, 295);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(220, 30);
            this.searchTxtBox.TabIndex = 42;
            this.searchTxtBox.text = "";
            // 
            // deletePicBox
            // 
            this.deletePicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletePicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletePicBox.Image = global::Desktop_LMS_UI.Properties.Resources.delete;
            this.deletePicBox.Location = new System.Drawing.Point(531, 218);
            this.deletePicBox.Name = "deletePicBox";
            this.deletePicBox.Size = new System.Drawing.Size(50, 39);
            this.deletePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deletePicBox.TabIndex = 41;
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
            this.saveBtn.Location = new System.Drawing.Point(424, 217);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.saveBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.saveBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.saveBtn.selected = false;
            this.saveBtn.Size = new System.Drawing.Size(104, 40);
            this.saveBtn.TabIndex = 40;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBtn.Textcolor = System.Drawing.Color.White;
            this.saveBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 677);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.deletePicBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deliveryDD);
            this.Controls.Add(this.studentNameDD);
            this.Controls.Add(this.bookTitleDD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.returnDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBook";
            this.Text = "ReturnBook";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker returnDateTimePicker;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown bookTitleDD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDropdown deliveryDD;
        private System.Windows.Forms.PictureBox deletePicBox;
        private Bunifu.Framework.UI.BunifuFlatButton saveBtn;
        private Bunifu.Framework.UI.BunifuTextbox searchTxtBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDropdown studentNameDD;
        private Bunifu.Framework.UI.BunifuFlatButton addNewBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn librarianIdGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn librarianNameGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryStatusGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineGVC;
    }
}