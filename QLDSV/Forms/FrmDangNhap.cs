using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.Forms
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e) // private
        {
            // trường hợp không tạo view phân mảnh

            //string chuoiketnoi = "Data Source=XICH-TOP;Initial Catalog=QLDSV;User ID=sa;Password=262799";

            //Program.Conn.ConnectionString = chuoiketnoi;

            //DataTable dt = new DataTable();
            ////gọi 1 view và trả về dưới dạng datatable
            //dt = Program.ExecSqlDataTable("SELECT * FROM V_DSPM");


            //// cất dt vào biến toàn cục Bds_Dspm
            //Program.Bds_Dspm.DataSource = dt;

            //// fix lỗi nho nhỏ :v
            //Program.Bds_Dspm.Sort = "TENKHOA ASC";
            //// đoạn code liên kết giữa bds với combobox
            //Utils.BindingDataToComBo(cmbKhoa, dt);



            // Trường hợp có tạo view phân mảnh
            phanManh.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'phanManh.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            //this.v_DS_PHANMANHTableAdapter.Connection.ConnectionString = chuoiketnoi;
            this.v_DS_PHANMANHTableAdapter.Fill(this.phanManh.V_DS_PHANMANH);


            cbbTenKhoa.SelectedIndex = 1;
            cbbTenKhoa.SelectedIndex = 0;
        }

        private void cbbTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // gán server đã chọn vào biến toàn cục.
                Program.ServerName = cbbTenKhoa.SelectedValue.ToString();
            }
            catch (Exception) { };
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được để trống!", "Lỗi đăng nhập", MessageBoxButtons.OK);
                // trỏ con trỏ chuột về ô user
                txtLogin.Focus();
                return;
            }
            Program.MLogin = txtLogin.Text;
            Program.MPassword = txtPass.Text;
            if (Program.KetNoi() == 0)
            {
                return;
            }
            //MessageBox.Show("Đăng nhập thành công!", "", MessageBoxButtons.OK);



            Program.MKhoa = cbbTenKhoa.SelectedIndex;// 0: CNTT ,  1: VT, 2: HỌC PHÍ
            Program.Bds_Dspm = bdsPhanManh;
            Program.MLoginDN = Program.MLogin;
            Program.PasswordDN = Program.MPassword;


            String strLenh = "exec SP_DANGNHAP '" + Program.MLogin + "'";
            Program.MyReader = Program.ExecSqlDataReader(strLenh);
            if (Program.MyReader == null)
            {
                return;
            }

            Program.MyReader.Read();


            Program.UserName = Program.MyReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.UserName))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\nBạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                Program.MHoten = Program.MyReader.GetString(1);
                Program.MGroup = Program.MyReader.GetString(2);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("---> Lỗi: " + ex.ToString());
                MessageBox.Show("Login bạn nhập không có quyền truy cập vào chương trình", "", MessageBoxButtons.OK);
                return;
            }

            Program.MyReader.Close();
            Program.Conn.Close();

            // truy cập vào frm main 
            Program.FrmMain = new FrmMain();

            // hiện thông tin tài khoản
            Program.FrmMain.lbMaGV.Text = "MÃ GIẢNG VIÊN : " + Program.UserName.Trim();
            Program.FrmMain.lbHoTen.Text = "HỌ VÀ TÊN : " + Program.MHoten.Trim();
            Program.FrmMain.lbNhom.Text = "NHÓM : " + Program.MGroup;

            Program.FrmMain.Show();
            Program.FrmDangNhap.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.Properties.UseSystemPasswordChar = (checkShowPass.Checked) ? false : true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDangNhap_VisibleChanged(object sender, EventArgs e)
        {
            Program.Bds_Dspm.RemoveFilter();
            cbbTenKhoa_SelectedIndexChanged(sender, e);
        }

        private void txtLogin_EditValueChanged(object sender, EventArgs e)
        {
            txtLogin.Properties.CharacterCasing = CharacterCasing.Upper;
        }

    }
}
