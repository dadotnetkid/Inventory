namespace Win.Ownr
{
    partial class frmAddEditOwner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditOwner));
            this.txtOwner = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtTelNo = new DevExpress.XtraEditors.TextEdit();
            this.txtMobileNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtOwner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(117, 41);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOwner.Properties.Appearance.Options.UseFont = true;
            this.txtOwner.Size = new System.Drawing.Size(305, 24);
            this.txtOwner.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(117, 65);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Size = new System.Drawing.Size(305, 24);
            this.txtAddress.TabIndex = 1;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(117, 89);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelNo.Properties.Appearance.Options.UseFont = true;
            this.txtTelNo.Properties.Mask.EditMask = "(000)-(000)-(000)";
            this.txtTelNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtTelNo.Size = new System.Drawing.Size(305, 24);
            this.txtTelNo.TabIndex = 2;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(117, 113);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMobileNo.Properties.Appearance.Options.UseFont = true;
            this.txtMobileNo.Size = new System.Drawing.Size(305, 24);
            this.txtMobileNo.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(4, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 17);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Owner Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(4, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 17);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Address";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(4, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 17);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Telephone No.";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(4, 116);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 17);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Mobile No.";
            // 
            // btnSubmit
            // 
            this.btnSubmit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSubmit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.ImageOptions.Image")));
            this.btnSubmit.Location = new System.Drawing.Point(347, 143);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmAddEditOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 179);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtOwner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEditOwner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owner";
            this.Load += new System.EventHandler(this.frmAddEditOwner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtOwner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtOwner;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtTelNo;
        private DevExpress.XtraEditors.TextEdit txtMobileNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
    }
}