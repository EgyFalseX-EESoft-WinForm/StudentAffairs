using DevExpress.XtraEditors;
using System.Collections.Generic;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Views;
using System.Drawing;
using StudentAffairs.Views.Code;
using StudentAffairs.Views.Data;
using StudentAffairs.Views.Permission;

namespace StudentAffairs.Views.Main
{
    public partial class MainForm : XtraForm
    {
        #region - Variables -
        #endregion
        #region - Functions -
        public MainForm()
        {
            InitializeComponent();
            windowsUIView.AddTileWhenCreatingDocument = DevExpress.Utils.DefaultBoolean.False;
            AddGeneralButtions();
            AddPrivateButtions();
        }
        private void AddGeneralButtions()
        {

            //Minimize Button
            DelegateAction btnMinimize = new DelegateAction(() => { return true; }, () =>
            {
                WindowState = System.Windows.Forms.FormWindowState.Minimized;
            });
            btnMinimize.Type = ActionType.Navigation;
            btnMinimize.Caption = "Minimize";
            btnMinimize.Behavior = ActionBehavior.Default;
            btnMinimize.Edge = ActionEdge.Default;
            btnMinimize.Image = StudentAffairs.Properties.Resources.next_32x32;
            windowsUIView.ContentContainerActions.Add(btnMinimize);
        }
        public void AddPrivateButtions()
        {
            //User Setting Button
            DelegateAction btnUserSettings = new DelegateAction(() => { return true; }, () =>
            {
                windowsUIView.Controller.Activate(pageUserSettings);
            });
            btnUserSettings.Type = ActionType.Context;
            btnUserSettings.Caption = "User Settings";
            btnUserSettings.Behavior = ActionBehavior.HideBarOnClick;
            btnUserSettings.Edge = ActionEdge.Left;
            btnUserSettings.Image = Properties.Resources.ide_32x32;
            windowsUIView.ContentContainerActions.Add(btnUserSettings);

        }
        public void LoadLayout()
        {
            // Load Layout Saved Settings
            string FileName = Program.TilesLayoutFile + Classes.Managers.UserManager.defaultInstance.User.UserId.ToString();
            if (System.IO.File.Exists(FileName))
            {
                System.IO.FileStream Fs = new System.IO.FileStream(FileName, System.IO.FileMode.Open);
                windowsUIView.RestoreLayoutFromStream(Fs);
            }
        }
        public void ActivateRules()
        {
            if (Classes.Managers.UserManager.defaultInstance.User.IsAdmin == true)
                return;

            foreach (var item in windowsUIView.ContentContainers.ToArray())
            {
                if (item.GetType() != typeof(TileContainer))//Apply Only For Tiles Containers 
                    continue;

                if (((TileContainer)item).Items == null)
                    continue;
                for (int InxContainers = 0; InxContainers < ((TileContainer)item).Items.Count; InxContainers++)
                {
                    TileContainer cntr = (TileContainer)item;
                    for (int i = (cntr).Items.Count - 1; i >= 0; i--)
                    {
                        Tile tile = (Tile)(cntr).Items[i];
                        StudentAffairs.Datasource.dsData.RuleDetailRow elementRule = Classes.Managers.UserManager.defaultInstance.RuleElementInformation(tile.Document.ControlName);
                        if (tile.Tag != null && (bool)tile.Tag)// Show Exception Tiles
                            tile.Visible = true;
                        else
                            tile.Visible = elementRule.Selecting;
                    }
                }
            }
        }
        #endregion
        #region - EventWhnd -
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            ActivateRules();
            LoadLayout();
            windowsUIView.ActivateContainer(tileContainerMain);
            
        }
        private void windowsUIView_QueryControl(object sender, QueryControlEventArgs e)
        {

            Datasource.dsData.RuleDetailRow RuleElemet = Classes.Managers.UserManager.defaultInstance.RuleElementInformation(e.Document.ControlName);
            if (e.Control != null)
                return;
            if (e.Document == docUserSetting)
            {
                e.Control = new UserSettingsUC();
            }
            else if (e.Document == docCodecdYear)
            {
                e.Control = new cdYearEditorUC(RuleElemet);
            }
            else if (e.Document == docCodecdSchool)
            {
                e.Control = new cdSchoolEditorUC(RuleElemet);
            }
            else if (e.Document == docCodecdStage)
            {
                e.Control = new cdStageEditorUC(RuleElemet);
            }
            else if (e.Document == docCodecdShopa)
            {
                e.Control = new cdShopaEditorUC(RuleElemet);
            }
            else if (e.Document == docCodecdExam)
            {
                e.Control = new cdExamEditorUC(RuleElemet);
            }
            else if (e.Document == docCodecdDept)
            {
                e.Control = new cdDeptEditorUC(RuleElemet);
            }
            else if (e.Document == docCodecdJob)
            {
                e.Control = new cdJobEditorUC(RuleElemet);
            }
            else if (e.Document == docCodeCdMada)
            {
                e.Control = new CdMadaEditorUC(RuleElemet);
            }
            else if (e.Document == docDatatblEmp)
            {
                e.Control = new tblEmpEditorUC(RuleElemet);
            }
            else if (e.Document == docDataTblMawadSfof)
            {
                e.Control = new TblMawadSfofEditorUC(RuleElemet);
            }
            else if (e.Document == docDataTblBean)// Data
            {
                e.Control = new TblBeanEditorUC(RuleElemet);
            }
            else if (e.Document == docDataTblBeanDragat)
            {
                e.Control = new TblBeanDragatEditorUC(RuleElemet);
            }
            else if (e.Document == docRuleUsers)// Rules
            {
                e.Control = new UsersUC(RuleElemet);
            }
            else if (e.Document == docRuleRule)
            {
                e.Control = new RolesUC(RuleElemet);
            }
            else if (e.Document == docRuleUserRoles)
            {
                e.Control = new UserRolesUC(RuleElemet);
            }
            else if (e.Document == docRuleRuleDetails)
            {
                e.Control = new RuleDetailsUC(RuleElemet);
            }


        }
        #endregion
        
    }
}
