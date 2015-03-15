﻿namespace StudentAffairs.Views.Code
{
    partial class cdSchoolEditorUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cdSchoolEditorUC));
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
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colschool = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStageId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditStageId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cdStageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsData = new StudentAffairs.Datasource.dsData();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStageName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdaraId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditEdaraId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cdEdaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEdara = new DevExpress.XtraGrid.Columns.GridColumn();
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.cdStageTableAdapter = new StudentAffairs.Datasource.dsDataTableAdapters.cdStageTableAdapter();
            this.cdEdaraTableAdapter = new StudentAffairs.Datasource.dsDataTableAdapters.cdEdaraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditStageId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdStageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditEdaraId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdEdaraBindingSource)).BeginInit();
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
            this.repositoryItemGridLookUpEditStageId,
            this.repositoryItemGridLookUpEditEdaraId});
            this.gridControlMain.Size = new System.Drawing.Size(652, 377);
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
            this.colschool,
            this.colStageId,
            this.colEdaraId});
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
            this.colschool.Width = 165;
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
            this.colStageId.VisibleIndex = 1;
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
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // colEdaraId
            // 
            this.colEdaraId.AppearanceCell.Options.UseTextOptions = true;
            this.colEdaraId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEdaraId.AppearanceHeader.Options.UseTextOptions = true;
            this.colEdaraId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEdaraId.Caption = "الادارة";
            this.colEdaraId.ColumnEdit = this.repositoryItemGridLookUpEditEdaraId;
            this.colEdaraId.FieldName = "EdaraId";
            this.colEdaraId.Name = "colEdaraId";
            this.colEdaraId.Visible = true;
            this.colEdaraId.VisibleIndex = 2;
            this.colEdaraId.Width = 128;
            // 
            // repositoryItemGridLookUpEditEdaraId
            // 
            this.repositoryItemGridLookUpEditEdaraId.AutoHeight = false;
            this.repositoryItemGridLookUpEditEdaraId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditEdaraId.DataSource = this.cdEdaraBindingSource;
            this.repositoryItemGridLookUpEditEdaraId.DisplayMember = "Edara";
            this.repositoryItemGridLookUpEditEdaraId.Name = "repositoryItemGridLookUpEditEdaraId";
            this.repositoryItemGridLookUpEditEdaraId.NullText = "";
            this.repositoryItemGridLookUpEditEdaraId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditEdaraId.ValueMember = "EdaraId";
            this.repositoryItemGridLookUpEditEdaraId.View = this.gridView1;
            // 
            // cdEdaraBindingSource
            // 
            this.cdEdaraBindingSource.DataMember = "cdEdara";
            this.cdEdaraBindingSource.DataSource = this.dsData;
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
            this.colEdara.FieldName = "Edara";
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
            this.XPSCS.ObjectType = typeof(StudentAffairs.Datasource.dsData.cdSchoolDataTable);
            this.XPSCS.Session = this.UOW;
            // 
            // cdStageTableAdapter
            // 
            this.cdStageTableAdapter.ClearBeforeFill = true;
            // 
            // cdEdaraTableAdapter
            // 
            this.cdEdaraTableAdapter.ClearBeforeFill = true;
            // 
            // cdSchoolEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "cdSchoolEditorUC";
            this.Size = new System.Drawing.Size(652, 408);
            this.Load += new System.EventHandler(this.RouteEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditStageId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdStageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditEdaraId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdEdaraBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colschool;
        private DevExpress.XtraGrid.Columns.GridColumn colStageId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditStageId;
        private System.Windows.Forms.BindingSource cdStageBindingSource;
        private Datasource.dsData dsData;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colStageName;
        private DevExpress.XtraGrid.Columns.GridColumn colEdaraId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditEdaraId;
        private System.Windows.Forms.BindingSource cdEdaraBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEdara;
        private Datasource.dsDataTableAdapters.cdStageTableAdapter cdStageTableAdapter;
        private Datasource.dsDataTableAdapters.cdEdaraTableAdapter cdEdaraTableAdapter;
    }
}
