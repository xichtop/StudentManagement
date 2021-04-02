namespace QLDSV.Forms
{
    partial class FrmDangKy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lookUpEditGV = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsDSGV = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.checkPass = new System.Windows.Forms.CheckBox();
            this.radioBtnPKT = new System.Windows.Forms.RadioButton();
            this.radioBtnUser = new System.Windows.Forms.RadioButton();
            this.radioBtnKhoa = new System.Windows.Forms.RadioButton();
            this.radioBtnPGV = new System.Windows.Forms.RadioButton();
            this.radioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dSGVTableAdapter = new QLDSV.DSTableAdapters.DSGVTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaGV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lookUpEditGV);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnDangKi);
            this.panel1.Controls.Add(this.checkPass);
            this.panel1.Controls.Add(this.radioBtnPKT);
            this.panel1.Controls.Add(this.radioBtnUser);
            this.panel1.Controls.Add(this.radioBtnKhoa);
            this.panel1.Controls.Add(this.radioBtnPGV);
            this.panel1.Controls.Add(this.radioGroup);
            this.panel1.Controls.Add(this.txtPass2);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(216, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 515);
            this.panel1.TabIndex = 0;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(439, 357);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.ReadOnly = true;
            this.txtMaGV.Size = new System.Drawing.Size(71, 28);
            this.txtMaGV.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mã GV:";
            // 
            // lookUpEditGV
            // 
            this.lookUpEditGV.Location = new System.Drawing.Point(137, 363);
            this.lookUpEditGV.Name = "lookUpEditGV";
            this.lookUpEditGV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditGV.Properties.DataSource = this.bdsDSGV;
            this.lookUpEditGV.Properties.DisplayMember = "HOTEN";
            this.lookUpEditGV.Properties.NullText = "Chọn Giảng Viên ...";
            this.lookUpEditGV.Properties.ValueMember = "MAGV";
            this.lookUpEditGV.Size = new System.Drawing.Size(224, 22);
            this.lookUpEditGV.TabIndex = 19;
            this.lookUpEditGV.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // bdsDSGV
            // 
            this.bdsDSGV.DataMember = "DSGV";
            this.bdsDSGV.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Giảng Viên:";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(302, 468);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(122, 31);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDangKi
            // 
            this.btnDangKi.Location = new System.Drawing.Point(137, 469);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(122, 31);
            this.btnDangKi.TabIndex = 16;
            this.btnDangKi.Text = "Đăng Kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // checkPass
            // 
            this.checkPass.AutoSize = true;
            this.checkPass.Location = new System.Drawing.Point(448, 313);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(75, 25);
            this.checkPass.TabIndex = 15;
            this.checkPass.Text = "Show";
            this.checkPass.UseVisualStyleBackColor = true;
            this.checkPass.CheckedChanged += new System.EventHandler(this.checkPass_CheckedChanged);
            // 
            // radioBtnPKT
            // 
            this.radioBtnPKT.AutoSize = true;
            this.radioBtnPKT.Location = new System.Drawing.Point(392, 413);
            this.radioBtnPKT.Name = "radioBtnPKT";
            this.radioBtnPKT.Size = new System.Drawing.Size(101, 25);
            this.radioBtnPKT.TabIndex = 13;
            this.radioBtnPKT.TabStop = true;
            this.radioBtnPKT.Text = "PKeToan";
            this.radioBtnPKT.UseVisualStyleBackColor = true;
            // 
            // radioBtnUser
            // 
            this.radioBtnUser.AutoSize = true;
            this.radioBtnUser.Location = new System.Drawing.Point(317, 413);
            this.radioBtnUser.Name = "radioBtnUser";
            this.radioBtnUser.Size = new System.Drawing.Size(66, 25);
            this.radioBtnUser.TabIndex = 12;
            this.radioBtnUser.TabStop = true;
            this.radioBtnUser.Text = "User";
            this.radioBtnUser.UseVisualStyleBackColor = true;
            // 
            // radioBtnKhoa
            // 
            this.radioBtnKhoa.AutoSize = true;
            this.radioBtnKhoa.Location = new System.Drawing.Point(237, 413);
            this.radioBtnKhoa.Name = "radioBtnKhoa";
            this.radioBtnKhoa.Size = new System.Drawing.Size(71, 25);
            this.radioBtnKhoa.TabIndex = 11;
            this.radioBtnKhoa.TabStop = true;
            this.radioBtnKhoa.Text = "Khoa";
            this.radioBtnKhoa.UseVisualStyleBackColor = true;
            // 
            // radioBtnPGV
            // 
            this.radioBtnPGV.AutoSize = true;
            this.radioBtnPGV.Location = new System.Drawing.Point(159, 413);
            this.radioBtnPGV.Name = "radioBtnPGV";
            this.radioBtnPGV.Size = new System.Drawing.Size(69, 25);
            this.radioBtnPGV.TabIndex = 10;
            this.radioBtnPGV.TabStop = true;
            this.radioBtnPGV.Text = "PGV";
            this.radioBtnPGV.UseVisualStyleBackColor = true;
            // 
            // radioGroup
            // 
            this.radioGroup.Location = new System.Drawing.Point(137, 396);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(373, 58);
            this.radioGroup.TabIndex = 9;
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(137, 313);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Size = new System.Drawing.Size(287, 28);
            this.txtPass2.TabIndex = 8;
            this.txtPass2.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(137, 264);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(373, 28);
            this.txtPass.TabIndex = 7;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(137, 218);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(373, 28);
            this.txtLogin.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDSV.Properties.Resources._942748;
            this.pictureBox1.Location = new System.Drawing.Point(237, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tạo Tài Khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Roles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // dSGVTableAdapter
            // 
            this.dSGVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.DSGVTableAdapter = this.dSGVTableAdapter;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 601);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDangKy";
            this.Text = "FrmDangKy";
            this.Load += new System.EventHandler(this.FrmDangKy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.CheckBox checkPass;
        private System.Windows.Forms.RadioButton radioBtnPKT;
        private System.Windows.Forms.RadioButton radioBtnUser;
        private System.Windows.Forms.RadioButton radioBtnKhoa;
        private System.Windows.Forms.RadioButton radioBtnPGV;
        private DevExpress.XtraEditors.RadioGroup radioGroup;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label6;
        private DS dS;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource bdsDSGV;
        private DSTableAdapters.DSGVTableAdapter dSGVTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}