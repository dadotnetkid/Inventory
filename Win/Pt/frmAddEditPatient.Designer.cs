namespace Win.Pt
{
    partial class frmAddEditPatient
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
            this.components = new System.ComponentModel.Container();
            this.txtPetName = new DevExpress.XtraEditors.TextEdit();
            this.dtDOB = new DevExpress.XtraEditors.DateEdit();
            this.cboSpecies = new DevExpress.XtraEditors.LookUpEdit();
            this.cboBreed = new DevExpress.XtraEditors.LookUpEdit();
            this.cboColor = new DevExpress.XtraEditors.LookUpEdit();
            this.cboSex = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.SexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ColorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BreedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SpeciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboOwner = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ownersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtPetName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDOB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDOB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSpecies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBreed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOwner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(108, 12);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPetName.Properties.Appearance.Options.UseFont = true;
            this.txtPetName.Size = new System.Drawing.Size(333, 24);
            this.txtPetName.TabIndex = 0;
            // 
            // dtDOB
            // 
            this.dtDOB.EditValue = null;
            this.dtDOB.Location = new System.Drawing.Point(108, 38);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtDOB.Properties.Appearance.Options.UseFont = true;
            this.dtDOB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDOB.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDOB.Size = new System.Drawing.Size(333, 24);
            this.dtDOB.TabIndex = 1;
            // 
            // cboSpecies
            // 
            this.cboSpecies.Location = new System.Drawing.Point(108, 64);
            this.cboSpecies.Name = "cboSpecies";
            this.cboSpecies.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSpecies.Properties.Appearance.Options.UseFont = true;
            this.cboSpecies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSpecies.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Species", "Species", 67, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboSpecies.Properties.DataSource = this.SpeciesBindingSource;
            this.cboSpecies.Properties.DisplayMember = "Species";
            this.cboSpecies.Properties.NullText = "";
            this.cboSpecies.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboSpecies.Properties.ValueMember = "Species";
            this.cboSpecies.Size = new System.Drawing.Size(333, 24);
            this.cboSpecies.TabIndex = 2;
            // 
            // cboBreed
            // 
            this.cboBreed.Location = new System.Drawing.Point(108, 90);
            this.cboBreed.Name = "cboBreed";
            this.cboBreed.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboBreed.Properties.Appearance.Options.UseFont = true;
            this.cboBreed.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboBreed.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Breed", "Breed", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboBreed.Properties.DataSource = this.BreedBindingSource;
            this.cboBreed.Properties.DisplayMember = "Breed";
            this.cboBreed.Properties.NullText = "";
            this.cboBreed.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboBreed.Properties.ValueMember = "Breed";
            this.cboBreed.Size = new System.Drawing.Size(333, 24);
            this.cboBreed.TabIndex = 3;
            // 
            // cboColor
            // 
            this.cboColor.Location = new System.Drawing.Point(108, 116);
            this.cboColor.Name = "cboColor";
            this.cboColor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboColor.Properties.Appearance.Options.UseFont = true;
            this.cboColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboColor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Color", "Color", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboColor.Properties.DataSource = this.ColorBindingSource;
            this.cboColor.Properties.DisplayMember = "Color";
            this.cboColor.Properties.NullText = "";
            this.cboColor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboColor.Properties.ValueMember = "Color";
            this.cboColor.Size = new System.Drawing.Size(333, 24);
            this.cboColor.TabIndex = 4;
            // 
            // cboSex
            // 
            this.cboSex.Location = new System.Drawing.Point(108, 142);
            this.cboSex.Name = "cboSex";
            this.cboSex.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSex.Properties.Appearance.Options.UseFont = true;
            this.cboSex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSex.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sex", "Sex", 43, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboSex.Properties.DataSource = this.SexBindingSource;
            this.cboSex.Properties.DisplayMember = "Sex";
            this.cboSex.Properties.NullText = "";
            this.cboSex.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboSex.Properties.ValueMember = "Sex";
            this.cboSex.Size = new System.Drawing.Size(333, 24);
            this.cboSex.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 17);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Pet Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 17);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Date Of Birth";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 17);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Species";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(18, 96);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 17);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Breed";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(18, 122);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 17);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Color";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(18, 148);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(20, 17);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Sex";
            // 
            // btnSubmit
            // 
            this.btnSubmit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSubmit.ImageOptions.Image = global::Win.Properties.Resources.addfile_16x16;
            this.btnSubmit.Location = new System.Drawing.Point(366, 198);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cboOwner
            // 
            this.cboOwner.Location = new System.Drawing.Point(108, 168);
            this.cboOwner.Name = "cboOwner";
            this.cboOwner.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboOwner.Properties.Appearance.Options.UseFont = true;
            this.cboOwner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboOwner.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OwnerName", "Owner Name", 87, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Address", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TelNo", "Tel No", 49, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MobileNo", "Mobile No", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboOwner.Properties.DataSource = this.ownersBindingSource;
            this.cboOwner.Properties.DisplayMember = "OwnerName";
            this.cboOwner.Properties.NullText = "";
            this.cboOwner.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboOwner.Properties.ValueMember = "Id";
            this.cboOwner.Size = new System.Drawing.Size(333, 24);
            this.cboOwner.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(18, 174);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(38, 17);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Owner";
            // 
            // ownersBindingSource
            // 
            this.ownersBindingSource.DataSource = typeof(Models.Owners);
            // 
            // frmAddEditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 231);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cboOwner);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.cboBreed);
            this.Controls.Add(this.cboSpecies);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.txtPetName);
            this.Name = "frmAddEditPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit Patient";
            this.Load += new System.EventHandler(this.Patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPetName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDOB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDOB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSpecies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBreed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOwner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtPetName;
        private DevExpress.XtraEditors.DateEdit dtDOB;
        private DevExpress.XtraEditors.LookUpEdit cboSpecies;
        private DevExpress.XtraEditors.LookUpEdit cboBreed;
        private DevExpress.XtraEditors.LookUpEdit cboColor;
        private DevExpress.XtraEditors.LookUpEdit cboSex;
        private System.Windows.Forms.BindingSource SpeciesBindingSource;
        private System.Windows.Forms.BindingSource BreedBindingSource;
        private System.Windows.Forms.BindingSource ColorBindingSource;
        private System.Windows.Forms.BindingSource SexBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.LookUpEdit cboOwner;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.BindingSource ownersBindingSource;
    }
}