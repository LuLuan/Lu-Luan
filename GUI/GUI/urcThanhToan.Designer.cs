﻿namespace GUI
{
    partial class urcThanhToan
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
      this.txtTienKhachDua = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtTienTraLai = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtMaTheKhachHang = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtMaNhanVien = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.ckbXuatHoaDon = new System.Windows.Forms.CheckBox();
      this.ckbGiaoHang = new System.Windows.Forms.CheckBox();
      this.ckbKhachHangVangLai = new System.Windows.Forms.CheckBox();
      this.lblTenKhachHang = new System.Windows.Forms.Label();
      this.picTick = new System.Windows.Forms.PictureBox();
      this.btnHuyBoThanhToan = new System.Windows.Forms.Button();
      this.btnXacNhanThanhToan = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.picTick)).BeginInit();
      this.SuspendLayout();
      // 
      // txtTienKhachDua
      // 
      this.txtTienKhachDua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtTienKhachDua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtTienKhachDua.ForeColor = System.Drawing.SystemColors.WindowFrame;
      this.txtTienKhachDua.Location = new System.Drawing.Point(255, 282);
      this.txtTienKhachDua.Name = "txtTienKhachDua";
      this.txtTienKhachDua.Size = new System.Drawing.Size(286, 30);
      this.txtTienKhachDua.TabIndex = 66;
      this.txtTienKhachDua.Text = "000";
      this.txtTienKhachDua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.txtTienKhachDua.TextChanged += new System.EventHandler(this.txtTienKhachDua_TextChanged);
      this.txtTienKhachDua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienKhachDua_KeyPress);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label1.ForeColor = System.Drawing.Color.ForestGreen;
      this.label1.Location = new System.Drawing.Point(148, 282);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 25);
      this.label1.TabIndex = 65;
      this.label1.Text = "Tiền đưa";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // txtTienTraLai
      // 
      this.txtTienTraLai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtTienTraLai.Enabled = false;
      this.txtTienTraLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtTienTraLai.Location = new System.Drawing.Point(255, 246);
      this.txtTienTraLai.Name = "txtTienTraLai";
      this.txtTienTraLai.Size = new System.Drawing.Size(286, 30);
      this.txtTienTraLai.TabIndex = 68;
      this.txtTienTraLai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label2.ForeColor = System.Drawing.Color.ForestGreen;
      this.label2.Location = new System.Drawing.Point(131, 248);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(114, 25);
      this.label2.TabIndex = 67;
      this.label2.Text = "Tiền trả lại";
      // 
      // txtMaTheKhachHang
      // 
      this.txtMaTheKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtMaTheKhachHang.Enabled = false;
      this.txtMaTheKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtMaTheKhachHang.Location = new System.Drawing.Point(255, 140);
      this.txtMaTheKhachHang.Name = "txtMaTheKhachHang";
      this.txtMaTheKhachHang.Size = new System.Drawing.Size(286, 30);
      this.txtMaTheKhachHang.TabIndex = 70;
      this.txtMaTheKhachHang.TextChanged += new System.EventHandler(this.txtMaTheKhachHang_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label3.ForeColor = System.Drawing.Color.ForestGreen;
      this.label3.Location = new System.Drawing.Point(133, 140);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(114, 25);
      this.label3.TabIndex = 69;
      this.label3.Text = "Mã thẻ KH";
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label4.ForeColor = System.Drawing.Color.DarkBlue;
      this.label4.Location = new System.Drawing.Point(-81, 15);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(657, 39);
      this.label4.TabIndex = 78;
      this.label4.Text = "THANH TOÁN";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // txtMaNhanVien
      // 
      this.txtMaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtMaNhanVien.Enabled = false;
      this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtMaNhanVien.Location = new System.Drawing.Point(255, 176);
      this.txtMaNhanVien.Name = "txtMaNhanVien";
      this.txtMaNhanVien.Size = new System.Drawing.Size(286, 30);
      this.txtMaNhanVien.TabIndex = 80;
      this.txtMaNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.txtMaNhanVien.TextChanged += new System.EventHandler(this.txtMaNhanVien_TextChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label5.ForeColor = System.Drawing.Color.ForestGreen;
      this.label5.Location = new System.Drawing.Point(136, 178);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(109, 25);
      this.label5.TabIndex = 79;
      this.label5.Text = "Nhân viên";
      // 
      // ckbXuatHoaDon
      // 
      this.ckbXuatHoaDon.AutoSize = true;
      this.ckbXuatHoaDon.Checked = true;
      this.ckbXuatHoaDon.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbXuatHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.ckbXuatHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.ckbXuatHoaDon.Location = new System.Drawing.Point(405, 350);
      this.ckbXuatHoaDon.Name = "ckbXuatHoaDon";
      this.ckbXuatHoaDon.Size = new System.Drawing.Size(136, 24);
      this.ckbXuatHoaDon.TabIndex = 85;
      this.ckbXuatHoaDon.Text = "Xuất hóa đơn";
      this.ckbXuatHoaDon.UseVisualStyleBackColor = true;
      // 
      // ckbGiaoHang
      // 
      this.ckbGiaoHang.AutoSize = true;
      this.ckbGiaoHang.Checked = true;
      this.ckbGiaoHang.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbGiaoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.ckbGiaoHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.ckbGiaoHang.Location = new System.Drawing.Point(546, 442);
      this.ckbGiaoHang.Name = "ckbGiaoHang";
      this.ckbGiaoHang.Size = new System.Drawing.Size(114, 24);
      this.ckbGiaoHang.TabIndex = 86;
      this.ckbGiaoHang.Text = "Giao Hàng";
      this.ckbGiaoHang.UseVisualStyleBackColor = true;
      this.ckbGiaoHang.Visible = false;
      // 
      // ckbKhachHangVangLai
      // 
      this.ckbKhachHangVangLai.AutoSize = true;
      this.ckbKhachHangVangLai.Checked = true;
      this.ckbKhachHangVangLai.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbKhachHangVangLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.ckbKhachHangVangLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.ckbKhachHangVangLai.Location = new System.Drawing.Point(397, 110);
      this.ckbKhachHangVangLai.Name = "ckbKhachHangVangLai";
      this.ckbKhachHangVangLai.Size = new System.Drawing.Size(144, 24);
      this.ckbKhachHangVangLai.TabIndex = 81;
      this.ckbKhachHangVangLai.Text = "Khách vãng lai";
      this.ckbKhachHangVangLai.UseVisualStyleBackColor = true;
      this.ckbKhachHangVangLai.CheckedChanged += new System.EventHandler(this.ckbKhachHangVangLai_CheckedChanged);
      // 
      // lblTenKhachHang
      // 
      this.lblTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.lblTenKhachHang.ForeColor = System.Drawing.Color.Purple;
      this.lblTenKhachHang.Location = new System.Drawing.Point(250, 208);
      this.lblTenKhachHang.Name = "lblTenKhachHang";
      this.lblTenKhachHang.Size = new System.Drawing.Size(285, 36);
      this.lblTenKhachHang.TabIndex = 88;
      this.lblTenKhachHang.Text = "Tên khách hàng";
      this.lblTenKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblTenKhachHang.Visible = false;
      // 
      // picTick
      // 
      this.picTick.Image = global::GUI.Properties.Resources.icons8_Checked_Checkbox_52px;
      this.picTick.Location = new System.Drawing.Point(547, 140);
      this.picTick.Name = "picTick";
      this.picTick.Size = new System.Drawing.Size(30, 30);
      this.picTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.picTick.TabIndex = 87;
      this.picTick.TabStop = false;
      this.picTick.Visible = false;
      this.picTick.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // btnHuyBoThanhToan
      // 
      this.btnHuyBoThanhToan.BackColor = System.Drawing.Color.White;
      this.btnHuyBoThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnHuyBoThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnHuyBoThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.btnHuyBoThanhToan.Image = global::GUI.Properties.Resources.icons8_Clear_Shopping_Cart_25px;
      this.btnHuyBoThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnHuyBoThanhToan.Location = new System.Drawing.Point(138, 380);
      this.btnHuyBoThanhToan.Name = "btnHuyBoThanhToan";
      this.btnHuyBoThanhToan.Size = new System.Drawing.Size(187, 38);
      this.btnHuyBoThanhToan.TabIndex = 77;
      this.btnHuyBoThanhToan.Text = "Hủy bỏ";
      this.btnHuyBoThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnHuyBoThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnHuyBoThanhToan.UseVisualStyleBackColor = false;
      this.btnHuyBoThanhToan.Click += new System.EventHandler(this.btnHuyBoThanhToan_Click);
      // 
      // btnXacNhanThanhToan
      // 
      this.btnXacNhanThanhToan.BackColor = System.Drawing.Color.White;
      this.btnXacNhanThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnXacNhanThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnXacNhanThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.btnXacNhanThanhToan.Image = global::GUI.Properties.Resources.icons8_Ok_25px;
      this.btnXacNhanThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnXacNhanThanhToan.Location = new System.Drawing.Point(354, 380);
      this.btnXacNhanThanhToan.Name = "btnXacNhanThanhToan";
      this.btnXacNhanThanhToan.Size = new System.Drawing.Size(187, 38);
      this.btnXacNhanThanhToan.TabIndex = 76;
      this.btnXacNhanThanhToan.Text = "Xác nhận";
      this.btnXacNhanThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnXacNhanThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnXacNhanThanhToan.UseVisualStyleBackColor = false;
      this.btnXacNhanThanhToan.Click += new System.EventHandler(this.btnXacNhanThanhToan_Click);
      // 
      // urcThanhToan
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.MintCream;
      this.Controls.Add(this.lblTenKhachHang);
      this.Controls.Add(this.picTick);
      this.Controls.Add(this.ckbGiaoHang);
      this.Controls.Add(this.ckbXuatHoaDon);
      this.Controls.Add(this.ckbKhachHangVangLai);
      this.Controls.Add(this.txtMaNhanVien);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btnHuyBoThanhToan);
      this.Controls.Add(this.btnXacNhanThanhToan);
      this.Controls.Add(this.txtMaTheKhachHang);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtTienTraLai);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtTienKhachDua);
      this.Controls.Add(this.label1);
      this.Name = "urcThanhToan";
      this.Size = new System.Drawing.Size(660, 530);
      this.Load += new System.EventHandler(this.urcThanhToan_Load);
      ((System.ComponentModel.ISupportInitialize)(this.picTick)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTienKhachDua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTienTraLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTheKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXacNhanThanhToan;
        private System.Windows.Forms.Button btnHuyBoThanhToan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbXuatHoaDon;
        private System.Windows.Forms.CheckBox ckbGiaoHang;
        private System.Windows.Forms.CheckBox ckbKhachHangVangLai;
        private System.Windows.Forms.PictureBox picTick;
        private System.Windows.Forms.Label lblTenKhachHang;

    }
}
