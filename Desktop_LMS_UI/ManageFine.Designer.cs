namespace Desktop_LMS_UI
{
    partial class ManageFine
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
            this.FineErrorLbl = new System.Windows.Forms.Label();
            this.addNewBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.FinesGridView = new System.Windows.Forms.DataGridView();
            this.saveBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.roleNameLbl = new System.Windows.Forms.Label();
            this.fineTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.idGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineValueGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editActionGVC = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteActionGVC = new System.Windows.Forms.DataGridViewImageColumn();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FinesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.panel1);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(830, 46);
            this.topPanel.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(144, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 5);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Fines";
            // 
            // FineErrorLbl
            // 
            this.FineErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FineErrorLbl.AutoSize = true;
            this.FineErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FineErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.FineErrorLbl.Location = new System.Drawing.Point(336, 124);
            this.FineErrorLbl.Name = "FineErrorLbl";
            this.FineErrorLbl.Size = new System.Drawing.Size(17, 24);
            this.FineErrorLbl.TabIndex = 60;
            this.FineErrorLbl.Text = "*";
            this.FineErrorLbl.Visible = false;
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
            this.addNewBtn.Location = new System.Drawing.Point(708, 52);
            this.addNewBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.addNewBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.addNewBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addNewBtn.selected = false;
            this.addNewBtn.Size = new System.Drawing.Size(104, 33);
            this.addNewBtn.TabIndex = 59;
            this.addNewBtn.Text = "Add New";
            this.addNewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewBtn.Textcolor = System.Drawing.Color.White;
            this.addNewBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.FinesGridView);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 308);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(830, 368);
            this.bottomPanel.TabIndex = 57;
            // 
            // FinesGridView
            // 
            this.FinesGridView.AllowUserToAddRows = false;
            this.FinesGridView.AllowUserToDeleteRows = false;
            this.FinesGridView.AllowUserToResizeColumns = false;
            this.FinesGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FinesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FinesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FinesGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FinesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FinesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FinesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGVC,
            this.fineValueGVC,
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
            this.FinesGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.FinesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinesGridView.EnableHeadersVisualStyles = false;
            this.FinesGridView.Location = new System.Drawing.Point(0, 0);
            this.FinesGridView.Name = "FinesGridView";
            this.FinesGridView.ReadOnly = true;
            this.FinesGridView.RowHeadersVisible = false;
            this.FinesGridView.RowTemplate.Height = 28;
            this.FinesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FinesGridView.Size = new System.Drawing.Size(830, 368);
            this.FinesGridView.TabIndex = 24;
            this.FinesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FinesGridView_CellContentClick);
            this.FinesGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FinesGridView_CellDoubleClick);
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
            this.saveBtn.Location = new System.Drawing.Point(452, 197);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.saveBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.saveBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.saveBtn.selected = false;
            this.saveBtn.Size = new System.Drawing.Size(104, 40);
            this.saveBtn.TabIndex = 56;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBtn.Textcolor = System.Drawing.Color.White;
            this.saveBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // roleNameLbl
            // 
            this.roleNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleNameLbl.AutoSize = true;
            this.roleNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleNameLbl.Location = new System.Drawing.Point(202, 130);
            this.roleNameLbl.Name = "roleNameLbl";
            this.roleNameLbl.Size = new System.Drawing.Size(138, 16);
            this.roleNameLbl.TabIndex = 55;
            this.roleNameLbl.Text = "Fine / Additional Day :";
            // 
            // fineTxtBox
            // 
            this.fineTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fineTxtBox.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.fineTxtBox.BorderColorIdle = System.Drawing.Color.DimGray;
            this.fineTxtBox.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.fineTxtBox.BorderThickness = 3;
            this.fineTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fineTxtBox.Enabled = false;
            this.fineTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fineTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fineTxtBox.isPassword = false;
            this.fineTxtBox.Location = new System.Drawing.Point(202, 150);
            this.fineTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.fineTxtBox.Name = "fineTxtBox";
            this.fineTxtBox.Size = new System.Drawing.Size(354, 40);
            this.fineTxtBox.TabIndex = 54;
            this.fineTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fineTxtBox.OnValueChanged += new System.EventHandler(this.fineTxtBox_OnValueChanged);
            // 
            // idGVC
            // 
            this.idGVC.DataPropertyName = "id";
            this.idGVC.HeaderText = "Id";
            this.idGVC.Name = "idGVC";
            this.idGVC.ReadOnly = true;
            this.idGVC.Visible = false;
            // 
            // fineValueGVC
            // 
            this.fineValueGVC.DataPropertyName = "fine";
            this.fineValueGVC.FillWeight = 272.7471F;
            this.fineValueGVC.HeaderText = "Fine / +Day";
            this.fineValueGVC.Name = "fineValueGVC";
            this.fineValueGVC.ReadOnly = true;
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
            // ManageFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 676);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.roleNameLbl);
            this.Controls.Add(this.fineTxtBox);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.FineErrorLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageFine";
            this.Text = "ManageFine";
            this.Load += new System.EventHandler(this.ManageFine_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FinesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FineErrorLbl;
        private Bunifu.Framework.UI.BunifuFlatButton addNewBtn;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.DataGridView FinesGridView;
        private Bunifu.Framework.UI.BunifuFlatButton saveBtn;
        private System.Windows.Forms.Label roleNameLbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox fineTxtBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineValueGVC;
        private System.Windows.Forms.DataGridViewImageColumn editActionGVC;
        private System.Windows.Forms.DataGridViewImageColumn deleteActionGVC;
    }
}