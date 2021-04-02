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
    public partial class PD : Form
    {
        public PD()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void PD_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.lOPTableAdapter.Fill(this.dS.LOP);
           

            Program.Bds_Dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Utils.BindingDataToComBo(cbbTenKhoa, Program.Bds_Dspm);

            if (Program.MGroup == Program.NhomQuyen[0] || Program.MGroup == Program.NhomQuyen[2])// PGV hoặc User
            {
                cbbTenKhoa.Visible = true;
                cbbTenKhoa.Enabled = true;
            }
            if (Program.MGroup == Program.NhomQuyen[1])// KHOA
            {
                cbbTenKhoa.Visible = false;
                cbbTenKhoa.Enabled = false;
                lbTenKhoa.Text = ((DataRowView)Program.Bds_Dspm[Program.MKhoa])["TENKHOA"].ToString();
            }

        }

        private void cbbTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO : Chuyển Bộ Phận
            Utils.ComboboxHelper(this.cbbTenKhoa);
            // kết nối database với dữ liệu ở đoạn code trên và fill dữ liệu, nếu như có lỗi thì thoát.
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }

            dS.EnforceConstraints = false;
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
            try
            {
                this.sP_DSSV_MHTableAdapter.Fill(this.dS.SP_DSSV_MH, this.lookUpEditLop.EditValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }



        private void btnIn_Click(object sender, EventArgs e)
        {
            ExtraReport_PD report = new ExtraReport_PD(this.txtMaSV.Text.Trim().ToString());
            report.txtLop.Text = lookUpEditLop.Text;
            report.txtHoTen.Text = lookUpEdit1.Text;
            report.txtAuthor.Text = "Người In Ấn : " + Program.MHoten;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtMaSV.Text = this.lookUpEdit1.EditValue.ToString();
            }
            catch (Exception) { }

        }
        
    }
}
