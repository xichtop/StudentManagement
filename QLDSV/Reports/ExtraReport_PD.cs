using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Reports
{
    public partial class ExtraReport_PD : DevExpress.XtraReports.UI.XtraReport
    {
        public ExtraReport_PD(string MASV)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.URL_Connect;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = MASV;
            this.sqlDataSource1.Fill();
        }

    }
}
