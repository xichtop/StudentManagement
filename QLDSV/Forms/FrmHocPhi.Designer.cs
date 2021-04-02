namespace QLDSV.Forms
{
    partial class FrmHocPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHocPhi));
            this.grcSV = new DevExpress.XtraEditors.GroupControl();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.lookUpEditSV = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsDSSV = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grcDongHP = new DevExpress.XtraEditors.GroupControl();
            this.txtHocPhi = new DevExpress.XtraEditors.TextEdit();
            this.bdsSPHocPhi = new System.Windows.Forms.BindingSource(this.components);
            this.txtSoTienDaDong = new DevExpress.XtraEditors.TextEdit();
            this.txtHocKi = new DevExpress.XtraEditors.TextEdit();
            this.txtNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.lbSoTienDong = new System.Windows.Forms.Label();
            this.txtSoTienDong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grcListHP = new DevExpress.XtraEditors.GroupControl();
            this.sP_HOCPHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_HOCPHITableAdapter = new QLDSV.DSTableAdapters.SP_HOCPHITableAdapter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sP_DSSVTableAdapter = new QLDSV.DSTableAdapters.SP_DSSVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grcSV)).BeginInit();
            this.grcSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDongHP)).BeginInit();
            this.grcDongHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocPhi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSPHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienDaDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcListHP)).BeginInit();
            this.grcListHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_HOCPHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grcSV
            // 
            this.grcSV.Controls.Add(this.txtMaLop);
            this.grcSV.Controls.Add(this.txtTenSV);
            this.grcSV.Controls.Add(this.lookUpEditSV);
            this.grcSV.Controls.Add(this.label3);
            this.grcSV.Controls.Add(this.label2);
            this.grcSV.Controls.Add(this.label1);
            this.grcSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.grcSV.Location = new System.Drawing.Point(0, 30);
            this.grcSV.Name = "grcSV";
            this.grcSV.Size = new System.Drawing.Size(1423, 100);
            this.grcSV.TabIndex = 0;
            this.grcSV.Text = "Thông Tin Sinh Viên";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(1166, 51);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(126, 23);
            this.txtMaLop.TabIndex = 5;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(759, 51);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.ReadOnly = true;
            this.txtTenSV.Size = new System.Drawing.Size(274, 23);
            this.txtTenSV.TabIndex = 4;
            // 
            // lookUpEditSV
            // 
            this.lookUpEditSV.Location = new System.Drawing.Point(122, 51);
            this.lookUpEditSV.Name = "lookUpEditSV";
            this.lookUpEditSV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditSV.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MASV", "Mã Sinh Viên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HOTEN", "Họ Tên", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MALOP", "Mã Lớp", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEditSV.Properties.DataSource = this.bdsDSSV;
            this.lookUpEditSV.Properties.DisplayMember = "MASV";
            this.lookUpEditSV.Properties.NullText = "Chọn mã sinh viên ...";
            this.lookUpEditSV.Properties.ValueMember = "MASV";
            this.lookUpEditSV.Size = new System.Drawing.Size(488, 22);
            this.lookUpEditSV.TabIndex = 3;
            this.lookUpEditSV.EditValueChanged += new System.EventHandler(this.lookUpEditSV_EditValueChanged);
            // 
            // bdsDSSV
            // 
            this.bdsDSSV.DataMember = "SP_DSSV";
            this.bdsDSSV.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1103, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(649, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sinh Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên:";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.DSGVTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.btnGhi,
            this.btnThoat,
            this.btnThem,
            this.btnHuy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 2;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 0;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 3;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 1;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1423, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 542);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1423, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 512);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1423, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 512);
            // 
            // grcDongHP
            // 
            this.grcDongHP.Controls.Add(this.txtHocPhi);
            this.grcDongHP.Controls.Add(this.txtSoTienDaDong);
            this.grcDongHP.Controls.Add(this.txtHocKi);
            this.grcDongHP.Controls.Add(this.txtNienKhoa);
            this.grcDongHP.Controls.Add(this.lbSoTienDong);
            this.grcDongHP.Controls.Add(this.txtSoTienDong);
            this.grcDongHP.Controls.Add(this.label7);
            this.grcDongHP.Controls.Add(this.label6);
            this.grcDongHP.Controls.Add(this.label5);
            this.grcDongHP.Controls.Add(this.label4);
            this.grcDongHP.Dock = System.Windows.Forms.DockStyle.Top;
            this.grcDongHP.Location = new System.Drawing.Point(0, 130);
            this.grcDongHP.Name = "grcDongHP";
            this.grcDongHP.Size = new System.Drawing.Size(1423, 153);
            this.grcDongHP.TabIndex = 5;
            this.grcDongHP.Text = "Thông Tin Đóng Học Phí";
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSPHocPhi, "HOCPHI", true));
            this.txtHocPhi.Location = new System.Drawing.Point(131, 99);
            this.txtHocPhi.MenuManager = this.barManager1;
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Properties.ReadOnly = true;
            this.txtHocPhi.Size = new System.Drawing.Size(220, 22);
            this.txtHocPhi.TabIndex = 16;
            // 
            // bdsSPHocPhi
            // 
            this.bdsSPHocPhi.DataMember = "SP_HOCPHI";
            this.bdsSPHocPhi.DataSource = this.dS;
            // 
            // txtSoTienDaDong
            // 
            this.txtSoTienDaDong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSPHocPhi, "SOTIENDADONG", true));
            this.txtSoTienDaDong.Location = new System.Drawing.Point(578, 102);
            this.txtSoTienDaDong.MenuManager = this.barManager1;
            this.txtSoTienDaDong.Name = "txtSoTienDaDong";
            this.txtSoTienDaDong.Properties.ReadOnly = true;
            this.txtSoTienDaDong.Size = new System.Drawing.Size(211, 22);
            this.txtSoTienDaDong.TabIndex = 15;
            // 
            // txtHocKi
            // 
            this.txtHocKi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSPHocPhi, "HOCKY", true));
            this.txtHocKi.Location = new System.Drawing.Point(578, 48);
            this.txtHocKi.MenuManager = this.barManager1;
            this.txtHocKi.Name = "txtHocKi";
            this.txtHocKi.Properties.ReadOnly = true;
            this.txtHocKi.Size = new System.Drawing.Size(211, 22);
            this.txtHocKi.TabIndex = 14;
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSPHocPhi, "NIENKHOA", true));
            this.txtNienKhoa.Location = new System.Drawing.Point(131, 48);
            this.txtNienKhoa.MenuManager = this.barManager1;
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Properties.ReadOnly = true;
            this.txtNienKhoa.Size = new System.Drawing.Size(220, 22);
            this.txtNienKhoa.TabIndex = 10;
            // 
            // lbSoTienDong
            // 
            this.lbSoTienDong.AutoSize = true;
            this.lbSoTienDong.Location = new System.Drawing.Point(857, 79);
            this.lbSoTienDong.Name = "lbSoTienDong";
            this.lbSoTienDong.Size = new System.Drawing.Size(96, 17);
            this.lbSoTienDong.TabIndex = 9;
            this.lbSoTienDong.Text = "Số Tiền Đóng:";
            // 
            // txtSoTienDong
            // 
            this.txtSoTienDong.Location = new System.Drawing.Point(974, 76);
            this.txtSoTienDong.Name = "txtSoTienDong";
            this.txtSoTienDong.Size = new System.Drawing.Size(207, 23);
            this.txtSoTienDong.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số Tiền Đã Đóng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Học Kì:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Học Phí:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Niên Khóa:";
            // 
            // grcListHP
            // 
            this.grcListHP.Controls.Add(this.sP_HOCPHIGridControl);
            this.grcListHP.Dock = System.Windows.Forms.DockStyle.Top;
            this.grcListHP.Location = new System.Drawing.Point(0, 283);
            this.grcListHP.Name = "grcListHP";
            this.grcListHP.Size = new System.Drawing.Size(1423, 335);
            this.grcListHP.TabIndex = 6;
            this.grcListHP.Text = "Thông Tin Đóng Học Phí Của Sinh Viên";
            // 
            // sP_HOCPHIGridControl
            // 
            this.sP_HOCPHIGridControl.DataSource = this.bdsSPHocPhi;
            this.sP_HOCPHIGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_HOCPHIGridControl.Location = new System.Drawing.Point(2, 28);
            this.sP_HOCPHIGridControl.MainView = this.gridView1;
            this.sP_HOCPHIGridControl.MenuManager = this.barManager1;
            this.sP_HOCPHIGridControl.Name = "sP_HOCPHIGridControl";
            this.sP_HOCPHIGridControl.Size = new System.Drawing.Size(1419, 220);
            this.sP_HOCPHIGridControl.TabIndex = 0;
            this.sP_HOCPHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colSOTIENDADONG});
            this.gridView1.GridControl = this.sP_HOCPHIGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colNIENKHOA.AppearanceHeader.Options.UseBackColor = true;
            this.colNIENKHOA.Caption = "Niên Khóa";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 25;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            this.colNIENKHOA.Width = 94;
            // 
            // colHOCKY
            // 
            this.colHOCKY.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colHOCKY.AppearanceHeader.Options.UseBackColor = true;
            this.colHOCKY.Caption = "Học Kì";
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 25;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            this.colHOCKY.Width = 94;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colHOCPHI.AppearanceHeader.Options.UseBackColor = true;
            this.colHOCPHI.Caption = "Học Phí";
            this.colHOCPHI.DisplayFormat.FormatString = "###,###,### đ";
            this.colHOCPHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 25;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            this.colHOCPHI.Width = 94;
            // 
            // colSOTIENDADONG
            // 
            this.colSOTIENDADONG.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colSOTIENDADONG.AppearanceHeader.Options.UseBackColor = true;
            this.colSOTIENDADONG.Caption = "Số Tiền Đã Đóng";
            this.colSOTIENDADONG.DisplayFormat.FormatString = "###,###,### đ";
            this.colSOTIENDADONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSOTIENDADONG.FieldName = "SOTIENDADONG";
            this.colSOTIENDADONG.MinWidth = 25;
            this.colSOTIENDADONG.Name = "colSOTIENDADONG";
            this.colSOTIENDADONG.Visible = true;
            this.colSOTIENDADONG.VisibleIndex = 3;
            this.colSOTIENDADONG.Width = 94;
            // 
            // sP_HOCPHITableAdapter
            // 
            this.sP_HOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // sP_DSSVTableAdapter
            // 
            this.sP_DSSVTableAdapter.ClearBeforeFill = true;
            // 
            // FrmHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 562);
            this.Controls.Add(this.grcListHP);
            this.Controls.Add(this.grcDongHP);
            this.Controls.Add(this.grcSV);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHocPhi";
            this.Text = "FrmHocPhi";
            this.Load += new System.EventHandler(this.FrmHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcSV)).EndInit();
            this.grcSV.ResumeLayout(false);
            this.grcSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDongHP)).EndInit();
            this.grcDongHP.ResumeLayout(false);
            this.grcDongHP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocPhi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSPHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienDaDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcListHP)).EndInit();
            this.grcListHP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_HOCPHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grcSV;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenSV;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl grcListHP;
        private DevExpress.XtraEditors.GroupControl grcDongHP;
        private System.Windows.Forms.Label lbSoTienDong;
        private System.Windows.Forms.TextBox txtSoTienDong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bdsSPHocPhi;
        private DSTableAdapters.SP_HOCPHITableAdapter sP_HOCPHITableAdapter;
        private DevExpress.XtraGrid.GridControl sP_HOCPHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDADONG;
        private DevExpress.XtraEditors.TextEdit txtNienKhoa;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevExpress.XtraEditors.TextEdit txtHocPhi;
        private DevExpress.XtraEditors.TextEdit txtSoTienDaDong;
        private DevExpress.XtraEditors.TextEdit txtHocKi;
        private System.Windows.Forms.BindingSource bdsDSSV;
        private DSTableAdapters.SP_DSSVTableAdapter sP_DSSVTableAdapter;
    }
}