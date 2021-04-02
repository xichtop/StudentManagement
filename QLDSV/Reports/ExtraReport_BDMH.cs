using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Reports
{
    public partial class ExtraReport_BDMH : DevExpress.XtraReports.UI.XtraReport
    {
        public ExtraReport_BDMH(string MALOP, string MAMH, decimal LAN)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.URL_Connect;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = MALOP;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = MAMH;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = LAN;
            this.sqlDataSource1.Fill();
        }

    }
}
