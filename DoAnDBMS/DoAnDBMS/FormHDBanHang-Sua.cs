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
    public partial class FormHDBanHang_Sua : Form
    {
        DB_KhachHang KH;
        DB_NhanVien NV;
        DB_HDBanHang HD;
        DataSet ds_KH, ds_NV,ds_HD;
        DataTable dt_KH, dt_NV,dt_HD;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                if
                    (!HD.CapNhatHD_BanHang
                        (ref err,
                        txt_MaHD.Text,
                        cbBox_MaNV.SelectedValue.ToString(),
                        cbBox_MaKH.SelectedValue.ToString(),
                        float.Parse(lb_Tien.Text),
                        DateTime.Parse(txt_Ngay.Text)))
                    MessageBox.Show("Lỗi :" + err);
                else

                {
                    MessageBox.Show("Cập Nhật Thành Công");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !!!" + ex);
            }
        }

        public FormHDBanHang_Sua()
        {
            KH = new DB_KhachHang();
            NV = new DB_NhanVien();
            HD = new DB_HDBanHang();
            InitializeComponent();
        }

        private void FormHDBanHang_Sua_Load(object sender, EventArgs e)
        {
            try
            {
                txt_MaHD.Clear();
                txt_Ngay.Clear();
                txt_MaHD.Focus();
                lb_Tien.ResetText();
                //xử lí textbox
                ds_HD = HD.HoaDonTheoMaHD(BienCucBo.Ma_HDBH);
                dt_HD = ds_HD.Tables[0];
                txt_MaHD.DataBindings.Add("Text", dt_HD, "Ma_HDBH");
                txt_Ngay.DataBindings.Add("Text", dt_HD, "NgayXuatHD");
                lb_Tien.DataBindings.Add("Text", dt_HD, "TongTien");
                //xử lí combobox khách hàng
                ds_KH = KH.GetDaTa();
                dt_KH = ds_KH.Tables[0];
                cbBox_MaKH.DataSource = dt_KH.Copy();
                cbBox_MaKH.DisplayMember = "Ten_KH";
                cbBox_MaKH.ValueMember = "Ma_KH";
                string MaKH = dt_HD.Rows[0][2].ToString();

                cbBox_MaKH.SelectedValue = MaKH;
                //xử lí combobox nhân viên
                ds_NV = NV.LayNV();
                dt_NV = ds_NV.Tables[0];
                cbBox_MaNV.DataSource = dt_NV.Copy();
                cbBox_MaNV.DisplayMember = "Ten_NV";
                cbBox_MaNV.ValueMember = "Ma_NV";
                string MaNV = dt_HD.Rows[0][1].ToString();
                cbBox_MaNV.SelectedValue = MaNV;
            }
            catch
            {
                MessageBox.Show("Lỗi nhé!!!!");
            }
        }
    }
}
