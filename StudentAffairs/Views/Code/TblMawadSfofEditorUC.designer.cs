namespace StudentAffairs.Views.Code
{
    partial class TblMawadSfofEditorUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TblMawadSfofEditorUC));
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
            this.tblMawadSfofBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsData = new StudentAffairs.Datasource.dsData();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colExamId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditExamId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cdExamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colExamName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMadaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditMadaId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cdMadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaxdeg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmindeg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tblMawadSfofTableAdapter = new StudentAffairs.Datasource.dsDataTableAdapters.TblMawadSfofTableAdapter();
            this.cdExamTableAdapter = new StudentAffairs.Datasource.dsDataTableAdapters.cdExamTableAdapter();
            this.cdMadaTableAdapter = new StudentAffairs.Datasource.dsDataTableAdapters.CdMadaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMawadSfofBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditExamId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdExamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditMadaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdMadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.gridControlMain.DataSource = this.tblMawadSfofBindingSource;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEditExamId,
            this.repositoryItemGridLookUpEditMadaId});
            this.gridControlMain.Size = new System.Drawing.Size(652, 377);
            this.gridControlMain.TabIndex = 5;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // tblMawadSfofBindingSource
            // 
            this.tblMawadSfofBindingSource.DataMember = "TblMawadSfof";
            this.tblMawadSfofBindingSource.DataSource = this.dsData;
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
            this.colExamId,
            this.colMadaId,
            this.colmaxdeg,
            this.colmindeg});
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
            // colExamId
            // 
            this.colExamId.AppearanceCell.Options.UseTextOptions = true;
            this.colExamId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExamId.AppearanceHeader.Options.UseTextOptions = true;
            this.colExamId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExamId.Caption = "الصف";
            this.colExamId.ColumnEdit = this.repositoryItemGridLookUpEditExamId;
            this.colExamId.FieldName = "ExamId";
            this.colExamId.Name = "colExamId";
            this.colExamId.Visible = true;
            this.colExamId.VisibleIndex = 0;
            this.colExamId.Width = 168;
            // 
            // repositoryItemGridLookUpEditExamId
            // 
            this.repositoryItemGridLookUpEditExamId.AutoHeight = false;
            this.repositoryItemGridLookUpEditExamId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditExamId.DataSource = this.cdExamBindingSource;
            this.repositoryItemGridLookUpEditExamId.DisplayMember = "ExamName";
            this.repositoryItemGridLookUpEditExamId.Name = "repositoryItemGridLookUpEditExamId";
            this.repositoryItemGridLookUpEditExamId.NullText = "";
            this.repositoryItemGridLookUpEditExamId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditExamId.ValueMember = "ExamId";
            this.repositoryItemGridLookUpEditExamId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // cdExamBindingSource
            // 
            this.cdExamBindingSource.DataMember = "cdExam";
            this.cdExamBindingSource.DataSource = this.dsData;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colExamName});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colExamName
            // 
            this.colExamName.AppearanceCell.Options.UseTextOptions = true;
            this.colExamName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExamName.AppearanceHeader.Options.UseTextOptions = true;
            this.colExamName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExamName.Caption = "الاسم";
            this.colExamName.FieldName = "ExamName";
            this.colExamName.Name = "colExamName";
            this.colExamName.Visible = true;
            this.colExamName.VisibleIndex = 0;
            // 
            // colMadaId
            // 
            this.colMadaId.AppearanceCell.Options.UseTextOptions = true;
            this.colMadaId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMadaId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMadaId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMadaId.Caption = "الادارة";
            this.colMadaId.ColumnEdit = this.repositoryItemGridLookUpEditMadaId;
            this.colMadaId.FieldName = "MadaId";
            this.colMadaId.Name = "colMadaId";
            this.colMadaId.Visible = true;
            this.colMadaId.VisibleIndex = 1;
            this.colMadaId.Width = 128;
            // 
            // repositoryItemGridLookUpEditMadaId
            // 
            this.repositoryItemGridLookUpEditMadaId.AutoHeight = false;
            this.repositoryItemGridLookUpEditMadaId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditMadaId.DataSource = this.cdMadaBindingSource;
            this.repositoryItemGridLookUpEditMadaId.DisplayMember = "Mada";
            this.repositoryItemGridLookUpEditMadaId.Name = "repositoryItemGridLookUpEditMadaId";
            this.repositoryItemGridLookUpEditMadaId.NullText = "";
            this.repositoryItemGridLookUpEditMadaId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditMadaId.ValueMember = "MadaId";
            this.repositoryItemGridLookUpEditMadaId.View = this.gridView1;
            // 
            // cdMadaBindingSource
            // 
            this.cdMadaBindingSource.DataMember = "CdMada";
            this.cdMadaBindingSource.DataSource = this.dsData;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMada});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMada
            // 
            this.colMada.AppearanceCell.Options.UseTextOptions = true;
            this.colMada.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMada.AppearanceHeader.Options.UseTextOptions = true;
            this.colMada.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMada.Caption = "الاسم";
            this.colMada.FieldName = "Mada";
            this.colMada.Name = "colMada";
            this.colMada.Visible = true;
            this.colMada.VisibleIndex = 0;
            // 
            // colmaxdeg
            // 
            this.colmaxdeg.AppearanceCell.Options.UseTextOptions = true;
            this.colmaxdeg.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmaxdeg.AppearanceHeader.Options.UseTextOptions = true;
            this.colmaxdeg.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmaxdeg.Caption = "العظمى";
            this.colmaxdeg.FieldName = "maxdeg";
            this.colmaxdeg.Name = "colmaxdeg";
            this.colmaxdeg.Visible = true;
            this.colmaxdeg.VisibleIndex = 2;
            // 
            // colmindeg
            // 
            this.colmindeg.AppearanceCell.Options.UseTextOptions = true;
            this.colmindeg.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmindeg.AppearanceHeader.Options.UseTextOptions = true;
            this.colmindeg.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmindeg.Caption = "الصغرى";
            this.colmindeg.FieldName = "mindeg";
            this.colmindeg.Name = "colmindeg";
            this.colmindeg.Visible = true;
            this.colmindeg.VisibleIndex = 3;
            // 
            // tblMawadSfofTableAdapter
            // 
            this.tblMawadSfofTableAdapter.ClearBeforeFill = true;
            // 
            // cdExamTableAdapter
            // 
            this.cdExamTableAdapter.ClearBeforeFill = true;
            // 
            // cdMadaTableAdapter
            // 
            this.cdMadaTableAdapter.ClearBeforeFill = true;
            // 
            // TblMawadSfofEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TblMawadSfofEditorUC";
            this.Size = new System.Drawing.Size(652, 408);
            this.Load += new System.EventHandler(this.RouteEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMawadSfofBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditExamId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdExamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditMadaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdMadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colExamId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditExamId;
        private Datasource.dsData dsData;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colMadaId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditMadaId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tblMawadSfofBindingSource;
        private Datasource.dsDataTableAdapters.TblMawadSfofTableAdapter tblMawadSfofTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colmaxdeg;
        private DevExpress.XtraGrid.Columns.GridColumn colmindeg;
        private System.Windows.Forms.BindingSource cdExamBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colExamName;
        private System.Windows.Forms.BindingSource cdMadaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMada;
        private Datasource.dsDataTableAdapters.cdExamTableAdapter cdExamTableAdapter;
        private Datasource.dsDataTableAdapters.CdMadaTableAdapter cdMadaTableAdapter;
    }
}
