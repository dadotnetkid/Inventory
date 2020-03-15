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

namespace Win.vt
{
    public partial class frmAddEditVeterinary : DevExpress.XtraEditors.XtraForm
    {
        private MethodType methodType;
        private int? vetId;

        public frmAddEditVeterinary(int? id, MethodType methodType)
        {
            InitializeComponent();
            this.vetId = id;
            this.methodType = methodType;
            Details(id);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (methodType == MethodType.Add)
                Add(Veterinaries());
            else
                Edit(Veterinaries());
            this.Close();
        }

        void Details(int? id)
        {
            if (id == null)
                return;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                var vet = unitOfWork.VeterinariesRepo.Find(m => m.Id == id);
                this.txtVetName.Text = vet.VetName;
                this.Tag = id;
            }
        }

        void Add(Veterinaries item)
        {

            try
            {

                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.VeterinariesRepo.Insert(item);
                    unitOfWork.Save();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Edit(Veterinaries item)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.VeterinariesRepo.Update(item);
                    unitOfWork.Save();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Veterinaries Veterinaries() => new Veterinaries()
        {
            VetName = txtVetName.EditValue.ToString(),
            Id = Convert.ToInt32(this.Tag ?? 0)
        };

    }
}