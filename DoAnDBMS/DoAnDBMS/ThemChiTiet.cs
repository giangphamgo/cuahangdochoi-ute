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
    public partial class ThemChiTiet : Form
    {
        DB_ChiTietBanHang CT;
        DB_MatHang MH;
        DataSet dsMH, dsGia;
        DataTable dtMH, dtGia;
        float TongTien;
        float GiaMH;
        int SoLuong;

        

        private void txt_SL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_SL.Text == null) SoLuong = 0;
                SoLuong = int.Parse(txt_SL.Text);
                TongTien =float.Parse((GiaMH * SoLuong).ToString());
                lbltongtien.ResetText();
                lbltongtien.Text = TongTien.ToString("N0");
            }
            catch (FormatException)
            {
                SoLuong = 0;
                lbltongtien.Text="0";
            }
        }
        private void cbBox_MaMH_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lblGiaTien.DataBindings.Clear();
            int r = cbBox_MaMH.SelectedIndex;
            string MaMH = dtMH.Rows[r]["Ma_MH"].ToString();
            dsGia = MH.MatHangtheoMaMH(MaMH);
            dtGia = dsGia.Tables[0];
            lblGiaTien.Text = dtGia.Rows[0][5].ToString();
            GiaMH = float.Parse(lblGiaTien.Text.ToString());

            TongTien = GiaMH * SoLuong;
            lbltongtien.ResetText();
            lbltongtien.Text = TongTien.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoLuong = 0;
            txt_SL.ResetText();
            txt_SL.Focus();
            lbltongtien.Text = "0";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                if
                    (!CT.ThemChiTiet_BanHang
                        (ref err,lbl_MaHD.Text,cbBox_MaMH.SelectedValue.ToString(),int.Parse(txt_SL.Text)))
                    MessageBox.Show("Lỗi :" + err);
                else

                {
                    MessageBox.Show("Thêm Thành Công");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !!!" + ex);
            }
        }

        public ThemChiTiet()
        {
            CT = new DB_ChiTietBanHang();
            MH = new DB_MatHang();
            InitializeComponent();
        }

        private void ThemChiTiet_Load(object sender, EventArgs e)
        {
            //Mã hóa đơn
            lbl_MaHD.ResetText();
            lbl_MaHD.Text = BienCucBo.Ma_HDBH;
            //combox mặt hàng
            dsMH = MH.GetDaTa();
            dtMH = dsMH.Tables[0];
            cbBox_MaMH.DataSource = dtMH.Copy();
            cbBox_MaMH.DisplayMember = "Ten_MH";
            cbBox_MaMH.ValueMember = "Ma_MH";
            //Số lượng
            txt_SL.ResetText();
            txt_SL.Focus();
            SoLuong = 0;
            //Giá Tiền
            lblGiaTien.ResetText();
            lblGiaTien.Text = dtMH.Rows[0]["GiaBan"].ToString();
            //Tổng tiền
            dsGia = MH.MatHangtheoMaMH(cbBox_MaMH.SelectedValue.ToString());
            dtGia = dsGia.Tables[0];
            GiaMH = float.Parse(dtGia.Rows[0]["GiaBan"].ToString());
            lbltongtien.Text = TongTien.ToString();
        }
    }
}
