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
    public partial class FormMatHang_Them : Form
    {
        DB_MatHang db_mathang;
        DB_LoaiMatHang db_loaimathang;
        DataSet ds_maloaiMH;
        DataTable dt_maloaiMH;
        public FormMatHang_Them()
        {
            db_mathang = new DB_MatHang();
            db_loaimathang = new DB_LoaiMatHang();
            InitializeComponent();
        }

        private void FormMatHang_Them_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        private void LoadData()
        {
            try
            {
                txt_MaMH.Clear();
                txtTenMatHang.Clear();
                txtSoLuong.Clear();
                txtGiaBan.Clear();
                txtGiaNhap.Clear();
                txtThoiGian.Clear();
                txt_MaMH.Focus();
                ds_maloaiMH = db_loaimathang.GetDaTa();
                dt_maloaiMH = ds_maloaiMH.Tables[0];
                cbbMaloaiMH.DataSource = dt_maloaiMH.Copy();
                cbbMaloaiMH.DisplayMember = "Ten_loaiMH";
                cbbMaloaiMH.ValueMember = "Ma_loaiMH";
            }
            catch(SqlException)
            {
                MessageBox.Show("Lỗi Lấy Dữ Liệu!!!");
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi!!!");
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txt_MaMH.ResetText();
                txtSoLuong.ResetText();
                txtTenMatHang.ResetText();
                txtGiaBan.ResetText();
                txtGiaNhap.ResetText();
                txtThoiGian.ResetText();
                txt_MaMH.Focus();
                ds_maloaiMH = db_loaimathang.GetDaTa();
                dt_maloaiMH = ds_maloaiMH.Tables[0];
                cbbMaloaiMH.DataSource = dt_maloaiMH.Copy();
                cbbMaloaiMH.DisplayMember = "Ten_loaiMH";
                cbbMaloaiMH.ValueMember = "Ma_loaiMH";
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi Lấy Dữ Liệu!!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi!!!");
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            
            try
            {
                string err = "";
                if
                    (!db_mathang.ThemMatHang
                        (ref err,
                        txt_MaMH.Text,
                        cbbMaloaiMH.SelectedValue.ToString(),
                        txtTenMatHang.Text,
                        int.Parse(txtSoLuong.Text),
                        float.Parse(txtGiaNhap.Text),
                        float.Parse(txtGiaBan.Text),
                        DateTime.Parse(txtThoiGian.Text)))
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

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_MaMH_TabIndexChanged(object sender, EventArgs e)
        {
            txtTenMatHang.Focus();
        }
    }
}
