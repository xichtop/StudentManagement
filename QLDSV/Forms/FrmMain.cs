using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QLDSV.Forms;
using QLDSV.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        Boolean dangxuat = false;

        public FrmMain()
        {
            InitializeComponent();
        }

        //kiem tra tồn tại
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        //mở form
        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.Activate();
                    return;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }


        private void barButtonItem_Lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmLop));
        }

        private void barButtonItem_MonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           ShowMdiChildren(typeof(FrmMonHoc));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmMain_Load_1(object sender, EventArgs e)
        {
            if (Program.MGroup == Program.NhomQuyen[3])// PKT
            {
                this.barButtonItem_Lop.Enabled = false;
                this.barButtonItem_MonHoc.Enabled = false;
                this.barButtonItem_SV.Enabled = false;
                this.barButtonItem_Diem.Enabled = false;
                this.barButtonItem_ChuyenLop.Enabled = false;
                this.barButtonItem_HocPhi.Enabled = true;

                this.barButtonItem_DSHP.Enabled = true;
                this.barButtonItem_DSSV.Enabled = false;
                this.barButtonItem_BDT.Enabled = false;
                this.barButtonItem_BDMH.Enabled = false;
                this.barButtonItem_PD.Enabled = false;
                this.barButtonItem_BDTK.Enabled = false;
            }
            else if (Program.MGroup == Program.NhomQuyen[2]) //User
            {
                this.barButtonItem_TaoTK.Enabled = false;
                this.barButtonItem_DSHP.Enabled = false;
                this.barButtonItem_HocPhi.Enabled = false;
            }
            else
            {
                this.barButtonItem_DSHP.Enabled = false;
                this.barButtonItem_HocPhi.Enabled = false;
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangxuat = true;
            Program.FrmMain.Close();
            Program.FrmDangNhap.Visible = true;
        }

        private void barButtonItem_SV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmSinhVien));
        }

        private void barButtonItem_Diem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmDiem));
        }

        private void barButtonItem_DSSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(DSSV));
        }

        private void barButtonItem_BDMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(BDMH));
        }

        private void barButtonItem_TaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmDangKy));
        }

        private void barButtonItem_BDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(DSTHM));
        }

        private void barButtonItem_PD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(PD));
        }

        private void barButtonItem_DSHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(DSDHP));
        }

        private void barButtonItem_BDTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(BDTK));
        }

        private void barButtonItem_HocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmHocPhi));
        }

        private void barButtonItem_ChuyenLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmChuyenLop));
        }
    }
}
