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
using DevExpress.XtraGrid.Views.Grid;
using Models;
using Win.Properties;

namespace Win.cnfnmnt
{
    public partial class frmConfinementRecords : DevExpress.XtraEditors.XtraForm
    {
        public frmConfinementRecords()
        {
            InitializeComponent();
            ucConfinementGrid1.ConfinedmentGrid.FocusedRowChanged += ConfinedmentGrid_FocusedRowChanged;
            this.Icon = Icon.FromHandle(Resources.user_16x16.GetHicon());
        }

        private void ConfinedmentGrid_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (sender is GridView grid)
            {
                if (grid.GetFocusedRow() is ConfinementRecords item)
                {
                    txtOwner.Text = item.Patients?.Owners.OwnerName;
                    txtAddress.Text = item.Patients?.Owners?.Address;
                    txtTelNo.Text = item.Patients?.Owners?.TelNo;
                    txtPetName.Text = item.Patients?.PetName;
                    txtColor.Text = item.Patients?.Color;
                    txtBreed.Text = item.Patients?.Breed;
                    txtObservation.Text = item.Observations;
                    txtAttendingVet.Text = item.Veterinaries?.VetName;
                    txtMedication.Text = item.Medication;
                    lblStatus.Text = item.Status;
                }
            }
        }

        private void btnNewConfine_Click(object sender, EventArgs e)
        {

            frmAddEditConfinedRecord frm = new frmAddEditConfinedRecord(null, MethodType.Add);
            frm.ShowDialog();
            ucConfinementGrid1.Reload();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (ucConfinementGrid1.ConfinedmentGrid.GetFocusedRow() is ConfinementRecords item)
            {
                frmAddEditConfinedRecord frm = new frmAddEditConfinedRecord(item, MethodType.Edit);
                frm.ShowDialog();
                ucConfinementGrid1.Reload();
            }
        }

        private void frmConfinementRecords_Load(object sender, EventArgs e)
        {

        }
    }
}