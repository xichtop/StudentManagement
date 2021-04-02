using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.Forms
{
    public partial class FrmChuyenLop : Form
    {
        private int STATE = 0;
        public FrmChuyenLop()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FrmChuyenLop_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            
            Program.Bds_Dspm.Filter = "TENKHOA LIKE 'Khoa%'";

            Utils.BindingDataToComBo(cbbTenKhoa, Program.Bds_Dspm);

            if (Program.MGroup == Program.NhomQuyen[0] || Program.MGroup == Program.NhomQuyen[2])// PGV
            {
                cbbTenKhoa.Visible = true;
                cbbTenKhoa.Enabled = true;
            }
            else if (Program.MGroup == Program.NhomQuyen[1]) // Khoa
            {
                cbbTenKhoa.Visible = false;
                lbTenKhoa.Text = ((DataRowView)Program.Bds_Dspm[Program.MKhoa])["TENKHOA"].ToString();

            }

            btnOK.Enabled = false;
            txtMaSVMoi.Enabled = false;
            lbSupport.Visible = false;
        }
        
        private void lookUpEditSV_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedSV = lookUpEditSV.GetSelectedDataRow() as DataRowView;
                txtMaSV.Text = selectedSV.Row["MASV"].ToString();
                txtTenSV.Text = selectedSV.Row["HO"] + " " + selectedSV.Row["TEN"];
                txtMaLop.Text = selectedSV.Row["MALOP"].ToString();
            }
            catch (Exception) { }
        }
        
        
        // =============== Validation ===================
        public static int CheckValidatedMASV(string maSVMoi)
        {
            string query1 = "DECLARE  @return_value int \n"
                                + "EXEC  @return_value = SP_CHECKID \n"
                                + "@Code = N'" + maSVMoi + "',@Type = N'MASV' \n"
                                + "SELECT  'Return Value' = @return_value ";

            int resultMaSV = Utils.CheckDataHelper(query1);
            if (resultMaSV == -1)
            {
                return -1;
            }
            else if (resultMaSV == 1)
            {
                return 1;
            }
            else if (resultMaSV == 2)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        private void cbbTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO : Chuyển Bộ Phận
            Utils.ComboboxHelper(this.cbbTenKhoa);

            // kết nối database với dữ liệu ở đoạn code trên và fill dữ liệu, nếu như có lỗi thì
            // thoát.
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                dS.EnforceConstraints = false;
                // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            }
        }

        private void sINHVIENBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (this.txtMaSV.Text.Trim().ToString().Equals("") || this.txtMaLopMoi.Text.Trim().ToString().Equals(""))
            {
                MessageBox.Show("Bạn phải điền thông tin Mã Sinh Viên Và Mã Lớp chuyển Đến !", "INFO", MessageBoxButtons.OK);
                return;
            }

            string QUERY;
            string MASV = "";
            string MALOP = "";
            SqlCommand command;
            SqlDataReader dataReader;
            SqlDataAdapter adapter = new SqlDataAdapter();
            using (SqlConnection connection = new SqlConnection(Program.URL_Connect))
            {
                // OPEN CONNECTION
                connection.Open();

                // TODO : Kiểm tra sinh viên còn đi học mới cho chuyển
                QUERY = string.Format("SELECT NGHIHOC FROM dbo.SINHVIEN WHERE MASV = '" + this.txtMaSV.Text.Trim().ToString() + "'");
                command = new SqlCommand(QUERY, connection);
                command.CommandType = CommandType.Text;
                bool nghihoc = false;
                try
                {
                    nghihoc = (Boolean)command.ExecuteScalar();
                }
                catch { }
                if (nghihoc == true)// Sinh Viên Đã Nghỉ Học
                {
                    Console.WriteLine("Status Nghi Hoc : " + nghihoc);
                    this.lbSupport.Visible = true;
                    this.lbSupport.Text = "Không thể chuyển sinh viên này vì đã nghỉ học";
                    this.txtMaSV.Focus();
                    return;
                }

                // TODO : Check Mã Lớp Chuyển Đến Ở Site Hiện Tại
                QUERY = string.Format("SELECT MALOP FROM dbo.LOP WHERE MALOP = '" + this.txtMaLopMoi.Text.Trim().ToString() + "'");
                command = new SqlCommand(QUERY, connection);
                command.CommandType = CommandType.Text;
                try
                {
                    MALOP = (String)command.ExecuteScalar();
                }
                catch { }

                if (MALOP != null) // TODO : Site hiện tại đang có
                {
                    // STATE = 1
                    lbSupport.Visible = true;
                    lbSupport.Text = "Chấp Nhận Chuyển Lớp Cùng Khoa ?";
                    this.btnOK.Enabled = true;
                    this.txtMaSVMoi.Enabled = false;
                    STATE = 1; // INFO : Chuyển Lớp Trên Cùng Khoa
                    return;
                }
                else // TODO : Find on Site Root
                {
                    QUERY = "SELECT MALOP FROM LINK_CN_VT.QLDSV.dbo.LOP WHERE MALOP = '" + this.txtMaLopMoi.Text.Trim().ToString() + "'";
                    command = new SqlCommand(QUERY, connection);
                    command.CommandType = CommandType.Text;
                    try
                    {
                        MALOP = (String)command.ExecuteScalar();
                    }
                    catch { }

                    if (MALOP == null) // INFO : Mã lớp không tồn tại trong Cơ Sở Dữ Liệu
                    {
                        MessageBox.Show("Mã Lớp Không Tồn Tại Trong Cơ Sở Dữ Liệu!");
                        this.txtMaLopMoi.Focus();
                        return;
                    }
                    if (MALOP != null) // TODO : MALOP tồn tại
                    {
                        QUERY = "SELECT TOP 1 MASV FROM LINK_CN_VT.QLDSV.dbo.SINHVIEN WHERE MALOP = '" + this.txtMaLopMoi.Text.Trim().ToString() + "' ORDER BY MASV DESC";
                        command = new SqlCommand(QUERY, connection);
                        command.CommandType = CommandType.Text;
                        try
                        {
                            MASV = (String)command.ExecuteScalar();
                        }
                        catch { }

                        if (MASV == null)// INFO : Lớp chưa tồn tại sinh viên
                        {
                            lbSupport.Visible = true;
                            this.lbSupport.Text = "Lớp hiện đang trống! Mã Sinh Viên sẽ được hệ thống tạo tự động";
                            this.btnOK.Enabled = true;
                            this.txtMaSVMoi.Enabled = false;
                            STATE = 2; // INFO : Chuyển Lớp Khác Khoa Khi Lớp Chưa Có Sinh Viên
                            return;
                        }
                        else // INFO : Lớp đã chứa sinh viên
                        {

                            //// TODO : Get List MaSV
                            //QUERY = string.Format("SELECT MASV FROM LINK0.QLDSV.dbo.SINHVIEN");
                            //command = new SqlCommand(QUERY, connection);
                            //dataReader = command.ExecuteReader();
                            //while (dataReader.Read())
                            //{
                            //    myListMASV.Add(dataReader.GetValue(0).ToString());
                            //}
                            //// TODO : Must Close dataReader
                            //dataReader.Close();

                            lbSupport.Visible = true;
                            this.lbSupport.Text = "Gợi Ý: Mã sinh viên cuối danh sách của lớp là : " + MASV;
                            this.txtMaSVMoi.Enabled = true;
                            this.btnOK.Enabled = true;
                            STATE = 3; // INFO : Chuyển Lớp Khác Khoa Khi Lớp Đã Có Sinh Viên
                        }
                        command.Dispose();
                        connection.Close();
                    }
                }

            }
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            string maSV = this.txtMaSV.Text.Trim().ToString();
            string maLopMoi = this.txtMaLopMoi.Text.Trim().ToString();

            string QUERY = "";
            string MASV = "";

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            using (SqlConnection connection = new SqlConnection(Program.URL_Connect))
            {
                // OPEN CONNECTION
                connection.Open();

                //INFO: MASV ensure validated by Check Button
                Console.WriteLine("Mã Sinh Viên : " + MASV);
                // ALL THING BE CHECK DONE !

                if (STATE == 1)// CHUYỂN LỚP CÙNG KHOA
                {
                    //MessageBox.Show("LỚP TỒN TẠI Ở SITE HIỆN TẠI");
                    // TODO : Cập nhập mã lớp cho sinh viên ở chính site hiện tại
                    QUERY = "Update SINHVIEN SET MALOP='" + maLopMoi + "' WHERE MASV='" + maSV + "'";
                    command = new SqlCommand(QUERY, connection);
                    adapter.UpdateCommand = new SqlCommand(QUERY, connection);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Chuyển Sinh Viên Cùng Khoa, Vào Lớp " + maLopMoi + " Thành Công", "Info", MessageBoxButtons.OK);

                    connection.Close();
                    FrmChuyenLop_Load(sender, e);
                    //return;
                }

                if (STATE == 2) // INFO : CHUYỂN LỚP KHÁC KHOA -LỚP ĐÓ ĐANG TRỐNG
                {
                    //    // TODO : Cấp mã mới
                    string nienkhoa = maLopMoi.Substring(1, 2);
                    string major = maLopMoi.Substring(5, 2);
                    string newID = "";
                    QUERY = "SELECT TOP 1 MASV FROM LINK_CN_VT.QLDSV.dbo.SINHVIEN WHERE MASV LIKE N'N" + nienkhoa + "DC" + major + "%' ORDER BY MASV DESC";
                    command = new SqlCommand(QUERY, connection);
                    command.CommandType = CommandType.Text;
                    try
                    {
                        MASV = (String)command.ExecuteScalar();
                    }
                    catch { }
                    if (MASV == null)
                    {
                        newID = "N" + nienkhoa + "DC" + major + "001";
                    }
                    else
                    {
                        string temp = MASV.Substring(7, 3);
                        int i = int.Parse(temp) + 1;
                        newID = "N" + nienkhoa + "DC" + major + i;
                    }

                    QUERY = "SP_CHUYENLOP";
                    command = new SqlCommand(QUERY, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("MASV", maSV);// masv cũ
                    command.Parameters.AddWithValue("MASVMOI", newID);// masv mới
                    command.Parameters.AddWithValue("MALOPCHUYENDEN", maLopMoi);// mã lớp chuyển đến

                    try
                    {
                        //int i = command.ExecuteNonQuery();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Chuyển Sinh Viên Qua Lớp " + maLopMoi + " Thành Công", "INFO", MessageBoxButtons.OK);

                        // MessageBox.Show("trạng thái" + i + "", "INFO", MessageBoxButtons.OK);
                        connection.Close();
                        FrmChuyenLop_Load(sender, e);

                        //return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "INFO", MessageBoxButtons.OK);
                    }
                    command.Dispose();
                }

                if (STATE == 3)
                {
                    // TODO : Kiểm tra mã sv mới trùng với mã đang có ?
                    if (this.txtMaSVMoi.Text.Trim().ToString().Length != 10 || this.txtMaSVMoi.Text.Trim().ToString().Equals(""))
                    {
                        this.btnOK.Enabled = true;
                        this.txtMaSVMoi.Text = "";
                        this.lbSupport.Text = "Mã sinh viên mới không được để trống và phải có 10 kí tự !";
                        txtMaSVMoi.Focus();
                        btnOK.Enabled = true;
                        return;
                    }
                    else if (CheckValidatedMASV(this.txtMaSVMoi.Text.Trim().ToString()) == -1)
                    {
                        MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                        this.Close();

                    }
                    else if (CheckValidatedMASV(this.txtMaSVMoi.Text.Trim().ToString()) == 1)
                    {
                        this.btnOK.Enabled = true;
                        this.txtMaSVMoi.Text = "";
                        this.lbSupport.Text = "Mã sinh viên đã tồn tại ở Khoa hiện tại !";
                        txtMaSVMoi.Focus();
                        btnOK.Enabled = true;
                        return;
                    }
                    else if (CheckValidatedMASV(this.txtMaSVMoi.Text.Trim().ToString()) == 2)
                    {
                        this.btnOK.Enabled = false;
                        this.txtMaSVMoi.Text = "";
                        this.lbSupport.Text = "Mã sinh viên đã tồn tại ở Khoa khác !";
                        txtMaSVMoi.Focus();
                        btnOK.Enabled = true;
                        return;
                    }
                    else
                    {
                        string newID = this.txtMaSVMoi.Text.Trim().ToString();// lấy mã mới do người dùng nhập

                        QUERY = "SP_CHUYENLOP";
                        command = new SqlCommand(QUERY, connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("MASV", maSV);// masv cũ
                        command.Parameters.AddWithValue("MASVMOI", newID);// masv mới
                        command.Parameters.AddWithValue("MALOPCHUYENDEN", maLopMoi);// mã lớp chuyển đến

                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Chuyển Sinh Viên Qua Lớp " + maLopMoi + " Thành Công", "INFO", MessageBoxButtons.OK);
                            connection.Close();
                            FrmChuyenLop_Load(sender, e);
                            //return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "INFO", MessageBoxButtons.OK);
                        }
                        command.Dispose();
                    }
                }
                connection.Close();
            }// END USING
            FrmChuyenLop_Load(sender, e);
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
