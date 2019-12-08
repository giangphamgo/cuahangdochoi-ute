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
    public partial class FormHDNhapHang : Form
    {
        DB_HDNhapHang db_hoadonnhaphang;
        DataSet ds_hoadonnhaphang;
        DataTable dt_hoadonnhaphang;
        public FormHDNhapHang()
        {
            db_hoadonnhaphang = new DB_HDNhapHang();
            InitializeComponent();
        }

        private void FormHDNhapHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                ds_hoadonnhaphang = db_hoadonnhaphang.GetDaTa();
                dt_hoadonnhaphang = ds_hoadonnhaphang.Tables[0];
                dgv_HDNH.DataSource = dt_hoadonnhaphang;
            }
            catch (SqlException)
            {
                MessageBox.Show("Bạn không có quyền truy xuất");
            }
        }

        private void FormHDNhapHang_Load_1(object sender, EventArgs e)
        {
            LoadData()
;        }
    }
}
