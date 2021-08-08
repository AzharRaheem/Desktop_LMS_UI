namespace Desktop_LMS_UI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainTLP = new System.Windows.Forms.TableLayoutPanel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.manageDepartmentsBtn = new System.Windows.Forms.Button();
            this.manageFineBtn = new System.Windows.Forms.Button();
            this.manageStudentsBtn = new System.Windows.Forms.Button();
            this.dailyReportBtn = new System.Windows.Forms.Button();
            this.returnBookBtn = new System.Windows.Forms.Button();
            this.issueBookBtn = new System.Windows.Forms.Button();
            this.manageBooksBtn = new System.Windows.Forms.Button();
            this.manageCategoryBtn = new System.Windows.Forms.Button();
            this.manageRolesBtn = new System.Windows.Forms.Button();
            this.manageUsersBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.leftTopPanel = new System.Windows.Forms.Panel();
            this.loginUserRoleLbl = new System.Windows.Forms.Label();
            this.loginUserNameLbl = new System.Windows.Forms.Label();
            this.loginUserProfilePicBox = new System.Windows.Forms.PictureBox();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.deptLogoPicBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.universityLogoPicBox = new System.Windows.Forms.PictureBox();
            this.mainTLP.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.leftTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginUserProfilePicBox)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptLogoPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityLogoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTLP
            // 
            this.mainTLP.ColumnCount = 2;
            this.mainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.79736F));
            this.mainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.20264F));
            this.mainTLP.Controls.Add(this.leftPanel, 0, 0);
            this.mainTLP.Controls.Add(this.bodyPanel, 1, 0);
            this.mainTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTLP.Location = new System.Drawing.Point(0, 0);
            this.mainTLP.Name = "mainTLP";
            this.mainTLP.RowCount = 1;
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 840F));
            this.mainTLP.Size = new System.Drawing.Size(1281, 840);
            this.mainTLP.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.leftPanel.Controls.Add(this.panel1);
            this.leftPanel.Controls.Add(this.leftTopPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(3, 3);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(286, 834);
            this.leftPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.manageDepartmentsBtn);
            this.panel1.Controls.Add(this.manageFineBtn);
            this.panel1.Controls.Add(this.manageStudentsBtn);
            this.panel1.Controls.Add(this.dailyReportBtn);
            this.panel1.Controls.Add(this.returnBookBtn);
            this.panel1.Controls.Add(this.issueBookBtn);
            this.panel1.Controls.Add(this.manageBooksBtn);
            this.panel1.Controls.Add(this.manageCategoryBtn);
            this.panel1.Controls.Add(this.manageRolesBtn);
            this.panel1.Controls.Add(this.manageUsersBtn);
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 739);
            this.panel1.TabIndex = 1;
            // 
            // manageDepartmentsBtn
            // 
            this.manageDepartmentsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manageDepartmentsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageDepartmentsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.manageDepartmentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageDepartmentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageDepartmentsBtn.ForeColor = System.Drawing.Color.White;
            this.manageDepartmentsBtn.Image = global::Desktop_LMS_UI.Properties.Resources.courthouse;
            this.manageDepartmentsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageDepartmentsBtn.Location = new System.Drawing.Point(4, 323);
            this.manageDepartmentsBtn.Name = "manageDepartmentsBtn";
            this.manageDepartmentsBtn.Size = new System.Drawing.Size(279, 49);
            this.manageDepartmentsBtn.TabIndex = 5;
            this.manageDepartmentsBtn.Text = "Manage Departments";
            this.manageDepartmentsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageDepartmentsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageDepartmentsBtn.UseVisualStyleBackColor = true;
            this.manageDepartmentsBtn.Click += new System.EventHandler(this.manageDepartmentsBtn_Click);
            // 
            // manageFineBtn
            // 
            this.manageFineBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manageFineBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageFineBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.manageFineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageFineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageFineBtn.ForeColor = System.Drawing.Color.White;
            this.manageFineBtn.Image = global::Desktop_LMS_UI.Properties.Resources.payment_method;
            this.manageFineBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageFineBtn.Location = new System.Drawing.Point(3, 433);
            this.manageFineBtn.Name = "manageFineBtn";
            this.manageFineBtn.Size = new System.Drawing.Size(279, 49);
            this.manageFineBtn.TabIndex = 4;
            this.manageFineBtn.Text = "Manage Fine";
            this.manageFineBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageFineBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageFineBtn.UseVisualStyleBackColor = true;
            this.manageFineBtn.Click += new System.EventHandler(this.manageFineBtn_Click);
            // 
            // manageStudentsBtn
            // 
            this.manageStudentsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manageStudentsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageStudentsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.manageStudentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageStudentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageStudentsBtn.ForeColor = System.Drawing.Color.White;
            this.manageStudentsBtn.Image = global::Desktop_LMS_UI.Properties.Resources.students;
            this.manageStudentsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageStudentsBtn.Location = new System.Drawing.Point(3, 378);
            this.manageStudentsBtn.Name = "manageStudentsBtn";
            this.manageStudentsBtn.Size = new System.Drawing.Size(279, 49);
            this.manageStudentsBtn.TabIndex = 3;
            this.manageStudentsBtn.Text = "Manage Students";
            this.manageStudentsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageStudentsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageStudentsBtn.UseVisualStyleBackColor = true;
            this.manageStudentsBtn.Click += new System.EventHandler(this.manageStudentsBtn_Click);
            // 
            // dailyReportBtn
            // 
            this.dailyReportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dailyReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dailyReportBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dailyReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailyReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyReportBtn.ForeColor = System.Drawing.Color.White;
            this.dailyReportBtn.Image = global::Desktop_LMS_UI.Properties.Resources.report;
            this.dailyReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dailyReportBtn.Location = new System.Drawing.Point(4, 598);
            this.dailyReportBtn.Name = "dailyReportBtn";
            this.dailyReportBtn.Size = new System.Drawing.Size(279, 49);
            this.dailyReportBtn.TabIndex = 3;
            this.dailyReportBtn.Text = "Daily Report";
            this.dailyReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dailyReportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dailyReportBtn.UseVisualStyleBackColor = true;
            this.dailyReportBtn.Click += new System.EventHandler(this.dailyReportBtn_Click);
            // 
            // returnBookBtn
            // 
            this.returnBookBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.returnBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBookBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.returnBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBookBtn.ForeColor = System.Drawing.Color.White;
            this.returnBookBtn.Image = global::Desktop_LMS_UI.Properties.Resources._return;
            this.returnBookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBookBtn.Location = new System.Drawing.Point(4, 543);
            this.returnBookBtn.Name = "returnBookBtn";
            this.returnBookBtn.Size = new System.Drawing.Size(279, 49);
            this.returnBookBtn.TabIndex = 3;
            this.returnBookBtn.Text = "Return Book";
            this.returnBookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.returnBookBtn.UseVisualStyleBackColor = true;
            this.returnBookBtn.Click += new System.EventHandler(this.returnBookBtn_Click);
            // 
            // issueBookBtn
            // 
            this.issueBookBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issueBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueBookBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.issueBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBookBtn.ForeColor = System.Drawing.Color.White;
            this.issueBookBtn.Image = global::Desktop_LMS_UI.Properties.Resources.read;
            this.issueBookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issueBookBtn.Location = new System.Drawing.Point(4, 488);
            this.issueBookBtn.Name = "issueBookBtn";
            this.issueBookBtn.Size = new System.Drawing.Size(279, 49);
            this.issueBookBtn.TabIndex = 3;
            this.issueBookBtn.Text = "Issue Book";
            this.issueBookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issueBookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.issueBookBtn.UseVisualStyleBackColor = true;
            this.issueBookBtn.Click += new System.EventHandler(this.issueBookBtn_Click);
            // 
            // manageBooksBtn
            // 
            this.manageBooksBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manageBooksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageBooksBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.manageBooksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBooksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBooksBtn.ForeColor = System.Drawing.Color.White;
            this.manageBooksBtn.Image = global::Desktop_LMS_UI.Properties.Resources.book;
            this.manageBooksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageBooksBtn.Location = new System.Drawing.Point(3, 267);
            this.manageBooksBtn.Name = "manageBooksBtn";
            this.manageBooksBtn.Size = new System.Drawing.Size(279, 49);
            this.manageBooksBtn.TabIndex = 3;
            this.manageBooksBtn.Text = "Manage Books";
            this.manageBooksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageBooksBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageBooksBtn.UseVisualStyleBackColor = true;
            this.manageBooksBtn.Click += new System.EventHandler(this.manageBooksBtn_Click);
            // 
            // manageCategoryBtn
            // 
            this.manageCategoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manageCategoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageCategoryBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.manageCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCategoryBtn.ForeColor = System.Drawing.Color.White;
            this.manageCategoryBtn.Image = global::Desktop_LMS_UI.Properties.Resources.backend;
            this.manageCategoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageCategoryBtn.Location = new System.Drawing.Point(3, 212);
            this.manageCategoryBtn.Name = "manageCategoryBtn";
            this.manageCategoryBtn.Size = new System.Drawing.Size(279, 49);
            this.manageCategoryBtn.TabIndex = 3;
            this.manageCategoryBtn.Text = "Manage Categories";
            this.manageCategoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageCategoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageCategoryBtn.UseVisualStyleBackColor = true;
            this.manageCategoryBtn.Click += new System.EventHandler(this.manageCategoryBtn_Click);
            // 
            // manageRolesBtn
            // 
            this.manageRolesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manageRolesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageRolesBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.manageRolesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageRolesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageRolesBtn.ForeColor = System.Drawing.Color.White;
            this.manageRolesBtn.Image = global::Desktop_LMS_UI.Properties.Resources.role;
            this.manageRolesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageRolesBtn.Location = new System.Drawing.Point(3, 157);
            this.manageRolesBtn.Name = "manageRolesBtn";
            this.manageRolesBtn.Size = new System.Drawing.Size(279, 49);
            this.manageRolesBtn.TabIndex = 3;
            this.manageRolesBtn.Text = "Manage Roles";
            this.manageRolesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageRolesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageRolesBtn.UseVisualStyleBackColor = true;
            this.manageRolesBtn.Click += new System.EventHandler(this.manageRolesBtn_Click);
            // 
            // manageUsersBtn
            // 
            this.manageUsersBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manageUsersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageUsersBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.manageUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageUsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUsersBtn.ForeColor = System.Drawing.Color.White;
            this.manageUsersBtn.Image = global::Desktop_LMS_UI.Properties.Resources.team;
            this.manageUsersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageUsersBtn.Location = new System.Drawing.Point(3, 102);
            this.manageUsersBtn.Name = "manageUsersBtn";
            this.manageUsersBtn.Size = new System.Drawing.Size(279, 49);
            this.manageUsersBtn.TabIndex = 3;
            this.manageUsersBtn.Text = "Manage Users";
            this.manageUsersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageUsersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageUsersBtn.UseVisualStyleBackColor = true;
            this.manageUsersBtn.Click += new System.EventHandler(this.manageUsersBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.Image = global::Desktop_LMS_UI.Properties.Resources.business_report;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(3, 47);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(279, 49);
            this.dashboardBtn.TabIndex = 3;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardBtn.UseVisualStyleBackColor = true;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Image = global::Desktop_LMS_UI.Properties.Resources.logout__4_;
            this.logoutBtn.Location = new System.Drawing.Point(0, 705);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(286, 34);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.onLogoutClick);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 41);
            this.panel2.TabIndex = 1;
            // 
            // leftTopPanel
            // 
            this.leftTopPanel.Controls.Add(this.loginUserRoleLbl);
            this.leftTopPanel.Controls.Add(this.loginUserNameLbl);
            this.leftTopPanel.Controls.Add(this.loginUserProfilePicBox);
            this.leftTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftTopPanel.Location = new System.Drawing.Point(0, 0);
            this.leftTopPanel.Name = "leftTopPanel";
            this.leftTopPanel.Size = new System.Drawing.Size(286, 95);
            this.leftTopPanel.TabIndex = 0;
            // 
            // loginUserRoleLbl
            // 
            this.loginUserRoleLbl.AutoSize = true;
            this.loginUserRoleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.loginUserRoleLbl.ForeColor = System.Drawing.Color.White;
            this.loginUserRoleLbl.Location = new System.Drawing.Point(95, 68);
            this.loginUserRoleLbl.Name = "loginUserRoleLbl";
            this.loginUserRoleLbl.Size = new System.Drawing.Size(96, 15);
            this.loginUserRoleLbl.TabIndex = 1;
            this.loginUserRoleLbl.Text = "Login User Role";
            // 
            // loginUserNameLbl
            // 
            this.loginUserNameLbl.AutoSize = true;
            this.loginUserNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.loginUserNameLbl.ForeColor = System.Drawing.Color.White;
            this.loginUserNameLbl.Location = new System.Drawing.Point(95, 51);
            this.loginUserNameLbl.Name = "loginUserNameLbl";
            this.loginUserNameLbl.Size = new System.Drawing.Size(119, 15);
            this.loginUserNameLbl.TabIndex = 1;
            this.loginUserNameLbl.Text = "Login User Name";
            // 
            // loginUserProfilePicBox
            // 
            this.loginUserProfilePicBox.Image = global::Desktop_LMS_UI.Properties.Resources.profile;
            this.loginUserProfilePicBox.Location = new System.Drawing.Point(4, 2);
            this.loginUserProfilePicBox.Name = "loginUserProfilePicBox";
            this.loginUserProfilePicBox.Size = new System.Drawing.Size(85, 89);
            this.loginUserProfilePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginUserProfilePicBox.TabIndex = 0;
            this.loginUserProfilePicBox.TabStop = false;
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.Color.White;
            this.bodyPanel.Controls.Add(this.contentPanel);
            this.bodyPanel.Controls.Add(this.footerPanel);
            this.bodyPanel.Controls.Add(this.headerPanel);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(295, 3);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(983, 834);
            this.bodyPanel.TabIndex = 1;
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 77);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(983, 737);
            this.contentPanel.TabIndex = 2;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Silver;
            this.footerPanel.Controls.Add(this.label1);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 814);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(983, 20);
            this.footerPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Rights Reserved 2021.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Silver;
            this.headerPanel.Controls.Add(this.deptLogoPicBox);
            this.headerPanel.Controls.Add(this.label3);
            this.headerPanel.Controls.Add(this.label2);
            this.headerPanel.Controls.Add(this.universityLogoPicBox);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(983, 77);
            this.headerPanel.TabIndex = 0;
            // 
            // deptLogoPicBox
            // 
            this.deptLogoPicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deptLogoPicBox.Image = global::Desktop_LMS_UI.Properties.Resources.Department_Logo;
            this.deptLogoPicBox.Location = new System.Drawing.Point(809, -4);
            this.deptLogoPicBox.Name = "deptLogoPicBox";
            this.deptLogoPicBox.Size = new System.Drawing.Size(83, 83);
            this.deptLogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deptLogoPicBox.TabIndex = 3;
            this.deptLogoPicBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(284, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Department of Software Engineering";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(160, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(644, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digital Library University of Azad Jammu and Kashmir";
            // 
            // universityLogoPicBox
            // 
            this.universityLogoPicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.universityLogoPicBox.Image = global::Desktop_LMS_UI.Properties.Resources.University_Logo;
            this.universityLogoPicBox.Location = new System.Drawing.Point(82, 2);
            this.universityLogoPicBox.Name = "universityLogoPicBox";
            this.universityLogoPicBox.Size = new System.Drawing.Size(82, 71);
            this.universityLogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.universityLogoPicBox.TabIndex = 2;
            this.universityLogoPicBox.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 840);
            this.Controls.Add(this.mainTLP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mainTLP.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.leftTopPanel.ResumeLayout(false);
            this.leftTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginUserProfilePicBox)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptLogoPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityLogoPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTLP;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel leftTopPanel;
        private System.Windows.Forms.Label loginUserRoleLbl;
        private System.Windows.Forms.Label loginUserNameLbl;
        private System.Windows.Forms.PictureBox loginUserProfilePicBox;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button dailyReportBtn;
        private System.Windows.Forms.Button returnBookBtn;
        private System.Windows.Forms.Button issueBookBtn;
        private System.Windows.Forms.Button manageBooksBtn;
        private System.Windows.Forms.Button manageStudentsBtn;
        private System.Windows.Forms.Button manageCategoryBtn;
        private System.Windows.Forms.Button manageUsersBtn;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button manageRolesBtn;
        private System.Windows.Forms.Button manageFineBtn;
        private System.Windows.Forms.PictureBox deptLogoPicBox;
        private System.Windows.Forms.PictureBox universityLogoPicBox;
        private System.Windows.Forms.Button manageDepartmentsBtn;
    }
}