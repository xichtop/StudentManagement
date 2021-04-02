namespace QLDSV.Forms
{
    partial class FrmDiem
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
            this.grpCNhapDiem = new DevExpress.XtraEditors.GroupControl();
            this.txtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.numericLanThi = new System.Windows.Forms.NumericUpDown();
            this.lookUpEditMonHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.lookUpEditLop = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.cbbTenKhoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTenKhoa = new System.Windows.Forms.Label();
            this.grpCButton = new DevExpress.XtraEditors.GroupControl();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.grCBangDiem = new DevExpress.XtraEditors.GroupControl();
            this.gridControlDiem = new DevExpress.XtraGrid.GridControl();
            this.gridViewDiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sP_DSSV_MHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DSSV_MHTableAdapter = new QLDSV.DSTableAdapters.SP_DSSV_MHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grpCNhapDiem)).BeginInit();
            this.grpCNhapDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLanThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCButton)).BeginInit();
            this.grpCButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCBangDiem)).BeginInit();
            this.grCBangDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSSV_MHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCNhapDiem
            // 
            this.grpCNhapDiem.Controls.Add(this.txtMaMH);
            this.grpCNhapDiem.Controls.Add(this.txtMaLop);
            this.grpCNhapDiem.Controls.Add(this.numericLanThi);
            this.grpCNhapDiem.Controls.Add(this.lookUpEditMonHoc);
            this.grpCNhapDiem.Controls.Add(this.lookUpEditLop);
            this.grpCNhapDiem.Controls.Add(this.cbbTenKhoa);
            this.grpCNhapDiem.Controls.Add(this.label6);
            this.grpCNhapDiem.Controls.Add(this.label5);
            this.grpCNhapDiem.Controls.Add(this.label4);
            this.grpCNhapDiem.Controls.Add(this.label3);
            this.grpCNhapDiem.Controls.Add(this.label2);
            this.grpCNhapDiem.Controls.Add(this.lbTenKhoa);
            this.grpCNhapDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCNhapDiem.Location = new System.Drawing.Point(0, 0);
            this.grpCNhapDiem.Name = "grpCNhapDiem";
            this.grpCNhapDiem.Size = new System.Drawing.Size(1058, 174);
            this.grpCNhapDiem.TabIndex = 0;
            this.grpCNhapDiem.Text = "Thông Tin";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(569, 105);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Properties.ReadOnly = true;
            this.txtMaMH.Size = new System.Drawing.Size(151, 22);
            this.txtMaMH.TabIndex = 11;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(569, 72);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(151, 22);
            this.txtMaLop.TabIndex = 10;
            this.txtMaLop.EditValueChanged += new System.EventHandler(this.txtMaLop_EditValueChanged);
            // 
            // numericLanThi
            // 
            this.numericLanThi.Location = new System.Drawing.Point(147, 140);
            this.numericLanThi.Name = "numericLanThi";
            this.numericLanThi.Size = new System.Drawing.Size(54, 23);
            this.numericLanThi.TabIndex = 9;
            this.numericLanThi.ValueChanged += new System.EventHandler(this.numericLanThi_ValueChanged);
            // 
            // lookUpEditMonHoc
            // 
            this.lookUpEditMonHoc.Location = new System.Drawing.Point(147, 105);
            this.lookUpEditMonHoc.Name = "lookUpEditMonHoc";
            this.lookUpEditMonHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditMonHoc.Properties.DataSource = this.bdsMonHoc;
            this.lookUpEditMonHoc.Properties.DisplayMember = "TENMH";
            this.lookUpEditMonHoc.Properties.NullText = "Chọn Môn Học ...";
            this.lookUpEditMonHoc.Properties.ValueMember = "MAMH";
            this.lookUpEditMonHoc.Size = new System.Drawing.Size(304, 22);
            this.lookUpEditMonHoc.TabIndex = 8;
            this.lookUpEditMonHoc.EditValueChanged += new System.EventHandler(this.lookUpEditMonHoc_EditValueChanged);
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lookUpEditLop
            // 
            this.lookUpEditLop.Location = new System.Drawing.Point(147, 72);
            this.lookUpEditLop.Name = "lookUpEditLop";
            this.lookUpEditLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditLop.Properties.DataSource = this.bdsLop;
            this.lookUpEditLop.Properties.DisplayMember = "TENLOP";
            this.lookUpEditLop.Properties.NullText = "Chọn Lớp ...";
            this.lookUpEditLop.Properties.ValueMember = "MALOP";
            this.lookUpEditLop.Size = new System.Drawing.Size(304, 22);
            this.lookUpEditLop.TabIndex = 7;
            this.lookUpEditLop.EditValueChanged += new System.EventHandler(this.lookUpEditLop_EditValueChanged);
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.dS;
            // 
            // cbbTenKhoa
            // 
            this.cbbTenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenKhoa.FormattingEnabled = true;
            this.cbbTenKhoa.Location = new System.Drawing.Point(147, 36);
            this.cbbTenKhoa.Name = "cbbTenKhoa";
            this.cbbTenKhoa.Size = new System.Drawing.Size(300, 24);
            this.cbbTenKhoa.TabIndex = 6;
            this.cbbTenKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã Môn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lần Thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Môn Học: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Lớp: ";
            // 
            // lbTenKhoa
            // 
            this.lbTenKhoa.AutoSize = true;
            this.lbTenKhoa.Location = new System.Drawing.Point(57, 36);
            this.lbTenKhoa.Name = "lbTenKhoa";
            this.lbTenKhoa.Size = new System.Drawing.Size(44, 17);
            this.lbTenKhoa.TabIndex = 0;
            this.lbTenKhoa.Text = "Khoa:";
            // 
            // grpCButton
            // 
            this.grpCButton.Controls.Add(this.btnThoat);
            this.grpCButton.Controls.Add(this.btnCancel);
            this.grpCButton.Controls.Add(this.btnUpdate);
            this.grpCButton.Controls.Add(this.btnStart);
            this.grpCButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCButton.Location = new System.Drawing.Point(0, 174);
            this.grpCButton.Name = "grpCButton";
            this.grpCButton.Size = new System.Drawing.Size(1058, 94);
            this.grpCButton.TabIndex = 1;
            this.grpCButton.Text = "Điều Khiển";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(386, 44);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 31);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(266, 44);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 31);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(158, 44);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 31);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(50, 44);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 31);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Bắt Đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.DSGVTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // grCBangDiem
            // 
            this.grCBangDiem.Controls.Add(this.gridControlDiem);
            this.grCBangDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.grCBangDiem.Location = new System.Drawing.Point(0, 268);
            this.grCBangDiem.Name = "grCBangDiem";
            this.grCBangDiem.Size = new System.Drawing.Size(1058, 235);
            this.grCBangDiem.TabIndex = 4;
            this.grCBangDiem.Text = "BẢNG ĐIỂM MÔN HỌC";
            this.grCBangDiem.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // gridControlDiem
            // 
            this.gridControlDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDiem.Location = new System.Drawing.Point(2, 28);
            this.gridControlDiem.MainView = this.gridViewDiem;
            this.gridControlDiem.Name = "gridControlDiem";
            this.gridControlDiem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControlDiem.Size = new System.Drawing.Size(1054, 205);
            this.gridControlDiem.TabIndex = 0;
            this.gridControlDiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDiem,
            this.gridView1});
            // 
            // gridViewDiem
            // 
            this.gridViewDiem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.HoTen,
            this.MASV,
            this.DIEM});
            this.gridViewDiem.GridControl = this.gridControlDiem;
            this.gridViewDiem.Name = "gridViewDiem";
            this.gridViewDiem.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDiem.OptionsView.ShowGroupPanel = false;
            this.gridViewDiem.OptionsView.ShowViewCaption = true;
            this.gridViewDiem.ViewCaption = "BẢNG ĐIỂM MÔN HỌC";
            this.gridViewDiem.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewDiem_CustomDrawRowIndicator);
            this.gridViewDiem.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewnNhap_RowCellStyle);
            this.gridViewDiem.HiddenEditor += new System.EventHandler(this.gridViewnNhap_HiddenEditor);
            this.gridViewDiem.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewnNhap_ValidatingEditor);
            // 
            // HoTen
            // 
            this.HoTen.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.HoTen.AppearanceHeader.Options.UseBackColor = true;
            this.HoTen.Caption = "Họ Tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.MinWidth = 25;
            this.HoTen.Name = "HoTen";
            this.HoTen.OptionsColumn.ReadOnly = true;
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 0;
            this.HoTen.Width = 94;
            // 
            // MASV
            // 
            this.MASV.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.MASV.AppearanceHeader.Options.UseBackColor = true;
            this.MASV.Caption = "Mã Sinh Viên";
            this.MASV.FieldName = "MASV";
            this.MASV.MinWidth = 25;
            this.MASV.Name = "MASV";
            this.MASV.OptionsColumn.ReadOnly = true;
            this.MASV.Visible = true;
            this.MASV.VisibleIndex = 1;
            this.MASV.Width = 94;
            // 
            // DIEM
            // 
            this.DIEM.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.DIEM.AppearanceHeader.Options.UseBackColor = true;
            this.DIEM.Caption = "Điểm";
            this.DIEM.ColumnEdit = this.repositoryItemTextEdit1;
            this.DIEM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DIEM.FieldName = "DIEM";
            this.DIEM.MinWidth = 25;
            this.DIEM.Name = "DIEM";
            this.DIEM.Visible = true;
            this.DIEM.VisibleIndex = 2;
            this.DIEM.Width = 94;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlDiem;
            this.gridView1.Name = "gridView1";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // sP_DSSV_MHBindingSource
            // 
            this.sP_DSSV_MHBindingSource.DataMember = "SP_DSSV_MH";
            this.sP_DSSV_MHBindingSource.DataSource = this.dS;
            // 
            // sP_DSSV_MHTableAdapter
            // 
            this.sP_DSSV_MHTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 515);
            this.Controls.Add(this.grCBangDiem);
            this.Controls.Add(this.grpCButton);
            this.Controls.Add(this.grpCNhapDiem);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDiem";
            this.Text = "Quản Lí Điểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpCNhapDiem)).EndInit();
            this.grpCNhapDiem.ResumeLayout(false);
            this.grpCNhapDiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLanThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCButton)).EndInit();
            this.grpCButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCBangDiem)).EndInit();
            this.grCBangDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSSV_MHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpCNhapDiem;
        private DevExpress.XtraEditors.GroupControl grpCButton;
        private DevExpress.XtraEditors.TextEdit txtMaMH;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private System.Windows.Forms.NumericUpDown numericLanThi;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditMonHoc;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditLop;
        private System.Windows.Forms.ComboBox cbbTenKhoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTenKhoa;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DevExpress.XtraEditors.GroupControl grCBangDiem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.BindingSource sP_DSSV_MHBindingSource;
        private DSTableAdapters.SP_DSSV_MHTableAdapter sP_DSSV_MHTableAdapter;
        private System.Windows.Forms.Button btnThoat;
        private DevExpress.XtraGrid.GridControl gridControlDiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDiem;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn MASV;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}