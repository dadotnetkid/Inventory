namespace Win.cnfnmnt
{
    partial class ucConfinementGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.entityServerModeSource1 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSearch = new DevExpress.XtraEditors.SearchControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwnerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPatientId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservations = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // entityServerModeSource1
            // 
            this.entityServerModeSource1.DefaultSorting = "Id ASC";
            this.entityServerModeSource1.ElementType = typeof(Models.ConfinementRecords);
            this.entityServerModeSource1.KeyExpression = "Id";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(4);
            this.panelControl1.Size = new System.Drawing.Size(552, 38);
            this.panelControl1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(6, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtSearch.Size = new System.Drawing.Size(540, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.entityServerModeSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 38);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(552, 392);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colVetId,
            this.colOwnerId,
            this.colPatientId,
            this.colObservations,
            this.colDateCreated,
            this.colCreatedBy});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 68;
            // 
            // colVetId
            // 
            this.colVetId.Caption = "Vet Name";
            this.colVetId.FieldName = "Veterinaries.VetName";
            this.colVetId.Name = "colVetId";
            // 
            // colOwnerId
            // 
            this.colOwnerId.Caption = "Owner";
            this.colOwnerId.FieldName = "Patients.Owners.OwnerName";
            this.colOwnerId.Name = "colOwnerId";
            this.colOwnerId.Visible = true;
            this.colOwnerId.VisibleIndex = 1;
            this.colOwnerId.Width = 151;
            // 
            // colPatientId
            // 
            this.colPatientId.Caption = "Patient";
            this.colPatientId.FieldName = "Patients.PetName";
            this.colPatientId.Name = "colPatientId";
            this.colPatientId.Visible = true;
            this.colPatientId.VisibleIndex = 2;
            this.colPatientId.Width = 151;
            // 
            // colObservations
            // 
            this.colObservations.FieldName = "Observations";
            this.colObservations.Name = "colObservations";
            // 
            // colDateCreated
            // 
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Visible = true;
            this.colDateCreated.VisibleIndex = 3;
            this.colDateCreated.Width = 157;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "Users.FullName";
            this.colCreatedBy.Name = "colCreatedBy";
            // 
            // ucConfinementGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucConfinementGrid";
            this.Size = new System.Drawing.Size(552, 430);
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colVetId;
        private DevExpress.XtraGrid.Columns.GridColumn colOwnerId;
        private DevExpress.XtraGrid.Columns.GridColumn colPatientId;
        private DevExpress.XtraGrid.Columns.GridColumn colObservations;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraEditors.SearchControl txtSearch;
    }
}
