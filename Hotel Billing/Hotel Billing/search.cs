using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Hotel_Billing
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        
        private void search1(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(@"E:\.net\Hotel Billing\Hotel Billing\CrystalReport1.rpt");
            crystalReportViewer1.ReportSource = rd;
        }
    }
}
