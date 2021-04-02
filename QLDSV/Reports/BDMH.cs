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
    public partial class BDMH : Form
    {
        public BDMH()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void BDMH_Load(object sender, EventArgs e)
        {
            

            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            Program.Bds_Dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Utils.BindingDataToComBo(cmbTenKhoa, Program.Bds_Dspm);

            if (Program.MGroup == Program.NhomQuyen[0] || Program.MGroup == Program.NhomQuyen[2])// PGV hoặc User
            {
                cmbTenKhoa.Visible = true;
                cmbTenKhoa.Enabled = true;
            }
            if (Program.MGroup == Program.NhomQuyen[1])// KHOA
            {
                cmbTenKhoa.Visible = false;
                cmbTenKhoa.Enabled = false;
                lbTenKhoa.Text = ((DataRowView)Program.Bds_Dspm[Program.MKhoa])["TENKHOA"].ToString();
            }

            this.txtMaLop.Text = this.cmbTenLop.SelectedValue.ToString();
            this.txtMaMH.Text = this.cmbTenMH.SelectedValue.ToString();

        }

        private void cmbTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO : Chuyển Bộ Phận
            Utils.ComboboxHelper(this.cmbTenKhoa);
            // kết nối database với dữ liệu ở đoạn code trên và fill dữ liệu, nếu như có lỗi thì thoát.
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }

            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ExtraReport_BDMH report = new ExtraReport_BDMH(this.cmbTenLop.SelectedValue.ToString(), this.cmbTenMH.SelectedValue.ToString(), this.numberLanThi.Value);
            report.txtLop.Text = cmbTenLop.Text;
            report.txtMonHoc.Text = cmbTenMH.Text;
            report.txtLanThi.Text = numberLanThi.Value.ToString();
            report.lbAuthor.Text = "Người In Ấn : " + Program.MHoten;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaLop.Text = this.cmbTenLop.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void cmbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaMH.Text = this.cmbTenMH.SelectedValue.ToString();
            }
            catch (Exception) { }
        }
    }
}
