using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;

namespace Win
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {


            InitializeComponent();
            frmSplashScreen frm = new frmSplashScreen();
            frm.ShowDialog();
        }

        void showCredentials()
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            lblUserName.Caption = $"User: { User.GetFullName()}";
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Pt.frmPatients frm = new Pt.frmPatients();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            showCredentials();
        }

        private void backstageViewTabItem1_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem1_ItemPressed(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            backstageViewClientControl1.Hide();
            backstageViewControl1.Close();

            showCredentials();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ownr.frmOwners frm = new Ownr.frmOwners();
            frm.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cnfnmnt.frmConfinementRecords frm = new cnfnmnt.frmConfinementRecords();
            frm.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vt.frmVeterinary frm = new vt.frmVeterinary();
            frm.ShowDialog();

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rprt.frmConfinementRecord frm = new rprt.frmConfinementRecord();
            frm.ShowDialog();
        }
    }
}
