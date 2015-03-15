using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Data;
using System.Data.SqlClient;

namespace StudentAffairs.Views.Code
{
    public partial class TblMawadSfofEditorUC : XtraUserControl
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TblMawadSfofEditorUC));
        Datasource.dsData.RuleDetailRow _elementRule = null;
        #endregion
        #region - Fun -
        public TblMawadSfofEditorUC(Datasource.dsData.RuleDetailRow RuleElement)
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
                    cdExamTableAdapter.Fill(dsData.cdExam);
                    cdMadaTableAdapter.Fill(dsData.CdMada);
                    tblMawadSfofTableAdapter.Fill(dsData.TblMawadSfof);
                    //XPSCS.Session.ConnectionString = Properties.Settings.Default.StudentAffairsConnectionString;
                    //gridControlMain.DataSource = XPSCS;
                    gridViewMain.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        public void ActivateRules()
        {
            
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
        private void UOW_BeforeCommitTransaction(object sender, DevExpress.Xpo.SessionManipulationEventArgs e)
        {
            // Get NewId
            int id = 0;
            object obj = Classes.Managers.DataManager.GetNewId("cdSchool", "SchoolId");
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
                if (item.GetMemberValue("SchoolId") == null)
                {
                    item.SetMemberValue("SchoolId", id);
                    id++;
                }
            }
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            this.Enabled = false;
            SplashScreenManager.ShowForm(typeof(StudentAffairs.Views.Main.WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormDescription(Properties.Settings.Default.msg_SavingInProgress);
            //System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            //{            });
            try
            {
                tblMawadSfofTableAdapter.Update(dsData.TblMawadSfof);

                MsgDlg.ShowAlert(Properties.Settings.Default.msg_SaveSuccess, MsgDlg.MessageType.Success, new Form());
                Logger.Info(Properties.Settings.Default.msg_SaveSuccess);
            }
            catch (SqlException ex)
            {
                MsgDlg.ShowAlert(String.Format("{0}, {1}, {2}", Properties.Settings.Default.msg_SavingFailed, Environment.NewLine, ex.Message), MsgDlg.MessageType.Error, (Form)Parent.Parent.Parent);
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
            SplashScreenManager.CloseForm();
            this.Enabled = true;
            
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
            //UOW.DropIdentityMap();
            //UOW.DropChanges();
            //XPSCS.Reload();
            LoadData();
            gridViewMain.RefreshData();
        }
        #endregion

    }
}
