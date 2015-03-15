using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace StudentAffairs.XRep
{
    public partial class XRep01 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep01(int id)
        {
            InitializeComponent();
            xRep01TableAdapter.Fill(dsRep1.XRep01, id);
        }

    }
}
