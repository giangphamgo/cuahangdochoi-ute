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
namespace DoAnDBMS
{
    public partial class FormNhanVien_Sua : Form
    {
        DB_NhanVien db;
        DataSet ds_nhanvien;
        DataTable dt_nhanvien;
        public FormNhanVien_Sua()
        {
            db = new DB_NhanVien();
            InitializeComponent();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                if(!db.CapNhapNhanVien(ref err, txtMa_NV.Text, txtTen_NV.Text, txtCmnd.Text, txtDienThoai.Text, DateTime.Parse(txtNgayLamViec.Text), float.Parse(txtLuong.Text)))
                    MessageBox.Show("Lỗi :" + err);
                else
                {
                    MessageBox.Show("Thêm Thành Công");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi!!! Thử Lại Lần Sau. ");
            }
        }

        private void FormNhanVien_Sua_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                //Get Data
                ds_nhanvien = db.NhanVientheoMaNV(BienCucBo.Ma_NV);
                dt_nhanvien = ds_nhanvien.Tables[0];
                //Clear 
                txtMa_NV.Clear();
                txtTen_NV.Clear();
                txtCmnd.Clear();
                txtDienThoai.Clear();
                txtNgayLamViec.Clear();
                txtLuong.Clear();
                txtTen_NV.Focus();
                //Binding
                txtMa_NV.DataBindings.Add("Text", dt_nhanvien, "Ma_NV");
                txtTen_NV.DataBindings.Add("Text", dt_nhanvien, "Ten_NV");
                txtCmnd.DataBindings.Add("Text", dt_nhanvien, "Cmnd");
                txtDienThoai.DataBindings.Add("Text", dt_nhanvien, "DienThoai");
                txtNgayLamViec.DataBindings.Add("Text", dt_nhanvien, "Ngay_LamViec");
                txtLuong.DataBindings.Add("Text", dt_nhanvien, "Luong");
            }
            catch
            {
                MessageBox.Show("Lỗi trong việc lấy dữ liệu!!!");
            }

        }
    }
}
