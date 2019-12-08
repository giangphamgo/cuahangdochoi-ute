namespace DoAnDBMS
{
    partial class FormMatHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_MatHang = new System.Windows.Forms.DataGridView();
            this.Ma_MH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_loaiMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_MH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.BtnLoc = new System.Windows.Forms.Button();
            this.btnXoaMatHang = new System.Windows.Forms.Button();
            this.btnCapNhatMatHang = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btn_ThemMatHang = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MatHang)).BeginInit();
            this.groupbox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_MatHang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 433);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ Liệu";
            // 
            // dgv_MatHang
            // 
            this.dgv_MatHang.AllowUserToAddRows = false;
            this.dgv_MatHang.AllowUserToDeleteRows = false;
            this.dgv_MatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_MH,
            this.Ma_loaiMH,
            this.Ten_MH,
            this.SoLuong,
            this.GiaNhap,
            this.GiaBan,
            this.ThoiGianBaoHanh});
            this.dgv_MatHang.Location = new System.Drawing.Point(8, 19);
            this.dgv_MatHang.Name = "dgv_MatHang";
            this.dgv_MatHang.ReadOnly = true;
            this.dgv_MatHang.Size = new System.Drawing.Size(644, 406);
            this.dgv_MatHang.TabIndex = 1;
            this.dgv_MatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_MatHang_CellClick);
            // 
            // Ma_MH
            // 
            this.Ma_MH.DataPropertyName = "Ma_MH";
            this.Ma_MH.HeaderText = "Mã Mặt Hàng";
            this.Ma_MH.Name = "Ma_MH";
            this.Ma_MH.ReadOnly = true;
            // 
            // Ma_loaiMH
            // 
            this.Ma_loaiMH.DataPropertyName = "Ma_loaiMH";
            this.Ma_loaiMH.HeaderText = "Mã Loại Mặt Hàng";
            this.Ma_loaiMH.Name = "Ma_loaiMH";
            this.Ma_loaiMH.ReadOnly = true;
            // 
            // Ten_MH
            // 
            this.Ten_MH.DataPropertyName = "Ten_MH";
            this.Ten_MH.HeaderText = "Tên Mặt Hàng";
            this.Ten_MH.Name = "Ten_MH";
            this.Ten_MH.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá Nhập";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // ThoiGianBaoHanh
            // 
            this.ThoiGianBaoHanh.DataPropertyName = "ThoiGianBaoHanh";
            this.ThoiGianBaoHanh.HeaderText = "Thời Gian Bảo Hành";
            this.ThoiGianBaoHanh.Name = "ThoiGianBaoHanh";
            this.ThoiGianBaoHanh.ReadOnly = true;
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.groupBox3);
            this.groupbox2.Controls.Add(this.btnXoaMatHang);
            this.groupbox2.Controls.Add(this.BtnLoc);
            this.groupbox2.Controls.Add(this.btnCapNhatMatHang);
            this.groupbox2.Controls.Add(this.btnXem);
            this.groupbox2.Controls.Add(this.btn_ThemMatHang);
            this.groupbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox2.Location = new System.Drawing.Point(676, 12);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(222, 433);
            this.groupbox2.TabIndex = 2;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "Phím Chức Năng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.cbbTimKiem);
            this.groupBox3.Location = new System.Drawing.Point(6, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 92);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Location = new System.Drawing.Point(6, 23);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(198, 24);
            this.cbbTimKiem.TabIndex = 2;
            // 
            // BtnLoc
            // 
            this.BtnLoc.ForeColor = System.Drawing.Color.Red;
            this.BtnLoc.Location = new System.Drawing.Point(13, 316);
            this.BtnLoc.Name = "BtnLoc";
            this.BtnLoc.Size = new System.Drawing.Size(203, 40);
            this.BtnLoc.TabIndex = 1;
            this.BtnLoc.Text = "Lọc Mặt Hàng";
            this.BtnLoc.UseVisualStyleBackColor = true;
            this.BtnLoc.Click += new System.EventHandler(this.BtnLoc_Click);
            // 
            // btnXoaMatHang
            // 
            this.btnXoaMatHang.ForeColor = System.Drawing.Color.Red;
            this.btnXoaMatHang.Location = new System.Drawing.Point(13, 362);
            this.btnXoaMatHang.Name = "btnXoaMatHang";
            this.btnXoaMatHang.Size = new System.Drawing.Size(203, 63);
            this.btnXoaMatHang.TabIndex = 3;
            this.btnXoaMatHang.Text = "Xóa Mặt Hàng";
            this.btnXoaMatHang.UseVisualStyleBackColor = true;
            this.btnXoaMatHang.Click += new System.EventHandler(this.BtnXoaMatHang_Click);
            // 
            // btnCapNhatMatHang
            // 
            this.btnCapNhatMatHang.ForeColor = System.Drawing.Color.Red;
            this.btnCapNhatMatHang.Location = new System.Drawing.Point(6, 84);
            this.btnCapNhatMatHang.Name = "btnCapNhatMatHang";
            this.btnCapNhatMatHang.Size = new System.Drawing.Size(210, 56);
            this.btnCapNhatMatHang.TabIndex = 2;
            this.btnCapNhatMatHang.Text = "Sửa Nội Dung Mặt Hàng";
            this.btnCapNhatMatHang.UseVisualStyleBackColor = true;
            this.btnCapNhatMatHang.Click += new System.EventHandler(this.BtnCapNhatMatHang_Click);
            // 
            // btnXem
            // 
            this.btnXem.ForeColor = System.Drawing.Color.Red;
            this.btnXem.Location = new System.Drawing.Point(6, 22);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(210, 56);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem Nội Dung Mặt Hàng";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.BtnXem_Click);
            // 
            // btn_ThemMatHang
            // 
            this.btn_ThemMatHang.ForeColor = System.Drawing.Color.Red;
            this.btn_ThemMatHang.Location = new System.Drawing.Point(6, 156);
            this.btn_ThemMatHang.Name = "btn_ThemMatHang";
            this.btn_ThemMatHang.Size = new System.Drawing.Size(210, 56);
            this.btn_ThemMatHang.TabIndex = 0;
            this.btn_ThemMatHang.Text = "Thêm Mặt Hàng";
            this.btn_ThemMatHang.UseVisualStyleBackColor = true;
            this.btn_ThemMatHang.Click += new System.EventHandler(this.Btn_ThemMatHang_Click);
            // 
            // FormMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 463);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mặt Hàng";
            this.Load += new System.EventHandler(this.FormMatHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MatHang)).EndInit();
            this.groupbox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_MatHang;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.Button btnXoaMatHang;
        private System.Windows.Forms.Button btnCapNhatMatHang;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btn_ThemMatHang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.Button BtnLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_MH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_loaiMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_MH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBaoHanh;
    }
}

