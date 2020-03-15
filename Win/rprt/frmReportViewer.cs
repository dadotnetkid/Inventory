using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Win.Properties;

namespace Win.rprt
{
    public partial class frmReportViewer : DevExpress.XtraEditors.XtraForm
    {
        private XtraReport report;

        public frmReportViewer(XtraReport report)
        {
            InitializeComponent();
            this.Icon = Icon.FromHandle(Resources.printer_16x16.GetHicon());
            this.report = report;
            report.CreateDocument();
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            this.documentViewer1.DocumentSource = report;
        }
    }
}