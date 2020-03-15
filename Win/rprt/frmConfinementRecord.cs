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
using Models;
using Models.Repository;

namespace Win.rprt
{
    public partial class frmConfinementRecord : DevExpress.XtraEditors.XtraForm
    {
        public frmConfinementRecord()
        {
            InitializeComponent();
            this.OwnerBindingSource.QueryableSource = new UnitOfWork().OwnersRepo.Fetch();
        }

        private void frmConfinementRecord_Load(object sender, EventArgs e)
        {

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is LookUpEdit lookUpEdit)
            {
                if (lookUpEdit.GetSelectedDataRow() is Owners item)
                {
                    cboPatients.Properties.DataSource = item.Patients;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cboPatients is LookUpEdit lookUpEdit)
            {
                if (lookUpEdit.GetSelectedDataRow() is Patients item)
                {
                    rptConfinementRecords rpt = new rptConfinementRecords()
                    {
                        DataSource = new List<Patients> { item }
                    };
                    new frmReportViewer(rpt).ShowDialog();
                }
            }
        }
    }
}