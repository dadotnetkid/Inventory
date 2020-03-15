namespace Win.rprt
{
    partial class frmConfinementRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfinementRecord));
            this.cboOwner = new DevExpress.XtraEditors.LookUpEdit();
            this.cboPatients = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.OwnerBindingSource = new DevExpress.Data.Linq.EntityServerModeSource();
            this.entityServerModeSource1 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cboOwner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPatients.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboOwner
            // 
            this.cboOwner.Location = new System.Drawing.Point(93, 11);
            this.cboOwner.Name = "cboOwner";
            this.cboOwner.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboOwner.Properties.Appearance.Options.UseFont = true;
            this.cboOwner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboOwner.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OwnerName", "Owner Name", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Address", 56, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboOwner.Properties.DataSource = this.OwnerBindingSource;
            this.cboOwner.Properties.DisplayMember = "OwnerName";
            this.cboOwner.Properties.NullText = "";
            this.cboOwner.Properties.ValueMember = "Id";
            this.cboOwner.Size = new System.Drawing.Size(193, 22);
            this.cboOwner.TabIndex = 4;
            this.cboOwner.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // cboPatients
            // 
            this.cboPatients.Location = new System.Drawing.Point(93, 39);
            this.cboPatients.Name = "cboPatients";
            this.cboPatients.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboPatients.Properties.Appearance.Options.UseFont = true;
            this.cboPatients.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPatients.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PetName", "Pet Name", 65, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Species", "Species", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Color", "Color", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboPatients.Properties.DataSource = this.entityServerModeSource1;
            this.cboPatients.Properties.DisplayMember = "PetName";
            this.cboPatients.Properties.NullText = "";
            this.cboPatients.Properties.ValueMember = "Id";
            this.cboPatients.Size = new System.Drawing.Size(193, 22);
            this.cboPatients.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 16);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Owner";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 16);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Patients";
            // 
            // OwnerBindingSource
            // 
            this.OwnerBindingSource.DefaultSorting = "Id";
            this.OwnerBindingSource.ElementType = typeof(Models.Owners);
            this.OwnerBindingSource.KeyExpression = "Id";
            // 
            // entityServerModeSource1
            // 
            this.entityServerModeSource1.DefaultSorting = "Id";
            this.entityServerModeSource1.ElementType = typeof(Models.Patients);
            this.entityServerModeSource1.KeyExpression = "Id";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSubmit.Appearance.Options.UseFont = true;
            this.btnSubmit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSubmit.ImageOptions.Image = global::Win.Properties.Resources.printer_16x16;
            this.btnSubmit.Location = new System.Drawing.Point(211, 75);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Print";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmConfinementRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 110);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cboPatients);
            this.Controls.Add(this.cboOwner);
            this.Controls.Add(this.btnSubmit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 142);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 142);
            this.Name = "frmConfinementRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confinement Record";
            this.Load += new System.EventHandler(this.frmConfinementRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboOwner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPatients.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.LookUpEdit cboOwner;
        private DevExpress.XtraEditors.LookUpEdit cboPatients;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.Data.Linq.EntityServerModeSource OwnerBindingSource;
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource1;
    }
}