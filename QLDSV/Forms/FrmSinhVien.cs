using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FrmSinhVien : Form
    {

        private int _position = 0;
        private string _flagOption; // true = add ; false = update ; default of boolean = false
        private string _oldMaSV = "";
        private string _oldHoSV = "";
        private string _oldTenSV = "";
        private string _oldNoiSinh = "";
        private string _oldDiaChi = "";
        private string _oldGhiChu = "";
        private Boolean _oldPhai = true;
        private Boolean _oldNghiHoc = false;
        private DateTime _oldNgaySinh;

        public FrmSinhVien()
        {
            InitializeComponent();
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.dIEMTableAdapter.Fill(this.dS.DIEM);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.lOPTableAdapter.Fill(this.dS.LOP);
           
           
            errorProvider.Clear();

            //this.conGhi.Enabled = false;

            lOPGridControl.Enabled = true;

            // đoạn code liên kết giữa bds với combo box
            // lọc phân mảnh trước
            Program.Bds_Dspm.Filter = "TENKHOA LIKE 'Khoa%'";
            Utils.BindingDataToComBo(cbbTenKhoa, Program.Bds_Dspm);

            lOPGridControl.Enabled = true;
            sINHVIENGridControl.Enabled = true;
            // TODO : Role Action
            if (Program.MGroup == Program.NhomQuyen[0] || Program.MGroup == Program.NhomQuyen[2])// PGV
            {
                cbbTenKhoa.Visible = true;
                cbbTenKhoa.Enabled = true;

                barBtnThem.Enabled
                   = barBtnXoa.Enabled
                   = barBtnSua.Enabled
                   = barBtnUndo.Enabled
                   = barBtnGhi.Enabled
                   = barBtnHuy.Enabled
                   = barBtnLamMoi.Enabled = true;
            }
            else if (Program.MGroup == Program.NhomQuyen[1]) // Khoa
            {
                cbbTenKhoa.Visible = false;
                barBtnThem.Enabled
                   = barBtnXoa.Enabled
                   = barBtnSua.Enabled
                   = barBtnUndo.Enabled
                   = barBtnGhi.Enabled
                   = barBtnHuy.Enabled
                   = barBtnLamMoi.Enabled = true;

                lbKhoa.Text = ((DataRowView)Program.Bds_Dspm[Program.MKhoa])["TENKHOA"].ToString();

            }

            barBtnHuy.Enabled = barBtnGhi.Enabled = false;

            // TODO : Turn off input
            pnNhapSV.Enabled = false;
        }

        private void lbKhoa_Click(object sender, EventArgs e)
        {

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
                // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
                this.lOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                // TODO: This line of code loads data into the 'dS.DIEM' table. You can move, or remove it, as needed.
                this.dIEMTableAdapter.Connection.ConnectionString = Program.URL_Connect;
                this.dIEMTableAdapter.Fill(this.dS.DIEM);



                //this.txtMaKhoa.EditValue = Utils.GetMaKhoa();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nGAYSINHLabel_Click(object sender, EventArgs e)
        {

        }

        private void nGAYSINHDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dIACHILabel_Click(object sender, EventArgs e)
        {

        }

        private void dIACHITextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void nOISINHLabel_Click(object sender, EventArgs e)
        {

        }

        private void nOISINHTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mALOPLabel_Click(object sender, EventArgs e)
        {

        }

        private void mALOPTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bdsDiem_CurrentChanged(object sender, EventArgs e)
        {
                    }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void grpSV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sINHVIENBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void mASVLabel1_Click(object sender, EventArgs e)
        {

        }

        private void mASVTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _flagOption = "ADD";//  Add action

            barBtnGhi.Enabled = barBtnHuy.Enabled = true;
            barBtnXoa.Enabled = barBtnThem.Enabled
                = barBtnSua.Enabled
                = barBtnUndo.Enabled
                = barBtnLamMoi.Enabled = false;


            cbbTenKhoa.Enabled = false;

            lOPGridControl.Enabled = false;
            sINHVIENGridControl.Enabled = false;
            pnNhapSV.Enabled = true;
            txtMaSV.ReadOnly = false;
            // thao tác chuẩn bị thêm
            bdsSV.AddNew();
            //this.txtMaKhoa.EditValue = Utils.GetMaKhoa();
        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDiem.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì đã có điểm.", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa sinh viên này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsSV.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                    return;

                }
            }
            if (bdsDiem.Count == 0) barBtnXoa.Enabled = false;


            barBtnLamMoi.Enabled = true;

            if (_position > 0)
            {
                bdsSV.Position = _position;
            }
        }

        private void barBtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _flagOption = "UPDATE";//  Update action
            _oldMaSV = this.txtMaSV.Text.Trim().ToString();
            _oldHoSV = this.txtHo.Text.Trim().ToString();
            _oldTenSV = this.txtTen.Text.Trim().ToString();
            _oldDiaChi = this.txtDiaChi.Text.Trim().ToString();
            _oldGhiChu = this.txtGhiChu.Text.Trim().ToString();
            _oldNoiSinh = this.txtNoiSinh.Text.Trim().ToString();
            _oldPhai = this.checkPhai.Checked;
            _oldNghiHoc = this.checkNghiHoc.Checked;
           // _oldNgaySinh = this.dateNgaySinh;


            // TODO: Display To handle
            lOPGridControl.Enabled = false;
            sINHVIENGridControl.Enabled = false;
            pnNhapSV.Enabled = true;
            if(bdsDiem.Count > 0) {
                txtMaSV.ReadOnly = true;
                MessageBox.Show("Sinh viên đã có điểm không thể sửa mã sinh viên!", "", MessageBoxButtons.OK);
            }
            barBtnGhi.Enabled = barBtnHuy.Enabled = true;

            barBtnThem.Enabled
                = barBtnXoa.Enabled
                = barBtnSua.Enabled
                = barBtnUndo.Enabled
                = barBtnLamMoi.Enabled = false;
            cbbTenKhoa.Enabled = false;
        }

        private void barBtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = this.ValidateInfoSV();
            if (check)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        barBtnThem.Enabled
                        = barBtnXoa.Enabled
                        = barBtnSua.Enabled
                        = barBtnUndo.Enabled
                        = barBtnLamMoi.Enabled = true;

                        lOPGridControl.Enabled = true;

                        this.bdsSV.EndEdit();
                        this.bdsSV.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                        this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                    }
                    catch (Exception ex)
                    {
                        bdsSV.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                // lỗi thì return thôi.
                return;
            }

            FrmSinhVien_Load(sender, e);

            cbbTenKhoa.Visible = true;
            cbbTenKhoa.Enabled = true;

            if (_position > 0)
            {
                bdsSV.Position = _position;
            }
        }

        private void barBtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSV.CancelEdit();

            // load lại cả form...
            FrmSinhVien_Load(sender, e);

            //barBtnThem.Enabled
            //       = barBtnXoa.Enabled
            //       = barBtnSua.Enabled
            //       = barBtnUndo.Enabled
            //       = barBtnGhi.Enabled
            //       = barBtnHuy.Enabled
            //       = barBtnLamMoi.Enabled = true;

            if (_position > 0)
            {
                bdsSV.Position = _position;
            }
        }

        private void barBtnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSinhVien_Load(sender, e);
            MessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.pnNhapSV.Enabled)
            {

                String notifi = " Dữ liệu Sinh Viên chưa lưu vào Database. \n Bạn có chắc muốn thoát !";


                DialogResult dr = MessageBox.Show(notifi, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                //this.Close();
                String notifi = "Bạn có chắc chắn muốn thoát không?";
                DialogResult dr = MessageBox.Show(notifi, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    this.Close();
                    return;
                }

            }
        }

        // ====================== SUPPORT VALIDATION ====================== //
        private bool ValidateInfoSV()
        {
            errorProvider.Clear();

            // TODO : Check khoảng trống ở textField
            if (txtMaSV.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtMaLop, "Mã sinh viên không được để trống !");
                return false;
            }
            if (txtHo.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtHo, "Họ sinh viên không được để trống !");
                return false;
            }
            if (txtTen.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtTen, "Tên sinh viên không được để trống !");
                return false;
            }

            if (_flagOption == "ADD")
            {
                //TODO: Check mã sinh vien có tồn tại chưa
                string query1 = "DECLARE  @return_value int \n"
                            + "EXEC  @return_value = SP_CHECKID \n"
                            + "@Code = N'" + txtMaSV.Text + "',@Type = N'MASV' \n"
                            + "SELECT  'Return Value' = @return_value ";

                int resultMaSV = Utils.CheckDataHelper(query1);
                if (resultMaSV == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultMaSV == 1)
                {
                    this.errorProvider.SetError(txtMaLop, "Mã sinh viên đã tồn tại ở Khoa hiên tại !");
                    return false;
                }
                if (resultMaSV == 2)
                {
                    this.errorProvider.SetError(txtMaLop, "Mã sinh viên đã tồn tại ở Khoa khác !");
                    return false;
                }



                if (_flagOption == "UPDATE")
                {
                    if (!this.txtMaSV.Text.Trim().ToString().Equals(_oldMaSV))// Nếu mã lớp thay đổi so với ban đầu
                    {
                        //TODO: Check mã Sinh Viên có tồn tại chưa
                        string query = "DECLARE  @return_value int \n"
                                    + "EXEC  @return_value = SP_CHECKID \n"
                                    + "@Code = N'" + txtMaSV.Text + "',@Type = N'MASV' \n"
                                    + "SELECT  'Return Value' = @return_value ";

                        int resultMa = Utils.CheckDataHelper(query);
                        if (resultMa == -1)
                        {
                            MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                            this.Close();
                        }
                        if (resultMa == 1)
                        {
                            this.errorProvider.SetError(txtMaLop, "Mã sinh viên đã tồn tại ở Khoa hiên tại !");
                            return false;
                        }
                        if (resultMa == 2)
                        {
                            this.errorProvider.SetError(txtMaLop, "Mã sinh viên đã tồn tại ở Khoa khác !");
                            return false;
                        }
                    }

                }

            }

            return true;
        }

        private void txtMaSV_EditValueChanged(object sender, EventArgs e)
        {
            // thường thành hoa
            txtMaSV.Properties.CharacterCasing = CharacterCasing.Upper;
        }

        private void gridView1_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Danh sách sinh viên";
        }


        private void gridView1_CustomDrawRowIndicator_1(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            e.Handled = true;
            SolidBrush brush = new SolidBrush(Color.FromArgb(0xC6, 0x64, 0xFF));
            e.Graphics.FillRectangle(brush, e.Bounds);
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height));
            Size size = ImageCollection.GetImageListSize(e.Info.ImageCollection);
            Rectangle r = e.Bounds;
            ImageCollection.DrawImageListImage(e.Cache, e.Info.ImageCollection, e.Info.ImageIndex,
                    new Rectangle(r.X + (r.Width - size.Width) / 2, r.Y + (r.Height - size.Height) / 2, size.Width, size.Height));
            brush.Dispose();
        }

        private void gridView1_RowCellStyle_1(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.LawnGreen;
            }
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            if (bdsSV.Position > 0)
            {
                _position = bdsSV.Position;
            }
        }

        private void gridView2_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            if (bdsLop.Position > 0)
            {
                _position = bdsLop.Position;
            }
        }
    }
}
