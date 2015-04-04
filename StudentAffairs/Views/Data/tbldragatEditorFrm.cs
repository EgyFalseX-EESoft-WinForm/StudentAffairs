using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace StudentAffairs.Views.Data
{
    public partial class tbldragatEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(tbldragatEditorFrm));
        Datasource.dsDataTableAdapters.QueriesTableAdapter adpQ = new Datasource.dsDataTableAdapters.QueriesTableAdapter();
        int _id;
        public tbldragatEditorFrm(int id)
        {
            InitializeComponent();

            _id = id;
            this.cdMadaTableAdapter.Fill(this.dsData.CdMada);
            
        }
        private void tbldragatEditorFrm_Load(object sender, EventArgs e)
        {
            adpQ.Inserttbldragat(_id.ToString());
            tbldragatTableAdapter.FillByBeanDragatId(dsData.tbldragat, _id);
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbldragatTableAdapter.Update(dsData.tbldragat);
            Close();
        }
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbldragatTableAdapter.FillByBeanDragatId(dsData.tbldragat, _id);
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
    }
}