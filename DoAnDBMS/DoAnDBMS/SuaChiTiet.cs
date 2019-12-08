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
    public partial class SuaChiTiet : Form
    {
        DB_MatHang MH;
        DB_ChiTietBanHang CT;
        DataSet dsMH, dsCT;
        DataTable dtMH, dtCT;
        float GiaTien; int SoLuong;
        int pop;
        public SuaChiTiet()
        {
            MH = new DB_MatHang();
            CT = new DB_ChiTietBanHang();
            InitializeComponent();
        }

        private void txt_SL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_SL.Text == null) SoLuong = pop;
                SoLuong = int.Parse(txt_SL.Text);
                float TongTien = float.Parse((GiaTien * SoLuong).ToString());
                lblTienMoi.ResetText();
                lblTienMoi.Text = TongTien.ToString("N0");
            }
            catch (FormatException)
            {
                SoLuong = pop;
                lblTienMoi.Text = lblTiencu.Text.ToString();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                if
                    (!CT.CapNhatChiTiet_BanHang
                        (ref err, BienCucBo.Ma_HD2, BienCucBo.Ma_MH2, SoLuong))
                    MessageBox.Show("Lỗi :" + err);
                else

                {
                    MessageBox.Show("Sửa Thành Công");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !!!" + ex);
            }
        }

        private void SuaChiTiet_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            //Mã hóa đơn
            lbl_MaHD.ResetText();
            lbl_MaHD.Text = BienCucBo.Ma_HD2;
            //Mã MH
            lblMH.ResetText();
            dsMH = MH.MatHangtheoMaMH(BienCucBo.Ma_MH2);
            dtMH = dsMH.Tables[0];
            string TenMH = dtMH.Rows[0]["Ten_MH"].ToString();
            lblMH.Text = TenMH;
            //Giá 1 MH
            GiaTien =float.Parse( dtMH.Rows[0]["GiaBan"].ToString());
            lblGiaTien.Text = GiaTien.ToString("N0");
            //Số lượng
            dsCT = CT.ChitietTheoMaHDvsMaHD(BienCucBo.Ma_HD2, BienCucBo .Ma_MH2);
            dtCT = dsCT.Tables[0];
            txt_SL.Text = dtCT.Rows[0]["SoLuong"].ToString();
            pop = int.Parse(dtCT.Rows[0]["SoLuong"].ToString());
            //Giá trị cũ
            lblTiencu.Text = (int.Parse(txt_SL.Text) * GiaTien).ToString("N0");
            lblTienMoi.Text = lblTiencu.Text;
        }
    }
}
