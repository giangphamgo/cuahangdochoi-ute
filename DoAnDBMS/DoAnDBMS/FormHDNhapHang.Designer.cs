namespace DoAnDBMS
{
    partial class FormHDNhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_HDNH = new System.Windows.Forms.DataGridView();
            this.Ma_HDNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_NPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuatHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDNH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_HDNH
            // 
            this.dgv_HDNH.AllowUserToAddRows = false;
            this.dgv_HDNH.AllowUserToDeleteRows = false;
            this.dgv_HDNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HDNH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_HDNH,
            this.Ma_NV,
            this.Ma_NPP,
            this.TongTien,
            this.NgayXuatHD});
            this.dgv_HDNH.Location = new System.Drawing.Point(2, 12);
            this.dgv_HDNH.Name = "dgv_HDNH";
            this.dgv_HDNH.ReadOnly = true;
            this.dgv_HDNH.Size = new System.Drawing.Size(793, 150);
            this.dgv_HDNH.TabIndex = 1;
            // 
            // Ma_HDNH
            // 
            this.Ma_HDNH.DataPropertyName = "Ma_HDNH";
            this.Ma_HDNH.HeaderText = "Mã Hóa Đơn Nhập Hàng";
            this.Ma_HDNH.Name = "Ma_HDNH";
            this.Ma_HDNH.ReadOnly = true;
            this.Ma_HDNH.Width = 150;
            // 
            // Ma_NV
            // 
            this.Ma_NV.DataPropertyName = "Ma_NV";
            this.Ma_NV.HeaderText = "Mã Nhân Viên";
            this.Ma_NV.Name = "Ma_NV";
            this.Ma_NV.ReadOnly = true;
            this.Ma_NV.Width = 150;
            // 
            // Ma_NPP
            // 
            this.Ma_NPP.DataPropertyName = "Ma_NPP";
            this.Ma_NPP.HeaderText = "Mã Nhà Phân Phối";
            this.Ma_NPP.Name = "Ma_NPP";
            this.Ma_NPP.ReadOnly = true;
            this.Ma_NPP.Width = 150;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 150;
            // 
            // NgayXuatHD
            // 
            this.NgayXuatHD.DataPropertyName = "NgayXuatHD";
            this.NgayXuatHD.HeaderText = "Ngày Xuất Hóa Đơn";
            this.NgayXuatHD.Name = "NgayXuatHD";
            this.NgayXuatHD.ReadOnly = true;
            this.NgayXuatHD.Width = 150;
            // 
            // FormHDNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 249);
            this.Controls.Add(this.dgv_HDNH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHDNhapHang";
            this.Text = "FormHDNhapHang";
            this.Load += new System.EventHandler(this.FormHDNhapHang_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDNH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_HDNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_HDNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuatHD;
    }
}