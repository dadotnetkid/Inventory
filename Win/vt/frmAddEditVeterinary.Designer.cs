namespace Win.vt
{
    partial class frmAddEditVeterinary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditVeterinary));
            this.txtVetName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtVetName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVetName
            // 
            this.txtVetName.Location = new System.Drawing.Point(75, 10);
            this.txtVetName.Name = "txtVetName";
            this.txtVetName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtVetName.Properties.Appearance.Options.UseFont = true;
            this.txtVetName.Size = new System.Drawing.Size(211, 22);
            this.txtVetName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 16);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Vet Name";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSubmit.Appearance.Options.UseFont = true;
            this.btnSubmit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSubmit.ImageOptions.Image = global::Win.Properties.Resources.addfile_16x16;
            this.btnSubmit.Location = new System.Drawing.Point(211, 38);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmAddEditVeterinary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 74);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtVetName);
            this.Controls.Add(this.btnSubmit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 106);
            this.MinimizeBox = false;
            this.Name = "frmAddEditVeterinary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit Vet";
            ((System.ComponentModel.ISupportInitialize)(this.txtVetName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.TextEdit txtVetName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}