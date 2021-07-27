using CrystalDecisions.CrystalReports.Engine;
using LMS_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_LMS_UI
{
    public partial class DailyReports : Form
    {
        IssueBookBL issueBooksBll;
        ReportDocument rd;
        public DailyReports()
        {
            InitializeComponent();
            issueBooksBll = new IssueBookBL();
        }

        private void DailyReports_Load(object sender, EventArgs e)
        {
            var issuedBooks = issueBooksBll.GetAllBooksWithStudents();
            rd = new ReportDocument();
            rd.Load(Application.StartupPath + "\\Reports\\IssuedBooksDailyReport.rpt");
            rd.SetDataSource(issuedBooks);
            dailyReportViewer.ReportSource = rd;
            dailyReportViewer.RefreshReport();
        }
    }
}
