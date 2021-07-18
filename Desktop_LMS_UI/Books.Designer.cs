namespace Desktop_LMS_UI
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            this.topPanel = new System.Windows.Forms.Panel();
            this.linePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bookNameLbl = new System.Windows.Forms.Label();
            this.bookNameTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.authorNameTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.publisherTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.publisherlbl = new System.Windows.Forms.Label();
            this.editionTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bookPriceLbl = new System.Windows.Forms.Label();
            this.barcodeTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.isbnTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.barcodeLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.booksGridView = new System.Windows.Forms.DataGridView();
            this.idGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookImagePathGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookImgBoxGVC = new System.Windows.Forms.DataGridViewImageColumn();
            this.bookNameGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editionGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnGVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editActionGVC = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteActionGVC = new System.Windows.Forms.DataGridViewImageColumn();
            this.categoryDD = new System.Windows.Forms.ComboBox();
            this.booknameErrorLbl = new System.Windows.Forms.Label();
            this.categoryDDErrorLbl = new System.Windows.Forms.Label();
            this.authorNameErrorLbl = new System.Windows.Forms.Label();
            this.publisherErrorLbl = new System.Windows.Forms.Label();
            this.editionVolumeErrorLbl = new System.Windows.Forms.Label();
            this.barcodeErrorLbl = new System.Windows.Forms.Label();
            this.priceErrorLbl = new System.Windows.Forms.Label();
            this.isbnErrorLbl = new System.Windows.Forms.Label();
            this.bookPictureOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.uploadBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.bookPicBox = new System.Windows.Forms.PictureBox();
            this.saveBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addNewBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.linePanel);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(905, 46);
            this.topPanel.TabIndex = 11;
            // 
            // linePanel
            // 
            this.linePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linePanel.Location = new System.Drawing.Point(80, 27);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(808, 5);
            this.linePanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Books";
            // 
            // bookNameLbl
            // 
            this.bookNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookNameLbl.AutoSize = true;
            this.bookNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameLbl.Location = new System.Drawing.Point(10, 123);
            this.bookNameLbl.Name = "bookNameLbl";
            this.bookNameLbl.Size = new System.Drawing.Size(78, 16);
            this.bookNameLbl.TabIndex = 14;
            this.bookNameLbl.Text = "Book Title : ";
            // 
            // bookNameTxtBox
            // 
            this.bookNameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookNameTxtBox.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.bookNameTxtBox.BorderColorIdle = System.Drawing.Color.DimGray;
            this.bookNameTxtBox.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.bookNameTxtBox.BorderThickness = 3;
            this.bookNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookNameTxtBox.Enabled = false;
            this.bookNameTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bookNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookNameTxtBox.isPassword = false;
            this.bookNameTxtBox.Location = new System.Drawing.Point(12, 141);
            this.bookNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.bookNameTxtBox.Name = "bookNameTxtBox";
            this.bookNameTxtBox.Size = new System.Drawing.Size(304, 40);
            this.bookNameTxtBox.TabIndex = 0;
            this.bookNameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bookNameTxtBox.OnValueChanged += new System.EventHandler(this.bookNameTxtBox_OnValueChanged);
            // 
            // categoryLbl
            // 
            this.categoryLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.Location = new System.Drawing.Point(347, 123);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(112, 16);
            this.categoryLbl.TabIndex = 14;
            this.categoryLbl.Text = "Category Name : ";
            // 
            // authorNameTxtBox
            // 
            this.authorNameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authorNameTxtBox.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.authorNameTxtBox.BorderColorIdle = System.Drawing.Color.DimGray;
            this.authorNameTxtBox.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.authorNameTxtBox.BorderThickness = 3;
            this.authorNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.authorNameTxtBox.Enabled = false;
            this.authorNameTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.authorNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.authorNameTxtBox.isPassword = false;
            this.authorNameTxtBox.Location = new System.Drawing.Point(12, 210);
            this.authorNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.authorNameTxtBox.Name = "authorNameTxtBox";
            this.authorNameTxtBox.Size = new System.Drawing.Size(304, 40);
            this.authorNameTxtBox.TabIndex = 2;
            this.authorNameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.authorNameTxtBox.OnValueChanged += new System.EventHandler(this.authorNameTxtBox_OnValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Author Name : ";
            // 
            // publisherTxtBox
            // 
            this.publisherTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.publisherTxtBox.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.publisherTxtBox.BorderColorIdle = System.Drawing.Color.DimGray;
            this.publisherTxtBox.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.publisherTxtBox.BorderThickness = 3;
            this.publisherTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.publisherTxtBox.Enabled = false;
            this.publisherTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.publisherTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.publisherTxtBox.isPassword = false;
            this.publisherTxtBox.Location = new System.Drawing.Point(349, 210);
            this.publisherTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.publisherTxtBox.Name = "publisherTxtBox";
            this.publisherTxtBox.Size = new System.Drawing.Size(299, 40);
            this.publisherTxtBox.TabIndex = 3;
            this.publisherTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.publisherTxtBox.OnValueChanged += new System.EventHandler(this.publisherTxtBox_OnValueChanged);
            // 
            // publisherlbl
            // 
            this.publisherlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.publisherlbl.AutoSize = true;
            this.publisherlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherlbl.Location = new System.Drawing.Point(347, 190);
            this.publisherlbl.Name = "publisherlbl";
            this.publisherlbl.Size = new System.Drawing.Size(70, 16);
            this.publisherlbl.TabIndex = 14;
            this.publisherlbl.Text = "Publisher :";
            // 
            // editionTxtBox
            // 
            this.editionTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editionTxtBox.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.editionTxtBox.BorderColorIdle = System.Drawing.Color.DimGray;
            this.editionTxtBox.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.editionTxtBox.BorderThickness = 3;
            this.editionTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editionTxtBox.Enabled = false;
            this.editionTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.editionTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editionTxtBox.isPassword = false;
            this.editionTxtBox.Location = new System.Drawing.Point(12, 278);
            this.editionTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.editionTxtBox.Name = "editionTxtBox";
            this.editionTxtBox.Size = new System.Drawing.Size(304, 40);
            this.editionTxtBox.TabIndex = 4;
            this.editionTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.editionTxtBox.OnValueChanged += new System.EventHandler(this.editionTxtBox_OnValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Edition / Volume : ";
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceTxtBox.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.priceTxtBox.BorderColorIdle = System.Drawing.Color.DimGray;
            this.priceTxtBox.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.priceTxtBox.BorderThickness = 3;
            this.priceTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTxtBox.Enabled = false;
            this.priceTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.priceTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceTxtBox.isPassword = false;
            this.priceTxtBox.Location = new System.Drawing.Point(12, 345);
            this.priceTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(304, 40);
            this.priceTxtBox.TabIndex = 6;
            this.priceTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.priceTxtBox.OnValueChanged += new System.EventHandler(this.priceTxtBox_OnValueChanged);
            // 
            // bookPriceLbl
            // 
            this.bookPriceLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookPriceLbl.AutoSize = true;
            this.bookPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookPriceLbl.Location = new System.Drawing.Point(12, 325);
            this.bookPriceLbl.Name = "bookPriceLbl";
            this.bookPriceLbl.Size = new System.Drawing.Size(48, 16);
            this.bookPriceLbl.TabIndex = 14;
            this.bookPriceLbl.Text = "Price : ";
            // 
            // barcodeTxtBox
            // 
            this.barcodeTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barcodeTxtBox.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.barcodeTxtBox.BorderColorIdle = System.Drawing.Color.DimGray;
            this.barcodeTxtBox.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.barcodeTxtBox.BorderThickness = 3;
            this.barcodeTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.barcodeTxtBox.Enabled = false;
            this.barcodeTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.barcodeTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barcodeTxtBox.isPassword = false;
            this.barcodeTxtBox.Location = new System.Drawing.Point(349, 278);
            this.barcodeTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.barcodeTxtBox.Name = "barcodeTxtBox";
            this.barcodeTxtBox.Size = new System.Drawing.Size(299, 40);
            this.barcodeTxtBox.TabIndex = 5;
            this.barcodeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.barcodeTxtBox.OnValueChanged += new System.EventHandler(this.barcodeTxtBox_OnValueChanged);
            // 
            // isbnTxtBox
            // 
            this.isbnTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isbnTxtBox.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.isbnTxtBox.BorderColorIdle = System.Drawing.Color.DimGray;
            this.isbnTxtBox.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.isbnTxtBox.BorderThickness = 3;
            this.isbnTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.isbnTxtBox.Enabled = false;
            this.isbnTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.isbnTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.isbnTxtBox.isPassword = false;
            this.isbnTxtBox.Location = new System.Drawing.Point(349, 345);
            this.isbnTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.isbnTxtBox.Name = "isbnTxtBox";
            this.isbnTxtBox.Size = new System.Drawing.Size(299, 40);
            this.isbnTxtBox.TabIndex = 7;
            this.isbnTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.isbnTxtBox.OnValueChanged += new System.EventHandler(this.isbnTxtBox_OnValueChanged);
            // 
            // barcodeLbl
            // 
            this.barcodeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barcodeLbl.AutoSize = true;
            this.barcodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeLbl.Location = new System.Drawing.Point(349, 258);
            this.barcodeLbl.Name = "barcodeLbl";
            this.barcodeLbl.Size = new System.Drawing.Size(69, 16);
            this.barcodeLbl.TabIndex = 14;
            this.barcodeLbl.Text = "Barcode : ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(349, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "ISBN : ";
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.booksGridView);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 444);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(905, 233);
            this.bottomPanel.TabIndex = 18;
            // 
            // booksGridView
            // 
            this.booksGridView.AllowUserToAddRows = false;
            this.booksGridView.AllowUserToDeleteRows = false;
            this.booksGridView.AllowUserToResizeColumns = false;
            this.booksGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.booksGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.booksGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.booksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGVC,
            this.bookImagePathGVC,
            this.bookImgBoxGVC,
            this.bookNameGVC,
            this.categoryIdGVC,
            this.categoryNameGVC,
            this.authorNameGVC,
            this.publisherGVC,
            this.editionGVC,
            this.barcodeGVC,
            this.priceGVC,
            this.isbnGVC,
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
            this.booksGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.booksGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksGridView.EnableHeadersVisualStyles = false;
            this.booksGridView.Location = new System.Drawing.Point(0, 0);
            this.booksGridView.Name = "booksGridView";
            this.booksGridView.ReadOnly = true;
            this.booksGridView.RowHeadersVisible = false;
            this.booksGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.booksGridView.RowTemplate.Height = 28;
            this.booksGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksGridView.Size = new System.Drawing.Size(905, 233);
            this.booksGridView.TabIndex = 26;
            this.booksGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksGridView_CellContentClick);
            this.booksGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksGridView_CellDoubleClick);
            // 
            // idGVC
            // 
            this.idGVC.DataPropertyName = "id";
            this.idGVC.HeaderText = "Id";
            this.idGVC.Name = "idGVC";
            this.idGVC.ReadOnly = true;
            this.idGVC.Visible = false;
            // 
            // bookImagePathGVC
            // 
            this.bookImagePathGVC.DataPropertyName = "bookImagePath";
            this.bookImagePathGVC.HeaderText = "Book Cover Path";
            this.bookImagePathGVC.Name = "bookImagePathGVC";
            this.bookImagePathGVC.ReadOnly = true;
            this.bookImagePathGVC.Visible = false;
            // 
            // bookImgBoxGVC
            // 
            this.bookImgBoxGVC.DataPropertyName = "bookImage";
            this.bookImgBoxGVC.FillWeight = 65.65633F;
            this.bookImgBoxGVC.HeaderText = "Book Cover";
            this.bookImgBoxGVC.Image = global::Desktop_LMS_UI.Properties.Resources.profile;
            this.bookImgBoxGVC.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.bookImgBoxGVC.Name = "bookImgBoxGVC";
            this.bookImgBoxGVC.ReadOnly = true;
            this.bookImgBoxGVC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bookImgBoxGVC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bookNameGVC
            // 
            this.bookNameGVC.DataPropertyName = "bookTitle";
            this.bookNameGVC.FillWeight = 148.9954F;
            this.bookNameGVC.HeaderText = "Book Title";
            this.bookNameGVC.Name = "bookNameGVC";
            this.bookNameGVC.ReadOnly = true;
            // 
            // categoryIdGVC
            // 
            this.categoryIdGVC.DataPropertyName = "categoryId";
            this.categoryIdGVC.HeaderText = "Category Id";
            this.categoryIdGVC.Name = "categoryIdGVC";
            this.categoryIdGVC.ReadOnly = true;
            this.categoryIdGVC.Visible = false;
            // 
            // categoryNameGVC
            // 
            this.categoryNameGVC.DataPropertyName = "category";
            this.categoryNameGVC.FillWeight = 115.2173F;
            this.categoryNameGVC.HeaderText = "Category";
            this.categoryNameGVC.Name = "categoryNameGVC";
            this.categoryNameGVC.ReadOnly = true;
            // 
            // authorNameGVC
            // 
            this.authorNameGVC.DataPropertyName = "authorName";
            this.authorNameGVC.FillWeight = 148.9954F;
            this.authorNameGVC.HeaderText = "Author";
            this.authorNameGVC.Name = "authorNameGVC";
            this.authorNameGVC.ReadOnly = true;
            // 
            // publisherGVC
            // 
            this.publisherGVC.DataPropertyName = "publisher";
            this.publisherGVC.FillWeight = 83.75633F;
            this.publisherGVC.HeaderText = "Publisher";
            this.publisherGVC.Name = "publisherGVC";
            this.publisherGVC.ReadOnly = true;
            // 
            // editionGVC
            // 
            this.editionGVC.DataPropertyName = "bookEdition";
            this.editionGVC.FillWeight = 117.5802F;
            this.editionGVC.HeaderText = "Volume/Edition";
            this.editionGVC.Name = "editionGVC";
            this.editionGVC.ReadOnly = true;
            // 
            // barcodeGVC
            // 
            this.barcodeGVC.DataPropertyName = "barcode";
            this.barcodeGVC.FillWeight = 148.9954F;
            this.barcodeGVC.HeaderText = "Barcode";
            this.barcodeGVC.Name = "barcodeGVC";
            this.barcodeGVC.ReadOnly = true;
            // 
            // priceGVC
            // 
            this.priceGVC.DataPropertyName = "price";
            this.priceGVC.FillWeight = 53.67995F;
            this.priceGVC.HeaderText = "Price";
            this.priceGVC.Name = "priceGVC";
            this.priceGVC.ReadOnly = true;
            // 
            // isbnGVC
            // 
            this.isbnGVC.DataPropertyName = "bookISBN";
            this.isbnGVC.FillWeight = 111.5351F;
            this.isbnGVC.HeaderText = "ISBN";
            this.isbnGVC.Name = "isbnGVC";
            this.isbnGVC.ReadOnly = true;
            // 
            // editActionGVC
            // 
            this.editActionGVC.FillWeight = 50.69311F;
            this.editActionGVC.HeaderText = "Edit";
            this.editActionGVC.Image = ((System.Drawing.Image)(resources.GetObject("editActionGVC.Image")));
            this.editActionGVC.Name = "editActionGVC";
            this.editActionGVC.ReadOnly = true;
            // 
            // deleteActionGVC
            // 
            this.deleteActionGVC.FillWeight = 54.89526F;
            this.deleteActionGVC.HeaderText = "Delete";
            this.deleteActionGVC.Image = ((System.Drawing.Image)(resources.GetObject("deleteActionGVC.Image")));
            this.deleteActionGVC.Name = "deleteActionGVC";
            this.deleteActionGVC.ReadOnly = true;
            // 
            // categoryDD
            // 
            this.categoryDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryDD.BackColor = System.Drawing.Color.Gray;
            this.categoryDD.Enabled = false;
            this.categoryDD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.categoryDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDD.ForeColor = System.Drawing.Color.White;
            this.categoryDD.FormattingEnabled = true;
            this.categoryDD.Location = new System.Drawing.Point(349, 145);
            this.categoryDD.Name = "categoryDD";
            this.categoryDD.Size = new System.Drawing.Size(299, 32);
            this.categoryDD.TabIndex = 1;
            this.categoryDD.SelectedIndexChanged += new System.EventHandler(this.categoryDD_SelectedIndexChanged);
            // 
            // booknameErrorLbl
            // 
            this.booknameErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.booknameErrorLbl.AutoSize = true;
            this.booknameErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booknameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.booknameErrorLbl.Location = new System.Drawing.Point(81, 118);
            this.booknameErrorLbl.Name = "booknameErrorLbl";
            this.booknameErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.booknameErrorLbl.TabIndex = 52;
            this.booknameErrorLbl.Text = "*";
            this.booknameErrorLbl.Visible = false;
            // 
            // categoryDDErrorLbl
            // 
            this.categoryDDErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryDDErrorLbl.AutoSize = true;
            this.categoryDDErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDDErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.categoryDDErrorLbl.Location = new System.Drawing.Point(454, 120);
            this.categoryDDErrorLbl.Name = "categoryDDErrorLbl";
            this.categoryDDErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.categoryDDErrorLbl.TabIndex = 52;
            this.categoryDDErrorLbl.Text = "*";
            this.categoryDDErrorLbl.Visible = false;
            // 
            // authorNameErrorLbl
            // 
            this.authorNameErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authorNameErrorLbl.AutoSize = true;
            this.authorNameErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorNameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.authorNameErrorLbl.Location = new System.Drawing.Point(98, 187);
            this.authorNameErrorLbl.Name = "authorNameErrorLbl";
            this.authorNameErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.authorNameErrorLbl.TabIndex = 52;
            this.authorNameErrorLbl.Text = "*";
            this.authorNameErrorLbl.Visible = false;
            // 
            // publisherErrorLbl
            // 
            this.publisherErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.publisherErrorLbl.AutoSize = true;
            this.publisherErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.publisherErrorLbl.Location = new System.Drawing.Point(414, 186);
            this.publisherErrorLbl.Name = "publisherErrorLbl";
            this.publisherErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.publisherErrorLbl.TabIndex = 52;
            this.publisherErrorLbl.Text = "*";
            this.publisherErrorLbl.Visible = false;
            // 
            // editionVolumeErrorLbl
            // 
            this.editionVolumeErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editionVolumeErrorLbl.AutoSize = true;
            this.editionVolumeErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editionVolumeErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.editionVolumeErrorLbl.Location = new System.Drawing.Point(117, 255);
            this.editionVolumeErrorLbl.Name = "editionVolumeErrorLbl";
            this.editionVolumeErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.editionVolumeErrorLbl.TabIndex = 52;
            this.editionVolumeErrorLbl.Text = "*";
            this.editionVolumeErrorLbl.Visible = false;
            // 
            // barcodeErrorLbl
            // 
            this.barcodeErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barcodeErrorLbl.AutoSize = true;
            this.barcodeErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.barcodeErrorLbl.Location = new System.Drawing.Point(412, 254);
            this.barcodeErrorLbl.Name = "barcodeErrorLbl";
            this.barcodeErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.barcodeErrorLbl.TabIndex = 52;
            this.barcodeErrorLbl.Text = "*";
            this.barcodeErrorLbl.Visible = false;
            // 
            // priceErrorLbl
            // 
            this.priceErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceErrorLbl.AutoSize = true;
            this.priceErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.priceErrorLbl.Location = new System.Drawing.Point(51, 321);
            this.priceErrorLbl.Name = "priceErrorLbl";
            this.priceErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.priceErrorLbl.TabIndex = 52;
            this.priceErrorLbl.Text = "*";
            this.priceErrorLbl.Visible = false;
            // 
            // isbnErrorLbl
            // 
            this.isbnErrorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isbnErrorLbl.AutoSize = true;
            this.isbnErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.isbnErrorLbl.Location = new System.Drawing.Point(389, 322);
            this.isbnErrorLbl.Name = "isbnErrorLbl";
            this.isbnErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.isbnErrorLbl.TabIndex = 52;
            this.isbnErrorLbl.Text = "*";
            this.isbnErrorLbl.Visible = false;
            // 
            // bookPictureOpenFileDialog
            // 
            this.bookPictureOpenFileDialog.FileName = "Select File";
            this.bookPictureOpenFileDialog.Filter = "(*.png; *.jpg; *.jpeg) | *.png; *.jpg; *.jpeg;";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "bookImage";
            this.dataGridViewImageColumn1.FillWeight = 40.60914F;
            this.dataGridViewImageColumn1.HeaderText = "Book Cover";
            this.dataGridViewImageColumn1.Image = global::Desktop_LMS_UI.Properties.Resources.profile;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 41;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 45.45039F;
            this.dataGridViewImageColumn2.HeaderText = "Edit";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 46;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.FillWeight = 46.00936F;
            this.dataGridViewImageColumn3.HeaderText = "Delete";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 46;
            // 
            // uploadBtn
            // 
            this.uploadBtn.Activecolor = System.Drawing.Color.SteelBlue;
            this.uploadBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uploadBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.uploadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uploadBtn.BorderRadius = 0;
            this.uploadBtn.ButtonText = "Browse..";
            this.uploadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadBtn.DisabledColor = System.Drawing.Color.Gray;
            this.uploadBtn.Enabled = false;
            this.uploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.uploadBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("uploadBtn.Iconimage")));
            this.uploadBtn.Iconimage_right = null;
            this.uploadBtn.Iconimage_right_Selected = null;
            this.uploadBtn.Iconimage_Selected = null;
            this.uploadBtn.IconMarginLeft = 0;
            this.uploadBtn.IconMarginRight = 0;
            this.uploadBtn.IconRightVisible = true;
            this.uploadBtn.IconRightZoom = 0D;
            this.uploadBtn.IconVisible = false;
            this.uploadBtn.IconZoom = 90D;
            this.uploadBtn.IsTab = false;
            this.uploadBtn.Location = new System.Drawing.Point(655, 253);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.uploadBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.uploadBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.uploadBtn.selected = false;
            this.uploadBtn.Size = new System.Drawing.Size(100, 33);
            this.uploadBtn.TabIndex = 8;
            this.uploadBtn.Text = "Browse..";
            this.uploadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uploadBtn.Textcolor = System.Drawing.Color.White;
            this.uploadBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTxtBox.BackColor = System.Drawing.Color.SteelBlue;
            this.searchTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTxtBox.BackgroundImage")));
            this.searchTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchTxtBox.ForeColor = System.Drawing.Color.White;
            this.searchTxtBox.Icon = ((System.Drawing.Image)(resources.GetObject("searchTxtBox.Icon")));
            this.searchTxtBox.Location = new System.Drawing.Point(676, 408);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(212, 30);
            this.searchTxtBox.TabIndex = 10;
            this.searchTxtBox.text = "";
            this.searchTxtBox.OnTextChange += new System.EventHandler(this.searchTxtBox_OnTextChange);
            // 
            // bookPicBox
            // 
            this.bookPicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookPicBox.Location = new System.Drawing.Point(655, 141);
            this.bookPicBox.Name = "bookPicBox";
            this.bookPicBox.Size = new System.Drawing.Size(100, 109);
            this.bookPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookPicBox.TabIndex = 16;
            this.bookPicBox.TabStop = false;
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
            this.saveBtn.Location = new System.Drawing.Point(655, 346);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.saveBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.saveBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.saveBtn.selected = false;
            this.saveBtn.Size = new System.Drawing.Size(100, 40);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBtn.Textcolor = System.Drawing.Color.White;
            this.saveBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
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
            this.addNewBtn.Location = new System.Drawing.Point(784, 52);
            this.addNewBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.addNewBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.addNewBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addNewBtn.selected = false;
            this.addNewBtn.Size = new System.Drawing.Size(104, 33);
            this.addNewBtn.TabIndex = 12;
            this.addNewBtn.Text = "Add New";
            this.addNewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewBtn.Textcolor = System.Drawing.Color.White;
            this.addNewBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 677);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.isbnErrorLbl);
            this.Controls.Add(this.priceErrorLbl);
            this.Controls.Add(this.barcodeErrorLbl);
            this.Controls.Add(this.editionVolumeErrorLbl);
            this.Controls.Add(this.publisherErrorLbl);
            this.Controls.Add(this.authorNameErrorLbl);
            this.Controls.Add(this.categoryDDErrorLbl);
            this.Controls.Add(this.booknameErrorLbl);
            this.Controls.Add(this.categoryDD);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.bookPicBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.publisherlbl);
            this.Controls.Add(this.barcodeLbl);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.isbnTxtBox);
            this.Controls.Add(this.publisherTxtBox);
            this.Controls.Add(this.barcodeTxtBox);
            this.Controls.Add(this.bookPriceLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceTxtBox);
            this.Controls.Add(this.authorNameTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.editionTxtBox);
            this.Controls.Add(this.bookNameLbl);
            this.Controls.Add(this.bookNameTxtBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton addNewBtn;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel linePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bookNameLbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox bookNameTxtBox;
        private System.Windows.Forms.Label categoryLbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox authorNameTxtBox;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox publisherTxtBox;
        private System.Windows.Forms.Label publisherlbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox editionTxtBox;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox priceTxtBox;
        private System.Windows.Forms.Label bookPriceLbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox barcodeTxtBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox isbnTxtBox;
        private System.Windows.Forms.Label barcodeLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox bookPicBox;
        private System.Windows.Forms.Panel bottomPanel;
        private Bunifu.Framework.UI.BunifuTextbox searchTxtBox;
        private Bunifu.Framework.UI.BunifuFlatButton saveBtn;
        private System.Windows.Forms.ComboBox categoryDD;
        private System.Windows.Forms.Label booknameErrorLbl;
        private System.Windows.Forms.Label categoryDDErrorLbl;
        private System.Windows.Forms.Label authorNameErrorLbl;
        private System.Windows.Forms.Label publisherErrorLbl;
        private System.Windows.Forms.Label editionVolumeErrorLbl;
        private System.Windows.Forms.Label barcodeErrorLbl;
        private System.Windows.Forms.Label priceErrorLbl;
        private System.Windows.Forms.Label isbnErrorLbl;
        private Bunifu.Framework.UI.BunifuFlatButton uploadBtn;
        private System.Windows.Forms.OpenFileDialog bookPictureOpenFileDialog;
        private System.Windows.Forms.DataGridView booksGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookImagePathGVC;
        private System.Windows.Forms.DataGridViewImageColumn bookImgBoxGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn editionGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnGVC;
        private System.Windows.Forms.DataGridViewImageColumn editActionGVC;
        private System.Windows.Forms.DataGridViewImageColumn deleteActionGVC;
    }
}