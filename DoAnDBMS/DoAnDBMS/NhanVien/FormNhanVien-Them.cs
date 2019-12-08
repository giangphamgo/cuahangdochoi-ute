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
    public partial class FormNhanVien_Them : Form
    {
        DB_NhanVien db;
        public FormNhanVien_Them()
        {
            db = new DB_NhanVien();
            InitializeComponent();
        }

        private void FormNhanVien_Them_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                txtMa_NV.Clear();
                txtTen_NV.Clear();
                txtCmnd.Clear();
                txtDienThoai.Clear();
                txtNgayLamViec.Clear();
                txtLuong.Clear();
                txtMa_NV.Focus();
            }
            catch
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                //if
                //    (!db.ThemNhanVien
                //        (ref err,
                //        txtMa_NV.Text,
                //        txtTen_NV.Text,
                //        txtCmnd.Text,
                //        txtDienThoai.Text,
                       
                //        DateTime.Parse(txtNgayLamViec.Text),
                //        float.Parse(txtLuong.Text)))
                if(!db.ThemNhanVien(ref err,txtMa_NV.Text,txtTen_NV.Text,txtCmnd.Text,txtDienThoai.Text, DateTime.Parse(txtNgayLamViec.Text), float.Parse(txtLuong.Text)))
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

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtMa_NV.Clear();
            txtTen_NV.Clear();
            txtCmnd.Clear();
            txtDienThoai.Clear();
            txtNgayLamViec.Clear();
            txtLuong.Clear();
            txtMa_NV.Focus();
        }
    }
}
