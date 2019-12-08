namespace DoAnDBMS
{
    partial class FormNPP
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
            this.dgvNPP = new System.Windows.Forms.DataGridView();
            this.Ma_NPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_NPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNPP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNPP
            // 
            this.dgvNPP.AllowUserToAddRows = false;
            this.dgvNPP.AllowUserToDeleteRows = false;
            this.dgvNPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNPP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_NPP,
            this.Ten_NPP,
            this.DiaChi,
            this.Email});
            this.dgvNPP.Location = new System.Drawing.Point(3, 12);
            this.dgvNPP.Name = "dgvNPP";
            this.dgvNPP.ReadOnly = true;
            this.dgvNPP.Size = new System.Drawing.Size(443, 182);
            this.dgvNPP.TabIndex = 1;
            // 
            // Ma_NPP
            // 
            this.Ma_NPP.DataPropertyName = "Ma_NPP";
            this.Ma_NPP.HeaderText = "Mã Nhà Phân Phối";
            this.Ma_NPP.Name = "Ma_NPP";
            this.Ma_NPP.ReadOnly = true;
            // 
            // Ten_NPP
            // 
            this.Ten_NPP.DataPropertyName = "Ten_NPP";
            this.Ten_NPP.HeaderText = "Tên Nhà Phân Phối";
            this.Ten_NPP.Name = "Ten_NPP";
            this.Ten_NPP.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // FormNPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 240);
            this.Controls.Add(this.dgvNPP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNPP";
            this.Text = "FormNPP";
            this.Load += new System.EventHandler(this.FormNPP_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNPP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_NPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}