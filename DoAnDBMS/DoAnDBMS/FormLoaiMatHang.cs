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
    public partial class FormLoaiMatHang : Form
    {
        DB_LoaiMatHang db_loaimathang;
        DataSet ds_loaimathang;
        DataTable dt_loaimathang;
        public FormLoaiMatHang()
        {
            db_loaimathang = new DB_LoaiMatHang();
            InitializeComponent();
        }
        
        private void LoadData()
        {
            try
            {
                ds_loaimathang = db_loaimathang.GetDaTa();
                dt_loaimathang = ds_loaimathang.Tables[0];
                dgv_LoaiMH.DataSource = dt_loaimathang;
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi trong việc truy xuất dữ liệu!");
            }
        }

        private void FormLoaiMatHang_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
