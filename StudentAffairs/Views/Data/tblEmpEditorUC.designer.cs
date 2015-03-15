namespace StudentAffairs.Views.Data
{
    partial class tblEmpEditorUC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tblEmpEditorUC));
            this.UOW = new DevExpress.Xpo.UnitOfWork(this.components);
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.dsData = new StudentAffairs.Datasource.dsData();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeptId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditDeptId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cdDeptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStageName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditJobId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cdJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEdara = new DevExpress.XtraGrid.Columns.GridColumn();
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.cdDeptTableAdapter = new StudentAffairs.Datasource.dsDataTableAdapters.cdDeptTableAdapter();
            this.cdJobTableAdapter = new StudentAffairs.Datasource.dsDataTableAdapters.cdJobTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditDeptId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdDeptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditJobId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdJobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).BeginInit();
            this.SuspendLayout();
            // 
            // UOW
            // 
            this.UOW.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UOW.TrackPropertiesModifications = false;
            this.UOW.BeforeCommitTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.UOW_BeforeCommitTransaction);
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // barManagerMain
            // 
            this.barManagerMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManagerMain.DockControls.Add(this.barDockControlTop);
            this.barManagerMain.DockControls.Add(this.barDockControlBottom);
            this.barManagerMain.DockControls.Add(this.barDockControlLeft);
            this.barManagerMain.DockControls.Add(this.barDockControlRight);
            this.barManagerMain.Form = this;
            this.barManagerMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiSave,
            this.bbiExport,
            this.bbiRefresh});
            this.barManagerMain.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Glyph = global::StudentAffairs.Properties.Resources.saveall_16x16;
            this.bbiSave.Id = 0;
            this.bbiSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.bbiSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSave.LargeGlyph")));
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Glyph = global::StudentAffairs.Properties.Resources.refresh2_16x16;
            this.bbiRefresh.Id = 2;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Export";
            this.bbiExport.Glyph = global::StudentAffairs.Properties.Resources.Export;
            this.bbiExport.Id = 1;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(652, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 408);
            this.barDockControlBottom.Size = new System.Drawing.Size(652, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 377);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(652, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 377);
            // 
            // gridControlMain
            // 
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEditDeptId,
            this.repositoryItemGridLookUpEditJobId});
            this.gridControlMain.Size = new System.Drawing.Size(652, 377);
            this.gridControlMain.TabIndex = 5;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewMain.Appearance.Row.Options.UseFont = true;
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpName,
            this.colDeptId,
            this.colJobId});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewMain.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewMain.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewMain.OptionsSelection.InvertSelection = true;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            // 
            // colEmpName
            // 
            this.colEmpName.AppearanceCell.Options.UseTextOptions = true;
            this.colEmpName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpName.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpName.Caption = "الاسم";
            this.colEmpName.FieldName = "EmpName";
            this.colEmpName.Name = "colEmpName";
            this.colEmpName.Visible = true;
            this.colEmpName.VisibleIndex = 0;
            this.colEmpName.Width = 165;
            // 
            // colDeptId
            // 
            this.colDeptId.AppearanceCell.Options.UseTextOptions = true;
            this.colDeptId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDeptId.AppearanceHeader.Options.UseTextOptions = true;
            this.colDeptId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDeptId.Caption = "القسم";
            this.colDeptId.ColumnEdit = this.repositoryItemGridLookUpEditDeptId;
            this.colDeptId.FieldName = "DeptId";
            this.colDeptId.Name = "colDeptId";
            this.colDeptId.Visible = true;
            this.colDeptId.VisibleIndex = 1;
            this.colDeptId.Width = 168;
            // 
            // repositoryItemGridLookUpEditDeptId
            // 
            this.repositoryItemGridLookUpEditDeptId.AutoHeight = false;
            this.repositoryItemGridLookUpEditDeptId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditDeptId.DataSource = this.cdDeptBindingSource;
            this.repositoryItemGridLookUpEditDeptId.DisplayMember = "Dept";
            this.repositoryItemGridLookUpEditDeptId.Name = "repositoryItemGridLookUpEditDeptId";
            this.repositoryItemGridLookUpEditDeptId.NullText = "";
            this.repositoryItemGridLookUpEditDeptId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditDeptId.ValueMember = "DeptId";
            this.repositoryItemGridLookUpEditDeptId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // cdDeptBindingSource
            // 
            this.cdDeptBindingSource.DataMember = "cdDept";
            this.cdDeptBindingSource.DataSource = this.dsData;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStageName});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colStageName
            // 
            this.colStageName.Caption = "الاسم";
            this.colStageName.FieldName = "Dept";
            this.colStageName.Name = "colStageName";
            this.colStageName.Visible = true;
            this.colStageName.VisibleIndex = 0;
            // 
            // colJobId
            // 
            this.colJobId.AppearanceCell.Options.UseTextOptions = true;
            this.colJobId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJobId.AppearanceHeader.Options.UseTextOptions = true;
            this.colJobId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJobId.Caption = "الوظيفة";
            this.colJobId.ColumnEdit = this.repositoryItemGridLookUpEditJobId;
            this.colJobId.FieldName = "JobId";
            this.colJobId.Name = "colJobId";
            this.colJobId.Visible = true;
            this.colJobId.VisibleIndex = 2;
            this.colJobId.Width = 128;
            // 
            // repositoryItemGridLookUpEditJobId
            // 
            this.repositoryItemGridLookUpEditJobId.AutoHeight = false;
            this.repositoryItemGridLookUpEditJobId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditJobId.DataSource = this.cdJobBindingSource;
            this.repositoryItemGridLookUpEditJobId.DisplayMember = "Job";
            this.repositoryItemGridLookUpEditJobId.Name = "repositoryItemGridLookUpEditJobId";
            this.repositoryItemGridLookUpEditJobId.NullText = "";
            this.repositoryItemGridLookUpEditJobId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditJobId.ValueMember = "JobId";
            this.repositoryItemGridLookUpEditJobId.View = this.gridView1;
            // 
            // cdJobBindingSource
            // 
            this.cdJobBindingSource.DataMember = "cdJob";
            this.cdJobBindingSource.DataSource = this.dsData;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEdara});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colEdara
            // 
            this.colEdara.Caption = "الاسم";
            this.colEdara.FieldName = "Job";
            this.colEdara.Name = "colEdara";
            this.colEdara.Visible = true;
            this.colEdara.VisibleIndex = 0;
            // 
            // XPSCS
            // 
            this.XPSCS.AllowEdit = true;
            this.XPSCS.AllowNew = true;
            this.XPSCS.AllowRemove = true;
            this.XPSCS.DeleteObjectOnRemove = true;
            this.XPSCS.ObjectType = typeof(StudentAffairs.Datasource.dsData.tblEmpDataTable);
            this.XPSCS.Session = this.UOW;
            // 
            // cdDeptTableAdapter
            // 
            this.cdDeptTableAdapter.ClearBeforeFill = true;
            // 
            // cdJobTableAdapter
            // 
            this.cdJobTableAdapter.ClearBeforeFill = true;
            // 
            // tblEmpEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "tblEmpEditorUC";
            this.Size = new System.Drawing.Size(652, 408);
            this.Load += new System.EventHandler(this.RouteEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditDeptId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdDeptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditJobId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdJobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.UnitOfWork UOW;
        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.Xpo.XPServerCollectionSource XPSCS;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpName;
        private DevExpress.XtraGrid.Columns.GridColumn colDeptId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditDeptId;
        private Datasource.dsData dsData;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colStageName;
        private DevExpress.XtraGrid.Columns.GridColumn colJobId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditJobId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEdara;
        private System.Windows.Forms.BindingSource cdDeptBindingSource;
        private System.Windows.Forms.BindingSource cdJobBindingSource;
        private Datasource.dsDataTableAdapters.cdDeptTableAdapter cdDeptTableAdapter;
        private Datasource.dsDataTableAdapters.cdJobTableAdapter cdJobTableAdapter;
    }
}
