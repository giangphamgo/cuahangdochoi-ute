namespace DoAnDBMS
{
    partial class FormHDBanHang_Them
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lb_Tien = new System.Windows.Forms.Label();
            this.cbBox_MaKH = new System.Windows.Forms.ComboBox();
            this.cbBox_MaNV = new System.Windows.Forms.ComboBox();
            this.txt_Ngay = new System.Windows.Forms.TextBox();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(225, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 35);
            this.button1.TabIndex = 36;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.AutoSize = true;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Red;
            this.btn_Them.Location = new System.Drawing.Point(15, 232);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(135, 35);
            this.btn_Them.TabIndex = 35;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lb_Tien
            // 
            this.lb_Tien.AutoSize = true;
            this.lb_Tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tien.Location = new System.Drawing.Point(193, 144);
            this.lb_Tien.Name = "lb_Tien";
            this.lb_Tien.Size = new System.Drawing.Size(57, 17);
            this.lb_Tien.TabIndex = 34;
            this.lb_Tien.Text = "Values";
            this.lb_Tien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbBox_MaKH
            // 
            this.cbBox_MaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_MaKH.FormattingEnabled = true;
            this.cbBox_MaKH.Location = new System.Drawing.Point(195, 102);
            this.cbBox_MaKH.Name = "cbBox_MaKH";
            this.cbBox_MaKH.Size = new System.Drawing.Size(173, 21);
            this.cbBox_MaKH.TabIndex = 33;
            // 
            // cbBox_MaNV
            // 
            this.cbBox_MaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_MaNV.FormattingEnabled = true;
            this.cbBox_MaNV.Location = new System.Drawing.Point(194, 60);
            this.cbBox_MaNV.Name = "cbBox_MaNV";
            this.cbBox_MaNV.Size = new System.Drawing.Size(174, 21);
            this.cbBox_MaNV.TabIndex = 32;
            // 
            // txt_Ngay
            // 
            this.txt_Ngay.Location = new System.Drawing.Point(194, 177);
            this.txt_Ngay.Multiline = true;
            this.txt_Ngay.Name = "txt_Ngay";
            this.txt_Ngay.Size = new System.Drawing.Size(175, 29);
            this.txt_Ngay.TabIndex = 31;
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(195, 15);
            this.txt_MaHD.Multiline = true;
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(173, 23);
            this.txt_MaHD.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ngày Xuất Hóa Đơn:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tổng Tiền:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã Khách Hàng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã Nhân Viên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(12, 21);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(158, 17);
            this.lb1.TabIndex = 25;
            this.lb1.Text = "Mã Hóa Đơn Bán Hàng:";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormHDBanHang_Them
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lb_Tien);
            this.Controls.Add(this.cbBox_MaKH);
            this.Controls.Add(this.cbBox_MaNV);
            this.Controls.Add(this.txt_Ngay);
            this.Controls.Add(this.txt_MaHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHDBanHang_Them";
            this.Text = "FormHDBanHang_Them";
            this.Load += new System.EventHandler(this.FormHDBanHang_Them_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lb_Tien;
        private System.Windows.Forms.ComboBox cbBox_MaKH;
        private System.Windows.Forms.ComboBox cbBox_MaNV;
        private System.Windows.Forms.TextBox txt_Ngay;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
    }
}