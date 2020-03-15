using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using Models.Repository;

namespace Win
{
    public partial class frmSplashScreen : SplashScreen
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            this.labelControl1.Text = "Copyright MCRC © 2020 - " + DateTime.Now.Year.ToString();
            BackgroundWorker bg = new BackgroundWorker();
            bg.RunWorkerCompleted += Bg_RunWorkerCompleted;
            bg.DoWork += Bg_DoWork;
            bg.RunWorkerAsync();
        }

        private void Bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var unitOfWork = new UnitOfWork();
                Debug.Write(unitOfWork.UsersRepo.Fetch().Select(x => new { x.Id }).Any());
                Thread.Sleep(100);


            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {

                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UnitOfWork.DataSource = ConnectionDialog.Connection();
                }));
            }
        }


        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}