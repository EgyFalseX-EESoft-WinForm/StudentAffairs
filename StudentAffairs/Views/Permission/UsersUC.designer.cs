﻿namespace StudentAffairs.Views.Permission
{
    partial class UsersUC
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
            this.UOW = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserPass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditPass = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colIsAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditEmpId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.LSMStblEmp = new DevExpress.Data.Linq.LinqServerModeSource();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditEmpId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMStblEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            this.SuspendLayout();
            // 
            // UOW
            // 
            this.UOW.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UOW.TrackPropertiesModifications = false;
            this.UOW.BeforeCommitTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.UOW_BeforeCommitTransaction);
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName,
            this.colUserPass,
            this.colIsActive,
            this.colIsAdmin,
            this.colEmpId});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.NewItemRowText = "Click here to add a new";
            this.gridViewMain.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewMain.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewMain.OptionsSelection.InvertSelection = true;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            this.gridViewMain.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewMain_InitNewRow);
            // 
            // colUserName
            // 
            this.colUserName.AppearanceCell.Options.UseTextOptions = true;
            this.colUserName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserName.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserName.Caption = "اسم المستخدم";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            this.colUserName.Width = 128;
            // 
            // colUserPass
            // 
            this.colUserPass.AppearanceCell.Options.UseTextOptions = true;
            this.colUserPass.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserPass.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserPass.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserPass.Caption = "كلمة المرور";
            this.colUserPass.ColumnEdit = this.repositoryItemTextEditPass;
            this.colUserPass.FieldName = "UserPass";
            this.colUserPass.Name = "colUserPass";
            this.colUserPass.Visible = true;
            this.colUserPass.VisibleIndex = 1;
            this.colUserPass.Width = 101;
            // 
            // repositoryItemTextEditPass
            // 
            this.repositoryItemTextEditPass.AutoHeight = false;
            this.repositoryItemTextEditPass.Name = "repositoryItemTextEditPass";
            this.repositoryItemTextEditPass.PasswordChar = '*';
            this.repositoryItemTextEditPass.UseSystemPasswordChar = true;
            // 
            // colIsActive
            // 
            this.colIsActive.AppearanceCell.Options.UseTextOptions = true;
            this.colIsActive.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsActive.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsActive.Caption = "متاح";
            this.colIsActive.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 4;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colIsAdmin
            // 
            this.colIsAdmin.AppearanceCell.Options.UseTextOptions = true;
            this.colIsAdmin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsAdmin.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsAdmin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsAdmin.Caption = "مدير";
            this.colIsAdmin.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colIsAdmin.FieldName = "IsAdmin";
            this.colIsAdmin.Name = "colIsAdmin";
            this.colIsAdmin.Visible = true;
            this.colIsAdmin.VisibleIndex = 2;
            // 
            // colEmpId
            // 
            this.colEmpId.AppearanceCell.Options.UseTextOptions = true;
            this.colEmpId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpId.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpId.Caption = "الاسم";
            this.colEmpId.ColumnEdit = this.repositoryItemGridLookUpEditEmpId;
            this.colEmpId.FieldName = "EmpId";
            this.colEmpId.Name = "colEmpId";
            this.colEmpId.Visible = true;
            this.colEmpId.VisibleIndex = 3;
            // 
            // repositoryItemGridLookUpEditEmpId
            // 
            this.repositoryItemGridLookUpEditEmpId.AutoHeight = false;
            this.repositoryItemGridLookUpEditEmpId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditEmpId.DataSource = this.LSMStblEmp;
            this.repositoryItemGridLookUpEditEmpId.DisplayMember = "EmpName";
            this.repositoryItemGridLookUpEditEmpId.Name = "repositoryItemGridLookUpEditEmpId";
            this.repositoryItemGridLookUpEditEmpId.NullText = "";
            this.repositoryItemGridLookUpEditEmpId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditEmpId.ValueMember = "EmpId";
            this.repositoryItemGridLookUpEditEmpId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // LSMStblEmp
            // 
            this.LSMStblEmp.ElementType = typeof(StudentAffairs.Datasource.linq.tblEmp);
            this.LSMStblEmp.KeyExpression = "[EmpId]";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "الاسم";
            this.gridColumn1.FieldName = "EmpName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridControlMain
            // 
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEditPass,
            this.repositoryItemCheckEdit1,
            this.repositoryItemGridLookUpEditEmpId});
            this.gridControlMain.Size = new System.Drawing.Size(679, 360);
            this.gridControlMain.TabIndex = 5;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
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
            this.bbiSave.LargeGlyph = global::StudentAffairs.Properties.Resources.saveall_32x32;
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Glyph = global::StudentAffairs.Properties.Resources.refresh2_16x16;
            this.bbiRefresh.Id = 2;
            this.bbiRefresh.LargeGlyph = global::StudentAffairs.Properties.Resources.refresh2_32x32;
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
            this.barDockControlTop.Size = new System.Drawing.Size(679, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 391);
            this.barDockControlBottom.Size = new System.Drawing.Size(679, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 360);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(679, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 360);
            // 
            // XPSCS
            // 
            this.XPSCS.AllowEdit = true;
            this.XPSCS.AllowNew = true;
            this.XPSCS.AllowRemove = true;
            this.XPSCS.DeleteObjectOnRemove = true;
            this.XPSCS.ObjectType = typeof(StudentAffairs.Datasource.dsData.UsersDataTable);
            this.XPSCS.Session = this.UOW;
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // UsersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UsersUC";
            this.Size = new System.Drawing.Size(679, 391);
            this.Load += new System.EventHandler(this.ProductEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditEmpId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMStblEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.UnitOfWork UOW;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.Xpo.XPServerCollectionSource XPSCS;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserPass;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditPass;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpId;
        private DevExpress.Data.Linq.LinqServerModeSource LSMStblEmp;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditEmpId;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}
