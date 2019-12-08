namespace DoAnDBMS
{
    partial class FormCTNhapHang
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
            this.dgv_CTNH = new System.Windows.Forms.DataGridView();
            this.Ma_HDNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_MH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTNH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_CTNH
            // 
            this.dgv_CTNH.AllowUserToAddRows = false;
            this.dgv_CTNH.AllowUserToDeleteRows = false;
            this.dgv_CTNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CTNH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_HDNH,
            this.Ma_MH,
            this.SoLuong});
            this.dgv_CTNH.Location = new System.Drawing.Point(3, 12);
            this.dgv_CTNH.Name = "dgv_CTNH";
            this.dgv_CTNH.ReadOnly = true;
            this.dgv_CTNH.Size = new System.Drawing.Size(496, 160);
            this.dgv_CTNH.TabIndex = 1;
            // 
            // Ma_HDNH
            // 
            this.Ma_HDNH.DataPropertyName = "Ma_HDNH";
            this.Ma_HDNH.HeaderText = "Mã Hóa Đơn Nhập Hàng";
            this.Ma_HDNH.Name = "Ma_HDNH";
            this.Ma_HDNH.ReadOnly = true;
            this.Ma_HDNH.Width = 150;
            // 
            // Ma_MH
            // 
            this.Ma_MH.DataPropertyName = "Ma_MH";
            this.Ma_MH.HeaderText = "Mã Mặt Hàng";
            this.Ma_MH.Name = "Ma_MH";
            this.Ma_MH.ReadOnly = true;
            this.Ma_MH.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 150;
            // 
            // FormCTNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 242);
            this.Controls.Add(this.dgv_CTNH);
            this.Name = "FormCTNhapHang";
            this.Text = "FormCTNhapHang";
            this.Load += new System.EventHandler(this.FormCTNhapHang_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTNH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CTNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_HDNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_MH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}