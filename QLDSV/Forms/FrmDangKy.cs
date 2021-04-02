using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.Forms
{
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }
        

        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.DSGV' table. You can move, or remove it, as needed.
            this.dSGVTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.dSGVTableAdapter.Fill(this.dS.DSGV);

            if (Program.MGroup == Program.NhomQuyen[0]) //PGV
            {
                radioBtnPGV.Checked = true;
                radioBtnPKT.Enabled = false;
            } // học phí chỉ được quyền đăng ký cho học phí
            else if (Program.MGroup == Program.NhomQuyen[3]) //PKT
            {
                radioBtnPKT.Checked = true;
                radioBtnPGV.Enabled = radioBtnKhoa.Enabled = radioBtnUser.Enabled = false;
            }
            else if (Program.MGroup == Program.NhomQuyen[1]) //Khoa
            {
                radioBtnPGV.Checked = true;
                radioBtnPKT.Enabled = radioBtnPGV.Enabled = false;
            }
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtMaGV.Text = this.lookUpEditGV.EditValue.ToString();
            }
            catch (Exception) { }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn hủy thao tác đăng ký tài khoản?",
                      "Xác thực", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
            {
                return;
            }
            else if (dr == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = (checkPass.Checked) ? false : true;
            txtPass2.UseSystemPasswordChar = (checkPass.Checked) ? false : true;
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            bool check = this.ValidateInfo();
            if (check)
            {
                createTaiKhoan();
            }
            else
            {
                return;
            }
        }


        // 1: trùng, 0 : not trùng
        private void createTaiKhoan()
        {

            String login = txtLogin.Text;
            String pass = txtPass.Text;
            String user = lookUpEditGV.EditValue.ToString();
            String role = "";
            if (radioBtnPGV.Checked) role = Program.NhomQuyen[0];
            else if (radioBtnKhoa.Checked) role = Program.NhomQuyen[1];
            else if (radioBtnUser.Checked) role = Program.NhomQuyen[2];
            else role = Program.NhomQuyen[3];

            String subLenh = " EXEC    @return_value = [dbo].[SP_TAOLOGIN] " +

                            " @LGNAME = N'" + login + "', " +
                            " @PASS = N'" + pass + "', " +
                            " @USERNAME = N'" + user + "', " +
                            " @ROLE = N'" + role + "' ";
 

            String strLenh = " DECLARE @return_value int " + subLenh +
                         " SELECT  'Return Value' = @return_value ";

            int resultCheckLogin = Utils.CheckDataHelper(strLenh);

            if (resultCheckLogin == -1)
            {
                MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (resultCheckLogin == 1)
            {
                errorProvider.SetError(this.txtLogin, "Login bị trùng . Mời bạn nhập login khác !");
            }
            else if (resultCheckLogin == 2)
            {
                errorProvider.SetError(this.lookUpEditGV, "Giảng viên đã có tài khoản rồi !");

            }
            else if (resultCheckLogin == 3)
            {
                MessageBox.Show("Lỗi thực thi trong cơ sơ dữ liệu !", "", MessageBoxButtons.OK);
            }
            else if (resultCheckLogin == 0)
            {
                MessageBox.Show("Tạo tài khoản thành công !", "", MessageBoxButtons.OK);
                Close();
            }

            return;
        }

        // true: ko empty, false : empty
        private Boolean isEmptyorNullTextEdits()
        {
            Boolean check = true;


            //check từng textedit

            if (string.IsNullOrEmpty(this.txtLogin.Text))
            {
                errorProvider.SetError(this.txtLogin, "Trường dữ liệu không được để trống !");
                check = false;
            }
            if (string.IsNullOrEmpty(this.txtPass.Text))
            {
                errorProvider.SetError(this.txtPass, "Trường dữ liệu không được để trống !");
                check = false;
            }

            if (string.IsNullOrEmpty(this.txtPass2.Text))
            {
                errorProvider.SetError(this.txtPass2, "Trường dữ liệu không được để trống !");
                check = false;
            }
            
            return check;
        }


        // true: ko empty, false : empty
        private Boolean isEmptyorNullRadioButtons()
        {
            //check từng radiobutton

            if (this.radioBtnKhoa.Checked || this.radioBtnPGV.Checked || this.radioBtnPKT.Checked || radioBtnUser.Checked)
            {
                return true;
            }

            errorProvider.SetError(this.radioGroup, "Bạn chưa chọn nhóm quyền !");

            return false;

        }


        private bool ValidateInfo()
        {
            bool isValid = true;

            // xóa hết thông báo ở errorProvider
            errorProvider.Clear();


            // check khoảng trống ở textedit
            if (!isEmptyorNullTextEdits())
            {
                isValid = false;
            }


            // check khớp mật khẩu
            if (txtPass2.Text != txtPass.Text)
            {
                this.errorProvider.SetError(txtPass2, "Mật khẩu không khớp");
                isValid = false;
            }

            // check khoảng trống ở radiobutton
            if (!isEmptyorNullRadioButtons())
            {
                isValid = false;
            }

            // login không được chứa khoảng trống
            if (txtLogin.Text.Contains(" "))
            {
                this.errorProvider.SetError(txtLogin, "Tên login không được chứa khoảng trắng !");
                isValid = false;
            }


            return isValid;
        }

        private void dSGVBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDSGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
    }
}
