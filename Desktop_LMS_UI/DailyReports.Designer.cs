namespace Desktop_LMS_UI
{
    partial class DailyReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyReports));
            this.dailyReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // dailyReportViewer
            // 
            this.dailyReportViewer.ActiveViewIndex = -1;
            this.dailyReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailyReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.dailyReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dailyReportViewer.Location = new System.Drawing.Point(0, 0);
            this.dailyReportViewer.Name = "dailyReportViewer";
            this.dailyReportViewer.ShowCloseButton = false;
            this.dailyReportViewer.ShowCopyButton = false;
            this.dailyReportViewer.ShowGroupTreeButton = false;
            this.dailyReportViewer.ShowLogo = false;
            this.dailyReportViewer.ShowParameterPanelButton = false;
            this.dailyReportViewer.Size = new System.Drawing.Size(892, 647);
            this.dailyReportViewer.TabIndex = 0;
            this.dailyReportViewer.ToolPanelWidth = 0;
            // 
            // DailyReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 647);
            this.Controls.Add(this.dailyReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DailyReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailyReport";
            this.Load += new System.EventHandler(this.DailyReports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer dailyReportViewer;
    }
}