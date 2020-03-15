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
using Models.Startup;
using Win.Properties;

namespace Win
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private bool isLogin;
        private ApplicationUserManager UserManager => new ApplicationUserManager(new UserStores(new ModelDb()));

        public frmLogin()
        {
            InitializeComponent();
            this.Icon = Icon.FromHandle(new Bitmap(Resources.bouser_16x16).GetHicon());
            txtPassword.EditValue = Settings.Default.Password;
            txtUserName.EditValue = Settings.Default.UserName;
            chkRemember.EditValue = Settings.Default.IsRememberMe;

        }

        void SaveSettings()
        {
            if (chkRemember.CheckState == CheckState.Checked)
            {

                Settings.Default.IsRememberMe = chkRemember.Checked;
                Settings.Default.UserName = txtUserName.Text;
                Settings.Default.Password = txtPassword.Text;
                Settings.Default.Save();
            }
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
                    return;
                var user = await UserManager.FindByNameAsync(txtUserName.Text);
                var res = await UserManager.CheckPasswordAsync(user, txtPassword.Text);
                if (res)
                {
                    User.UserId = user.Id;
                    this.isLogin = true;
                    SaveSettings();
                    this.Close();
                }
                else
                    MessageBox.Show("Invalid Credentials" + Environment.NewLine + "Contact System Admininistrator",
                        "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = string.Empty;
                txtUserName.Text = string.Empty;
                txtUserName.Focus();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLogin)
                Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}