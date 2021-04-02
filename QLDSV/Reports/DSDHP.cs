using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.Reports
{
    public partial class DSDHP : Form
    {
        public DSDHP()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void DSDHP_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            
            // TODO: This line of code loads data into the 'dS.HOCPHI' table. You can move, or remove it, as needed.
            this.hOCPHITableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.hOCPHITableAdapter.Fill(this.dS.HOCPHI);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            

        }

        private void lookUpEditLop_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtMaLop.Text = this.lookUpEditLop.EditValue.ToString();
            }
            catch (Exception) { }
        }

        private void cbbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExtraReport_DSDHP1 report = new ExtraReport_DSDHP1(this.lookUpEditLop.EditValue.ToString(), this.lookUpEditNienKhoa.EditValue.ToString(), this.numericHocKi.Value);
            report.lbLop.Text = lookUpEditLop.Text;
            report.lbNienKhoa.Text = lookUpEditNienKhoa.Text;
            report.lbHocKi.Text = numericHocKi.Value.ToString();
            report.lbAuthor.Text = "Người In Ấn : " + Program.MHoten;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }
    }
}
