using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Layer1;
using System.Data.SqlClient;
namespace DoAnDBMS
{
    public partial class DangNhap : Form
    {
        SqlConnection cnn;
        string Stringcnn;
        string ID, Pass ,wifi;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txt_DangNhap.ResetText();
            txt_MatKhau.ResetText();
            txtIP.ResetText();
            txtIP.Text = Logins.Wifi.ToString();
        }

        private void btn_Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                
                ID = txt_DangNhap.Text.Trim();
                Pass = txt_MatKhau.Text.Trim();
                wifi = txtIP.Text.Trim();
                Stringcnn = "Server=DELL-7490;Database=QuanLyCuaHangDoChoi;User Id="+ID+";Password = "+Pass+";";
                //Stringcnn = "Server =192.168.174.1;User ID=" +ID  + "; Password=" + Pass + ";Integrated Security=True;";
                //Khởi động connection
                cnn = new SqlConnection(Stringcnn);
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                Logins.ID = ID;
                Logins.Pass = Pass;
                this.Visible = false;
                FormMenu Menu = new FormMenu();
                Menu.ShowDialog();
                //bẫy sql
                string que = "SELECT name FROM sys.databases";
                SqlCommand cmd = new SqlCommand(que, cnn);
                SqlDataReader DR = cmd.ExecuteReader();
                //bẫy
            }
            catch(SqlException)
            {
                MessageBox.Show("Đăng Nhập Thất Bại", "Thông báo",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
}
    }
}
