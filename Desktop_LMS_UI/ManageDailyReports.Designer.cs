namespace Desktop_LMS_UI
{
    partial class ManageDailyReports
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.linePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.issueReportCard = new Bunifu.Framework.UI.BunifuCards();
            this.issueBookGetReportBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.issueBookDailyReportLbl = new System.Windows.Forms.Label();
            this.dailyReportPicBox = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.issueReportCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.linePanel);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(848, 46);
            this.topPanel.TabIndex = 14;
            // 
            // linePanel
            // 
            this.linePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linePanel.Location = new System.Drawing.Point(151, 27);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(680, 5);
            this.linePanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Reports";
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.tableLayoutPanel1);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 46);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(848, 619);
            this.bodyPanel.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bunifuCards1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.issueReportCard, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.78675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.82553F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 619);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SteelBlue;
            this.bunifuCards1.Controls.Add(this.bunifuFlatButton1);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(427, 3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(418, 166);
            this.bunifuCards1.TabIndex = 1;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.SteelBlue;
            this.bunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.SteelBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "Get Report";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::Desktop_LMS_UI.Properties.Resources.plus;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 45D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(181, 87);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.SteelBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Orange;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.SteelBlue;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(171, 40);
            this.bunifuFlatButton1.TabIndex = 37;
            this.bunifuFlatButton1.Text = "Get Report";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(148, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Return Books Report";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Desktop_LMS_UI.Properties.Resources.ReturnBookReport__2_;
            this.pictureBox1.Location = new System.Drawing.Point(16, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // issueReportCard
            // 
            this.issueReportCard.BackColor = System.Drawing.Color.White;
            this.issueReportCard.BorderRadius = 5;
            this.issueReportCard.BottomSahddow = true;
            this.issueReportCard.color = System.Drawing.Color.SteelBlue;
            this.issueReportCard.Controls.Add(this.issueBookGetReportBtn);
            this.issueReportCard.Controls.Add(this.issueBookDailyReportLbl);
            this.issueReportCard.Controls.Add(this.dailyReportPicBox);
            this.issueReportCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issueReportCard.LeftSahddow = false;
            this.issueReportCard.Location = new System.Drawing.Point(3, 3);
            this.issueReportCard.Name = "issueReportCard";
            this.issueReportCard.RightSahddow = true;
            this.issueReportCard.ShadowDepth = 20;
            this.issueReportCard.Size = new System.Drawing.Size(418, 166);
            this.issueReportCard.TabIndex = 0;
            // 
            // issueBookGetReportBtn
            // 
            this.issueBookGetReportBtn.Activecolor = System.Drawing.Color.SteelBlue;
            this.issueBookGetReportBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.issueBookGetReportBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.issueBookGetReportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.issueBookGetReportBtn.BorderRadius = 5;
            this.issueBookGetReportBtn.ButtonText = "Get Report";
            this.issueBookGetReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueBookGetReportBtn.DisabledColor = System.Drawing.Color.Gray;
            this.issueBookGetReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBookGetReportBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.issueBookGetReportBtn.Iconimage = global::Desktop_LMS_UI.Properties.Resources.plus;
            this.issueBookGetReportBtn.Iconimage_right = null;
            this.issueBookGetReportBtn.Iconimage_right_Selected = null;
            this.issueBookGetReportBtn.Iconimage_Selected = null;
            this.issueBookGetReportBtn.IconMarginLeft = 0;
            this.issueBookGetReportBtn.IconMarginRight = 0;
            this.issueBookGetReportBtn.IconRightVisible = true;
            this.issueBookGetReportBtn.IconRightZoom = 0D;
            this.issueBookGetReportBtn.IconVisible = false;
            this.issueBookGetReportBtn.IconZoom = 45D;
            this.issueBookGetReportBtn.IsTab = false;
            this.issueBookGetReportBtn.Location = new System.Drawing.Point(181, 87);
            this.issueBookGetReportBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.issueBookGetReportBtn.Name = "issueBookGetReportBtn";
            this.issueBookGetReportBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.issueBookGetReportBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.issueBookGetReportBtn.OnHoverTextColor = System.Drawing.Color.SteelBlue;
            this.issueBookGetReportBtn.selected = false;
            this.issueBookGetReportBtn.Size = new System.Drawing.Size(171, 40);
            this.issueBookGetReportBtn.TabIndex = 37;
            this.issueBookGetReportBtn.Text = "Get Report";
            this.issueBookGetReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.issueBookGetReportBtn.Textcolor = System.Drawing.Color.White;
            this.issueBookGetReportBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBookGetReportBtn.Click += new System.EventHandler(this.issueBookGetReportBtn_Click);
            // 
            // issueBookDailyReportLbl
            // 
            this.issueBookDailyReportLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.issueBookDailyReportLbl.AutoSize = true;
            this.issueBookDailyReportLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBookDailyReportLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.issueBookDailyReportLbl.Location = new System.Drawing.Point(148, 42);
            this.issueBookDailyReportLbl.Name = "issueBookDailyReportLbl";
            this.issueBookDailyReportLbl.Size = new System.Drawing.Size(241, 29);
            this.issueBookDailyReportLbl.TabIndex = 2;
            this.issueBookDailyReportLbl.Text = "Issue Books Report";
            // 
            // dailyReportPicBox
            // 
            this.dailyReportPicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dailyReportPicBox.Image = global::Desktop_LMS_UI.Properties.Resources.issueBookReport;
            this.dailyReportPicBox.Location = new System.Drawing.Point(15, 17);
            this.dailyReportPicBox.Name = "dailyReportPicBox";
            this.dailyReportPicBox.Size = new System.Drawing.Size(120, 131);
            this.dailyReportPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dailyReportPicBox.TabIndex = 1;
            this.dailyReportPicBox.TabStop = false;
            // 
            // ManageDailyReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 665);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageDailyReports";
            this.Text = "ManageDailyReports";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bodyPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.issueReportCard.ResumeLayout(false);
            this.issueReportCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel linePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCards issueReportCard;
        private System.Windows.Forms.Label issueBookDailyReportLbl;
        private System.Windows.Forms.PictureBox dailyReportPicBox;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton issueBookGetReportBtn;
    }
}