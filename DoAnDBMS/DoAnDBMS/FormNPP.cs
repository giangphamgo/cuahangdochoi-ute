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
    public partial class FormNPP : Form
    {
        DB_NhaPhanPhoi db_nhaphanphoi;
        DataSet ds_nhaphanphoi;
        DataTable dt_nhaphanphoi;
        public FormNPP()
        {
            db_nhaphanphoi = new DB_NhaPhanPhoi();
            InitializeComponent();
        }

        private void FormNPP_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                ds_nhaphanphoi = db_nhaphanphoi.GetDaTa();
                dt_nhaphanphoi = ds_nhaphanphoi.Tables[0];
                dgvNPP.DataSource = dt_nhaphanphoi;
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi trong việc truy xuất dữ liệu!");
            }
        }

        private void FormNPP_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
