namespace Desktop_LMS_UI
{
    partial class Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roles));
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.roleNameLbl = new System.Windows.Forms.Label();
            this.roleNameTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.rolesGridView = new System.Windows.Forms.DataGridView();
            this.idGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editActionGVC = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteActionGVC = new System.Windows.Forms.DataGridViewImageColumn();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.roleNameErrorLbl = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.addNewBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.saveBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesGridView)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.panel1);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(759, 46);
            this.topPanel.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(69, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 5);
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
            this.label1.Text = "Roles";
            // 
            // roleNameLbl
            // 
            this.roleNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleNameLbl.AutoSize = true;
            this.roleNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleNameLbl.Location = new System.Drawing.Point(211, 102);
            this.roleNameLbl.Name = "roleNameLbl";
            this.roleNameLbl.Size = new System.Drawing.Size(86, 16);
            this.roleNameLbl.TabIndex = 17;
            this.roleNameLbl.Text = "Role Name : ";
            // 
            // roleNameTxtBox
            // 
            this.roleNameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleNameTxtBox.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.roleNameTxtBox.BorderColorIdle = System.Drawing.Color.DimGray;
            this.roleNameTxtBox.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.roleNameTxtBox.BorderThickness = 3;
            this.roleNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roleNameTxtBox.Enabled = false;
            this.roleNameTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.roleNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roleNameTxtBox.isPassword = false;
            this.roleNameTxtBox.Location = new System.Drawing.Point(211, 122);
            this.roleNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.roleNameTxtBox.Name = "roleNameTxtBox";
            this.roleNameTxtBox.Size = new System.Drawing.Size(354, 40);
            this.roleNameTxtBox.TabIndex = 16;
            this.roleNameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.roleNameTxtBox.OnValueChanged += new System.EventHandler(this.onRoleTxtBoxValueChanged);
            // 
            // rolesGridView
            // 
            this.rolesGridView.AllowUserToAddRows = false;
            this.rolesGridView.AllowUserToDeleteRows = false;
            this.rolesGridView.AllowUserToResizeColumns = false;
            this.rolesGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rolesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.rolesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rolesGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rolesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGVC,
            this.roleNameGVC,
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
            this.rolesGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.rolesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesGridView.EnableHeadersVisualStyles = false;
            this.rolesGridView.Location = new System.Drawing.Point(0, 0);
            this.rolesGridView.Name = "rolesGridView";
            this.rolesGridView.ReadOnly = true;
            this.rolesGridView.RowHeadersVisible = false;
            this.rolesGridView.RowTemplate.Height = 28;
            this.rolesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rolesGridView.Size = new System.Drawing.Size(759, 353);
            this.rolesGridView.TabIndex = 24;
            this.rolesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rolesGridView_CellClick);
            this.rolesGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rolesGridView_CellContentDoubleClick);
            // 
            // idGVC
            // 
            this.idGVC.DataPropertyName = "id";
            this.idGVC.HeaderText = "Id";
            this.idGVC.Name = "idGVC";
            this.idGVC.ReadOnly = true;
            this.idGVC.Visible = false;
            // 
            // roleNameGVC
            // 
            this.roleNameGVC.DataPropertyName = "name";
            this.roleNameGVC.FillWeight = 272.7471F;
            this.roleNameGVC.HeaderText = "Role";
            this.roleNameGVC.Name = "roleNameGVC";
            this.roleNameGVC.ReadOnly = true;
            // 
            // editActionGVC
            // 
            this.editActionGVC.FillWeight = 12.18274F;
            this.editActionGVC.HeaderText = "Edit";
            this.editActionGVC.Image = global::Desktop_LMS_UI.Properties.Resources.pencil__1_1;
            this.editActionGVC.Name = "editActionGVC";
            this.editActionGVC.ReadOnly = true;
            // 
            // deleteActionGVC
            // 
            this.deleteActionGVC.FillWeight = 15.07016F;
            this.deleteActionGVC.HeaderText = "Delete";
            this.deleteActionGVC.Image = global::Desktop_LMS_UI.Properties.Resources.delete__2_1;
            this.deleteActionGVC.Name = "deleteActionGVC";
            this.deleteActionGVC.ReadOnly = true;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.rolesGridView);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 313);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(759, 353);
            this.bottomPanel.TabIndex = 25;
            // 
            // roleNameErrorLbl
            // 
            this.roleNameErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleNameErrorLbl.AutoSize = true;
            this.roleNameErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleNameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.roleNameErrorLbl.Location = new System.Drawing.Point(292, 97);
            this.roleNameErrorLbl.Name = "roleNameErrorLbl";
            this.roleNameErrorLbl.Size = new System.Drawing.Size(17, 24);
            this.roleNameErrorLbl.TabIndex = 45;
            this.roleNameErrorLbl.Text = "*";
            this.roleNameErrorLbl.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = global::Desktop_LMS_UI.Properties.Resources.pencil__1_1;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 252;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = global::Desktop_LMS_UI.Properties.Resources.delete__2_1;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 252;
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
            this.addNewBtn.Location = new System.Drawing.Point(637, 52);
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
            this.searchTxtBox.Location = new System.Drawing.Point(498, 273);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(243, 34);
            this.searchTxtBox.TabIndex = 43;
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
            this.saveBtn.Location = new System.Drawing.Point(461, 169);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.saveBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.saveBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.saveBtn.selected = false;
            this.saveBtn.Size = new System.Drawing.Size(104, 40);
            this.saveBtn.TabIndex = 22;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBtn.Textcolor = System.Drawing.Color.White;
            this.saveBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 666);
            this.Controls.Add(this.roleNameErrorLbl);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.roleNameLbl);
            this.Controls.Add(this.roleNameTxtBox);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Roles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Roles_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesGridView)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label roleNameLbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox roleNameTxtBox;
        private Bunifu.Framework.UI.BunifuFlatButton saveBtn;
        private System.Windows.Forms.DataGridView rolesGridView;
        private System.Windows.Forms.Panel bottomPanel;
        private Bunifu.Framework.UI.BunifuTextbox searchTxtBox;
        private Bunifu.Framework.UI.BunifuFlatButton addNewBtn;
        private System.Windows.Forms.Label roleNameErrorLbl;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameGVC;
        private System.Windows.Forms.DataGridViewImageColumn editActionGVC;
        private System.Windows.Forms.DataGridViewImageColumn deleteActionGVC;
    }
}