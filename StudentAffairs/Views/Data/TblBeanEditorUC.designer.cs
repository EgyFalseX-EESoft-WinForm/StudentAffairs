namespace StudentAffairs.Views.Data
{
    partial class TblBeanEditorUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TblBeanEditorUC));
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBeanTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditBeanTypeId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cdBeanTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsData = new StudentAffairs.Datasource.dsData();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBeanType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStageId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditStageId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cdStageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStageName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExamId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditExamId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cdExamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colExamName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditYearId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cdYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colYearName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSchoolId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditSchoolId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cdSchoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colschool = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgloosno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShopaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditShopaId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cdShopaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colShopaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaslDrasyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditFaslDrasyId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cdFaslDrasyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFaslDrasy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgeha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colesal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colesaldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditdmy = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colesalmony = new DevExpress.XtraGrid.Columns.GridColumn();
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.sessionMain = new DevExpress.Xpo.Session(this.components);
            this.cdStageTableAdapter = new StudentAffairs.Datasource.dsDataTableAdapters.cdStageTableAdapter();
            this.cdBeanTypeTableAdapter = new StudentAffairs.Datasource.dsDataTableAdapters.CdBeanTypeTableAdapter();
            this.cdExamTableAdapter = new StudentAffairs.Datasource.dsDataTableAdapters.cdExamTableAdapter();
            this.cdYearTableAdapter = new StudentAffairs.Datasource.dsDataTableAdapters.cdYearTableAdapter();
            this.cdSchoolTableAdapter = new StudentAffairs.Datasource.dsDataTableAdapters.cdSchoolTableAdapter();
            this.cdShopaTableAdapter = new StudentAffairs.Datasource.dsDataTableAdapters.cdShopaTableAdapter();
            this.cdFaslDrasyTableAdapter = new StudentAffairs.Datasource.dsDataTableAdapters.CdFaslDrasyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditBeanTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdBeanTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditStageId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdStageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditExamId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdExamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditYearId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSchoolId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdSchoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditShopaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdShopaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditFaslDrasyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdFaslDrasyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditdmy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditdmy.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionMain)).BeginInit();
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
            this.bbiRefresh,
            this.barButtonItemAddNew,
            this.barButtonItemEdit,
            this.barButtonItemPrint});
            this.barManagerMain.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAddNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // barButtonItemAddNew
            // 
            this.barButtonItemAddNew.Caption = "اضافة";
            this.barButtonItemAddNew.Glyph = global::StudentAffairs.Properties.Resources.add_16x16;
            this.barButtonItemAddNew.Id = 3;
            this.barButtonItemAddNew.LargeGlyph = global::StudentAffairs.Properties.Resources.add_32x32;
            this.barButtonItemAddNew.Name = "barButtonItemAddNew";
            this.barButtonItemAddNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItemAddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAddNew_ItemClick);
            // 
            // barButtonItemEdit
            // 
            this.barButtonItemEdit.Caption = "تعديل";
            this.barButtonItemEdit.Glyph = global::StudentAffairs.Properties.Resources.pictureshapeoutlinecolor_16x16;
            this.barButtonItemEdit.Id = 4;
            this.barButtonItemEdit.LargeGlyph = global::StudentAffairs.Properties.Resources.pictureshapeoutlinecolor_32x32;
            this.barButtonItemEdit.Name = "barButtonItemEdit";
            this.barButtonItemEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItemEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEdit_ItemClick);
            // 
            // barButtonItemPrint
            // 
            this.barButtonItemPrint.Caption = "طباعة";
            this.barButtonItemPrint.Glyph = global::StudentAffairs.Properties.Resources.print_16x16;
            this.barButtonItemPrint.Id = 5;
            this.barButtonItemPrint.LargeGlyph = global::StudentAffairs.Properties.Resources.print_32x32;
            this.barButtonItemPrint.Name = "barButtonItemPrint";
            this.barButtonItemPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItemPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPrint_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "تحديث";
            this.bbiRefresh.Glyph = global::StudentAffairs.Properties.Resources.refresh2_16x16;
            this.bbiRefresh.Id = 2;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "تصدير";
            this.bbiExport.Glyph = global::StudentAffairs.Properties.Resources.Export;
            this.bbiExport.Id = 1;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(906, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 408);
            this.barDockControlBottom.Size = new System.Drawing.Size(906, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(906, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 377);
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
            // gridControlMain
            // 
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEditStageId,
            this.repositoryItemGridLookUpEditBeanTypeId,
            this.repositoryItemGridLookUpEditExamId,
            this.repositoryItemGridLookUpEditYearId,
            this.repositoryItemGridLookUpEditSchoolId,
            this.repositoryItemGridLookUpEditShopaId,
            this.repositoryItemGridLookUpEditFaslDrasyId,
            this.repositoryItemDateEditdmy});
            this.gridControlMain.Size = new System.Drawing.Size(906, 377);
            this.gridControlMain.TabIndex = 5;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewMain.Appearance.Row.Options.UseFont = true;
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBeanTypeId,
            this.colStageId,
            this.colExamId,
            this.colYearId,
            this.colstname,
            this.colSchoolId,
            this.colgloosno,
            this.colShopaId,
            this.colFaslDrasyId,
            this.colgeha,
            this.colesal,
            this.colesaldate,
            this.colesalmony});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewMain.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridViewMain.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewMain.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gridViewMain.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewMain.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewMain.OptionsSelection.InvertSelection = true;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            // 
            // colBeanTypeId
            // 
            this.colBeanTypeId.AppearanceCell.Options.UseTextOptions = true;
            this.colBeanTypeId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBeanTypeId.AppearanceHeader.Options.UseTextOptions = true;
            this.colBeanTypeId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBeanTypeId.Caption = "نوع البيان";
            this.colBeanTypeId.ColumnEdit = this.repositoryItemGridLookUpEditBeanTypeId;
            this.colBeanTypeId.FieldName = "BeanTypeId";
            this.colBeanTypeId.Name = "colBeanTypeId";
            this.colBeanTypeId.Visible = true;
            this.colBeanTypeId.VisibleIndex = 1;
            this.colBeanTypeId.Width = 128;
            // 
            // repositoryItemGridLookUpEditBeanTypeId
            // 
            this.repositoryItemGridLookUpEditBeanTypeId.AutoHeight = false;
            this.repositoryItemGridLookUpEditBeanTypeId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditBeanTypeId.DataSource = this.cdBeanTypeBindingSource;
            this.repositoryItemGridLookUpEditBeanTypeId.DisplayMember = "BeanType";
            this.repositoryItemGridLookUpEditBeanTypeId.Name = "repositoryItemGridLookUpEditBeanTypeId";
            this.repositoryItemGridLookUpEditBeanTypeId.NullText = "";
            this.repositoryItemGridLookUpEditBeanTypeId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditBeanTypeId.ValueMember = "BeanTypeId";
            this.repositoryItemGridLookUpEditBeanTypeId.View = this.gridView1;
            // 
            // cdBeanTypeBindingSource
            // 
            this.cdBeanTypeBindingSource.DataMember = "CdBeanType";
            this.cdBeanTypeBindingSource.DataSource = this.dsData;
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBeanType});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colBeanType
            // 
            this.colBeanType.Caption = "الاسم";
            this.colBeanType.FieldName = "BeanType";
            this.colBeanType.Name = "colBeanType";
            this.colBeanType.Visible = true;
            this.colBeanType.VisibleIndex = 0;
            // 
            // colStageId
            // 
            this.colStageId.AppearanceCell.Options.UseTextOptions = true;
            this.colStageId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStageId.AppearanceHeader.Options.UseTextOptions = true;
            this.colStageId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStageId.Caption = "المرحلة";
            this.colStageId.ColumnEdit = this.repositoryItemGridLookUpEditStageId;
            this.colStageId.FieldName = "StageId";
            this.colStageId.Name = "colStageId";
            this.colStageId.Visible = true;
            this.colStageId.VisibleIndex = 0;
            this.colStageId.Width = 168;
            // 
            // repositoryItemGridLookUpEditStageId
            // 
            this.repositoryItemGridLookUpEditStageId.AutoHeight = false;
            this.repositoryItemGridLookUpEditStageId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditStageId.DataSource = this.cdStageBindingSource;
            this.repositoryItemGridLookUpEditStageId.DisplayMember = "StageName";
            this.repositoryItemGridLookUpEditStageId.Name = "repositoryItemGridLookUpEditStageId";
            this.repositoryItemGridLookUpEditStageId.NullText = "";
            this.repositoryItemGridLookUpEditStageId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditStageId.ValueMember = "StageId";
            this.repositoryItemGridLookUpEditStageId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // cdStageBindingSource
            // 
            this.cdStageBindingSource.DataMember = "cdStage";
            this.cdStageBindingSource.DataSource = this.dsData;
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
            this.colStageName.FieldName = "StageName";
            this.colStageName.Name = "colStageName";
            this.colStageName.Visible = true;
            this.colStageName.VisibleIndex = 0;
            // 
            // colExamId
            // 
            this.colExamId.AppearanceCell.Options.UseTextOptions = true;
            this.colExamId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExamId.AppearanceHeader.Options.UseTextOptions = true;
            this.colExamId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExamId.Caption = "امتحان";
            this.colExamId.ColumnEdit = this.repositoryItemGridLookUpEditExamId;
            this.colExamId.FieldName = "ExamId";
            this.colExamId.Name = "colExamId";
            this.colExamId.Visible = true;
            this.colExamId.VisibleIndex = 2;
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
            this.repositoryItemGridLookUpEditExamId.View = this.gridView2;
            // 
            // cdExamBindingSource
            // 
            this.cdExamBindingSource.DataMember = "cdExam";
            this.cdExamBindingSource.DataSource = this.dsData;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colExamName});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
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
            // colYearId
            // 
            this.colYearId.AppearanceCell.Options.UseTextOptions = true;
            this.colYearId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearId.AppearanceHeader.Options.UseTextOptions = true;
            this.colYearId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearId.Caption = "العام";
            this.colYearId.ColumnEdit = this.repositoryItemGridLookUpEditYearId;
            this.colYearId.FieldName = "YearId";
            this.colYearId.Name = "colYearId";
            this.colYearId.Visible = true;
            this.colYearId.VisibleIndex = 3;
            // 
            // repositoryItemGridLookUpEditYearId
            // 
            this.repositoryItemGridLookUpEditYearId.AutoHeight = false;
            this.repositoryItemGridLookUpEditYearId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditYearId.DataSource = this.cdYearBindingSource;
            this.repositoryItemGridLookUpEditYearId.DisplayMember = "YearName";
            this.repositoryItemGridLookUpEditYearId.Name = "repositoryItemGridLookUpEditYearId";
            this.repositoryItemGridLookUpEditYearId.NullText = "";
            this.repositoryItemGridLookUpEditYearId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditYearId.ValueMember = "YearId";
            this.repositoryItemGridLookUpEditYearId.View = this.gridView3;
            // 
            // cdYearBindingSource
            // 
            this.cdYearBindingSource.DataMember = "cdYear";
            this.cdYearBindingSource.DataSource = this.dsData;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colYearName});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colYearName
            // 
            this.colYearName.AppearanceCell.Options.UseTextOptions = true;
            this.colYearName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearName.AppearanceHeader.Options.UseTextOptions = true;
            this.colYearName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearName.Caption = "الاسم";
            this.colYearName.FieldName = "YearName";
            this.colYearName.Name = "colYearName";
            this.colYearName.Visible = true;
            this.colYearName.VisibleIndex = 0;
            // 
            // colstname
            // 
            this.colstname.AppearanceCell.Options.UseTextOptions = true;
            this.colstname.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colstname.AppearanceHeader.Options.UseTextOptions = true;
            this.colstname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colstname.Caption = "الاسم";
            this.colstname.FieldName = "stname";
            this.colstname.Name = "colstname";
            this.colstname.Visible = true;
            this.colstname.VisibleIndex = 4;
            // 
            // colSchoolId
            // 
            this.colSchoolId.AppearanceCell.Options.UseTextOptions = true;
            this.colSchoolId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSchoolId.AppearanceHeader.Options.UseTextOptions = true;
            this.colSchoolId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSchoolId.Caption = "المدرسة";
            this.colSchoolId.ColumnEdit = this.repositoryItemGridLookUpEditSchoolId;
            this.colSchoolId.FieldName = "SchoolId";
            this.colSchoolId.Name = "colSchoolId";
            this.colSchoolId.Visible = true;
            this.colSchoolId.VisibleIndex = 5;
            // 
            // repositoryItemGridLookUpEditSchoolId
            // 
            this.repositoryItemGridLookUpEditSchoolId.AutoHeight = false;
            this.repositoryItemGridLookUpEditSchoolId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditSchoolId.DataSource = this.cdSchoolBindingSource;
            this.repositoryItemGridLookUpEditSchoolId.DisplayMember = "school";
            this.repositoryItemGridLookUpEditSchoolId.Name = "repositoryItemGridLookUpEditSchoolId";
            this.repositoryItemGridLookUpEditSchoolId.NullText = "";
            this.repositoryItemGridLookUpEditSchoolId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditSchoolId.ValueMember = "SchoolId";
            this.repositoryItemGridLookUpEditSchoolId.View = this.gridView4;
            // 
            // cdSchoolBindingSource
            // 
            this.cdSchoolBindingSource.DataMember = "cdSchool";
            this.cdSchoolBindingSource.DataSource = this.dsData;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colschool});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colschool
            // 
            this.colschool.AppearanceCell.Options.UseTextOptions = true;
            this.colschool.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colschool.AppearanceHeader.Options.UseTextOptions = true;
            this.colschool.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colschool.Caption = "الاسم";
            this.colschool.FieldName = "school";
            this.colschool.Name = "colschool";
            this.colschool.Visible = true;
            this.colschool.VisibleIndex = 0;
            // 
            // colgloosno
            // 
            this.colgloosno.AppearanceCell.Options.UseTextOptions = true;
            this.colgloosno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgloosno.AppearanceHeader.Options.UseTextOptions = true;
            this.colgloosno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgloosno.Caption = "رقم الجلوس";
            this.colgloosno.FieldName = "gloosno";
            this.colgloosno.Name = "colgloosno";
            this.colgloosno.Visible = true;
            this.colgloosno.VisibleIndex = 6;
            // 
            // colShopaId
            // 
            this.colShopaId.AppearanceCell.Options.UseTextOptions = true;
            this.colShopaId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colShopaId.AppearanceHeader.Options.UseTextOptions = true;
            this.colShopaId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colShopaId.Caption = "الشعبة";
            this.colShopaId.ColumnEdit = this.repositoryItemGridLookUpEditShopaId;
            this.colShopaId.FieldName = "ShopaId";
            this.colShopaId.Name = "colShopaId";
            this.colShopaId.Visible = true;
            this.colShopaId.VisibleIndex = 7;
            // 
            // repositoryItemGridLookUpEditShopaId
            // 
            this.repositoryItemGridLookUpEditShopaId.AutoHeight = false;
            this.repositoryItemGridLookUpEditShopaId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditShopaId.DataSource = this.cdShopaBindingSource;
            this.repositoryItemGridLookUpEditShopaId.DisplayMember = "ShopaName";
            this.repositoryItemGridLookUpEditShopaId.Name = "repositoryItemGridLookUpEditShopaId";
            this.repositoryItemGridLookUpEditShopaId.NullText = "";
            this.repositoryItemGridLookUpEditShopaId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditShopaId.ValueMember = "ShopaId";
            this.repositoryItemGridLookUpEditShopaId.View = this.gridView5;
            // 
            // cdShopaBindingSource
            // 
            this.cdShopaBindingSource.DataMember = "cdShopa";
            this.cdShopaBindingSource.DataSource = this.dsData;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colShopaName});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colShopaName
            // 
            this.colShopaName.AppearanceCell.Options.UseTextOptions = true;
            this.colShopaName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colShopaName.AppearanceHeader.Options.UseTextOptions = true;
            this.colShopaName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colShopaName.Caption = "الاسم";
            this.colShopaName.FieldName = "ShopaName";
            this.colShopaName.Name = "colShopaName";
            this.colShopaName.Visible = true;
            this.colShopaName.VisibleIndex = 0;
            // 
            // colFaslDrasyId
            // 
            this.colFaslDrasyId.AppearanceCell.Options.UseTextOptions = true;
            this.colFaslDrasyId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFaslDrasyId.AppearanceHeader.Options.UseTextOptions = true;
            this.colFaslDrasyId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFaslDrasyId.Caption = "دور";
            this.colFaslDrasyId.ColumnEdit = this.repositoryItemGridLookUpEditFaslDrasyId;
            this.colFaslDrasyId.FieldName = "FaslDrasyId";
            this.colFaslDrasyId.Name = "colFaslDrasyId";
            this.colFaslDrasyId.Visible = true;
            this.colFaslDrasyId.VisibleIndex = 8;
            // 
            // repositoryItemGridLookUpEditFaslDrasyId
            // 
            this.repositoryItemGridLookUpEditFaslDrasyId.AutoHeight = false;
            this.repositoryItemGridLookUpEditFaslDrasyId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditFaslDrasyId.DataSource = this.cdFaslDrasyBindingSource;
            this.repositoryItemGridLookUpEditFaslDrasyId.DisplayMember = "FaslDrasy";
            this.repositoryItemGridLookUpEditFaslDrasyId.Name = "repositoryItemGridLookUpEditFaslDrasyId";
            this.repositoryItemGridLookUpEditFaslDrasyId.NullText = "";
            this.repositoryItemGridLookUpEditFaslDrasyId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditFaslDrasyId.ValueMember = "FaslDrasyId";
            this.repositoryItemGridLookUpEditFaslDrasyId.View = this.gridView6;
            // 
            // cdFaslDrasyBindingSource
            // 
            this.cdFaslDrasyBindingSource.DataMember = "CdFaslDrasy";
            this.cdFaslDrasyBindingSource.DataSource = this.dsData;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFaslDrasy});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // colFaslDrasy
            // 
            this.colFaslDrasy.AppearanceCell.Options.UseTextOptions = true;
            this.colFaslDrasy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFaslDrasy.AppearanceHeader.Options.UseTextOptions = true;
            this.colFaslDrasy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFaslDrasy.Caption = "الاسم";
            this.colFaslDrasy.FieldName = "FaslDrasy";
            this.colFaslDrasy.Name = "colFaslDrasy";
            this.colFaslDrasy.Visible = true;
            this.colFaslDrasy.VisibleIndex = 0;
            // 
            // colgeha
            // 
            this.colgeha.AppearanceCell.Options.UseTextOptions = true;
            this.colgeha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgeha.AppearanceHeader.Options.UseTextOptions = true;
            this.colgeha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgeha.Caption = "الجهة";
            this.colgeha.FieldName = "geha";
            this.colgeha.Name = "colgeha";
            this.colgeha.Visible = true;
            this.colgeha.VisibleIndex = 9;
            // 
            // colesal
            // 
            this.colesal.AppearanceCell.Options.UseTextOptions = true;
            this.colesal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesal.AppearanceHeader.Options.UseTextOptions = true;
            this.colesal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesal.Caption = "رقم الايصال";
            this.colesal.FieldName = "esal";
            this.colesal.Name = "colesal";
            this.colesal.Visible = true;
            this.colesal.VisibleIndex = 10;
            // 
            // colesaldate
            // 
            this.colesaldate.AppearanceCell.Options.UseTextOptions = true;
            this.colesaldate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesaldate.AppearanceHeader.Options.UseTextOptions = true;
            this.colesaldate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesaldate.Caption = "تاريخ الايصال";
            this.colesaldate.ColumnEdit = this.repositoryItemDateEditdmy;
            this.colesaldate.FieldName = "esaldate";
            this.colesaldate.Name = "colesaldate";
            this.colesaldate.Visible = true;
            this.colesaldate.VisibleIndex = 11;
            // 
            // repositoryItemDateEditdmy
            // 
            this.repositoryItemDateEditdmy.AutoHeight = false;
            this.repositoryItemDateEditdmy.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditdmy.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditdmy.DisplayFormat.FormatString = "d/M/yyyy";
            this.repositoryItemDateEditdmy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditdmy.EditFormat.FormatString = "d/M/yyyy";
            this.repositoryItemDateEditdmy.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditdmy.Mask.EditMask = "d/M/yyyy";
            this.repositoryItemDateEditdmy.Name = "repositoryItemDateEditdmy";
            // 
            // colesalmony
            // 
            this.colesalmony.AppearanceCell.Options.UseTextOptions = true;
            this.colesalmony.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesalmony.AppearanceHeader.Options.UseTextOptions = true;
            this.colesalmony.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesalmony.Caption = "المبلغ";
            this.colesalmony.FieldName = "esalmony";
            this.colesalmony.Name = "colesalmony";
            this.colesalmony.Visible = true;
            this.colesalmony.VisibleIndex = 12;
            // 
            // XPSCS
            // 
            this.XPSCS.AllowEdit = true;
            this.XPSCS.AllowNew = true;
            this.XPSCS.AllowRemove = true;
            this.XPSCS.DeleteObjectOnRemove = true;
            this.XPSCS.ObjectType = typeof(StudentAffairs.Datasource.dsData.TblBeanDataTable);
            this.XPSCS.Session = this.sessionMain;
            // 
            // sessionMain
            // 
            this.sessionMain.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionMain.TrackPropertiesModifications = false;
            this.sessionMain.BeforeCommitTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.sessionMain_BeforeCommitTransaction);
            this.sessionMain.AfterCommitTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.sessionMain_AfterCommitTransaction);
            // 
            // cdStageTableAdapter
            // 
            this.cdStageTableAdapter.ClearBeforeFill = true;
            // 
            // cdBeanTypeTableAdapter
            // 
            this.cdBeanTypeTableAdapter.ClearBeforeFill = true;
            // 
            // cdExamTableAdapter
            // 
            this.cdExamTableAdapter.ClearBeforeFill = true;
            // 
            // cdYearTableAdapter
            // 
            this.cdYearTableAdapter.ClearBeforeFill = true;
            // 
            // cdSchoolTableAdapter
            // 
            this.cdSchoolTableAdapter.ClearBeforeFill = true;
            // 
            // cdShopaTableAdapter
            // 
            this.cdShopaTableAdapter.ClearBeforeFill = true;
            // 
            // cdFaslDrasyTableAdapter
            // 
            this.cdFaslDrasyTableAdapter.ClearBeforeFill = true;
            // 
            // TblBeanEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TblBeanEditorUC";
            this.Size = new System.Drawing.Size(906, 408);
            this.Load += new System.EventHandler(this.RouteEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditBeanTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdBeanTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditStageId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdStageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditExamId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdExamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditYearId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSchoolId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdSchoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditShopaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdShopaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditFaslDrasyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdFaslDrasyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditdmy.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditdmy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionMain)).EndInit();
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
        private DevExpress.Xpo.XPServerCollectionSource XPSCS;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colStageId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditStageId;
        private System.Windows.Forms.BindingSource cdStageBindingSource;
        private Datasource.dsData dsData;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colStageName;
        private DevExpress.XtraGrid.Columns.GridColumn colBeanTypeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditBeanTypeId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colBeanType;
        private Datasource.dsDataTableAdapters.cdStageTableAdapter cdStageTableAdapter;
        private System.Windows.Forms.BindingSource cdBeanTypeBindingSource;
        private Datasource.dsDataTableAdapters.CdBeanTypeTableAdapter cdBeanTypeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colExamId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditExamId;
        private System.Windows.Forms.BindingSource cdExamBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colExamName;
        private Datasource.dsDataTableAdapters.cdExamTableAdapter cdExamTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colYearId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditYearId;
        private System.Windows.Forms.BindingSource cdYearBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colYearName;
        private DevExpress.XtraGrid.Columns.GridColumn colstname;
        private DevExpress.XtraGrid.Columns.GridColumn colSchoolId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditSchoolId;
        private System.Windows.Forms.BindingSource cdSchoolBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colschool;
        private Datasource.dsDataTableAdapters.cdYearTableAdapter cdYearTableAdapter;
        private Datasource.dsDataTableAdapters.cdSchoolTableAdapter cdSchoolTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colgloosno;
        private DevExpress.XtraGrid.Columns.GridColumn colShopaId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditShopaId;
        private System.Windows.Forms.BindingSource cdShopaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colShopaName;
        private DevExpress.XtraGrid.Columns.GridColumn colFaslDrasyId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditFaslDrasyId;
        private System.Windows.Forms.BindingSource cdFaslDrasyBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colFaslDrasy;
        private DevExpress.XtraGrid.Columns.GridColumn colgeha;
        private DevExpress.XtraGrid.Columns.GridColumn colesal;
        private DevExpress.XtraGrid.Columns.GridColumn colesaldate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditdmy;
        private DevExpress.XtraGrid.Columns.GridColumn colesalmony;
        private Datasource.dsDataTableAdapters.cdShopaTableAdapter cdShopaTableAdapter;
        private Datasource.dsDataTableAdapters.CdFaslDrasyTableAdapter cdFaslDrasyTableAdapter;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddNew;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPrint;
        private DevExpress.Xpo.Session sessionMain;
    }
}
