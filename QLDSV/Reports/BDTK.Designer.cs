namespace QLDSV.Reports
{
    partial class BDTK
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
            this.lbTenKhoa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTenKhoa = new System.Windows.Forms.ComboBox();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.dS = new QLDSV.DS();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenKhoa
            // 
            this.lbTenKhoa.AutoSize = true;
            this.lbTenKhoa.Location = new System.Drawing.Point(244, 109);
            this.lbTenKhoa.Name = "lbTenKhoa";
            this.lbTenKhoa.Size = new System.Drawing.Size(54, 21);
            this.lbTenKhoa.TabIndex = 0;
            this.lbTenKhoa.Text = "Khoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Lớp:";
            // 
            // cbbTenKhoa
            // 
            this.cbbTenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenKhoa.FormattingEnabled = true;
            this.cbbTenKhoa.Location = new System.Drawing.Point(327, 106);
            this.cbbTenKhoa.Name = "cbbTenKhoa";
            this.cbbTenKhoa.Size = new System.Drawing.Size(409, 28);
            this.cbbTenKhoa.TabIndex = 3;
            this.cbbTenKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbTenKhoa_SelectedIndexChanged);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(327, 153);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MALOP", "Mã Lớp"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENLOP", "Tên Lớp")});
            this.lookUpEdit1.Properties.DataSource = this.bdsLop;
            this.lookUpEdit1.Properties.DisplayMember = "TENLOP";
            this.lookUpEdit1.Properties.NullText = "Chọn Lớp ...";
            this.lookUpEdit1.Properties.ValueMember = "MALOP";
            this.lookUpEdit1.Size = new System.Drawing.Size(413, 22);
            this.lookUpEdit1.TabIndex = 4;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(327, 198);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(100, 28);
            this.txtMaLop.TabIndex = 5;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.dS;
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
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(371, 276);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(125, 31);
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(536, 275);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 31);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // BDTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.cbbTenKhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTenKhoa);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BDTK";
            this.Text = "BDTK";
            this.Load += new System.EventHandler(this.BDTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTenKhoa;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.TextBox txtMaLop;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThoat;
    }
}