namespace DoAnDBMS
{
    partial class FormHDBanHang
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
            this.btn_XoaCTHD = new System.Windows.Forms.Button();
            this.btn_SuaCTHD = new System.Windows.Forms.Button();
            this.btn_ThemCTHD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Ngay = new System.Windows.Forms.Label();
            this.lbl_MaHD = new System.Windows.Forms.Label();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.lbl_MaKH = new System.Windows.Forms.Label();
            this.lbl_Tien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.btn_XoaHD = new System.Windows.Forms.Button();
            this.btn_Loc = new System.Windows.Forms.DataGridView();
            this.Ma_HDBH_CT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_MH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.Ma_HDBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_SuaHD = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Loc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_XoaCTHD
            // 
            this.btn_XoaCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaCTHD.ForeColor = System.Drawing.Color.Red;
            this.btn_XoaCTHD.Location = new System.Drawing.Point(569, 129);
            this.btn_XoaCTHD.Name = "btn_XoaCTHD";
            this.btn_XoaCTHD.Size = new System.Drawing.Size(106, 102);
            this.btn_XoaCTHD.TabIndex = 31;
            this.btn_XoaCTHD.Text = "Xóa Chi Tiết Hóa Đơn";
            this.btn_XoaCTHD.UseVisualStyleBackColor = true;
            this.btn_XoaCTHD.Click += new System.EventHandler(this.btn_XoaCTHD_Click);
            // 
            // btn_SuaCTHD
            // 
            this.btn_SuaCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaCTHD.ForeColor = System.Drawing.Color.Red;
            this.btn_SuaCTHD.Location = new System.Drawing.Point(569, 73);
            this.btn_SuaCTHD.Name = "btn_SuaCTHD";
            this.btn_SuaCTHD.Size = new System.Drawing.Size(106, 50);
            this.btn_SuaCTHD.TabIndex = 30;
            this.btn_SuaCTHD.Text = "Sửa Hóa Đơn";
            this.btn_SuaCTHD.UseVisualStyleBackColor = true;
            this.btn_SuaCTHD.Click += new System.EventHandler(this.btn_SuaCTHD_Click);
            // 
            // btn_ThemCTHD
            // 
            this.btn_ThemCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemCTHD.ForeColor = System.Drawing.Color.Red;
            this.btn_ThemCTHD.Location = new System.Drawing.Point(569, 16);
            this.btn_ThemCTHD.Name = "btn_ThemCTHD";
            this.btn_ThemCTHD.Size = new System.Drawing.Size(106, 50);
            this.btn_ThemCTHD.TabIndex = 29;
            this.btn_ThemCTHD.Text = "Thêm Chi Tiết HD";
            this.btn_ThemCTHD.UseVisualStyleBackColor = true;
            this.btn_ThemCTHD.Click += new System.EventHandler(this.btn_ThemCTHD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Ngay);
            this.groupBox1.Controls.Add(this.lbl_MaHD);
            this.groupBox1.Controls.Add(this.lbl_MaNV);
            this.groupBox1.Controls.Add(this.lbl_MaKH);
            this.groupBox1.Controls.Add(this.lbl_Tien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 227);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết";
            // 
            // lbl_Ngay
            // 
            this.lbl_Ngay.AutoSize = true;
            this.lbl_Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ngay.ForeColor = System.Drawing.Color.Black;
            this.lbl_Ngay.Location = new System.Drawing.Point(193, 190);
            this.lbl_Ngay.Name = "lbl_Ngay";
            this.lbl_Ngay.Size = new System.Drawing.Size(57, 17);
            this.lbl_Ngay.TabIndex = 16;
            this.lbl_Ngay.Text = "Values";
            this.lbl_Ngay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_MaHD
            // 
            this.lbl_MaHD.AutoSize = true;
            this.lbl_MaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaHD.ForeColor = System.Drawing.Color.Black;
            this.lbl_MaHD.Location = new System.Drawing.Point(193, 22);
            this.lbl_MaHD.Name = "lbl_MaHD";
            this.lbl_MaHD.Size = new System.Drawing.Size(57, 17);
            this.lbl_MaHD.TabIndex = 15;
            this.lbl_MaHD.Text = "Values";
            this.lbl_MaHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNV.ForeColor = System.Drawing.Color.Black;
            this.lbl_MaNV.Location = new System.Drawing.Point(193, 61);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(57, 17);
            this.lbl_MaNV.TabIndex = 14;
            this.lbl_MaNV.Text = "Values";
            this.lbl_MaNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_MaKH
            // 
            this.lbl_MaKH.AutoSize = true;
            this.lbl_MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaKH.ForeColor = System.Drawing.Color.Black;
            this.lbl_MaKH.Location = new System.Drawing.Point(193, 103);
            this.lbl_MaKH.Name = "lbl_MaKH";
            this.lbl_MaKH.Size = new System.Drawing.Size(57, 17);
            this.lbl_MaKH.TabIndex = 13;
            this.lbl_MaKH.Text = "Values";
            this.lbl_MaKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Tien
            // 
            this.lbl_Tien.AutoSize = true;
            this.lbl_Tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tien.ForeColor = System.Drawing.Color.Black;
            this.lbl_Tien.Location = new System.Drawing.Point(193, 145);
            this.lbl_Tien.Name = "lbl_Tien";
            this.lbl_Tien.Size = new System.Drawing.Size(57, 17);
            this.lbl_Tien.TabIndex = 12;
            this.lbl_Tien.Text = "Values";
            this.lbl_Tien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Xuất Hóa Đơn:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng Tiền:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Khách Hàng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Black;
            this.lb1.Location = new System.Drawing.Point(12, 22);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(158, 17);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Mã Hóa Đơn Bán Hàng:";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_XoaHD
            // 
            this.btn_XoaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaHD.ForeColor = System.Drawing.Color.Red;
            this.btn_XoaHD.Location = new System.Drawing.Point(396, 189);
            this.btn_XoaHD.Name = "btn_XoaHD";
            this.btn_XoaHD.Size = new System.Drawing.Size(106, 50);
            this.btn_XoaHD.TabIndex = 27;
            this.btn_XoaHD.Text = "Xóa Hóa Đơn";
            this.btn_XoaHD.UseVisualStyleBackColor = true;
            this.btn_XoaHD.Click += new System.EventHandler(this.btn_XoaHD_Click);
            // 
            // btn_Loc
            // 
            this.btn_Loc.AllowUserToAddRows = false;
            this.btn_Loc.AllowUserToDeleteRows = false;
            this.btn_Loc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.btn_Loc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_HDBH_CT,
            this.Ma_MH,
            this.SL});
            this.btn_Loc.Location = new System.Drawing.Point(678, 16);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.ReadOnly = true;
            this.btn_Loc.Size = new System.Drawing.Size(345, 215);
            this.btn_Loc.TabIndex = 26;
            this.btn_Loc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTiet_CellClick);
            // 
            // Ma_HDBH_CT
            // 
            this.Ma_HDBH_CT.DataPropertyName = "Ma_HDBH";
            this.Ma_HDBH_CT.HeaderText = "Mã Hóa Đơn Bán Hàng";
            this.Ma_HDBH_CT.Name = "Ma_HDBH_CT";
            this.Ma_HDBH_CT.ReadOnly = true;
            // 
            // Ma_MH
            // 
            this.Ma_MH.DataPropertyName = "Ma_MH";
            this.Ma_MH.HeaderText = "Mã Mặt Hàng";
            this.Ma_MH.Name = "Ma_MH";
            this.Ma_MH.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SoLuong";
            this.SL.HeaderText = "Số Lượng";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.AllowUserToAddRows = false;
            this.dgv_HoaDon.AllowUserToDeleteRows = false;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_HDBH,
            this.Ma_NV,
            this.Ma_KH,
            this.NgayXuat});
            this.dgv_HoaDon.Location = new System.Drawing.Point(23, 250);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.ReadOnly = true;
            this.dgv_HoaDon.Size = new System.Drawing.Size(1003, 262);
            this.dgv_HoaDon.TabIndex = 25;
            this.dgv_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_CellClick);
            // 
            // Ma_HDBH
            // 
            this.Ma_HDBH.DataPropertyName = "Ma_HDBH";
            this.Ma_HDBH.HeaderText = "Mã Hóa Đơn Bán Hàng";
            this.Ma_HDBH.Name = "Ma_HDBH";
            this.Ma_HDBH.ReadOnly = true;
            this.Ma_HDBH.Width = 240;
            // 
            // Ma_NV
            // 
            this.Ma_NV.DataPropertyName = "Ma_NV";
            this.Ma_NV.HeaderText = "Mã Nhân Viên";
            this.Ma_NV.Name = "Ma_NV";
            this.Ma_NV.ReadOnly = true;
            this.Ma_NV.Width = 240;
            // 
            // Ma_KH
            // 
            this.Ma_KH.DataPropertyName = "Ma_KH";
            this.Ma_KH.HeaderText = "Mã Khách Hàng";
            this.Ma_KH.Name = "Ma_KH";
            this.Ma_KH.ReadOnly = true;
            this.Ma_KH.Width = 240;
            // 
            // NgayXuat
            // 
            this.NgayXuat.DataPropertyName = "NgayXuatHD";
            this.NgayXuat.HeaderText = "Ngày Xuất Hóa Đơn";
            this.NgayXuat.Name = "NgayXuat";
            this.NgayXuat.ReadOnly = true;
            this.NgayXuat.Width = 240;
            // 
            // btn_SuaHD
            // 
            this.btn_SuaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaHD.ForeColor = System.Drawing.Color.Red;
            this.btn_SuaHD.Location = new System.Drawing.Point(396, 72);
            this.btn_SuaHD.Name = "btn_SuaHD";
            this.btn_SuaHD.Size = new System.Drawing.Size(106, 50);
            this.btn_SuaHD.TabIndex = 24;
            this.btn_SuaHD.Text = "Sửa Hóa Đơn";
            this.btn_SuaHD.UseVisualStyleBackColor = true;
            this.btn_SuaHD.Click += new System.EventHandler(this.btn_SuaHD_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Red;
            this.btn_Them.Location = new System.Drawing.Point(396, 16);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(106, 50);
            this.btn_Them.TabIndex = 23;
            this.btn_Them.Text = "Thêm Hóa Đơn";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(396, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 50);
            this.button1.TabIndex = 32;
            this.button1.Text = "Lọc Hóa Đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormHDBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_XoaCTHD);
            this.Controls.Add(this.btn_SuaCTHD);
            this.Controls.Add(this.btn_ThemCTHD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_XoaHD);
            this.Controls.Add(this.btn_Loc);
            this.Controls.Add(this.dgv_HoaDon);
            this.Controls.Add(this.btn_SuaHD);
            this.Controls.Add(this.btn_Them);
            this.Name = "FormHDBanHang";
            this.Text = "FormHDBanHang";
            this.Load += new System.EventHandler(this.FormHDBanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Loc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_XoaCTHD;
        private System.Windows.Forms.Button btn_SuaCTHD;
        private System.Windows.Forms.Button btn_ThemCTHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Tien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btn_XoaHD;
        private System.Windows.Forms.DataGridView btn_Loc;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.Button btn_SuaHD;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lbl_Ngay;
        private System.Windows.Forms.Label lbl_MaHD;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.Label lbl_MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_HDBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_HDBH_CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_MH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.Button button1;
    }
}