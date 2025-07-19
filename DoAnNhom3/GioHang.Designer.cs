namespace DoAnNhom3
{
    partial class GioHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btxoagiohang = new System.Windows.Forms.Button();
            this.btthanhtoan = new System.Windows.Forms.Button();
            this.dgvgiohang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbtongtien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgiohang)).BeginInit();
            this.SuspendLayout();
            // 
            // btxoagiohang
            // 
            this.btxoagiohang.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btxoagiohang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoagiohang.ForeColor = System.Drawing.Color.Black;
            this.btxoagiohang.Location = new System.Drawing.Point(152, 386);
            this.btxoagiohang.Name = "btxoagiohang";
            this.btxoagiohang.Size = new System.Drawing.Size(127, 45);
            this.btxoagiohang.TabIndex = 14;
            this.btxoagiohang.Text = "Xóa";
            this.btxoagiohang.UseVisualStyleBackColor = false;
            // 
            // btthanhtoan
            // 
            this.btthanhtoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthanhtoan.ForeColor = System.Drawing.Color.Black;
            this.btthanhtoan.Location = new System.Drawing.Point(417, 386);
            this.btthanhtoan.Name = "btthanhtoan";
            this.btthanhtoan.Size = new System.Drawing.Size(114, 45);
            this.btthanhtoan.TabIndex = 13;
            this.btthanhtoan.Text = "Thanh toán";
            this.btthanhtoan.UseVisualStyleBackColor = true;
            this.btthanhtoan.Click += new System.EventHandler(this.btthanhtoan_Click);
            // 
            // dgvgiohang
            // 
            this.dgvgiohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgiohang.Location = new System.Drawing.Point(63, 97);
            this.dgvgiohang.Name = "dgvgiohang";
            this.dgvgiohang.Size = new System.Drawing.Size(570, 148);
            this.dgvgiohang.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Giỏ hàng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tổng tiền";
            // 
            // txbtongtien
            // 
            this.txbtongtien.Location = new System.Drawing.Point(199, 314);
            this.txbtongtien.Name = "txbtongtien";
            this.txbtongtien.Size = new System.Drawing.Size(352, 20);
            this.txbtongtien.TabIndex = 16;
            // 
            // GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbtongtien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btxoagiohang);
            this.Controls.Add(this.btthanhtoan);
            this.Controls.Add(this.dgvgiohang);
            this.Controls.Add(this.label1);
            this.Name = "GioHang";
            this.Size = new System.Drawing.Size(692, 488);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgiohang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btxoagiohang;
        private System.Windows.Forms.Button btthanhtoan;
        private System.Windows.Forms.DataGridView dgvgiohang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbtongtien;
    }
}
