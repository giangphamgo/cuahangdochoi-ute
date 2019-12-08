using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDBMS
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVien NV = new FormNhanVien();
            NV.ShowDialog();
        }

        private void mặtHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormMatHang MH = new FormMatHang();
            MH.ShowDialog();
        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHDBanHang HDBH = new FormHDBanHang();
            HDBH.ShowDialog();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection FC = Application.OpenForms;
            foreach (Form fc in FC)
            {
                fc.Close();
            }
        }

        private void nhàPhânPhốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNPP NPP = new FormNPP();
            NPP.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang.FormKhachHang KH = new KhachHang.FormKhachHang();
            KH.ShowDialog();
        }

        private void chiTiếtNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCTNhapHang CTNH = new FormCTNhapHang();
            CTNH.ShowDialog();
        }

        private void loạiMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoaiMatHang LMH = new FormLoaiMatHang();
            LMH.ShowDialog();
        }

        private void hóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHDNhapHang form = new FormHDNhapHang();
            form.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
