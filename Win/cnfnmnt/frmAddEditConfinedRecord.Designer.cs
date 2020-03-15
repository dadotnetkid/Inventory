namespace Win.cnfnmnt
{
    partial class frmAddEditConfinedRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTelNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboOwner = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtColor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSpecies = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cboPetName = new DevExpress.XtraEditors.LookUpEdit();
            this.txtObservation = new DevExpress.XtraEditors.MemoEdit();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.cboAttendingVet = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtMedication = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.entityServerModeSource2 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.OwnerBinding = new DevExpress.Data.Linq.EntityServerModeSource();
            this.VetBinding = new DevExpress.Data.Linq.EntityServerModeSource();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOwner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpecies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPetName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAttendingVet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedication.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VetBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtTelNo);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtAddress);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cboOwner);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(253, 103);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Owner Details";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelNo.Location = new System.Drawing.Point(87, 68);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTelNo.Properties.Appearance.Options.UseFont = true;
            this.txtTelNo.Properties.ReadOnly = true;
            this.txtTelNo.Properties.UseReadOnlyAppearance = false;
            this.txtTelNo.Size = new System.Drawing.Size(161, 22);
            this.txtTelNo.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(6, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 16);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Tel No";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(87, 46);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Properties.ReadOnly = true;
            this.txtAddress.Properties.UseReadOnlyAppearance = false;
            this.txtAddress.Size = new System.Drawing.Size(161, 22);
            this.txtAddress.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Address";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Owner";
            // 
            // cboOwner
            // 
            this.cboOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOwner.EditValue = "";
            this.cboOwner.Location = new System.Drawing.Point(87, 24);
            this.cboOwner.Name = "cboOwner";
            this.cboOwner.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboOwner.Properties.Appearance.Options.UseFont = true;
            this.cboOwner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboOwner.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OwnerName", "Owner Name")});
            this.cboOwner.Properties.DataSource = this.OwnerBinding;
            this.cboOwner.Properties.DisplayMember = "OwnerName";
            this.cboOwner.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboOwner.Properties.ValueMember = "Id";
            this.cboOwner.Size = new System.Drawing.Size(161, 22);
            this.cboOwner.TabIndex = 0;
            this.cboOwner.EditValueChanged += new System.EventHandler(this.gridLookUpEdit1_EditValueChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtColor);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtSpecies);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.cboPetName);
            this.groupControl2.Location = new System.Drawing.Point(271, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(253, 103);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Owner Details";
            // 
            // txtColor
            // 
            this.txtColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColor.Location = new System.Drawing.Point(87, 68);
            this.txtColor.Name = "txtColor";
            this.txtColor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtColor.Properties.Appearance.Options.UseFont = true;
            this.txtColor.Properties.ReadOnly = true;
            this.txtColor.Properties.UseReadOnlyAppearance = false;
            this.txtColor.Size = new System.Drawing.Size(161, 22);
            this.txtColor.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(6, 71);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 16);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Color";
            // 
            // txtSpecies
            // 
            this.txtSpecies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpecies.Location = new System.Drawing.Point(87, 46);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSpecies.Properties.Appearance.Options.UseFont = true;
            this.txtSpecies.Properties.ReadOnly = true;
            this.txtSpecies.Properties.UseReadOnlyAppearance = false;
            this.txtSpecies.Size = new System.Drawing.Size(161, 22);
            this.txtSpecies.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(6, 49);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 16);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Species";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(6, 27);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 16);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Pet Name";
            // 
            // cboPetName
            // 
            this.cboPetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPetName.EditValue = "";
            this.cboPetName.Location = new System.Drawing.Point(87, 24);
            this.cboPetName.Name = "cboPetName";
            this.cboPetName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboPetName.Properties.Appearance.Options.UseFont = true;
            this.cboPetName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPetName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PetName", "Pet Name", 65, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Species", "Species", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Color", "Color", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboPetName.Properties.DataSource = this.entityServerModeSource2;
            this.cboPetName.Properties.DisplayMember = "PetName";
            this.cboPetName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboPetName.Properties.ValueMember = "Id";
            this.cboPetName.Size = new System.Drawing.Size(161, 22);
            this.cboPetName.TabIndex = 0;
            this.cboPetName.EditValueChanged += new System.EventHandler(this.cboPetName_EditValueChanged);
            // 
            // txtObservation
            // 
            this.txtObservation.Location = new System.Drawing.Point(96, 122);
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(428, 96);
            this.txtObservation.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSubmit.ImageOptions.Image = global::Win.Properties.Resources.addfile_16x16;
            this.btnSubmit.Location = new System.Drawing.Point(449, 323);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cboAttendingVet
            // 
            this.cboAttendingVet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAttendingVet.EditValue = "";
            this.cboAttendingVet.Location = new System.Drawing.Point(96, 323);
            this.cboAttendingVet.Name = "cboAttendingVet";
            this.cboAttendingVet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboAttendingVet.Properties.Appearance.Options.UseFont = true;
            this.cboAttendingVet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboAttendingVet.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VetName", "Vet Name", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboAttendingVet.Properties.DataSource = this.VetBinding;
            this.cboAttendingVet.Properties.DisplayMember = "VetName";
            this.cboAttendingVet.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboAttendingVet.Properties.ValueMember = "Id";
            this.cboAttendingVet.Size = new System.Drawing.Size(164, 22);
            this.cboAttendingVet.TabIndex = 0;
            this.cboAttendingVet.EditValueChanged += new System.EventHandler(this.cboPetName_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(13, 326);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(77, 16);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Attending Vet";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(13, 123);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(74, 16);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Observations";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(13, 225);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(61, 16);
            this.labelControl9.TabIndex = 1;
            this.labelControl9.Text = "Medication";
            // 
            // txtMedication
            // 
            this.txtMedication.Location = new System.Drawing.Point(96, 224);
            this.txtMedication.Name = "txtMedication";
            this.txtMedication.Size = new System.Drawing.Size(428, 96);
            this.txtMedication.TabIndex = 7;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(271, 326);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(36, 16);
            this.labelControl10.TabIndex = 1;
            this.labelControl10.Text = "Status";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(313, 323);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Check In",
            "Check Out"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(100, 22);
            this.comboBoxEdit1.TabIndex = 14;
            // 
            // entityServerModeSource2
            // 
            this.entityServerModeSource2.DefaultSorting = "Id ASC";
            this.entityServerModeSource2.ElementType = typeof(Models.Patients);
            this.entityServerModeSource2.KeyExpression = "Id";
            // 
            // OwnerBinding
            // 
            this.OwnerBinding.DefaultSorting = "Id ASC";
            this.OwnerBinding.ElementType = typeof(Models.Owners);
            this.OwnerBinding.KeyExpression = "Id";
            // 
            // VetBinding
            // 
            this.VetBinding.DefaultSorting = "Id";
            this.VetBinding.ElementType = typeof(Models.Veterinaries);
            this.VetBinding.KeyExpression = "Id";
            // 
            // frmAddEditConfinedRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 357);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtMedication);
            this.Controls.Add(this.txtObservation);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.cboAttendingVet);
            this.MaximizeBox = false;
            this.Name = "frmAddEditConfinedRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit Confined Record";
            this.Load += new System.EventHandler(this.frmAddEditConfinedRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOwner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpecies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPetName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAttendingVet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedication.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VetBinding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Data.Linq.EntityServerModeSource OwnerBinding;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtTelNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtColor;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSpecies;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource2;
        private DevExpress.XtraEditors.MemoEdit txtObservation;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.LookUpEdit cboOwner;
        private DevExpress.XtraEditors.LookUpEdit cboPetName;
        private DevExpress.XtraEditors.LookUpEdit cboAttendingVet;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.Data.Linq.EntityServerModeSource VetBinding;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.MemoEdit txtMedication;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
    }
}