namespace Desktop_LMS_UI
{
    partial class ManageReturnBookReport
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
            this.returnedBookReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // returnedBookReportViewer
            // 
            this.returnedBookReportViewer.ActiveViewIndex = -1;
            this.returnedBookReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.returnedBookReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.returnedBookReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnedBookReportViewer.Location = new System.Drawing.Point(0, 0);
            this.returnedBookReportViewer.Name = "returnedBookReportViewer";
            this.returnedBookReportViewer.ShowCloseButton = false;
            this.returnedBookReportViewer.ShowCopyButton = false;
            this.returnedBookReportViewer.ShowGroupTreeButton = false;
            this.returnedBookReportViewer.ShowLogo = false;
            this.returnedBookReportViewer.ShowParameterPanelButton = false;
            this.returnedBookReportViewer.Size = new System.Drawing.Size(812, 643);
            this.returnedBookReportViewer.TabIndex = 1;
            this.returnedBookReportViewer.ToolPanelWidth = 0;
            // 
            // ManageReturnBookReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 643);
            this.Controls.Add(this.returnedBookReportViewer);
            this.Name = "ManageReturnBookReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageReturnBookReport";
            this.Load += new System.EventHandler(this.ManageReturnBookReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer returnedBookReportViewer;
    }
}