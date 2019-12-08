namespace DoAnDBMS
{
    partial class FormLoaiMatHang
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
            this.dgv_LoaiMH = new System.Windows.Forms.DataGridView();
            this.Ma_LoaiMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_LoaiMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiMH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LoaiMH
            // 
            this.dgv_LoaiMH.AllowUserToAddRows = false;
            this.dgv_LoaiMH.AllowUserToDeleteRows = false;
            this.dgv_LoaiMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_LoaiMH,
            this.Ten_LoaiMH});
            this.dgv_LoaiMH.Location = new System.Drawing.Point(2, 12);
            this.dgv_LoaiMH.Name = "dgv_LoaiMH";
            this.dgv_LoaiMH.ReadOnly = true;
            this.dgv_LoaiMH.Size = new System.Drawing.Size(286, 150);
            this.dgv_LoaiMH.TabIndex = 1;
            // 
            // Ma_LoaiMH
            // 
            this.Ma_LoaiMH.DataPropertyName = "Ma_LoaiMH";
            this.Ma_LoaiMH.HeaderText = "Mã Loại Mặt Hàng";
            this.Ma_LoaiMH.Name = "Ma_LoaiMH";
            this.Ma_LoaiMH.ReadOnly = true;
            this.Ma_LoaiMH.Width = 120;
            // 
            // Ten_LoaiMH
            // 
            this.Ten_LoaiMH.DataPropertyName = "Ten_LoaiMH";
            this.Ten_LoaiMH.HeaderText = "Tên Loại Mặt Hàng";
            this.Ten_LoaiMH.Name = "Ten_LoaiMH";
            this.Ten_LoaiMH.ReadOnly = true;
            this.Ten_LoaiMH.Width = 120;
            // 
            // FormLoaiMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 219);
            this.Controls.Add(this.dgv_LoaiMH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoaiMatHang";
            this.Text = "FormLoaiMatHang";
            this.Load += new System.EventHandler(this.FormLoaiMatHang_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiMH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LoaiMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_LoaiMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_LoaiMH;
    }
}