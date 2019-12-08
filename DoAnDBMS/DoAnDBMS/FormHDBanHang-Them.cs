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
    public partial class FormHDBanHang_Them : Form
    {
        DB_KhachHang KH;
        DB_NhanVien NV;
        DB_HDBanHang HD;
        DataSet ds_KH, ds_NV;
        DataTable dt_KH, dt_NV;

        private void button1_Click(object sender, EventArgs e)
        {
            txt_MaHD.Clear();
            txt_Ngay.Clear();
            txt_MaHD.Focus();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                if
                    (!HD.ThemHD_BanHang
                        (ref err,
                        txt_MaHD.Text,
                        cbBox_MaNV.SelectedValue.ToString(),
                        cbBox_MaKH.SelectedValue.ToString(),
                        float.Parse(lb_Tien.Text),
                        DateTime.Parse(txt_Ngay.Text)))
                    MessageBox.Show("Lỗi :" + err);
                else

                {
                    MessageBox.Show("Thêm Thành Công");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !!!"+ex);
            }
        }

        public FormHDBanHang_Them()
        {
            KH = new DB_KhachHang();
            NV = new DB_NhanVien();
            HD = new DB_HDBanHang();
            InitializeComponent();
        }

        private void FormHDBanHang_Them_Load(object sender, EventArgs e)
        {
            try
            {
                txt_MaHD.Clear();
                txt_Ngay.Clear();
                txt_MaHD.Focus();
                lb_Tien.Text = "0";
                //xử lí combobox khách hàng
                ds_KH=KH.GetDaTa();
                dt_KH = ds_KH.Tables[0];
                cbBox_MaKH.DataSource = dt_KH.Copy();
                cbBox_MaKH.DisplayMember = "Ten_KH";
                cbBox_MaKH.ValueMember = "Ma_KH";
                //xử lí combobox nhân viên
                ds_NV = NV.LayNV();
                dt_NV = ds_NV.Tables[0];
                cbBox_MaNV.DataSource = dt_NV.Copy();
                cbBox_MaNV.DisplayMember = "Ten_NV";
                cbBox_MaNV.ValueMember = "Ma_NV";
                DateTime thoigian = DateTime.Now;
                txt_Ngay.Text = thoigian.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi nhé!!!!");
            }
        }
    }
}
