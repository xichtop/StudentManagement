namespace QLDSV.Forms
{
    partial class FrmChuyenLop
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
            this.dS = new QLDSV.DS();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.grCTimSV1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.lookUpEditSV = new DevExpress.XtraEditors.LookUpEdit();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grCTimSV = new DevExpress.XtraEditors.GroupControl();
            this.lbTenKhoa = new System.Windows.Forms.Label();
            this.cbbTenKhoa = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbSupport = new System.Windows.Forms.Label();
            this.txtMaSVMoi = new System.Windows.Forms.TextBox();
            this.txtMaLopMoi = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLDSV.DSTableAdapters.SINHVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCTimSV1)).BeginInit();
            this.grCTimSV1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCTimSV)).BeginInit();
            this.grCTimSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // grCTimSV1
            // 
            this.grCTimSV1.Controls.Add(this.lbTenKhoa);
            this.grCTimSV1.Controls.Add(this.cbbTenKhoa);
            this.grCTimSV1.Dock = System.Windows.Forms.DockStyle.Top;
            this.grCTimSV1.Location = new System.Drawing.Point(0, 0);
            this.grCTimSV1.Name = "grCTimSV1";
            this.grCTimSV1.Size = new System.Drawing.Size(1123, 101);
            this.grCTimSV1.TabIndex = 2;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(967, 53);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(146, 23);
            this.txtMaLop.TabIndex = 11;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(662, 53);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.ReadOnly = true;
            this.txtTenSV.Size = new System.Drawing.Size(236, 23);
            this.txtTenSV.TabIndex = 10;
            // 
            // lookUpEditSV
            // 
            this.lookUpEditSV.Location = new System.Drawing.Point(112, 53);
            this.lookUpEditSV.Name = "lookUpEditSV";
            this.lookUpEditSV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditSV.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MASV", "Mã Sinh Viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HO", "Họ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEN", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MALOP", "Mã Lớp")});
            this.lookUpEditSV.Properties.DataSource = this.bdsSV;
            this.lookUpEditSV.Properties.DisplayMember = "MASV";
            this.lookUpEditSV.Properties.NullText = "Tìm Sinh Viên ...";
            this.lookUpEditSV.Properties.ValueMember = "MASV";
            this.lookUpEditSV.Size = new System.Drawing.Size(427, 22);
            this.lookUpEditSV.TabIndex = 9;
            this.lookUpEditSV.EditValueChanged += new System.EventHandler(this.lookUpEditSV_EditValueChanged);
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Location = new System.Drawing.Point(904, 56);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(57, 17);
            this.lbMaLop.TabIndex = 8;
            this.lbMaLop.Text = "Mã Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Sinh Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm Sinh Viên:";
            // 
            // grCTimSV
            // 
            this.grCTimSV.Controls.Add(this.txtMaLop);
            this.grCTimSV.Controls.Add(this.label1);
            this.grCTimSV.Controls.Add(this.txtTenSV);
            this.grCTimSV.Controls.Add(this.label2);
            this.grCTimSV.Controls.Add(this.lookUpEditSV);
            this.grCTimSV.Controls.Add(this.lbMaLop);
            this.grCTimSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.grCTimSV.Location = new System.Drawing.Point(0, 101);
            this.grCTimSV.Name = "grCTimSV";
            this.grCTimSV.Size = new System.Drawing.Size(1123, 110);
            this.grCTimSV.TabIndex = 4;
            this.grCTimSV.Text = "Tìm Sinh Viên";
            // 
            // lbTenKhoa
            // 
            this.lbTenKhoa.AutoSize = true;
            this.lbTenKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKhoa.Location = new System.Drawing.Point(338, 53);
            this.lbTenKhoa.Name = "lbTenKhoa";
            this.lbTenKhoa.Size = new System.Drawing.Size(72, 22);
            this.lbTenKhoa.TabIndex = 3;
            this.lbTenKhoa.Text = "KHOA:";
            // 
            // cbbTenKhoa
            // 
            this.cbbTenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenKhoa.FormattingEnabled = true;
            this.cbbTenKhoa.Location = new System.Drawing.Point(416, 52);
            this.cbbTenKhoa.Name = "cbbTenKhoa";
            this.cbbTenKhoa.Size = new System.Drawing.Size(366, 24);
            this.cbbTenKhoa.TabIndex = 2;
            this.cbbTenKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbTenKhoa_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.btnOK);
            this.groupControl1.Controls.Add(this.btnCheck);
            this.groupControl1.Controls.Add(this.lbSupport);
            this.groupControl1.Controls.Add(this.txtMaSVMoi);
            this.groupControl1.Controls.Add(this.txtMaLopMoi);
            this.groupControl1.Controls.Add(this.txtMaSV);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 211);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1123, 324);
            this.groupControl1.TabIndex = 5;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(598, 257);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(149, 38);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(414, 257);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(149, 38);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "Xác Nhận";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(766, 108);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(122, 38);
            this.btnCheck.TabIndex = 17;
            this.btnCheck.Text = "Kiểm Tra";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lbSupport
            // 
            this.lbSupport.AutoSize = true;
            this.lbSupport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSupport.ForeColor = System.Drawing.Color.Blue;
            this.lbSupport.Location = new System.Drawing.Point(410, 214);
            this.lbSupport.Name = "lbSupport";
            this.lbSupport.Size = new System.Drawing.Size(72, 22);
            this.lbSupport.TabIndex = 16;
            this.lbSupport.Text = "Support";
            // 
            // txtMaSVMoi
            // 
            this.txtMaSVMoi.Location = new System.Drawing.Point(414, 165);
            this.txtMaSVMoi.Name = "txtMaSVMoi";
            this.txtMaSVMoi.Size = new System.Drawing.Size(333, 23);
            this.txtMaSVMoi.TabIndex = 15;
            // 
            // txtMaLopMoi
            // 
            this.txtMaLopMoi.Location = new System.Drawing.Point(414, 114);
            this.txtMaLopMoi.Name = "txtMaLopMoi";
            this.txtMaLopMoi.Size = new System.Drawing.Size(333, 23);
            this.txtMaLopMoi.TabIndex = 14;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(414, 66);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(333, 23);
            this.txtMaSV.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã Sinh Viên Mới:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã Lớp Chuyển Đến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã Sinh Viên:";
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "SINHVIEN";
            this.bdsSV.DataSource = this.dS;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // FrmChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 507);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grCTimSV);
            this.Controls.Add(this.grCTimSV1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmChuyenLop";
            this.Text = "FrmChuyenLop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmChuyenLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCTimSV1)).EndInit();
            this.grCTimSV1.ResumeLayout(false);
            this.grCTimSV1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCTimSV)).EndInit();
            this.grCTimSV.ResumeLayout(false);
            this.grCTimSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl grCTimSV1;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenSV;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditSV;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl grCTimSV;
        private System.Windows.Forms.Label lbTenKhoa;
        private System.Windows.Forms.ComboBox cbbTenKhoa;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbSupport;
        private System.Windows.Forms.TextBox txtMaSVMoi;
        private System.Windows.Forms.TextBox txtMaLopMoi;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bdsSV;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
    }
}