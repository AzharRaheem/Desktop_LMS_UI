namespace Desktop_LMS_UI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.topPanel = new System.Windows.Forms.Panel();
            this.linePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.returnBooksProgressBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.issueBooksProgressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.booksProgressBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCards6 = new Bunifu.Framework.UI.BunifuCards();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.returnBooksCountLbl = new System.Windows.Forms.Label();
            this.bunifuCards5 = new Bunifu.Framework.UI.BunifuCards();
            this.booksLbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.issueBooksCount = new System.Windows.Forms.Label();
            this.bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.studentsCountLbl = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.usersPicBox = new System.Windows.Forms.PictureBox();
            this.userCountLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.rolesPicBox = new System.Windows.Forms.PictureBox();
            this.roleCountLbl = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.booksPicBox = new System.Windows.Forms.PictureBox();
            this.booksCountLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.bunifuCards6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.bunifuCards5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bunifuCards4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersPicBox)).BeginInit();
            this.bunifuCards3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesPicBox)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.linePanel);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1264, 46);
            this.topPanel.TabIndex = 14;
            // 
            // linePanel
            // 
            this.linePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linePanel.Location = new System.Drawing.Point(126, 27);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(1125, 5);
            this.linePanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.returnBooksProgressBar);
            this.panel1.Controls.Add(this.issueBooksProgressbar);
            this.panel1.Controls.Add(this.booksProgressBar);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 602);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(793, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "BOOKS RETURNED";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(553, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "BOOKS ISSUED";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(343, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "BOOKS";
            // 
            // returnBooksProgressBar
            // 
            this.returnBooksProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnBooksProgressBar.animated = false;
            this.returnBooksProgressBar.animationIterval = 5;
            this.returnBooksProgressBar.animationSpeed = 300;
            this.returnBooksProgressBar.BackColor = System.Drawing.Color.White;
            this.returnBooksProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returnBooksProgressBar.BackgroundImage")));
            this.returnBooksProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.returnBooksProgressBar.ForeColor = System.Drawing.Color.SteelBlue;
            this.returnBooksProgressBar.LabelVisible = true;
            this.returnBooksProgressBar.LineProgressThickness = 8;
            this.returnBooksProgressBar.LineThickness = 5;
            this.returnBooksProgressBar.Location = new System.Drawing.Point(803, 383);
            this.returnBooksProgressBar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.returnBooksProgressBar.MaxValue = 100;
            this.returnBooksProgressBar.Name = "returnBooksProgressBar";
            this.returnBooksProgressBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.returnBooksProgressBar.ProgressColor = System.Drawing.Color.Magenta;
            this.returnBooksProgressBar.Size = new System.Drawing.Size(201, 201);
            this.returnBooksProgressBar.TabIndex = 2;
            this.returnBooksProgressBar.Value = 0;
            // 
            // issueBooksProgressbar
            // 
            this.issueBooksProgressbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.issueBooksProgressbar.animated = false;
            this.issueBooksProgressbar.animationIterval = 5;
            this.issueBooksProgressbar.animationSpeed = 300;
            this.issueBooksProgressbar.BackColor = System.Drawing.Color.White;
            this.issueBooksProgressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("issueBooksProgressbar.BackgroundImage")));
            this.issueBooksProgressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.issueBooksProgressbar.ForeColor = System.Drawing.Color.SteelBlue;
            this.issueBooksProgressbar.LabelVisible = true;
            this.issueBooksProgressbar.LineProgressThickness = 8;
            this.issueBooksProgressbar.LineThickness = 5;
            this.issueBooksProgressbar.Location = new System.Drawing.Point(547, 383);
            this.issueBooksProgressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.issueBooksProgressbar.MaxValue = 100;
            this.issueBooksProgressbar.Name = "issueBooksProgressbar";
            this.issueBooksProgressbar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.issueBooksProgressbar.ProgressColor = System.Drawing.Color.Green;
            this.issueBooksProgressbar.Size = new System.Drawing.Size(201, 201);
            this.issueBooksProgressbar.TabIndex = 2;
            this.issueBooksProgressbar.Value = 0;
            // 
            // booksProgressBar
            // 
            this.booksProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.booksProgressBar.animated = false;
            this.booksProgressBar.animationIterval = 5;
            this.booksProgressBar.animationSpeed = 300;
            this.booksProgressBar.BackColor = System.Drawing.Color.White;
            this.booksProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("booksProgressBar.BackgroundImage")));
            this.booksProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.booksProgressBar.ForeColor = System.Drawing.Color.SteelBlue;
            this.booksProgressBar.LabelVisible = true;
            this.booksProgressBar.LineProgressThickness = 8;
            this.booksProgressBar.LineThickness = 5;
            this.booksProgressBar.Location = new System.Drawing.Point(291, 383);
            this.booksProgressBar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.booksProgressBar.MaxValue = 100;
            this.booksProgressBar.Name = "booksProgressBar";
            this.booksProgressBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.booksProgressBar.ProgressColor = System.Drawing.Color.Orange;
            this.booksProgressBar.Size = new System.Drawing.Size(201, 201);
            this.booksProgressBar.TabIndex = 2;
            this.booksProgressBar.Value = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.bunifuCards6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bunifuCards5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bunifuCards4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bunifuCards1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bunifuCards3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bunifuCards2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1234, 335);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // bunifuCards6
            // 
            this.bunifuCards6.BackColor = System.Drawing.Color.White;
            this.bunifuCards6.BorderRadius = 5;
            this.bunifuCards6.BottomSahddow = true;
            this.bunifuCards6.color = System.Drawing.Color.SteelBlue;
            this.bunifuCards6.Controls.Add(this.label9);
            this.bunifuCards6.Controls.Add(this.pictureBox3);
            this.bunifuCards6.Controls.Add(this.returnBooksCountLbl);
            this.bunifuCards6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards6.LeftSahddow = false;
            this.bunifuCards6.Location = new System.Drawing.Point(825, 170);
            this.bunifuCards6.Name = "bunifuCards6";
            this.bunifuCards6.RightSahddow = true;
            this.bunifuCards6.ShadowDepth = 20;
            this.bunifuCards6.Size = new System.Drawing.Size(406, 162);
            this.bunifuCards6.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(203, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 31);
            this.label9.TabIndex = 1;
            this.label9.Text = "Return Books";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::Desktop_LMS_UI.Properties.Resources.return__1_;
            this.pictureBox3.Location = new System.Drawing.Point(76, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(146, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // returnBooksCountLbl
            // 
            this.returnBooksCountLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnBooksCountLbl.AutoSize = true;
            this.returnBooksCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooksCountLbl.ForeColor = System.Drawing.Color.Navy;
            this.returnBooksCountLbl.Location = new System.Drawing.Point(253, 98);
            this.returnBooksCountLbl.Name = "returnBooksCountLbl";
            this.returnBooksCountLbl.Size = new System.Drawing.Size(39, 20);
            this.returnBooksCountLbl.TabIndex = 2;
            this.returnBooksCountLbl.Text = "100";
            // 
            // bunifuCards5
            // 
            this.bunifuCards5.BackColor = System.Drawing.Color.White;
            this.bunifuCards5.BorderRadius = 5;
            this.bunifuCards5.BottomSahddow = true;
            this.bunifuCards5.color = System.Drawing.Color.SteelBlue;
            this.bunifuCards5.Controls.Add(this.booksLbl);
            this.bunifuCards5.Controls.Add(this.pictureBox2);
            this.bunifuCards5.Controls.Add(this.issueBooksCount);
            this.bunifuCards5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards5.LeftSahddow = false;
            this.bunifuCards5.Location = new System.Drawing.Point(414, 170);
            this.bunifuCards5.Name = "bunifuCards5";
            this.bunifuCards5.RightSahddow = true;
            this.bunifuCards5.ShadowDepth = 20;
            this.bunifuCards5.Size = new System.Drawing.Size(405, 162);
            this.bunifuCards5.TabIndex = 5;
            // 
            // booksLbl
            // 
            this.booksLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.booksLbl.AutoSize = true;
            this.booksLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.booksLbl.Location = new System.Drawing.Point(198, 58);
            this.booksLbl.Name = "booksLbl";
            this.booksLbl.Size = new System.Drawing.Size(190, 31);
            this.booksLbl.TabIndex = 1;
            this.booksLbl.Text = "Books Issued";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Desktop_LMS_UI.Properties.Resources.reading;
            this.pictureBox2.Location = new System.Drawing.Point(75, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // issueBooksCount
            // 
            this.issueBooksCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.issueBooksCount.AutoSize = true;
            this.issueBooksCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBooksCount.ForeColor = System.Drawing.Color.Navy;
            this.issueBooksCount.Location = new System.Drawing.Point(249, 98);
            this.issueBooksCount.Name = "issueBooksCount";
            this.issueBooksCount.Size = new System.Drawing.Size(39, 20);
            this.issueBooksCount.TabIndex = 2;
            this.issueBooksCount.Text = "100";
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.BackColor = System.Drawing.Color.White;
            this.bunifuCards4.BorderRadius = 5;
            this.bunifuCards4.BottomSahddow = true;
            this.bunifuCards4.color = System.Drawing.Color.SteelBlue;
            this.bunifuCards4.Controls.Add(this.label5);
            this.bunifuCards4.Controls.Add(this.pictureBox1);
            this.bunifuCards4.Controls.Add(this.studentsCountLbl);
            this.bunifuCards4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards4.LeftSahddow = false;
            this.bunifuCards4.Location = new System.Drawing.Point(3, 170);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = true;
            this.bunifuCards4.ShadowDepth = 20;
            this.bunifuCards4.Size = new System.Drawing.Size(405, 162);
            this.bunifuCards4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(211, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Students";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Desktop_LMS_UI.Properties.Resources.student;
            this.pictureBox1.Location = new System.Drawing.Point(75, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // studentsCountLbl
            // 
            this.studentsCountLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentsCountLbl.AutoSize = true;
            this.studentsCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsCountLbl.ForeColor = System.Drawing.Color.Navy;
            this.studentsCountLbl.Location = new System.Drawing.Point(249, 98);
            this.studentsCountLbl.Name = "studentsCountLbl";
            this.studentsCountLbl.Size = new System.Drawing.Size(39, 20);
            this.studentsCountLbl.TabIndex = 2;
            this.studentsCountLbl.Text = "100";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SteelBlue;
            this.bunifuCards1.Controls.Add(this.usersPicBox);
            this.bunifuCards1.Controls.Add(this.userCountLbl);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(3, 3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(405, 161);
            this.bunifuCards1.TabIndex = 0;
            // 
            // usersPicBox
            // 
            this.usersPicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usersPicBox.Image = global::Desktop_LMS_UI.Properties.Resources.team__1_;
            this.usersPicBox.Location = new System.Drawing.Point(76, 17);
            this.usersPicBox.Name = "usersPicBox";
            this.usersPicBox.Size = new System.Drawing.Size(146, 130);
            this.usersPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usersPicBox.TabIndex = 3;
            this.usersPicBox.TabStop = false;
            // 
            // userCountLbl
            // 
            this.userCountLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userCountLbl.AutoSize = true;
            this.userCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCountLbl.ForeColor = System.Drawing.Color.Navy;
            this.userCountLbl.Location = new System.Drawing.Point(251, 97);
            this.userCountLbl.Name = "userCountLbl";
            this.userCountLbl.Size = new System.Drawing.Size(39, 20);
            this.userCountLbl.TabIndex = 2;
            this.userCountLbl.Text = "100";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(224, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Users";
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.SteelBlue;
            this.bunifuCards3.Controls.Add(this.rolesPicBox);
            this.bunifuCards3.Controls.Add(this.roleCountLbl);
            this.bunifuCards3.Controls.Add(this.lbl);
            this.bunifuCards3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(825, 3);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(406, 161);
            this.bunifuCards3.TabIndex = 0;
            // 
            // rolesPicBox
            // 
            this.rolesPicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rolesPicBox.Image = global::Desktop_LMS_UI.Properties.Resources.settings;
            this.rolesPicBox.Location = new System.Drawing.Point(75, 17);
            this.rolesPicBox.Name = "rolesPicBox";
            this.rolesPicBox.Size = new System.Drawing.Size(146, 130);
            this.rolesPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rolesPicBox.TabIndex = 3;
            this.rolesPicBox.TabStop = false;
            // 
            // roleCountLbl
            // 
            this.roleCountLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleCountLbl.AutoSize = true;
            this.roleCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleCountLbl.ForeColor = System.Drawing.Color.Navy;
            this.roleCountLbl.Location = new System.Drawing.Point(253, 97);
            this.roleCountLbl.Name = "roleCountLbl";
            this.roleCountLbl.Size = new System.Drawing.Size(39, 20);
            this.roleCountLbl.TabIndex = 2;
            this.roleCountLbl.Text = "100";
            // 
            // lbl
            // 
            this.lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl.Location = new System.Drawing.Point(226, 57);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(89, 31);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Roles";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.SteelBlue;
            this.bunifuCards2.Controls.Add(this.booksPicBox);
            this.bunifuCards2.Controls.Add(this.booksCountLbl);
            this.bunifuCards2.Controls.Add(this.label3);
            this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(414, 3);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(405, 161);
            this.bunifuCards2.TabIndex = 0;
            // 
            // booksPicBox
            // 
            this.booksPicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.booksPicBox.Image = global::Desktop_LMS_UI.Properties.Resources.books;
            this.booksPicBox.Location = new System.Drawing.Point(75, 17);
            this.booksPicBox.Name = "booksPicBox";
            this.booksPicBox.Size = new System.Drawing.Size(146, 130);
            this.booksPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.booksPicBox.TabIndex = 3;
            this.booksPicBox.TabStop = false;
            // 
            // booksCountLbl
            // 
            this.booksCountLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.booksCountLbl.AutoSize = true;
            this.booksCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksCountLbl.ForeColor = System.Drawing.Color.Navy;
            this.booksCountLbl.Location = new System.Drawing.Point(249, 97);
            this.booksCountLbl.Name = "booksCountLbl";
            this.booksCountLbl.Size = new System.Drawing.Size(39, 20);
            this.booksCountLbl.TabIndex = 2;
            this.booksCountLbl.Text = "100";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(222, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Books";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.bunifuCards6.ResumeLayout(false);
            this.bunifuCards6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.bunifuCards5.ResumeLayout(false);
            this.bunifuCards5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bunifuCards4.ResumeLayout(false);
            this.bunifuCards4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersPicBox)).EndInit();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesPicBox)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel linePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label userCountLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label roleCountLbl;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label booksCountLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox usersPicBox;
        private System.Windows.Forms.PictureBox rolesPicBox;
        private System.Windows.Forms.PictureBox booksPicBox;
        private Bunifu.Framework.UI.BunifuCards bunifuCards6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label returnBooksCountLbl;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuCards bunifuCards5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label issueBooksCount;
        private System.Windows.Forms.Label booksLbl;
        private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label studentsCountLbl;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCircleProgressbar booksProgressBar;
        private Bunifu.Framework.UI.BunifuCircleProgressbar returnBooksProgressBar;
        private Bunifu.Framework.UI.BunifuCircleProgressbar issueBooksProgressbar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}