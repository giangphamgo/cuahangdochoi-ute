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
    public partial class FormCTBanHang : Form
    {
        DB_ChiTietBanHang db_chitietbanhang;
        DataSet ds_chitietbanhang;
        DataTable dt_chitietbanhang;
        public FormCTBanHang()
        {
            db_chitietbanhang = new DB_ChiTietBanHang();
            InitializeComponent();
        }

        private void FormCTBanHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                ds_chitietbanhang = db_chitietbanhang.GetDaTa();
                dt_chitietbanhang = ds_chitietbanhang.Tables[0];
                dgv_CTBH.DataSource = dt_chitietbanhang;
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi trong việc truy xuất dữ liệu!");
            }
        }

        private void FormCTBanHang_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
