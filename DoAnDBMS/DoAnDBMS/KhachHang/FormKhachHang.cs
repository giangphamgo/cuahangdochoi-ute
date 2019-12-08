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

namespace DoAnDBMS.KhachHang
{
    public partial class FormKhachHang : Form
    {
        DB_KhachHang db_khachhang;
        DataSet ds_khachhang;
        DataTable dt_khachhang;
        public FormKhachHang()
        {
            db_khachhang = new DB_KhachHang();
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                btn_Xoa.Enabled = false;
                //Lấy dữ liệu
                ds_khachhang = db_khachhang.GetDaTa();
                dt_khachhang = ds_khachhang.Tables[0];
                dgv_KhachHang.DataSource = dt_khachhang;
                //Clear
                txt_MaKH.DataBindings.Clear();
                txt_TenKH.DataBindings.Clear();
                txtDiaChi.DataBindings.Clear();
                txt_DT.DataBindings.Clear();
                txt_Email.DataBindings.Clear();
                //Bindings
                txt_MaKH.DataBindings.Add("Text", dt_khachhang, "Ma_KH");
                txt_TenKH.DataBindings.Add("Text", dt_khachhang, "Ten_KH");
                txtDiaChi.DataBindings.Add("Text", dt_khachhang, "DiaChi");
                txt_DT.DataBindings.Add("Text", dt_khachhang, "DienThoai");
                txt_Email.DataBindings.Add("Text", dt_khachhang, "Email");
                //disable
                txt_MaKH.Enabled = false;
                txt_TenKH.Enabled = false;
                txtDiaChi.Enabled = false;
                txt_DT.Enabled = false;
                txt_Email.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi trong việc truy xuất dữ liệu!");
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            FormKhachHang_Them them = new FormKhachHang_Them();
            them.ShowDialog();
            LoadData();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_KhachHang.CurrentCell.RowIndex;
            BienCucBo.Ma_KH = dgv_KhachHang.Rows[r].Cells[0].Value.ToString();
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            if (BienCucBo.Ma_KH == null)
                MessageBox.Show("Hãy chọn Khách Hàng cần xóa!!!");
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

                        if (db_khachhang.XoaKhachHang(ref err, BienCucBo.Ma_KH))
                        {
                            MessageBox.Show("Xóa Thành Công");
                            LoadData();
                            BienCucBo.Ma_KH = null;
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

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            try
            {
                btn_Xoa.Enabled = true;
                ds_khachhang = db_khachhang.KhachHangchuaxai();
                dt_khachhang = ds_khachhang.Tables[0];
                dgv_KhachHang.DataSource = dt_khachhang;
            }
            catch(SqlException)
            {
                MessageBox.Show("Bạn Không có quyền truy xuất");
            }
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            FormKhachHang_Them form = new FormKhachHang_Them();
            form.ShowDialog();
        }

        private void FormKhachHang_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_KhachHang.CurrentCell.RowIndex;
            BienCucBo.Ma_KH = dgv_KhachHang.Rows[r].Cells[0].Value.ToString();
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            if (BienCucBo.Ma_KH == null)
                MessageBox.Show("Hãy chọn Khách Hàng cần sửa!!!");
            else
            {
                FormKhachHang_Sua sua = new FormKhachHang_Sua();
                sua.ShowDialog();
                LoadData();
            }
        }
    }
}
