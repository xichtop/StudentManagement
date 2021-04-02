namespace QLDSV.Forms
{
    partial class FrmSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinhVien));
            this.mASVLabel = new System.Windows.Forms.Label();
            this.hOLabel = new System.Windows.Forms.Label();
            this.tENLabel = new System.Windows.Forms.Label();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.pHAILabel = new System.Windows.Forms.Label();
            this.nGAYSINHLabel = new System.Windows.Forms.Label();
            this.nOISINHLabel = new System.Windows.Forms.Label();
            this.dIACHILabel = new System.Windows.Forms.Label();
            this.gHICHULabel = new System.Windows.Forms.Label();
            this.nGHIHOCLabel = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSua = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbTenKhoa = new System.Windows.Forms.ComboBox();
            this.lbKhoa = new System.Windows.Forms.Label();
            this.grpLop = new DevExpress.XtraEditors.GroupControl();
            this.lOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpSV = new DevExpress.XtraEditors.GroupControl();
            this.sINHVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOISINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnNhapSV = new System.Windows.Forms.Panel();
            this.checkNghiHoc = new DevExpress.XtraEditors.CheckEdit();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtNoiSinh = new DevExpress.XtraEditors.TextEdit();
            this.dateNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.checkPhai = new DevExpress.XtraEditors.CheckEdit();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.dIEMTableAdapter = new QLDSV.DSTableAdapters.DIEMTableAdapter();
            this.sINHVIENTableAdapter = new QLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.bdsDiem = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpLop)).BeginInit();
            this.grpLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSV)).BeginInit();
            this.grpSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.pnNhapSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkNghiHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiSinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPhai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDiem)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            this.mASVLabel.AutoSize = true;
            this.mASVLabel.Location = new System.Drawing.Point(7, 41);
            this.mASVLabel.Name = "mASVLabel";
            this.mASVLabel.Size = new System.Drawing.Size(71, 21);
            this.mASVLabel.TabIndex = 0;
            this.mASVLabel.Text = "Mã SV: ";
            // 
            // hOLabel
            // 
            this.hOLabel.AutoSize = true;
            this.hOLabel.Location = new System.Drawing.Point(7, 72);
            this.hOLabel.Name = "hOLabel";
            this.hOLabel.Size = new System.Drawing.Size(42, 21);
            this.hOLabel.TabIndex = 2;
            this.hOLabel.Text = "Họ: ";
            // 
            // tENLabel
            // 
            this.tENLabel.AutoSize = true;
            this.tENLabel.Location = new System.Drawing.Point(7, 105);
            this.tENLabel.Name = "tENLabel";
            this.tENLabel.Size = new System.Drawing.Size(48, 21);
            this.tENLabel.TabIndex = 4;
            this.tENLabel.Text = "Tên: ";
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Location = new System.Drawing.Point(290, 40);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(74, 21);
            this.lbMaLop.TabIndex = 6;
            this.lbMaLop.Text = "Mã Lớp:";
            this.lbMaLop.Click += new System.EventHandler(this.mALOPLabel_Click);
            // 
            // pHAILabel
            // 
            this.pHAILabel.AutoSize = true;
            this.pHAILabel.Location = new System.Drawing.Point(290, 105);
            this.pHAILabel.Name = "pHAILabel";
            this.pHAILabel.Size = new System.Drawing.Size(46, 21);
            this.pHAILabel.TabIndex = 8;
            this.pHAILabel.Text = "Phái:";
            // 
            // nGAYSINHLabel
            // 
            this.nGAYSINHLabel.AutoSize = true;
            this.nGAYSINHLabel.Location = new System.Drawing.Point(290, 73);
            this.nGAYSINHLabel.Name = "nGAYSINHLabel";
            this.nGAYSINHLabel.Size = new System.Drawing.Size(91, 21);
            this.nGAYSINHLabel.TabIndex = 10;
            this.nGAYSINHLabel.Text = "Ngày Sinh:";
            this.nGAYSINHLabel.Click += new System.EventHandler(this.nGAYSINHLabel_Click);
            // 
            // nOISINHLabel
            // 
            this.nOISINHLabel.AutoSize = true;
            this.nOISINHLabel.Location = new System.Drawing.Point(7, 138);
            this.nOISINHLabel.Name = "nOISINHLabel";
            this.nOISINHLabel.Size = new System.Drawing.Size(79, 21);
            this.nOISINHLabel.TabIndex = 12;
            this.nOISINHLabel.Text = "Nơi Sinh:";
            this.nOISINHLabel.Click += new System.EventHandler(this.nOISINHLabel_Click);
            // 
            // dIACHILabel
            // 
            this.dIACHILabel.AutoSize = true;
            this.dIACHILabel.Location = new System.Drawing.Point(7, 178);
            this.dIACHILabel.Name = "dIACHILabel";
            this.dIACHILabel.Size = new System.Drawing.Size(73, 21);
            this.dIACHILabel.TabIndex = 14;
            this.dIACHILabel.Text = "Địa Chỉ:";
            this.dIACHILabel.Click += new System.EventHandler(this.dIACHILabel_Click);
            // 
            // gHICHULabel
            // 
            this.gHICHULabel.AutoSize = true;
            this.gHICHULabel.Location = new System.Drawing.Point(7, 211);
            this.gHICHULabel.Name = "gHICHULabel";
            this.gHICHULabel.Size = new System.Drawing.Size(77, 21);
            this.gHICHULabel.TabIndex = 16;
            this.gHICHULabel.Text = "Ghi Chú:";
            // 
            // nGHIHOCLabel
            // 
            this.nGHIHOCLabel.AutoSize = true;
            this.nGHIHOCLabel.Location = new System.Drawing.Point(420, 105);
            this.nGHIHOCLabel.Name = "nGHIHOCLabel";
            this.nGHIHOCLabel.Size = new System.Drawing.Size(88, 21);
            this.nGHIHOCLabel.TabIndex = 18;
            this.nGHIHOCLabel.Text = "Nghỉ Học:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnThem,
            this.barBtnXoa,
            this.barBtnSua,
            this.barBtnUndo,
            this.barBtnGhi,
            this.barBtnHuy,
            this.barBtnLamMoi,
            this.barBtnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barBtnThem
            // 
            this.barBtnThem.Caption = "Thêm";
            this.barBtnThem.Id = 0;
            this.barBtnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnThem.ImageOptions.SvgImage")));
            this.barBtnThem.Name = "barBtnThem";
            this.barBtnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThem_ItemClick);
            // 
            // barBtnXoa
            // 
            this.barBtnXoa.Caption = "Xóa";
            this.barBtnXoa.Id = 1;
            this.barBtnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnXoa.ImageOptions.SvgImage")));
            this.barBtnXoa.Name = "barBtnXoa";
            this.barBtnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnXoa_ItemClick);
            // 
            // barBtnSua
            // 
            this.barBtnSua.Caption = "Sửa";
            this.barBtnSua.Id = 2;
            this.barBtnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSua.ImageOptions.Image")));
            this.barBtnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSua.ImageOptions.LargeImage")));
            this.barBtnSua.Name = "barBtnSua";
            this.barBtnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSua_ItemClick);
            // 
            // barBtnUndo
            // 
            this.barBtnUndo.Caption = "Phục Hồi";
            this.barBtnUndo.Id = 3;
            this.barBtnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnUndo.ImageOptions.SvgImage")));
            this.barBtnUndo.Name = "barBtnUndo";
            // 
            // barBtnGhi
            // 
            this.barBtnGhi.Caption = "Ghi";
            this.barBtnGhi.Id = 4;
            this.barBtnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnGhi.ImageOptions.SvgImage")));
            this.barBtnGhi.Name = "barBtnGhi";
            this.barBtnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGhi_ItemClick);
            // 
            // barBtnHuy
            // 
            this.barBtnHuy.Caption = "Hủy";
            this.barBtnHuy.Id = 5;
            this.barBtnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnHuy.ImageOptions.SvgImage")));
            this.barBtnHuy.Name = "barBtnHuy";
            this.barBtnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnHuy_ItemClick);
            // 
            // barBtnLamMoi
            // 
            this.barBtnLamMoi.Caption = "Làm Mới";
            this.barBtnLamMoi.Id = 6;
            this.barBtnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnLamMoi.ImageOptions.SvgImage")));
            this.barBtnLamMoi.Name = "barBtnLamMoi";
            this.barBtnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLamMoi_ItemClick);
            // 
            // barBtnThoat
            // 
            this.barBtnThoat.Caption = "Thoát";
            this.barBtnThoat.Id = 7;
            this.barBtnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnThoat.ImageOptions.SvgImage")));
            this.barBtnThoat.Name = "barBtnThoat";
            this.barBtnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1455, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 611);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1455, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 581);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1455, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 581);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbTenKhoa);
            this.panel1.Controls.Add(this.lbKhoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 44);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbbTenKhoa
            // 
            this.cbbTenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenKhoa.FormattingEnabled = true;
            this.cbbTenKhoa.Location = new System.Drawing.Point(471, 8);
            this.cbbTenKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTenKhoa.Name = "cbbTenKhoa";
            this.cbbTenKhoa.Size = new System.Drawing.Size(356, 28);
            this.cbbTenKhoa.TabIndex = 1;
            this.cbbTenKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbTenKhoa_SelectedIndexChanged);
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.lbKhoa.Location = new System.Drawing.Point(368, 13);
            this.lbKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(72, 21);
            this.lbKhoa.TabIndex = 0;
            this.lbKhoa.Text = "KHOA: ";
            this.lbKhoa.Click += new System.EventHandler(this.lbKhoa_Click);
            // 
            // grpLop
            // 
            this.grpLop.Controls.Add(this.lOPGridControl);
            this.grpLop.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpLop.Location = new System.Drawing.Point(0, 0);
            this.grpLop.Name = "grpLop";
            this.grpLop.Size = new System.Drawing.Size(920, 247);
            this.grpLop.TabIndex = 9;
            this.grpLop.Text = "DANH SÁCH LỚP";
            // 
            // lOPGridControl
            // 
            this.lOPGridControl.DataSource = this.bdsLop;
            this.lOPGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lOPGridControl.Location = new System.Drawing.Point(2, 28);
            this.lOPGridControl.MainView = this.gridView1;
            this.lOPGridControl.MenuManager = this.barManager1;
            this.lOPGridControl.Name = "lOPGridControl";
            this.lOPGridControl.Size = new System.Drawing.Size(916, 217);
            this.lOPGridControl.TabIndex = 0;
            this.lOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP});
            this.gridView1.GridControl = this.lOPGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator_1);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle_1);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged_1);
            // 
            // colMALOP
            // 
            this.colMALOP.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colMALOP.AppearanceHeader.Options.UseBackColor = true;
            this.colMALOP.Caption = "Mã Lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.FieldNameSortGroup = "Mã Lớp";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.ReadOnly = true;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 94;
            // 
            // colTENLOP
            // 
            this.colTENLOP.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colTENLOP.AppearanceHeader.Options.UseBackColor = true;
            this.colTENLOP.Caption = "Tên Lớp";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.FieldNameSortGroup = "Tên Lớp";
            this.colTENLOP.MinWidth = 25;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.ReadOnly = true;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 94;
            // 
            // grpSV
            // 
            this.grpSV.Controls.Add(this.sINHVIENGridControl);
            this.grpSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpSV.Location = new System.Drawing.Point(0, 325);
            this.grpSV.Name = "grpSV";
            this.grpSV.Size = new System.Drawing.Size(1455, 286);
            this.grpSV.TabIndex = 10;
            this.grpSV.Text = "DANH SÁCH SINH VIÊN";
            this.grpSV.Paint += new System.Windows.Forms.PaintEventHandler(this.grpSV_Paint);
            // 
            // sINHVIENGridControl
            // 
            this.sINHVIENGridControl.DataSource = this.bdsSV;
            this.sINHVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sINHVIENGridControl.Location = new System.Drawing.Point(2, 28);
            this.sINHVIENGridControl.MainView = this.gridView2;
            this.sINHVIENGridControl.MenuManager = this.barManager1;
            this.sINHVIENGridControl.Name = "sINHVIENGridControl";
            this.sINHVIENGridControl.Size = new System.Drawing.Size(1451, 256);
            this.sINHVIENGridControl.TabIndex = 0;
            this.sINHVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSV.DataSource = this.bdsLop;
            this.bdsSV.CurrentChanged += new System.EventHandler(this.sINHVIENBindingSource_CurrentChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colNGAYSINH,
            this.colNOISINH,
            this.colDIACHI,
            this.colGHICHU,
            this.colNGHIHOC});
            this.gridView2.GridControl = this.sINHVIENGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator_1);
            this.gridView2.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle_1);
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged_1);
            // 
            // colMASV
            // 
            this.colMASV.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colMASV.AppearanceHeader.Options.UseBackColor = true;
            this.colMASV.Caption = "Mã Sinh Viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.ReadOnly = true;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colHO.AppearanceHeader.Options.UseBackColor = true;
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.ReadOnly = true;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colTEN.AppearanceHeader.Options.UseBackColor = true;
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.ReadOnly = true;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colPHAI
            // 
            this.colPHAI.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colPHAI.AppearanceHeader.Options.UseBackColor = true;
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.OptionsColumn.ReadOnly = true;
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            this.colPHAI.Width = 94;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colNGAYSINH.AppearanceHeader.Options.UseBackColor = true;
            this.colNGAYSINH.Caption = "Ngày Sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.ReadOnly = true;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            this.colNGAYSINH.Width = 94;
            // 
            // colNOISINH
            // 
            this.colNOISINH.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colNOISINH.AppearanceHeader.Options.UseBackColor = true;
            this.colNOISINH.Caption = "Nơi Sinh";
            this.colNOISINH.FieldName = "NOISINH";
            this.colNOISINH.MinWidth = 25;
            this.colNOISINH.Name = "colNOISINH";
            this.colNOISINH.OptionsColumn.ReadOnly = true;
            this.colNOISINH.Visible = true;
            this.colNOISINH.VisibleIndex = 5;
            this.colNOISINH.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colDIACHI.AppearanceHeader.Options.UseBackColor = true;
            this.colDIACHI.Caption = "Địa Chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.ReadOnly = true;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 6;
            this.colDIACHI.Width = 94;
            // 
            // colGHICHU
            // 
            this.colGHICHU.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colGHICHU.AppearanceHeader.Options.UseBackColor = true;
            this.colGHICHU.Caption = "Ghi Chú";
            this.colGHICHU.FieldName = "GHICHU";
            this.colGHICHU.MinWidth = 25;
            this.colGHICHU.Name = "colGHICHU";
            this.colGHICHU.OptionsColumn.ReadOnly = true;
            this.colGHICHU.Visible = true;
            this.colGHICHU.VisibleIndex = 7;
            this.colGHICHU.Width = 94;
            // 
            // colNGHIHOC
            // 
            this.colNGHIHOC.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colNGHIHOC.AppearanceHeader.Options.UseBackColor = true;
            this.colNGHIHOC.Caption = "Nghỉ Học";
            this.colNGHIHOC.FieldName = "NGHIHOC";
            this.colNGHIHOC.MinWidth = 25;
            this.colNGHIHOC.Name = "colNGHIHOC";
            this.colNGHIHOC.OptionsColumn.ReadOnly = true;
            this.colNGHIHOC.Visible = true;
            this.colNGHIHOC.VisibleIndex = 8;
            this.colNGHIHOC.Width = 94;
            // 
            // pnNhapSV
            // 
            this.pnNhapSV.Controls.Add(this.checkNghiHoc);
            this.pnNhapSV.Controls.Add(this.txtGhiChu);
            this.pnNhapSV.Controls.Add(this.txtDiaChi);
            this.pnNhapSV.Controls.Add(this.txtNoiSinh);
            this.pnNhapSV.Controls.Add(this.dateNgaySinh);
            this.pnNhapSV.Controls.Add(this.checkPhai);
            this.pnNhapSV.Controls.Add(this.txtMaLop);
            this.pnNhapSV.Controls.Add(this.txtTen);
            this.pnNhapSV.Controls.Add(this.txtHo);
            this.pnNhapSV.Controls.Add(this.txtMaSV);
            this.pnNhapSV.Controls.Add(this.label1);
            this.pnNhapSV.Controls.Add(this.nGHIHOCLabel);
            this.pnNhapSV.Controls.Add(this.gHICHULabel);
            this.pnNhapSV.Controls.Add(this.dIACHILabel);
            this.pnNhapSV.Controls.Add(this.nOISINHLabel);
            this.pnNhapSV.Controls.Add(this.nGAYSINHLabel);
            this.pnNhapSV.Controls.Add(this.pHAILabel);
            this.pnNhapSV.Controls.Add(this.lbMaLop);
            this.pnNhapSV.Controls.Add(this.tENLabel);
            this.pnNhapSV.Controls.Add(this.hOLabel);
            this.pnNhapSV.Controls.Add(this.mASVLabel);
            this.pnNhapSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnNhapSV.Location = new System.Drawing.Point(920, 0);
            this.pnNhapSV.Name = "pnNhapSV";
            this.pnNhapSV.Size = new System.Drawing.Size(535, 247);
            this.pnNhapSV.TabIndex = 11;
            this.pnNhapSV.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // checkNghiHoc
            // 
            this.checkNghiHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "NGHIHOC", true));
            this.checkNghiHoc.Location = new System.Drawing.Point(508, 102);
            this.checkNghiHoc.MenuManager = this.barManager1;
            this.checkNghiHoc.Name = "checkNghiHoc";
            this.checkNghiHoc.Properties.Caption = "";
            this.checkNghiHoc.Size = new System.Drawing.Size(35, 24);
            this.checkNghiHoc.TabIndex = 30;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "GHICHU", true));
            this.txtGhiChu.Location = new System.Drawing.Point(84, 212);
            this.txtGhiChu.MenuManager = this.barManager1;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(442, 22);
            this.txtGhiChu.TabIndex = 29;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(85, 176);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(442, 22);
            this.txtDiaChi.TabIndex = 28;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "NOISINH", true));
            this.txtNoiSinh.Location = new System.Drawing.Point(84, 139);
            this.txtNoiSinh.MenuManager = this.barManager1;
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(442, 22);
            this.txtNoiSinh.TabIndex = 27;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "NGAYSINH", true));
            this.dateNgaySinh.EditValue = null;
            this.dateNgaySinh.Location = new System.Drawing.Point(387, 73);
            this.dateNgaySinh.MenuManager = this.barManager1;
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Size = new System.Drawing.Size(139, 22);
            this.dateNgaySinh.TabIndex = 26;
            // 
            // checkPhai
            // 
            this.checkPhai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "PHAI", true));
            this.checkPhai.Location = new System.Drawing.Point(342, 104);
            this.checkPhai.MenuManager = this.barManager1;
            this.checkPhai.Name = "checkPhai";
            this.checkPhai.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPhai.Properties.Appearance.Options.UseFont = true;
            this.checkPhai.Properties.Caption = "Nam";
            this.checkPhai.Size = new System.Drawing.Size(81, 24);
            this.checkPhai.TabIndex = 25;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "MALOP", true));
            this.txtMaLop.Location = new System.Drawing.Point(387, 40);
            this.txtMaLop.MenuManager = this.barManager1;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(140, 22);
            this.txtMaLop.TabIndex = 24;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(84, 103);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(195, 22);
            this.txtTen.TabIndex = 23;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(84, 73);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(195, 22);
            this.txtHo.TabIndex = 22;
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "MASV", true));
            this.txtMaSV.Location = new System.Drawing.Point(84, 41);
            this.txtMaSV.MenuManager = this.barManager1;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(195, 22);
            this.txtMaSV.TabIndex = 21;
            this.txtMaSV.EditValueChanged += new System.EventHandler(this.txtMaSV_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nhập Sinh Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = this.dIEMTableAdapter;
            this.tableAdapterManager.DSGVTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bdsDiem
            // 
            this.bdsDiem.DataMember = "FK_DIEM_SINHVIEN";
            this.bdsDiem.DataSource = this.bdsSV;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnNhapSV);
            this.panel2.Controls.Add(this.grpLop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1455, 247);
            this.panel2.TabIndex = 16;
            // 
            // FrmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1455, 631);
            this.Controls.Add(this.grpSV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSinhVien";
            this.Text = "FrmSinhVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpLop)).EndInit();
            this.grpLop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSV)).EndInit();
            this.grpSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.pnNhapSV.ResumeLayout(false);
            this.pnNhapSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkNghiHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiSinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPhai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDiem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnThem;
        private DevExpress.XtraBars.BarButtonItem barBtnXoa;
        private DevExpress.XtraBars.BarButtonItem barBtnSua;
        private DevExpress.XtraBars.BarButtonItem barBtnUndo;
        private DevExpress.XtraBars.BarButtonItem barBtnGhi;
        private DevExpress.XtraBars.BarButtonItem barBtnHuy;
        private DevExpress.XtraBars.BarButtonItem barBtnLamMoi;
        private DevExpress.XtraBars.BarButtonItem barBtnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbTenKhoa;
        private System.Windows.Forms.Label lbKhoa;
        private DevExpress.XtraEditors.GroupControl grpLop;
        private System.Windows.Forms.Panel pnNhapSV;
        private DevExpress.XtraEditors.GroupControl grpSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label mASVLabel;
        private System.Windows.Forms.Label hOLabel;
        private System.Windows.Forms.Label tENLabel;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Label pHAILabel;
        private System.Windows.Forms.Label nGAYSINHLabel;
        private System.Windows.Forms.Label nOISINHLabel;
        private System.Windows.Forms.Label dIACHILabel;
        private System.Windows.Forms.Label gHICHULabel;
        private System.Windows.Forms.Label nGHIHOCLabel;
        private System.Windows.Forms.BindingSource bdsLop;
        private DS dS;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsSV;
        private DevExpress.XtraGrid.GridControl sINHVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DSTableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private System.Windows.Forms.BindingSource bdsDiem;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colNOISINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGHIHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.XtraEditors.CheckEdit checkNghiHoc;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtNoiSinh;
        private DevExpress.XtraEditors.DateEdit dateNgaySinh;
        private DevExpress.XtraEditors.CheckEdit checkPhai;
        private System.Windows.Forms.Panel panel2;
    }
}