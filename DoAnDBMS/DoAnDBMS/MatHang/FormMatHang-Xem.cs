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
    public partial class FormMatHang_Xem : Form
    {
        DB_MatHang db;
        DataSet ds_mathang;
        DataTable dt_mathang ;
        public FormMatHang_Xem()
        {
            db = new DB_MatHang();
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMatHang_Xem_Load(object sender, EventArgs e)
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
                lblMaMatHang.ResetText();
                lblMaLoaiMatHang.ResetText();
                lblSoLuong.ResetText();
                lblTenMatHang.ResetText();
                lblGiaBan.ResetText();
                lblGiaNhap.ResetText();
                lblThoiGian.ResetText();
                //binding
                lblMaMatHang.DataBindings.Add("Text", dt_mathang, "Ma_MH");
                lblTenMatHang.DataBindings.Add("Text", dt_mathang, "Ten_MH");
                lblSoLuong.DataBindings.Add("Text", dt_mathang, "SoLuong");
                lblGiaNhap.DataBindings.Add("Text", dt_mathang, "GiaNhap");
                lblGiaBan.DataBindings.Add("Text", dt_mathang, "GiaBan");
                lblThoiGian.DataBindings.Add("Text", dt_mathang, "ThoiGianBaoHanh");
                lblMaLoaiMatHang.DataBindings.Add("Text", dt_mathang, "Ma_loaiMH");
            }
           catch
            {
                MessageBox.Show("Lỗi Rồi!!!");
            }
        }
    }
}
