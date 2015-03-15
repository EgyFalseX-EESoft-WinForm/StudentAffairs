using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Data;

namespace StudentAffairs.Views.Data
{
    public partial class TblBeanEditorUC : XtraUserControl
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TblBeanEditorUC));
        Datasource.dsData.RuleDetailRow _elementRule = null;
        int PrintId = -1;
        #endregion
        #region - Fun -
        public TblBeanEditorUC(Datasource.dsData.RuleDetailRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
        }
        void LoadData()
        {
            SplashScreenManager.ShowForm(typeof(StudentAffairs.Views.Main.WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                Invoke(new MethodInvoker(() =>
                {
                    LoadDefaultData();
                    XPSCS.Session.ConnectionString = Properties.Settings.Default.StudentAffairsConnectionString;
                    gridControlMain.DataSource = XPSCS;
                    gridViewMain.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        void LoadDefaultData()
        {
            cdStageTableAdapter.Fill(dsData.cdStage);
            cdBeanTypeTableAdapter.Fill(dsData.CdBeanType);
            cdExamTableAdapter.Fill(dsData.cdExam);
            cdYearTableAdapter.Fill(dsData.cdYear);
            cdSchoolTableAdapter.Fill(dsData.cdSchool);
            cdShopaTableAdapter.Fill(dsData.cdShopa);
            cdFaslDrasyTableAdapter.Fill(dsData.CdFaslDrasy);
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
        private void RouteEditorUC_Load(object sender, EventArgs e)
        {
            LoadData();
            ActivateRules();
        }
        private void sessionMain_BeforeCommitTransaction(object sender, DevExpress.Xpo.SessionManipulationEventArgs e)
        {
            // Get NewId
            int id = 0;
            object obj = Classes.Managers.DataManager.GetNewId("TblBean", "Beanid");
            if (obj == null)
            {
                MsgDlg.ShowAlert(Properties.Settings.Default.msg_SavingFailed, MsgDlg.MessageType.Error, (Form)Parent.Parent.Parent);
                return;
            }
            id = Convert.ToInt32(obj);
            // Assgin NewId to New Rows
            DevExpress.Xpo.Helpers.ObjectSet Rows = (DevExpress.Xpo.Helpers.ObjectSet)e.Session.GetObjectsToSave();
            DateTime DTServer = Classes.Managers.DataManager.GetServerDatetime;
            foreach (DevExpress.Xpo.Metadata.XPDataTableObject item in Rows)
            {
                item.SetMemberValue("datein", DTServer);
                item.SetMemberValue("userin", Classes.Managers.UserManager.defaultInstance.User.UserId);

                if (item.GetMemberValue("Beanid") == null)
                {
                    item.SetMemberValue("Beanid", id);
                    item.Save();
                    PrintId = id;
                    id++;
                }
            }
        }
        private void barButtonItemAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewMain.AddNewRow();
            gridViewMain.ShowEditForm();
            //DevExpress.Xpo.Metadata.XPDataTableObject row = (DevExpress.Xpo.Metadata.XPDataTableObject)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
            //object aaa = row.GetMemberValue("Beanid");
        }
        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewMain.ShowEditForm();
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
            sessionMain.CommitTransactionAsync(CommitCallBack);
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
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            LoadDefaultData();
            sessionMain.DropIdentityMap();
            //sessionMain.DropChanges();
            XPSCS.Reload();
            gridViewMain.RefreshData();
        }
        #endregion

        private void barButtonItemPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.Xpo.Metadata.XPDataTableObject row = ((DevExpress.Xpo.Metadata.XPDataTableObject)gridViewMain.GetRow(gridViewMain.FocusedRowHandle));
            if (row == null)
                return;
            int id = Convert.ToInt32(row.GetMemberValue("Beanid"));
            XRep.XRep01 report = new XRep.XRep01(id);
            Classes.Misc.ShowPrintPreview(report);
        }

        private void sessionMain_AfterCommitTransaction(object sender, DevExpress.Xpo.SessionManipulationEventArgs e)
        {
            if (PrintId == -1)
                return;
            int id = PrintId;
            XRep.XRep01 report = new XRep.XRep01(id);
            PrintId = -1;
            Classes.Misc.ShowPrintPreview(report);
        }

    }
}
