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
    public partial class ManageReturnBookReport : Form
    {
        ReturnBookBL returnBookBll;
        ReportDocument rd;
        public ManageReturnBookReport()
        {
            InitializeComponent();
            returnBookBll = new ReturnBookBL();
        }

        private void ManageReturnBookReport_Load(object sender, EventArgs e)
        {
            var allReturnedBooks = returnBookBll.GetAllReturnedBooks();
            rd = new ReportDocument();
            rd.Load(Application.StartupPath + "\\Reports\\ReturnedBooksDailyReport.rpt");
            rd.SetDataSource(allReturnedBooks);
            returnedBookReportViewer.ReportSource = rd;
            returnedBookReportViewer.RefreshReport();
        }
    }
}
