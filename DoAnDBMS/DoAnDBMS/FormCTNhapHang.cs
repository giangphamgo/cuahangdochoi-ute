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
    public partial class FormCTNhapHang : Form
    {
        DB_ChiTietNhapHang db_chitietnhaphang;
        DataSet ds_chitietnhaphang;
        DataTable dt_chitietnhaphang;
        public FormCTNhapHang()
        {
            db_chitietnhaphang = new DB_ChiTietNhapHang();
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                ds_chitietnhaphang = db_chitietnhaphang.GetDaTa();
                dt_chitietnhaphang = ds_chitietnhaphang.Tables[0];
                dgv_CTNH.DataSource = dt_chitietnhaphang;
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi trong việc truy xuất dữ liệu!");
            }
        }

        private void FormCTNhapHang_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
