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
using Helpers;
using Models;
using Models.Repository;

namespace Win.Ownr
{
    public partial class frmAddEditOwner : DevExpress.XtraEditors.XtraForm
    {
        private MethodType methodType;

        public frmAddEditOwner(int? id = null, MethodType methodType = MethodType.Add)
        {
            InitializeComponent();
            Details(id);
            this.methodType = methodType;
        }

        private void frmAddEditOwner_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;
            var owner = new Owners()
            {
                OwnerName = txtOwner.Text,
                Address = txtAddress.Text,
                MobileNo = txtAddress.Text,
                TelNo = txtTelNo.Text,

            };
            if (this.methodType == MethodType.Add)
            {
                Add(owner);
            }
            else
            {
                Edit(owner);
            }

            this.Close();
        }

        void Details(int? id)
        {
            if (id == null)
                return;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                this.Tag = id;
                var owner = unitOfWork.OwnersRepo.Find(m => m.Id == id);
                txtAddress.Text = owner.Address;
                txtMobileNo.Text = owner.MobileNo;
                txtOwner.Text = owner.OwnerName;
                txtTelNo.Text = owner.TelNo;
            }
        }
        private void Edit(Owners owner)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                owner.Id = this.Tag.ToInt();
                unitOfWork.OwnersRepo.Update(owner);
                unitOfWork.Save();
            }
        }

        private void Add(Owners owner)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                unitOfWork.OwnersRepo.Insert(owner);
                unitOfWork.Save();
            }
        }
    }
}