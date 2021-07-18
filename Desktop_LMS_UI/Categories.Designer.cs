namespace Desktop_LMS_UI
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.topPanel = new System.Windows.Forms.Panel();
            this.linePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryNameTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.categoryNameLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.statusDD = new Bunifu.Framework.UI.BunifuDropdown();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.categoryGridView = new System.Windows.Forms.DataGridView();
            this.idGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusValueGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editActionGVC = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteActionGVC = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameErrorLbl = new System.Windows.Forms.Label();
            this.statusErrorLbl = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.saveBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.addNewBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.linePanel);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(846, 46);
            this.topPanel.TabIndex = 0;
            // 
            // linePanel
            // 
            this.linePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linePanel.Location = new System.Drawing.Point(126, 27);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(703, 5);
            this.linePanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories ";
            // 
            // categoryNameTxtBox
            // 
            this.categoryNameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryNameTxtBox.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.categoryNameTxtBox.BorderColorIdle = System.Drawing.Color.DimGray;
            this.categoryNameTxtBox.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.categoryNameTxtBox.BorderThickness = 3;
            this.categoryNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categoryNameTxtBox.Enabled = false;
            this.categoryNameTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.categoryNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categoryNameTxtBox.isPassword = false;
            this.categoryNameTxtBox.Location = new System.Drawing.Point(28, 128);
            this.categoryNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryNameTxtBox.Name = "categoryNameTxtBox";
            this.categoryNameTxtBox.Size = new System.Drawing.Size(354, 40);
            this.categoryNameTxtBox.TabIndex = 0;
            this.categoryNameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.categoryNameTxtBox.OnValueChanged += new System.EventHandler(this.categoryNameTxtBox_OnValueChanged);
            // 
            // categoryNameLbl
            // 
            this.categoryNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryNameLbl.AutoSize = true;
            this.categoryNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameLbl.Location = new System.Drawing.Point(28, 108);
            this.categoryNameLbl.Name = "categoryNameLbl";
            this.categoryNameLbl.Size = new System.Drawing.Size(112, 16);
            this.categoryNameLbl.TabIndex = 6;
            this.categoryNameLbl.Text = "Category Name : ";
            // 
            // statusLbl
            // 
            this.statusLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Location = new System.Drawing.Point(419, 108);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(51, 16);
            this.statusLbl.TabIndex = 6;
            this.statusLbl.Text = "Status :";
            // 
            // statusDD
            // 
            this.statusDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusDD.BackColor = System.Drawing.Color.Transparent;
            this.statusDD.BorderRadius = 3;
            this.statusDD.Enabled = false;
            this.statusDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDD.ForeColor = System.Drawing.Color.White;
            this.statusDD.Items = new string[] {
        "Select...",
        "Active ",
        "In-Active"};
            this.statusDD.Location = new System.Drawing.Point(422, 128);
            this.statusDD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusDD.Name = "statusDD";
            this.statusDD.NomalColor = System.Drawing.Color.Gray;
            this.statusDD.onHoverColor = System.Drawing.Color.SteelBlue;
            this.statusDD.selectedIndex = -1;
            this.statusDD.Size = new System.Drawing.Size(351, 38);
            this.statusDD.TabIndex = 1;
            this.statusDD.onItemSelected += new System.EventHandler(this.statusDD_onItemSelected);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.categoryGridView);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 292);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(846, 385);
            this.bottomPanel.TabIndex = 9;
            // 
            // categoryGridView
            // 
            this.categoryGridView.AllowUserToAddRows = false;
            this.categoryGridView.AllowUserToDeleteRows = false;
            this.categoryGridView.AllowUserToResizeColumns = false;
            this.categoryGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.categoryGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.categoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.categoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGVC,
            this.categoryNameGVC,
            this.statusValueGVC,
            this.statusGVC,
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
            this.categoryGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.categoryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryGridView.EnableHeadersVisualStyles = false;
            this.categoryGridView.Location = new System.Drawing.Point(0, 0);
            this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.ReadOnly = true;
            this.categoryGridView.RowHeadersVisible = false;
            this.categoryGridView.RowTemplate.Height = 28;
            this.categoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryGridView.Size = new System.Drawing.Size(846, 385);
            this.categoryGridView.TabIndex = 25;
            this.categoryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryGridView_CellContentClick);
            this.categoryGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryGridView_CellDoubleClick);
            // 
            // idGVC
            // 
            this.idGVC.DataPropertyName = "id";
            this.idGVC.HeaderText = "Id";
            this.idGVC.Name = "idGVC";
            this.idGVC.ReadOnly = true;
            this.idGVC.Visible = false;
            // 
            // categoryNameGVC
            // 
            this.categoryNameGVC.DataPropertyName = "name";
            this.categoryNameGVC.FillWeight = 267.5182F;
            this.categoryNameGVC.HeaderText = "Category";
            this.categoryNameGVC.Name = "categoryNameGVC";
            this.categoryNameGVC.ReadOnly = true;
            // 
            // statusValueGVC
            // 
            this.statusValueGVC.DataPropertyName = "statusValue";
            this.statusValueGVC.FillWeight = 98.96188F;
            this.statusValueGVC.HeaderText = "Status";
            this.statusValueGVC.Name = "statusValueGVC";
            this.statusValueGVC.ReadOnly = true;
            // 
            // statusGVC
            // 
            this.statusGVC.DataPropertyName = "statusIndex";
            this.statusGVC.FillWeight = 96.49529F;
            this.statusGVC.HeaderText = "Status Index";
            this.statusGVC.Name = "statusGVC";
            this.statusGVC.ReadOnly = true;
            this.statusGVC.Visible = false;
            // 
            // editActionGVC
            // 
            this.editActionGVC.FillWeight = 16.38598F;
            this.editActionGVC.HeaderText = "Edit";
            this.editActionGVC.Image = global::Desktop_LMS_UI.Properties.Resources.pencil__1_1;
            this.editActionGVC.Name = "editActionGVC";
            this.editActionGVC.ReadOnly = true;
            // 
            // deleteActionGVC
            // 
            this.deleteActionGVC.FillWeight = 20.63863F;
            this.deleteActionGVC.HeaderText = "Delete";
            this.deleteActionGVC.Image = global::Desktop_LMS_UI.Properties.Resources.delete__2_1;
            this.deleteActionGVC.Name = "deleteActionGVC";
            this.deleteActionGVC.ReadOnly = true;
            // 
            // nameErrorLbl
            // 
            this.nameErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameErrorLbl.AutoSize = true;
            this.nameErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.nameErrorLbl.Location = new System.Drawing.Point(135, 103);
            this.nameErrorLbl.Name = "nameErrorLbl";
            this.nameErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.nameErrorLbl.TabIndex = 22;
            this.nameErrorLbl.Text = "*";
            this.nameErrorLbl.Visible = false;
            // 
            // statusErrorLbl
            // 
            this.statusErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusErrorLbl.AutoSize = true;
            this.statusErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.statusErrorLbl.Location = new System.Drawing.Point(465, 104);
            this.statusErrorLbl.Name = "statusErrorLbl";
            this.statusErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.statusErrorLbl.TabIndex = 23;
            this.statusErrorLbl.Text = "*";
            this.statusErrorLbl.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 40.60914F;
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = global::Desktop_LMS_UI.Properties.Resources.pencil__1_;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 86;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 20.30457F;
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = global::Desktop_LMS_UI.Properties.Resources.delete__2_;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 43;
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
            this.saveBtn.Location = new System.Drawing.Point(669, 173);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.saveBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.saveBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.saveBtn.selected = false;
            this.saveBtn.Size = new System.Drawing.Size(104, 40);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBtn.Textcolor = System.Drawing.Color.White;
            this.saveBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTxtBox.BackColor = System.Drawing.Color.SteelBlue;
            this.searchTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTxtBox.BackgroundImage")));
            this.searchTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchTxtBox.ForeColor = System.Drawing.Color.White;
            this.searchTxtBox.Icon = ((System.Drawing.Image)(resources.GetObject("searchTxtBox.Icon")));
            this.searchTxtBox.Location = new System.Drawing.Point(609, 256);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(220, 30);
            this.searchTxtBox.TabIndex = 3;
            this.searchTxtBox.text = "";
            this.searchTxtBox.OnTextChange += new System.EventHandler(this.searchTxtBox_OnTextChange);
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
            this.addNewBtn.Location = new System.Drawing.Point(725, 51);
            this.addNewBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.addNewBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.addNewBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addNewBtn.selected = false;
            this.addNewBtn.Size = new System.Drawing.Size(104, 33);
            this.addNewBtn.TabIndex = 10;
            this.addNewBtn.Text = "Add New";
            this.addNewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewBtn.Textcolor = System.Drawing.Color.White;
            this.addNewBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 677);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.statusDD);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.categoryNameLbl);
            this.Controls.Add(this.categoryNameTxtBox);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.nameErrorLbl);
            this.Controls.Add(this.statusErrorLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Categories";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Categories_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel linePanel;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox categoryNameTxtBox;
        private System.Windows.Forms.Label categoryNameLbl;
        private System.Windows.Forms.Label statusLbl;
        private Bunifu.Framework.UI.BunifuDropdown statusDD;
        private System.Windows.Forms.Panel bottomPanel;
        private Bunifu.Framework.UI.BunifuFlatButton addNewBtn;
        private Bunifu.Framework.UI.BunifuTextbox searchTxtBox;
        private Bunifu.Framework.UI.BunifuFlatButton saveBtn;
        private System.Windows.Forms.Label nameErrorLbl;
        private System.Windows.Forms.Label statusErrorLbl;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView categoryGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusValueGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGVC;
        private System.Windows.Forms.DataGridViewImageColumn editActionGVC;
        private System.Windows.Forms.DataGridViewImageColumn deleteActionGVC;
    }
}