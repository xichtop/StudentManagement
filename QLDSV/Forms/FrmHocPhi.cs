using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FrmHocPhi : Form
    {
        private int _position = 0;

        public FrmHocPhi()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSPHocPhi.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FrmHocPhi_Load(object sender, EventArgs e)
        {
            
            
            dS.EnforceConstraints = false;
            //// TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            //this.sINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            //this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            // TODO: This line of code loads data into the 'dS.SP_DSSV' table. You can move, or remove it, as needed.
            this.sP_DSSVTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.sP_DSSVTableAdapter.Fill(this.dS.SP_DSSV);

            grcDongHP.Enabled = grcListHP.Enabled = false;

            btnThem.Enabled = btnGhi.Enabled = btnHuy.Enabled = false;
            btnThoat.Enabled = true;
        }

        private void lookUpEditSV_EditValueChanged(object sender, EventArgs e)
        {
            var selectedSV = lookUpEditSV.GetSelectedDataRow() as DataRowView;

            txtTenSV.Text = selectedSV.Row["HOTEN"].ToString();
            txtMaLop.Text = selectedSV.Row["MALOP"].ToString();
            
            grcListHP.Enabled = true;
            btnThem.Enabled = true;
            try
            {
                this.sP_HOCPHITableAdapter.Fill(this.dS.SP_HOCPHI, selectedSV.Row["MASV"].ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            if(bdsSPHocPhi.Count == 0)
            {
                MessageBox.Show("Sinh viên này chưa được nhập dữ liệu học phí!", "", MessageBoxButtons.OK);
                btnThem.Enabled = false;
            }
        }

     

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.grcDongHP.Enabled)
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

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtHocPhi.Text.Equals(txtSoTienDaDong.Text))
            {
                MessageBox.Show("Sinh viên này đã đóng đủ học phí cho kì này!", "", MessageBoxButtons.OK);
            }
            else
            {
                txtSoTienDong.Enabled = true;
                grcDongHP.Enabled = true;
                btnGhi.Enabled = btnHuy.Enabled = true;
                btnThem.Enabled = false;
            }
            
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmHocPhi_Load(sender, e);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = ValidateInfoHOCPHI();
            if (check)
            {
                // bắt đầu ghi dữ liệu
                SqlConnection conn = new SqlConnection(Program.URL_Connect);
                // bắt đầu transaction
                SqlTransaction tran;

                conn.Open();
                tran = conn.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand("SP_INSERT_CTHP", conn);
                    cmd.Connection = conn;
                    cmd.Transaction = tran;
                    
                    cmd.CommandType = CommandType.StoredProcedure;

                    String maSV = (String)this.lookUpEditSV.EditValue;
                    String nienKhoa = (String)this.txtNienKhoa.Text;
                    int hocKi = int.Parse(this.txtHocKi.Text);
                    int soTienDong = int.Parse(this.txtSoTienDong.Text);

                    cmd.Parameters.Add(new SqlParameter("@MASV", maSV));
                    cmd.Parameters.Add(new SqlParameter("@NIENKHOA", nienKhoa));
                    cmd.Parameters.Add(new SqlParameter("@HOCKI", hocKi));
                    cmd.Parameters.Add(new SqlParameter("@SOTIENDONG", soTienDong));
                    cmd.ExecuteNonQuery();
                    

                    tran.Commit();
                }
                catch (SqlException sqlex)
                {
                    try
                    {
                        tran.Rollback();
                        MessageBox.Show("Lỗi thêm học phí vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);
                        MessageBox.Show("Học sinh này đã thêm học phí hôm nay!", "", MessageBoxButtons.OK);

                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                    conn.Close();
                    return;
                }
                finally
                {
                    conn.Close();
                }
                
                MessageBox.Show("Thao tác thành công!", "", MessageBoxButtons.OK);
                FrmHocPhi_Load(sender, e);
            }
            else
            {
                return;
            }
        }

        private bool ValidateInfoHOCPHI()
        {
            errorProvider.Clear();

            // TODO : Check khoảng trống ở textField
            if (txtSoTienDong.Text.Trim().Equals(""))
            {
               this.errorProvider.SetError(txtSoTienDong, "Số tiền đóng không được để trống!");
                return false;
            }

            if((int.Parse(txtSoTienDong.Text) + int.Parse(txtSoTienDaDong.Text)) > int.Parse(txtHocPhi.Text))
            {
                this.errorProvider.SetError(txtSoTienDong, "Số tiền đóng bị dư!");
                return false;
            }

            return true;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsSPHocPhi.Position > 0)
            {
                _position = bdsSPHocPhi.Position;
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
    }
}
