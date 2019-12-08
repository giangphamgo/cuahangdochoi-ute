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
    public partial class FormMatHang : Form
    {
        DB_MatHang db_mathang;
        DataSet ds_mathang;
        DataTable dt_mathang;

        public FormMatHang()
        {
            db_mathang = new DB_MatHang();
            InitializeComponent();

            //xử lí combobox
            cbbTimKiem.Items.Add("Mã Mặt Hàng");
            cbbTimKiem.Items.Add("Mã Loại Mặt Hàng");
            cbbTimKiem.Items.Add("Tên Mặt Hàng");
            cbbTimKiem.Items.Add("Số Lượng");
            cbbTimKiem.Items.Add("Giá Nhập");
            cbbTimKiem.Items.Add("Giá Bán");
            cbbTimKiem.SelectedItem = "Chọn";
        }

        private void BtnXoaMatHang_Click(object sender, EventArgs e)
        {
            if (BienCucBo.Ma_MH == null)
                MessageBox.Show("Hãy chọn Mặt Hàng cần xóa!!!");
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

                        if (db_mathang.XoaMatHang(ref err, BienCucBo.Ma_MH))
                        {
                            MessageBox.Show("Xóa Thành Công");
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
   

        private void Btn_ThemMatHang_Click(object sender, EventArgs e)
        {
            FormMatHang_Them ThemKhachHang = new FormMatHang_Them();
            ThemKhachHang.ShowDialog();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
               
                ds_mathang = db_mathang.GetDaTa();
                dt_mathang = ds_mathang.Tables[0];
                dgv_MatHang.DataSource = dt_mathang;
                btnXoaMatHang.Enabled = false;
            }
            catch(SqlException)
            {
                MessageBox.Show("Bạn Không có quyền truy xuất");
            }
        }

        private void FormMatHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Dgv_MatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_MatHang.CurrentCell.RowIndex;
            BienCucBo.Ma_MH = dgv_MatHang.Rows[r].Cells[0].Value.ToString();
        }

        private void BtnCapNhatMatHang_Click(object sender, EventArgs e)
        {
            FormMatHang_Sua SuaKhachHang = new FormMatHang_Sua();
            SuaKhachHang.ShowDialog();
            LoadData();
        }

        private void BtnXem_Click(object sender, EventArgs e)
        {
            FormMatHang_Xem XemKhachHang = new FormMatHang_Xem();
            XemKhachHang.ShowDialog();
            LoadData();
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
        //    string Tim = textBox1.Text;
        //    switch (cbbTimKiem.SelectedItem.ToString().Trim())
        //    {
        //        case "Mã Mặt Hàng":
        //                ds_mathang = db_mathang.TimMHtheoMaMH(Tim);
        //                dt_mathang = ds_mathang.Tables[0];
        //            break;
        //        case "Mã Loại Mặt Hàng":
        //            ds_mathang = db_mathang.TimMHtheoMaloaiMH(Tim);
        //            dt_mathang = ds_mathang.Tables[0];
        //            break;
        //        case "Tên Mặt Hàng":
        //            ds_mathang = db_mathang.TimMHtheoTenMH(Tim);
        //            dt_mathang = ds_mathang.Tables[0];
        //            break;
        //        case "Số Lượng":
        //            ds_mathang = db_mathang.TimMHtheoSoLuong(Tim);
        //            dt_mathang = ds_mathang.Tables[0];
        //            break;
        //        case "Giá Nhập":
        //            ds_mathang = db_mathang.TimMHtheoGiaNhap(Tim);
        //            dt_mathang = ds_mathang.Tables[0];
        //            break;
        //        case "Giá Bán":
        //            ds_mathang = db_mathang.TimMHtheoGiaBan(Tim);
        //            dt_mathang = ds_mathang.Tables[0];
        //            break;
        //        default:
        //            MessageBox.Show("Không thấy tìm thấy kết quả!!!");
        ////            break;
        //    }
        //    dgv_MatHang.DataSource = dt_mathang;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string Tim = textBox1.Text;
            switch (cbbTimKiem.SelectedItem.ToString().Trim())
            {
                case "Mã Mặt Hàng":
                    ds_mathang = db_mathang.TimMHtheoMaMH(Tim);
                    dt_mathang = ds_mathang.Tables[0];
                    break;
                case "Mã Loại Mặt Hàng":
                    ds_mathang = db_mathang.TimMHtheoMaloaiMH(Tim);
                    dt_mathang = ds_mathang.Tables[0];
                    break;
                case "Tên Mặt Hàng":
                    ds_mathang = db_mathang.TimMHtheoTenMH(Tim);
                    dt_mathang = ds_mathang.Tables[0];
                    break;
                case "Số Lượng":
                    ds_mathang = db_mathang.TimMHtheoSoLuong(Tim);
                    dt_mathang = ds_mathang.Tables[0];
                    break;
                case "Giá Nhập":
                    ds_mathang = db_mathang.TimMHtheoGiaNhap(Tim);
                    dt_mathang = ds_mathang.Tables[0];
                    break;
                case "Giá Bán":
                    ds_mathang = db_mathang.TimMHtheoGiaBan(Tim);
                    dt_mathang = ds_mathang.Tables[0];
                    break;
                default:
                    MessageBox.Show("Không thấy tìm thấy kết quả!!!");
                    break;
            }
            dgv_MatHang.DataSource = dt_mathang;
        }

        private void BtnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                btnXoaMatHang.Enabled = true;
                ds_mathang = db_mathang.MatHangChuaXai();
                dt_mathang = ds_mathang.Tables[0];
                dgv_MatHang.DataSource = dt_mathang;
            }
            catch (SqlException)
            {
                MessageBox.Show("Bạn Không có quyền truy xuất");
            }
        }
    }
}
