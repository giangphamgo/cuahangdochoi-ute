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
    public partial class FormKhachHang_Them : Form
    {
        DB_KhachHang db;
        public FormKhachHang_Them()
        {
            db = new DB_KhachHang();
            InitializeComponent();
        }
        private void FormKhachHang_Them_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                //Clear
                txt_MaKH.DataBindings.Clear();
                txt_TenKH.DataBindings.Clear();
                txtDiaChi.DataBindings.Clear();
                txtDT.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi trong việc truy xuất dữ liệu!");
            }
        }

        //button thoat click
        

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            try
            {
                string err = " ";
                if (!db.ThemKhachHang
                    (ref err, txt_MaKH.Text, txt_TenKH.Text,
                    txtDiaChi.Text, txtDT.Text, txtEmail.Text))
                    MessageBox.Show("Lỗi thêm khách hàng!");
                else MessageBox.Show("Thêm khách hàng thành công!");
            }
            catch
            {
                MessageBox.Show("Lỗi! Xin thử lại!");
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_MaKH.Clear();
            txt_TenKH.Clear();
            txtDiaChi.Clear();
            txtDT.Clear();
            txtEmail.Clear();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
