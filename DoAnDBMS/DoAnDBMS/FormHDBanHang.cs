using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Layer2;
namespace DoAnDBMS
{
    public partial class FormHDBanHang : Form
    {
        DB_HDBanHang dbhoadon;
        DB_ChiTietBanHang dbchitiet;
        DB_NhanVien dbnhanvien;
        DB_KhachHang dbkhachhang;
        DataSet ds_hoadon, ds_chitiet, ds_nhanvien, ds_khachhang;
        DataTable dt_hoadon, dt_chitiet, dt_nhanvien, dt_khachhang;
        string manv;

        private void btn_ThemCTHD_Click(object sender, EventArgs e)
        {
            if (BienCucBo.Ma_HDBH == null)
            {
                MessageBox.Show("Hãy chọn hóa đơn cần thêm!!!");
            }
            else
            {
                ThemChiTiet form = new ThemChiTiet();
                form.ShowDialog();
                LoadData();
                ds_chitiet = dbchitiet.ChitietTheoMaHD(BienCucBo.Ma_HDBH);
                dt_chitiet = ds_chitiet.Tables[0];
                btn_Loc.DataSource = dt_chitiet;
            }
            
        }

        private void btn_XoaCTHD_Click(object sender, EventArgs e)
        {
            if (BienCucBo.Ma_HD2 == null&&BienCucBo.Ma_MH2==null)
                MessageBox.Show("Hãy chọn Chi tiết  cần xóa!!!");
            else
            {
                try
                {
                    string err = " ";
                    // Khai báo biến traloi 
                    DialogResult traloi;
                    // Hiện hộp thoại hỏi đáp 
                    traloi = MessageBox.Show("Chắc xóa không?", "Trả lời",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    // Kiểm tra có nhắp chọn nút Ok không? 
                    if (traloi == DialogResult.OK)
                    {

                        if (dbchitiet.XoaChiTiet_BanHang(ref err, BienCucBo.Ma_HD2, BienCucBo.Ma_MH2))
                        {
                            MessageBox.Show("Xóa Thành Công");
                            ds_chitiet = dbchitiet.ChitietTheoMaHD(BienCucBo.Ma_MH2);
                            dt_chitiet = ds_chitiet.Tables[0];
                            btn_Loc.DataSource = dt_chitiet;
                            LoadData();
                            BienCucBo.Ma_MH = null;
                        }
                        else
                        {
                            MessageBox.Show("Lỗi :" + err);
                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi!!! Thử Lại Lần Sau.");
                }
            }
        }
        private void dgv_ChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           int i = btn_Loc.CurrentCell.RowIndex;
            BienCucBo.Ma_HD2 = btn_Loc.Rows[i].Cells[0].Value.ToString();
            BienCucBo.Ma_MH2=btn_Loc.Rows[i].Cells[1].Value.ToString();
        }

        private void btn_SuaCTHD_Click(object sender, EventArgs e)
        {
            if (BienCucBo.Ma_HD2 == null && BienCucBo.Ma_MH2 == null)
                MessageBox.Show("Hãy chọn Chi tiết  cần sửa!!!");
            else
            {
                SuaChiTiet form = new SuaChiTiet();
                form.ShowDialog();
                LoadData();
                ds_chitiet = dbchitiet.ChitietTheoMaHD(BienCucBo.Ma_HDBH);
                dt_chitiet = ds_chitiet.Tables[0];
                btn_Loc.DataSource = dt_chitiet;
            }
        }

        private void btn_SuaHD_Click(object sender, EventArgs e)
        {
            if (BienCucBo.Ma_HDBH == null)
            {
                MessageBox.Show("Hãy chọn hóa đơn cần thêm!!!");
            }
            else
            {
                FormHDBanHang_Sua form = new FormHDBanHang_Sua();
                form.ShowDialog();
                LoadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                btn_XoaHD.Enabled = true;
                ds_hoadon = dbhoadon.HoaDonChuaXai();
                dt_hoadon = ds_hoadon.Tables[0];
                dgv_HoaDon.DataSource = dt_hoadon;
            }
            catch (SqlException)
            {
                MessageBox.Show("Bạn Không có quyền truy xuất");
            }
        }

        private void btn_XoaHD_Click(object sender, EventArgs e)
        {

            if (BienCucBo.Ma_HDBH == null)
                MessageBox.Show("Hãy chọn Hóa Đơn cần xóa!!!");

            else
            {
                try
                {
                    string err = " ";
                    // Khai báo biến traloi 
                    DialogResult traloi;
                    // Hiện hộp thoại hỏi đáp 
                    traloi = MessageBox.Show("Chắc xóa không?", "Trả lời",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    // Kiểm tra có nhắp chọn nút Ok không? 
                    if (traloi == DialogResult.OK)
                    {
                        try
                        {
                            if (!dbhoadon.XoaHD_BanHang(ref err, BienCucBo.Ma_HDBH))

                                MessageBox.Show("Xóa Thành Công");
                            LoadData();
                            BienCucBo.Ma_HDBH = null;
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show(err.ToString());
                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi!!! Thử Lại Lần Sau.");
                }
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            FormHDBanHang_Them form = new FormHDBanHang_Them();
            form.ShowDialog();
            LoadData();
        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_HoaDon.CurrentCell.RowIndex;
            BienCucBo.Ma_HDBH = dgv_HoaDon.Rows[r].Cells[0].Value.ToString();
            string Ma_NV = dgv_HoaDon.Rows[r].Cells[1].Value.ToString();
            string Ma_KH= dgv_HoaDon.Rows[r].Cells[2].Value.ToString();
            //clear
            lbl_MaHD.DataBindings.Clear();
            lbl_MaNV.DataBindings.Clear();
            lbl_MaKH.DataBindings.Clear();
            lbl_Ngay.DataBindings.Clear();
            lbl_Tien.DataBindings.Clear();
            //binding
            lbl_MaHD.DataBindings.Add("Text", dt_hoadon, "Ma_HDBH");
            lbl_Ngay.DataBindings.Add("Text", dt_hoadon, "NgayXuatHD");
            lbl_Tien.DataBindings.Add("Text", dt_hoadon, "TongTien");
            //xử lí nhân viên
            ds_nhanvien = dbnhanvien.NhanVientheoMaNV(Ma_NV);
            dt_nhanvien = ds_nhanvien.Tables[0];
            lbl_MaNV.DataBindings.Add("Text", dt_nhanvien, "Ten_NV");
            //xử lí khách hàng
            ds_khachhang = dbkhachhang.KhachHangtheoMaKH(Ma_KH);
            dt_khachhang = ds_khachhang.Tables[0];
            lbl_MaKH.DataBindings.Add("Text", dt_khachhang, "Ten_KH");
            //xử lí dgv chi tiết
            ds_chitiet = dbchitiet.ChitietTheoMaHD(BienCucBo.Ma_HDBH);
            dt_chitiet = ds_chitiet.Tables[0];
            btn_Loc.DataSource = dt_chitiet;
        }

        public FormHDBanHang()
        {
            dbchitiet = new DB_ChiTietBanHang();
            dbhoadon = new DB_HDBanHang();
            dbnhanvien = new DB_NhanVien();
            dbkhachhang = new DB_KhachHang();
            InitializeComponent();
        }
        public FormHDBanHang(string MaNV)
        {
            this.manv = MaNV;
            dbchitiet = new DB_ChiTietBanHang();
            dbhoadon = new DB_HDBanHang();
            dbnhanvien = new DB_NhanVien();
            dbkhachhang = new DB_KhachHang();
            InitializeComponent();
        }

        private void FormHDBanHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (manv == null)
            {
                try
                {
                    ds_hoadon = dbhoadon.GetDaTa();
                    dt_hoadon = ds_hoadon.Tables[0];
                    dgv_HoaDon.DataSource = dt_hoadon;
                    btn_XoaHD.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!!!" + ex);
                }
            }
            else
            {
                try
                {
                    ds_hoadon = dbhoadon.Func_HoaDoncuaNhanVien(manv);
                    dt_hoadon = ds_hoadon.Tables[0];
                    dgv_HoaDon.DataSource = dt_hoadon;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!!!" + ex);
                }
            }
        }
    }
}
