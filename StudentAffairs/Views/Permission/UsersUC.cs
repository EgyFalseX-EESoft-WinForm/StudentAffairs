﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Data;

namespace StudentAffairs.Views.Permission
{
    public partial class UsersUC : XtraUserControl
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(UsersUC));
        StudentAffairs.Datasource.dsData.RuleDetailRow _elementRule = null;
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        int? NewId = null;
        #endregion
        #region - Fun -
        public UsersUC(StudentAffairs.Datasource.dsData.RuleDetailRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
        }
        void LoadData()
        {
            SplashScreenManager.ShowForm(typeof(StudentAffairs.Views.Main.WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                Invoke(new MethodInvoker(() => {
                    LSMStblEmp.QueryableSource = from q in dsLinq.tblEmps select q;
                    XPSCS.Session.ConnectionString = Properties.Settings.Default.StudentAffairsConnectionString;
                    gridControlMain.DataSource = XPSCS;
                    gridViewMain.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        public void ActivateRules()
        {
            XPSCS.AllowNew = _elementRule.Inserting;
            XPSCS.AllowRemove = _elementRule.Deleting;
            XPSCS.AllowEdit = _elementRule.Updateing;

            if (!_elementRule.Updateing)
                bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            if (!_elementRule.Inserting)
            {
                gridViewMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            }

            if (!_elementRule.Deleting)
                gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;

        }
        #endregion
        #region -  EventWhnd - 
        private void ProductEditorUC_Load(object sender, EventArgs e)
        {
            LoadData();
            ActivateRules();
        }
        private void gridViewMain_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.Xpo.Metadata.XPDataTableObject row = ((DevExpress.Xpo.Metadata.XPDataTableObject)gridViewMain.GetRow(e.RowHandle));
            row.SetMemberValue("ModereaId", 0);
        }
        private void UOW_BeforeCommitTransaction(object sender, DevExpress.Xpo.SessionManipulationEventArgs e)
        {
            // Get NewId
            int id = 0;
            object obj = Classes.Managers.DataManager.GetNewId("Users", "UserID");
            if (obj == null)
            {
                MsgDlg.ShowAlert(Properties.Settings.Default.msg_SavingFailed, MsgDlg.MessageType.Error, (Form)Parent.Parent.Parent);
                return;
            }
            id = Convert.ToInt32(obj);
            // Assgin NewId to New Rows
            DevExpress.Xpo.Helpers.ObjectSet Rows = (DevExpress.Xpo.Helpers.ObjectSet)e.Session.GetObjectsToSave();
            foreach (DevExpress.Xpo.Metadata.XPDataTableObject item in Rows)
            {
                if (item.GetMemberValue("UserID") == null)
                {
                    item.SetMemberValue("UserID", id);
                    id++;
                }
            }
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;

            DevExpress.Xpo.AsyncCommitCallback CommitCallBack = (o) =>
            {
                SplashScreenManager.CloseForm();
                if (o == null)
                {
                    MsgDlg.ShowAlert(Properties.Settings.Default.msg_SaveSuccess, MsgDlg.MessageType.Success, (Form)Parent.Parent.Parent);
                    Logger.Info(Properties.Settings.Default.msg_SaveSuccess);
                }
                else
                {
                    MsgDlg.ShowAlert(String.Format("{0}, {1}, {2}", Properties.Settings.Default.msg_SavingFailed, Environment.NewLine, o.Message), MsgDlg.MessageType.Error, (Form)Parent.Parent.Parent);
                    Classes.Core.LogException(Logger, o.InnerException, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                }
            };

            SplashScreenManager.ShowForm(typeof(StudentAffairs.Views.Main.WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormDescription(Properties.Settings.Default.msg_SavingInProgress);
            UOW.CommitTransactionAsync(CommitCallBack);
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlMain.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            gridControlMain.ShowRibbonPrintPreview();
        }
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            UOW.DropIdentityMap();
            UOW.DropChanges();
            XPSCS.Reload();
            gridViewMain.RefreshData();
        }
        #endregion

    }
}
