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

namespace DoAnDBMS.KhachHang
{
    public partial class FormKhachHang_Sua : Form
    {
        DB_KhachHang db;
        DataSet ds_khachhang;
        DataTable dt_khachhang;
        public FormKhachHang_Sua()
        {
            //cnn = new SqlConnection(StringCnn);
            //cmd = cnn.CreateCommand();
            db = new DB_KhachHang();
            dt_khachhang = new DataTable();
            InitializeComponent();
        }
        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadData()
        {
            try
            {
                //mở conn
                //if (cnn.State == ConnectionState.Open)
                //    cnn.Close();
                //cnn.Open();
                //adp = new SqlDataAdapter("Select * From MatHang Where Ma_MH =  '" + BienCucBo.Ma_MH + "' ", cnn);
                //adp.Fill(dt_khachhang);
                //datatable 
                ds_khachhang = db.KhachHangtheoMaKH(BienCucBo.Ma_KH);
                dt_khachhang = ds_khachhang.Tables[0];
                //clear
                txt_MaKH.Clear();
                txt_TenKH.Clear();
                txtDiaChi.Clear();
                txtDT.Clear();
                txtEmail.Clear();

                //binding
                txt_MaKH.DataBindings.Add("Text", dt_khachhang, "Ma_KH");
                txt_TenKH.DataBindings.Add("Text", dt_khachhang, "Ten_KH");
                txtDiaChi.DataBindings.Add("Text", dt_khachhang, "DiaChi");
                txtDT.DataBindings.Add("Text", dt_khachhang, "DienThoai");
                txtEmail.DataBindings.Add("Text", dt_khachhang, "Email");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void FormKhachHang_Sua_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {

            try
            {
                string err = " ";
                if
                    (!db.CapNhatKhachHang
                        (ref err,
                        txt_MaKH.Text,
                        txt_TenKH.Text,
                        txtDiaChi.Text,
                        txtDT.Text,
                        txtEmail.Text))
                    MessageBox.Show("Lỗi Cập Nhât Khách Hàng");
                else
                    MessageBox.Show("Cập Nhật Thành Công!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi!!! Thử Lại Lần Sau.");
            }
        }
    }
}
