using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Layer2;
using System.Data.SqlClient;
namespace DoAnDBMS
{
    public partial class FormNhanVien : Form
    {
        DB_NhanVien db_nhanvien;
        DataSet ds_nhanvien;
        DataTable dt_nhanvien;
        int r;
    public FormNhanVien()
        {
            db_nhanvien = new DB_NhanVien();
            
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                //lấy dữ liệu
                ds_nhanvien = db_nhanvien.GetDaTa();
                dt_nhanvien = ds_nhanvien.Tables[0];
                dgv_NhanVien.DataSource = dt_nhanvien;
                //Clear 
                txtMa_NV.DataBindings.Clear();
                txtTen_NV.DataBindings.Clear();
                txtCmnd.DataBindings.Clear();
                txtDienThoai.DataBindings.Clear();
                txtNgayLamViec.DataBindings.Clear();
                txtLuong.DataBindings.Clear();
                //binding
                txtMa_NV.DataBindings.Add("Text", dt_nhanvien, "Ma_NV");
                txtTen_NV.DataBindings.Add("Text", dt_nhanvien, "Ten_NV");
                txtCmnd.DataBindings.Add("Text", dt_nhanvien, "Cmnd");
                txtDienThoai.DataBindings.Add("Text", dt_nhanvien, "DienThoai");
                txtNgayLamViec.DataBindings.Add("Text", dt_nhanvien, "Ngay_LamViec");
                txtLuong.DataBindings.Add("Text", dt_nhanvien, "Luong");
                //disable
                txtMa_NV.Enabled = false;
                txtTen_NV.Enabled = false;
                txtNgayLamViec.Enabled = false;
                txtDienThoai.Enabled = false;
                txtLuong.Enabled = false;
                txtCmnd.Enabled = false;
                btnXoa.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Bạn Không có quyền truy xuất");
            }
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            FormNhanVien_Them them = new FormNhanVien_Them();
            them.ShowDialog();
            LoadData();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            FormNhanVien_Sua sua = new FormNhanVien_Sua();
            sua.ShowDialog();
            LoadData();
        }

        private void Dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r = dgv_NhanVien.CurrentCell.RowIndex;
            BienCucBo.Ma_NV = dgv_NhanVien.Rows[r].Cells[0].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string MaNV = dgv_NhanVien.Rows[r].Cells[0].Value.ToString();
            FormHDBanHang form = new FormHDBanHang(MaNV);
            form.ShowDialog();
        }

        private void btn_ChuaXai_Click(object sender, EventArgs e)

        {
            try
            {
                btnXoa.Enabled = true;
                ds_nhanvien = db_nhanvien.NhanVienChuaXai();
                dt_nhanvien = ds_nhanvien.Tables[0];
                dgv_NhanVien.DataSource = dt_nhanvien;
            }
            catch (SqlException)
            {
                MessageBox.Show("Bạn Không có quyền truy xuất");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (BienCucBo.Ma_NV == null)
                MessageBox.Show("Hãy chọn Nhân Viên cần xóa!!!");

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

                        if (db_nhanvien.XoaNhanVien(ref err, BienCucBo.Ma_NV))
                        {
                            MessageBox.Show("Xóa Thành Công");
                            LoadData();
                            BienCucBo.Ma_NV = null;
                        }
                        else
                            MessageBox.Show("Lỗi :" + err);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi!!! Thử Lại Lần Sau.");
                }
            }
        }
    }
}
