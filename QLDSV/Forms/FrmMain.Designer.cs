namespace QLDSV
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem_Lop = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_MonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_SV = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Diem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_ChuyenLop = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_HocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_DSSV = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_BDT = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_BDMH = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_PD = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_DSHP = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_BDTK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_TaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem_SinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbMaGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbNhom = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem_Lop,
            this.barButtonItem_MonHoc,
            this.barButtonItem_SV,
            this.barButtonItem_Diem,
            this.barButtonItem_ChuyenLop,
            this.barButtonItem_HocPhi,
            this.barButtonItem_DSSV,
            this.barButtonItem_BDT,
            this.barButtonItem_BDMH,
            this.barButtonItem_PD,
            this.barButtonItem_DSHP,
            this.barButtonItem_BDTK,
            this.barButtonItem_TaoTK,
            this.barButtonItem_DangXuat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(1725, 217);
            // 
            // barButtonItem_Lop
            // 
            this.barButtonItem_Lop.Caption = "LỚP";
            this.barButtonItem_Lop.Id = 1;
            this.barButtonItem_Lop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Lop.ImageOptions.Image")));
            this.barButtonItem_Lop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Lop.ImageOptions.LargeImage")));
            this.barButtonItem_Lop.LargeWidth = 75;
            this.barButtonItem_Lop.Name = "barButtonItem_Lop";
            this.barButtonItem_Lop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Lop_ItemClick);
            // 
            // barButtonItem_MonHoc
            // 
            this.barButtonItem_MonHoc.Caption = "MÔN HỌC";
            this.barButtonItem_MonHoc.Id = 2;
            this.barButtonItem_MonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_MonHoc.ImageOptions.Image")));
            this.barButtonItem_MonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_MonHoc.ImageOptions.LargeImage")));
            this.barButtonItem_MonHoc.LargeWidth = 75;
            this.barButtonItem_MonHoc.Name = "barButtonItem_MonHoc";
            this.barButtonItem_MonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_MonHoc_ItemClick);
            // 
            // barButtonItem_SV
            // 
            this.barButtonItem_SV.Caption = "SINH VIÊN";
            this.barButtonItem_SV.Id = 3;
            this.barButtonItem_SV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_SV.ImageOptions.Image")));
            this.barButtonItem_SV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_SV.ImageOptions.LargeImage")));
            this.barButtonItem_SV.LargeWidth = 75;
            this.barButtonItem_SV.Name = "barButtonItem_SV";
            this.barButtonItem_SV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_SV_ItemClick);
            // 
            // barButtonItem_Diem
            // 
            this.barButtonItem_Diem.Caption = "ĐIỂM";
            this.barButtonItem_Diem.Id = 4;
            this.barButtonItem_Diem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Diem.ImageOptions.Image")));
            this.barButtonItem_Diem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Diem.ImageOptions.LargeImage")));
            this.barButtonItem_Diem.LargeWidth = 75;
            this.barButtonItem_Diem.Name = "barButtonItem_Diem";
            this.barButtonItem_Diem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Diem_ItemClick);
            // 
            // barButtonItem_ChuyenLop
            // 
            this.barButtonItem_ChuyenLop.Caption = "CHUYỂN LỚP";
            this.barButtonItem_ChuyenLop.Id = 5;
            this.barButtonItem_ChuyenLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChuyenLop.ImageOptions.Image")));
            this.barButtonItem_ChuyenLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChuyenLop.ImageOptions.LargeImage")));
            this.barButtonItem_ChuyenLop.LargeWidth = 75;
            this.barButtonItem_ChuyenLop.Name = "barButtonItem_ChuyenLop";
            this.barButtonItem_ChuyenLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ChuyenLop_ItemClick);
            // 
            // barButtonItem_HocPhi
            // 
            this.barButtonItem_HocPhi.Caption = "HỌC PHÍ";
            this.barButtonItem_HocPhi.Id = 6;
            this.barButtonItem_HocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_HocPhi.ImageOptions.Image")));
            this.barButtonItem_HocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_HocPhi.ImageOptions.LargeImage")));
            this.barButtonItem_HocPhi.LargeWidth = 75;
            this.barButtonItem_HocPhi.Name = "barButtonItem_HocPhi";
            this.barButtonItem_HocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_HocPhi_ItemClick);
            // 
            // barButtonItem_DSSV
            // 
            this.barButtonItem_DSSV.Caption = "DANH SÁCH SINH VIÊN";
            this.barButtonItem_DSSV.Id = 7;
            this.barButtonItem_DSSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_DSSV.ImageOptions.SvgImage")));
            this.barButtonItem_DSSV.LargeWidth = 100;
            this.barButtonItem_DSSV.Name = "barButtonItem_DSSV";
            this.barButtonItem_DSSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_DSSV_ItemClick);
            // 
            // barButtonItem_BDT
            // 
            this.barButtonItem_BDT.Caption = "BẢNG ĐIỂM THI";
            this.barButtonItem_BDT.Id = 8;
            this.barButtonItem_BDT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_BDT.ImageOptions.SvgImage")));
            this.barButtonItem_BDT.LargeWidth = 100;
            this.barButtonItem_BDT.Name = "barButtonItem_BDT";
            this.barButtonItem_BDT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_BDT_ItemClick);
            // 
            // barButtonItem_BDMH
            // 
            this.barButtonItem_BDMH.Caption = "BẢNG ĐIỂM MÔN HỌC";
            this.barButtonItem_BDMH.Id = 9;
            this.barButtonItem_BDMH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_BDMH.ImageOptions.SvgImage")));
            this.barButtonItem_BDMH.LargeWidth = 100;
            this.barButtonItem_BDMH.Name = "barButtonItem_BDMH";
            this.barButtonItem_BDMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_BDMH_ItemClick);
            // 
            // barButtonItem_PD
            // 
            this.barButtonItem_PD.Caption = "PHIẾU ĐIỂM";
            this.barButtonItem_PD.Id = 10;
            this.barButtonItem_PD.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_PD.ImageOptions.SvgImage")));
            this.barButtonItem_PD.LargeWidth = 100;
            this.barButtonItem_PD.Name = "barButtonItem_PD";
            this.barButtonItem_PD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_PD_ItemClick);
            // 
            // barButtonItem_DSHP
            // 
            this.barButtonItem_DSHP.Caption = "DANH SÁCH ĐÓNG HỌC PHÍ CỦA LỚP";
            this.barButtonItem_DSHP.Id = 11;
            this.barButtonItem_DSHP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_DSHP.ImageOptions.SvgImage")));
            this.barButtonItem_DSHP.LargeWidth = 100;
            this.barButtonItem_DSHP.Name = "barButtonItem_DSHP";
            this.barButtonItem_DSHP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_DSHP_ItemClick);
            // 
            // barButtonItem_BDTK
            // 
            this.barButtonItem_BDTK.Caption = "BẢNG ĐIỂM TỔNG KẾT";
            this.barButtonItem_BDTK.Id = 12;
            this.barButtonItem_BDTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_BDTK.ImageOptions.SvgImage")));
            this.barButtonItem_BDTK.LargeWidth = 100;
            this.barButtonItem_BDTK.Name = "barButtonItem_BDTK";
            this.barButtonItem_BDTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_BDTK_ItemClick);
            // 
            // barButtonItem_TaoTK
            // 
            this.barButtonItem_TaoTK.Caption = "TẠO TÀI KHOẢN";
            this.barButtonItem_TaoTK.Id = 13;
            this.barButtonItem_TaoTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_TaoTK.ImageOptions.SvgImage")));
            this.barButtonItem_TaoTK.LargeWidth = 75;
            this.barButtonItem_TaoTK.Name = "barButtonItem_TaoTK";
            this.barButtonItem_TaoTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_TaoTK_ItemClick);
            // 
            // barButtonItem_DangXuat
            // 
            this.barButtonItem_DangXuat.Caption = "ĐĂNG XUẤT";
            this.barButtonItem_DangXuat.Id = 14;
            this.barButtonItem_DangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_DangXuat.ImageOptions.SvgImage")));
            this.barButtonItem_DangXuat.LargeWidth = 75;
            this.barButtonItem_DangXuat.Name = "barButtonItem_DangXuat";
            this.barButtonItem_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPage1.ImageOptions.SvgImage")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "QUẢN TRỊ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem_Lop);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem_MonHoc);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem_SV);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem_Diem);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem_ChuyenLop);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem_HocPhi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "QUẢN LÍ DỮ LIỆU";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPage2.ImageOptions.SvgImage")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "BÁO CÁO";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem_DSSV);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem_BDT);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem_BDMH);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem_PD);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem_DSHP);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem_BDTK);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "DANH MỤC BÁO CÁO";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPage3.ImageOptions.SvgImage")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "CẤU HÌNH";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem_TaoTK);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem_DangXuat);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "HỆ THỐNG";
            // 
            // barButtonItem_SinhVien
            // 
            this.barButtonItem_SinhVien.Caption = "SINH VIÊN";
            this.barButtonItem_SinhVien.Id = 22;
            this.barButtonItem_SinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_SinhVien.ImageOptions.Image")));
            this.barButtonItem_SinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_SinhVien.ImageOptions.LargeImage")));
            this.barButtonItem_SinhVien.ItemAppearance.Normal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem_SinhVien.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem_SinhVien.LargeWidth = 75;
            this.barButtonItem_SinhVien.Name = "barButtonItem_SinhVien";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbMaGV,
            this.lbHoTen,
            this.lbNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1725, 25);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lbMaGV
            // 
            this.lbMaGV.Name = "lbMaGV";
            this.lbMaGV.Size = new System.Drawing.Size(51, 20);
            this.lbMaGV.Text = "MAGV";
            // 
            // lbHoTen
            // 
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(57, 20);
            this.lbHoTen.Text = "HOTEN";
            // 
            // lbNhom
            // 
            this.lbNhom.Name = "lbNhom";
            this.lbNhom.Size = new System.Drawing.Size(55, 20);
            this.lbNhom.Text = "NHOM";
            // 
            // FrmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1725, 491);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "QUẢN LÍ ĐIỂM SINH VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Lop;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_MonHoc;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_SV;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Diem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ChuyenLop;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_HocPhi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_SinhVien;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lbMaGV;
        public System.Windows.Forms.ToolStripStatusLabel lbHoTen;
        public System.Windows.Forms.ToolStripStatusLabel lbNhom;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_DSSV;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_BDT;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_BDMH;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_PD;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_DSHP;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_BDTK;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_TaoTK;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_DangXuat;
    }
}

