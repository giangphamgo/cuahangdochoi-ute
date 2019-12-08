namespace DoAnDBMS
{
    partial class FormCTBanHang
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
            this.dgv_CTBH = new System.Windows.Forms.DataGridView();
            this.Ma_CTBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_MH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTBH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_CTBH
            // 
            this.dgv_CTBH.AllowUserToAddRows = false;
            this.dgv_CTBH.AllowUserToDeleteRows = false;
            this.dgv_CTBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CTBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_CTBH,
            this.Ma_MH,
            this.SoLuong});
            this.dgv_CTBH.Location = new System.Drawing.Point(3, 12);
            this.dgv_CTBH.Name = "dgv_CTBH";
            this.dgv_CTBH.ReadOnly = true;
            this.dgv_CTBH.Size = new System.Drawing.Size(496, 160);
            this.dgv_CTBH.TabIndex = 2;
            // 
            // Ma_CTBH
            // 
            this.Ma_CTBH.DataPropertyName = "Ma_CTBH";
            this.Ma_CTBH.HeaderText = "Mã Chi Tiết Bán Hàng";
            this.Ma_CTBH.Name = "Ma_CTBH";
            this.Ma_CTBH.ReadOnly = true;
            this.Ma_CTBH.Width = 150;
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
            // FormCTBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 261);
            this.Controls.Add(this.dgv_CTBH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCTBanHang";
            this.Text = "FormCTBanHang";
            this.Load += new System.EventHandler(this.FormCTBanHang_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTBH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CTBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_CTBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_MH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}