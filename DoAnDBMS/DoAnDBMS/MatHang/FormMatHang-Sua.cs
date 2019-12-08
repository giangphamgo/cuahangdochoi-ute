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
    public partial class FormMatHang_Sua : Form
    {
        
        DB_MatHang db;
        DB_LoaiMatHang db_loaimathang;
        DataSet ds_mathang, ds_maloaiMH;
        DataTable dt_mathang, dt_maloaiMH;
        public FormMatHang_Sua()
        {
            db = new DB_MatHang();
            db_loaimathang = new DB_LoaiMatHang();
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            try
            {
                string err = " ";
                if
                    (!db.CapNhatMatHang
                        (ref err,
                        txt_MaMH.Text,
                        cbbMaloaiMH.SelectedValue.ToString(),
                        txtTenMatHang.Text,
                        int.Parse(txtSoLuong.Text),
                        float.Parse(txtGiaNhap.Text),
                        float.Parse(txtGiaBan.Text),
                        DateTime.Parse(txtThoiGian.Text)))
                    MessageBox.Show("Lỗi :"+err);
                else
                {
                    MessageBox.Show("Cập Nhật Thành Công");
                    BienCucBo.Ma_MH = null;
                    this.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi!!! Thử Lại Lần Sau.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMatHang_Sua_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                
                //datatable 
                ds_mathang = db.MatHangtheoMaMH(BienCucBo.Ma_MH);
                dt_mathang = ds_mathang.Tables[0];
                //clear
                txt_MaMH.Clear();
                txtTenMatHang.Clear();
                txtSoLuong.Clear();
                txtGiaBan.Clear();
                txtGiaNhap.Clear();
                txtThoiGian.Clear();
                //binding
                txt_MaMH.DataBindings.Add("Text", dt_mathang, "Ma_MH");
                txtTenMatHang.DataBindings.Add("Text", dt_mathang, "Ten_MH");
                txtSoLuong.DataBindings.Add("Text", dt_mathang, "SoLuong");
                txtGiaNhap.DataBindings.Add("Text", dt_mathang, "GiaNhap");
                txtGiaBan.DataBindings.Add("Text", dt_mathang, "GiaBan");
                txtThoiGian.DataBindings.Add("Text", dt_mathang, "ThoiGianBaoHanh");
                //combobox
                
                ds_maloaiMH = db_loaimathang.GetDaTa();
                dt_maloaiMH = ds_maloaiMH.Tables[0];
                cbbMaloaiMH.DataSource = dt_maloaiMH.Copy();
                cbbMaloaiMH.DisplayMember = "Ten_loaiMH";
                cbbMaloaiMH.ValueMember = "Ma_loaiMH";
                string Ma_loaiMH = dt_mathang.Rows[0][1].ToString();

                cbbMaloaiMH.SelectedValue = Ma_loaiMH;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }
    }
}
