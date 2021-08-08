namespace Desktop_LMS_UI
{
    partial class ManageReturnBooks
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.returnDateTimePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ReturnedBooksGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.addNewReturnBookBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.returnSaveBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.studentDD = new System.Windows.Forms.ComboBox();
            this.studentDDErrorLbl = new System.Windows.Forms.Label();
            this.bookDDErrorLbl = new System.Windows.Forms.Label();
            this.bookDD = new System.Windows.Forms.ComboBox();
            this.idGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librarianIdGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librarianGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIdGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryStatusGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineValueGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteActionGVC = new System.Windows.Forms.DataGridViewImageColumn();
            this.topPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnedBooksGridView)).BeginInit();
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
            this.returnDateTimePicker.Location = new System.Drawing.Point(49, 157);
            this.returnDateTimePicker.Name = "returnDateTimePicker";
            this.returnDateTimePicker.Size = new System.Drawing.Size(269, 36);
            this.returnDateTimePicker.TabIndex = 35;
            this.returnDateTimePicker.Value = new System.DateTime(2021, 6, 17, 21, 35, 4, 782);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Return Date : ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Book Title : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ReturnedBooksGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 436);
            this.panel2.TabIndex = 43;
            // 
            // ReturnedBooksGridView
            // 
            this.ReturnedBooksGridView.AllowUserToAddRows = false;
            this.ReturnedBooksGridView.AllowUserToDeleteRows = false;
            this.ReturnedBooksGridView.AllowUserToResizeColumns = false;
            this.ReturnedBooksGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ReturnedBooksGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ReturnedBooksGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReturnedBooksGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReturnedBooksGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ReturnedBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnedBooksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGVC,
            this.studentIdGVC,
            this.studentGVC,
            this.librarianIdGVC,
            this.librarianGVC,
            this.bookIdGVC,
            this.bookTitleGVC,
            this.returnDateGVC,
            this.deliveryStatusGVC,
            this.fineValueGVC,
            this.deleteActionGVC});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 3, 3, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReturnedBooksGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ReturnedBooksGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReturnedBooksGridView.EnableHeadersVisualStyles = false;
            this.ReturnedBooksGridView.Location = new System.Drawing.Point(0, 0);
            this.ReturnedBooksGridView.Name = "ReturnedBooksGridView";
            this.ReturnedBooksGridView.ReadOnly = true;
            this.ReturnedBooksGridView.RowHeadersVisible = false;
            this.ReturnedBooksGridView.RowTemplate.Height = 26;
            this.ReturnedBooksGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReturnedBooksGridView.Size = new System.Drawing.Size(797, 436);
            this.ReturnedBooksGridView.TabIndex = 1;
            this.ReturnedBooksGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReturnedBooksGridView_CellContentClick);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Student Name : ";
            // 
            // addNewReturnBookBtn
            // 
            this.addNewReturnBookBtn.Activecolor = System.Drawing.Color.SteelBlue;
            this.addNewReturnBookBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewReturnBookBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.addNewReturnBookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addNewReturnBookBtn.BorderRadius = 5;
            this.addNewReturnBookBtn.ButtonText = "Return A Book";
            this.addNewReturnBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewReturnBookBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addNewReturnBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.addNewReturnBookBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addNewReturnBookBtn.Iconimage = global::Desktop_LMS_UI.Properties.Resources.plus;
            this.addNewReturnBookBtn.Iconimage_right = null;
            this.addNewReturnBookBtn.Iconimage_right_Selected = null;
            this.addNewReturnBookBtn.Iconimage_Selected = null;
            this.addNewReturnBookBtn.IconMarginLeft = 0;
            this.addNewReturnBookBtn.IconMarginRight = 0;
            this.addNewReturnBookBtn.IconRightVisible = true;
            this.addNewReturnBookBtn.IconRightZoom = 0D;
            this.addNewReturnBookBtn.IconVisible = true;
            this.addNewReturnBookBtn.IconZoom = 45D;
            this.addNewReturnBookBtn.IsTab = false;
            this.addNewReturnBookBtn.Location = new System.Drawing.Point(657, 52);
            this.addNewReturnBookBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addNewReturnBookBtn.Name = "addNewReturnBookBtn";
            this.addNewReturnBookBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.addNewReturnBookBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.addNewReturnBookBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addNewReturnBookBtn.selected = false;
            this.addNewReturnBookBtn.Size = new System.Drawing.Size(130, 33);
            this.addNewReturnBookBtn.TabIndex = 44;
            this.addNewReturnBookBtn.Text = "Return A Book";
            this.addNewReturnBookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewReturnBookBtn.Textcolor = System.Drawing.Color.White;
            this.addNewReturnBookBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewReturnBookBtn.Click += new System.EventHandler(this.addNewReturnBookBtn_Click);
            // 
            // returnSaveBtn
            // 
            this.returnSaveBtn.Activecolor = System.Drawing.Color.SteelBlue;
            this.returnSaveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnSaveBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.returnSaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnSaveBtn.BorderRadius = 5;
            this.returnSaveBtn.ButtonText = "Return";
            this.returnSaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnSaveBtn.DisabledColor = System.Drawing.Color.Gray;
            this.returnSaveBtn.Enabled = false;
            this.returnSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnSaveBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.returnSaveBtn.Iconimage = global::Desktop_LMS_UI.Properties.Resources.plus;
            this.returnSaveBtn.Iconimage_right = null;
            this.returnSaveBtn.Iconimage_right_Selected = null;
            this.returnSaveBtn.Iconimage_Selected = null;
            this.returnSaveBtn.IconMarginLeft = 0;
            this.returnSaveBtn.IconMarginRight = 0;
            this.returnSaveBtn.IconRightVisible = true;
            this.returnSaveBtn.IconRightZoom = 0D;
            this.returnSaveBtn.IconVisible = false;
            this.returnSaveBtn.IconZoom = 45D;
            this.returnSaveBtn.IsTab = false;
            this.returnSaveBtn.Location = new System.Drawing.Point(512, 157);
            this.returnSaveBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.returnSaveBtn.Name = "returnSaveBtn";
            this.returnSaveBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.returnSaveBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.returnSaveBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.returnSaveBtn.selected = false;
            this.returnSaveBtn.Size = new System.Drawing.Size(104, 40);
            this.returnSaveBtn.TabIndex = 40;
            this.returnSaveBtn.Text = "Return";
            this.returnSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.returnSaveBtn.Textcolor = System.Drawing.Color.White;
            this.returnSaveBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnSaveBtn.Click += new System.EventHandler(this.returnSaveBtn_Click);
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
            this.studentDD.Location = new System.Drawing.Point(50, 82);
            this.studentDD.Name = "studentDD";
            this.studentDD.Size = new System.Drawing.Size(269, 33);
            this.studentDD.TabIndex = 58;
            // 
            // studentDDErrorLbl
            // 
            this.studentDDErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentDDErrorLbl.AutoSize = true;
            this.studentDDErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDDErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.studentDDErrorLbl.Location = new System.Drawing.Point(145, 56);
            this.studentDDErrorLbl.Name = "studentDDErrorLbl";
            this.studentDDErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.studentDDErrorLbl.TabIndex = 59;
            this.studentDDErrorLbl.Text = "*";
            this.studentDDErrorLbl.Visible = false;
            // 
            // bookDDErrorLbl
            // 
            this.bookDDErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookDDErrorLbl.AutoSize = true;
            this.bookDDErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDDErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.bookDDErrorLbl.Location = new System.Drawing.Point(423, 55);
            this.bookDDErrorLbl.Name = "bookDDErrorLbl";
            this.bookDDErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.bookDDErrorLbl.TabIndex = 60;
            this.bookDDErrorLbl.Text = "*";
            this.bookDDErrorLbl.Visible = false;
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
            this.bookDD.Location = new System.Drawing.Point(353, 82);
            this.bookDD.Name = "bookDD";
            this.bookDD.Size = new System.Drawing.Size(269, 33);
            this.bookDD.TabIndex = 61;
            // 
            // idGVC
            // 
            this.idGVC.DataPropertyName = "id";
            this.idGVC.HeaderText = "id";
            this.idGVC.Name = "idGVC";
            this.idGVC.ReadOnly = true;
            this.idGVC.Visible = false;
            // 
            // studentIdGVC
            // 
            this.studentIdGVC.DataPropertyName = "studentId";
            this.studentIdGVC.HeaderText = "Student Id";
            this.studentIdGVC.Name = "studentIdGVC";
            this.studentIdGVC.ReadOnly = true;
            this.studentIdGVC.Visible = false;
            // 
            // studentGVC
            // 
            this.studentGVC.DataPropertyName = "studentName";
            this.studentGVC.FillWeight = 125.1376F;
            this.studentGVC.HeaderText = "Student Name";
            this.studentGVC.Name = "studentGVC";
            this.studentGVC.ReadOnly = true;
            // 
            // librarianIdGVC
            // 
            this.librarianIdGVC.DataPropertyName = "librarianId";
            this.librarianIdGVC.HeaderText = "Librarian Id";
            this.librarianIdGVC.Name = "librarianIdGVC";
            this.librarianIdGVC.ReadOnly = true;
            this.librarianIdGVC.Visible = false;
            // 
            // librarianGVC
            // 
            this.librarianGVC.DataPropertyName = "librarianName";
            this.librarianGVC.FillWeight = 125.1376F;
            this.librarianGVC.HeaderText = "Librarian";
            this.librarianGVC.Name = "librarianGVC";
            this.librarianGVC.ReadOnly = true;
            // 
            // bookIdGVC
            // 
            this.bookIdGVC.DataPropertyName = "bookId";
            this.bookIdGVC.HeaderText = "Book Id";
            this.bookIdGVC.Name = "bookIdGVC";
            this.bookIdGVC.ReadOnly = true;
            this.bookIdGVC.Visible = false;
            // 
            // bookTitleGVC
            // 
            this.bookTitleGVC.DataPropertyName = "bookTitle";
            this.bookTitleGVC.FillWeight = 125.1376F;
            this.bookTitleGVC.HeaderText = "Book Title";
            this.bookTitleGVC.Name = "bookTitleGVC";
            this.bookTitleGVC.ReadOnly = true;
            // 
            // returnDateGVC
            // 
            this.returnDateGVC.DataPropertyName = "returnDate";
            this.returnDateGVC.FillWeight = 125.1376F;
            this.returnDateGVC.HeaderText = "Return Date";
            this.returnDateGVC.Name = "returnDateGVC";
            this.returnDateGVC.ReadOnly = true;
            // 
            // deliveryStatusGVC
            // 
            this.deliveryStatusGVC.DataPropertyName = "DeliveryStatus";
            this.deliveryStatusGVC.FillWeight = 125.1376F;
            this.deliveryStatusGVC.HeaderText = "Delivery Status";
            this.deliveryStatusGVC.Name = "deliveryStatusGVC";
            this.deliveryStatusGVC.ReadOnly = true;
            // 
            // fineValueGVC
            // 
            this.fineValueGVC.DataPropertyName = "fine";
            this.fineValueGVC.FillWeight = 99.47874F;
            this.fineValueGVC.HeaderText = "Fine";
            this.fineValueGVC.Name = "fineValueGVC";
            this.fineValueGVC.ReadOnly = true;
            // 
            // deleteActionGVC
            // 
            this.deleteActionGVC.FillWeight = 42.88619F;
            this.deleteActionGVC.HeaderText = "Delete";
            this.deleteActionGVC.Image = global::Desktop_LMS_UI.Properties.Resources.delete__2_;
            this.deleteActionGVC.Name = "deleteActionGVC";
            this.deleteActionGVC.ReadOnly = true;
            // 
            // ManageReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 677);
            this.Controls.Add(this.bookDD);
            this.Controls.Add(this.bookDDErrorLbl);
            this.Controls.Add(this.studentDD);
            this.Controls.Add(this.addNewReturnBookBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.returnSaveBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.returnDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.studentDDErrorLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageReturnBooks";
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReturnedBooksGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker returnDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton returnSaveBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton addNewReturnBookBtn;
        private System.Windows.Forms.ComboBox studentDD;
        private System.Windows.Forms.Label studentDDErrorLbl;
        private System.Windows.Forms.Label bookDDErrorLbl;
        private System.Windows.Forms.ComboBox bookDD;
        private System.Windows.Forms.DataGridView ReturnedBooksGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn librarianIdGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn librarianGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryStatusGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineValueGVC;
        private System.Windows.Forms.DataGridViewImageColumn deleteActionGVC;
    }
}