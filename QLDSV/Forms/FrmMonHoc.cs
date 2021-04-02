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
    public partial class FrmMonHoc : Form
    {

        private int _position = 0;
        private string flagOption; // true = add ; false = update ; default of boolean = false
        private string oldMaMonHoc = "";
        private string oldTenMonHoc = "";

        public FrmMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSet);

        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            dSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.mONHOCTableAdapter.Fill(this.dSet.MONHOC);
            // TODO: This line of code loads data into the 'dSet.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.dIEMTableAdapter.Fill(this.dSet.DIEM);
            

            mONHOCGridControl.Enabled = true;
            // TODO : Role Action
            //if (Program.MGroup == Program.NhomQuyen[0])// PGV
            //{
            //    barBtnThem.Enabled
            //       = barBtnXoa.Enabled
            //       = barBtnSua.Enabled
            //       = barBtnUndo.Enabled
            //       = barBtnGhi.Enabled
            //       = barBtnHuy.Enabled
            //       = barBtnLamMoi.Enabled = true;
            //}
            //else if (Program.MGroup == Program.NhomQuyen[1]) // KHOA
            //{
                barBtnThem.Enabled
                    = barBtnXoa.Enabled
                    = barBtnSua.Enabled
                    = barBtnUndo.Enabled
                    = barBtnGhi.Enabled
                    = barBtnHuy.Enabled = true;
            //}

            barBtnHuy.Enabled = barBtnGhi.Enabled = false;

            // TODO : Turn off input
            groupBoxMonHoc.Enabled = false;

        }

        private void mAMHTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tENMHTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagOption = "ADD";//  Add action

            barBtnGhi.Enabled = barBtnHuy.Enabled = true;
            barBtnThem.Enabled
                = barBtnXoa.Enabled
                = barBtnSua.Enabled
                = barBtnUndo.Enabled
                = barBtnLamMoi.Enabled = false;

            groupBoxMonHoc.Enabled = true;
            txtMaMH.ReadOnly = false;
            mONHOCGridControl.Enabled = false;

            // TODO : Thao tác chuẩn bị thêm
            bdsMonHoc.AddNew();
        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDiem.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đang chứa điểm.", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa môn học này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsMonHoc.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.URL_Connect;
                    this.mONHOCTableAdapter.Update(this.dSet.MONHOC);
                    this.bdsMonHoc.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học.\nBạn hãy xem lại\n" + ex.Message, "", MessageBoxButtons.OK);
                }


            }


            if (_position > 0)
            {

                bdsMonHoc.Position = _position;
            }
        }

        private void barBtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagOption = "UPDATE";//  Update action
            oldMaMonHoc = this.txtMaMH.Text.Trim().ToString();
            oldTenMonHoc = this.txtTenMH.Text.Trim().ToString();

            // TODO: Display To handle
            mONHOCGridControl.Enabled = false;
            groupBoxMonHoc.Enabled = true;
            if(bdsDiem.Count > 0)
            {
                txtMaMH.ReadOnly = true;
                MessageBox.Show("Môn học đã có điểm không thể sửa mã môn học!", "", MessageBoxButtons.OK);
            }
            barBtnGhi.Enabled = barBtnHuy.Enabled = true;

            barBtnThem.Enabled
                = barBtnXoa.Enabled
                = barBtnSua.Enabled
                = barBtnUndo.Enabled
                = barBtnLamMoi.Enabled = false;
        }

        private void barBtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMonHoc.CancelEdit();

            FrmMonHoc_Load(sender, e);
            if (_position > 0)
            {
                bdsMonHoc.Position = _position;
            }
        }

        private void barBtnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMonHoc_Load(sender, e);
            MessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.groupBoxMonHoc.Enabled)
            {
                String notifi = " Dữ liệu Môn Học chưa lưu vào Database. \n Bạn có chắc muốn thoát !";

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
        private bool ValidateInfoMONHOC()
        {
            errorProvider.Clear();

            // TODO : Check khoảng trống ở textField
            if (txtMaMH.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtMaMH, "Mã môn học không được để trống!");
                return false;
            }
            if (txtTenMH.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtTenMH, "Tên môn học không được để trống");
                return false;
            }


            if (flagOption == "ADD")
            {
                //TODO: Check mã môn học có tồn tại chưa
                string query1 = "DECLARE  @return_value int \n"
                            + "EXEC @return_value = SP_CHECKID \n"
                            + "@Code = N'" + txtMaMH.Text + "',@Type = N'MAMONHOC' \n"
                            + "SELECT 'Return Value' = @return_value";

                int resultMa = Utils.CheckDataHelper(query1);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultMa == 1)
                {
                    this.errorProvider.SetError(txtMaMH, "Mã môn học đã tồn tại!");
                    return false;
                }

                // TODO : Check tên môn học có tồn tại chưa
                string query2 = "DECLARE  @return_value int \n"
                            + "EXEC @return_value = SP_CHECKNAME \n"
                            + "@Name = N'" + txtTenMH.Text + "',@Type = N'TENMONHOC' \n"
                            + "SELECT 'Return Value' = @return_value";

                int resultTen = Utils.CheckDataHelper(query2);
                if (resultTen == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultTen == 1)
                {
                    this.errorProvider.SetError(txtTenMH, "Tên môn học đã tồn tại!");
                    return false;
                }
            }

            if (flagOption == "UPDATE")
            {
                if (!this.txtMaMH.Text.Trim().ToString().Equals(oldMaMonHoc))// Nếu mã môn học thay đổi so với ban đầu
                {
                    //TODO: Check mã môn học có tồn tại chưa
                    string query1 = "DECLARE  @return_value int \n"
                                + "EXEC @return_value = SP_CHECKID \n"
                                + "@Code = N'" + txtMaMH.Text + "',@Type = N'MAMONHOC' \n"
                                + "SELECT 'Return Value' = @return_value";

                    int resultMa = Utils.CheckDataHelper(query1);
                    if (resultMa == -1)
                    {
                        MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultMa == 1)
                    {
                        this.errorProvider.SetError(txtMaMH, "Mã môn học đã tồn tại!");
                        return false;
                    }
                }
                if (!this.txtTenMH.Text.Trim().ToString().Equals(oldTenMonHoc))// Nếu tên môn học thay đổi so với ban đầu
                {
                    // TODO : Check tên môn học có tồn tại chưa
                    string query2 = "DECLARE  @return_value int \n"
                                + "EXEC @return_value = SP_CHECKNAME \n"
                                + "@Name = N'" + txtTenMH.Text + "',@Type = N'TENMONHOC' \n"
                                + "SELECT 'Return Value' = @return_value";

                    int resultTen = Utils.CheckDataHelper(query2);
                    if (resultTen == -1)
                    {
                        MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultTen == 1)
                    {
                        this.errorProvider.SetError(txtTenMH, "Tên môn học đã tồn tại!");
                        return false;
                    }
                }
            }

            return true;
        }

        private void txtMaMonHoc_EditValueChanged(object sender, EventArgs e)
        {
            txtMaMH.Properties.CharacterCasing = CharacterCasing.Upper;
        }


        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsMonHoc.Position > 0)
            {
                _position = bdsMonHoc.Position;
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.LawnGreen;
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void barBtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = ValidateInfoMONHOC();
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

                        mONHOCGridControl.Enabled = true;
                        groupBoxMonHoc.Enabled = false;

                        this.bdsMonHoc.EndEdit();
                        this.bdsMonHoc.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                        this.mONHOCTableAdapter.Update(this.dSet.MONHOC);

                    }
                    catch (Exception ex)
                    {
                        bdsMonHoc.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                return;
            }
        }

        private void mONHOCGridControl_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxMonHoc_Enter(object sender, EventArgs e)
        {

        }

        private void tENMHTextEdit_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void mONHOCBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mONHOCBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSet);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mONHOCGridControl_Click_1(object sender, EventArgs e)
        {

        }
    }
}
