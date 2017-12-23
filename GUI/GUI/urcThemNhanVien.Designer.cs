namespace GUI
{
    partial class urcThemNhanVien
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnDongCuaSo = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
      this.label11 = new System.Windows.Forms.Label();
      this.txtSoDienThoai = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtDiaChi = new System.Windows.Forms.TextBox();
      this.rdbNam = new System.Windows.Forms.RadioButton();
      this.rdbNu = new System.Windows.Forms.RadioButton();
      this.label9 = new System.Windows.Forms.Label();
      this.lblHoTen = new System.Windows.Forms.Label();
      this.txtHoTen = new System.Windows.Forms.TextBox();
      this.cboChucVu = new System.Windows.Forms.ComboBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtMatKhau = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtMaNhanVien = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
      this.chbKichHoatTK = new System.Windows.Forms.CheckBox();
      this.btnDongY = new System.Windows.Forms.Button();
      this.btnThemAnh = new System.Windows.Forms.Button();
      this.picAnhDaiDien = new System.Windows.Forms.PictureBox();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
      this.panel1.Controls.Add(this.btnDongCuaSo);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(573, 40);
      this.panel1.TabIndex = 0;
      // 
      // btnDongCuaSo
      // 
      this.btnDongCuaSo.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnDongCuaSo.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnDongCuaSo.FlatAppearance.BorderSize = 0;
      this.btnDongCuaSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDongCuaSo.Image = global::GUI.Properties.Resources.white_close2;
      this.btnDongCuaSo.Location = new System.Drawing.Point(526, 0);
      this.btnDongCuaSo.Name = "btnDongCuaSo";
      this.btnDongCuaSo.Size = new System.Drawing.Size(47, 40);
      this.btnDongCuaSo.TabIndex = 1;
      this.btnDongCuaSo.UseVisualStyleBackColor = true;
      this.btnDongCuaSo.Click += new System.EventHandler(this.btnDongCuaSo_Click);
      this.btnDongCuaSo.MouseEnter += new System.EventHandler(this.btnDongCuaSo_MouseEnter);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(574, 40);
      this.label1.TabIndex = 0;
      this.label1.Text = "THÊM NHÂN VIÊN";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label8.Location = new System.Drawing.Point(33, 254);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(80, 17);
      this.label8.TabIndex = 104;
      this.label8.Text = "Ngày sinh";
      // 
      // dtpNgaySinh
      // 
      this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpNgaySinh.Location = new System.Drawing.Point(154, 249);
      this.dtpNgaySinh.Name = "dtpNgaySinh";
      this.dtpNgaySinh.Size = new System.Drawing.Size(126, 23);
      this.dtpNgaySinh.TabIndex = 103;
      this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label11.Location = new System.Drawing.Point(286, 279);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(82, 17);
      this.label11.TabIndex = 102;
      this.label11.Text = "Điện thoại";
      // 
      // txtSoDienThoai
      // 
      this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtSoDienThoai.Location = new System.Drawing.Point(375, 276);
      this.txtSoDienThoai.MaxLength = 13;
      this.txtSoDienThoai.Name = "txtSoDienThoai";
      this.txtSoDienThoai.ShortcutsEnabled = false;
      this.txtSoDienThoai.Size = new System.Drawing.Size(161, 23);
      this.txtSoDienThoai.TabIndex = 101;
      this.txtSoDienThoai.TextChanged += new System.EventHandler(this.txtSoDienThoai_TextChanged);
      this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label5.Location = new System.Drawing.Point(33, 309);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(58, 17);
      this.label5.TabIndex = 100;
      this.label5.Text = "Địa chỉ";
      // 
      // txtDiaChi
      // 
      this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtDiaChi.Location = new System.Drawing.Point(154, 307);
      this.txtDiaChi.MaxLength = 250;
      this.txtDiaChi.Name = "txtDiaChi";
      this.txtDiaChi.Size = new System.Drawing.Size(382, 23);
      this.txtDiaChi.TabIndex = 99;
      this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
      // 
      // rdbNam
      // 
      this.rdbNam.AutoSize = true;
      this.rdbNam.Checked = true;
      this.rdbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.rdbNam.Location = new System.Drawing.Point(375, 249);
      this.rdbNam.Name = "rdbNam";
      this.rdbNam.Size = new System.Drawing.Size(58, 21);
      this.rdbNam.TabIndex = 97;
      this.rdbNam.TabStop = true;
      this.rdbNam.Text = "Nam";
      this.rdbNam.UseVisualStyleBackColor = true;
      // 
      // rdbNu
      // 
      this.rdbNu.AutoSize = true;
      this.rdbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.rdbNu.Location = new System.Drawing.Point(439, 249);
      this.rdbNu.Name = "rdbNu";
      this.rdbNu.Size = new System.Drawing.Size(46, 21);
      this.rdbNu.TabIndex = 98;
      this.rdbNu.Text = "Nữ";
      this.rdbNu.UseVisualStyleBackColor = true;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label9.Location = new System.Drawing.Point(286, 251);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(69, 17);
      this.label9.TabIndex = 96;
      this.label9.Text = "Giới tính";
      // 
      // lblHoTen
      // 
      this.lblHoTen.AutoSize = true;
      this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.lblHoTen.Location = new System.Drawing.Point(33, 223);
      this.lblHoTen.Name = "lblHoTen";
      this.lblHoTen.Size = new System.Drawing.Size(56, 17);
      this.lblHoTen.TabIndex = 95;
      this.lblHoTen.Text = "Họ tên";
      // 
      // txtHoTen
      // 
      this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtHoTen.Location = new System.Drawing.Point(154, 220);
      this.txtHoTen.MaxLength = 50;
      this.txtHoTen.Name = "txtHoTen";
      this.txtHoTen.Size = new System.Drawing.Size(201, 23);
      this.txtHoTen.TabIndex = 94;
      this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
      // 
      // cboChucVu
      // 
      this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.cboChucVu.FormattingEnabled = true;
      this.cboChucVu.Location = new System.Drawing.Point(375, 219);
      this.cboChucVu.Name = "cboChucVu";
      this.cboChucVu.Size = new System.Drawing.Size(161, 24);
      this.cboChucVu.TabIndex = 107;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label7.Location = new System.Drawing.Point(33, 194);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(74, 17);
      this.label7.TabIndex = 116;
      this.label7.Text = "Mật khẩu";
      // 
      // txtMatKhau
      // 
      this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtMatKhau.Location = new System.Drawing.Point(154, 191);
      this.txtMatKhau.MaxLength = 20;
      this.txtMatKhau.Name = "txtMatKhau";
      this.txtMatKhau.Size = new System.Drawing.Size(201, 23);
      this.txtMatKhau.TabIndex = 115;
      this.txtMatKhau.UseSystemPasswordChar = true;
      this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label3.Location = new System.Drawing.Point(33, 165);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(105, 17);
      this.label3.TabIndex = 114;
      this.label3.Text = "Mã nhân viên";
      // 
      // txtMaNhanVien
      // 
      this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtMaNhanVien.Location = new System.Drawing.Point(154, 162);
      this.txtMaNhanVien.Name = "txtMaNhanVien";
      this.txtMaNhanVien.ReadOnly = true;
      this.txtMaNhanVien.Size = new System.Drawing.Size(201, 23);
      this.txtMaNhanVien.TabIndex = 113;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label6.Location = new System.Drawing.Point(33, 282);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(106, 17);
      this.label6.TabIndex = 125;
      this.label6.Text = "Ngày vào làm";
      // 
      // dtpNgayVaoLam
      // 
      this.dtpNgayVaoLam.Enabled = false;
      this.dtpNgayVaoLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpNgayVaoLam.Location = new System.Drawing.Point(154, 278);
      this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
      this.dtpNgayVaoLam.Size = new System.Drawing.Size(126, 23);
      this.dtpNgayVaoLam.TabIndex = 124;
      this.dtpNgayVaoLam.ValueChanged += new System.EventHandler(this.dtpNgayVaoLam_ValueChanged);
      // 
      // chbKichHoatTK
      // 
      this.chbKichHoatTK.AutoSize = true;
      this.chbKichHoatTK.Checked = true;
      this.chbKichHoatTK.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chbKichHoatTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.chbKichHoatTK.Location = new System.Drawing.Point(375, 164);
      this.chbKichHoatTK.Name = "chbKichHoatTK";
      this.chbKichHoatTK.Size = new System.Drawing.Size(167, 21);
      this.chbKichHoatTK.TabIndex = 126;
      this.chbKichHoatTK.Text = "Kích hoạt tài khoản";
      this.chbKichHoatTK.UseVisualStyleBackColor = true;
      // 
      // btnDongY
      // 
      this.btnDongY.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnDongY.FlatAppearance.BorderSize = 0;
      this.btnDongY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnDongY.Image = global::GUI.Properties.Resources.Ok_50px;
      this.btnDongY.Location = new System.Drawing.Point(447, 89);
      this.btnDongY.Name = "btnDongY";
      this.btnDongY.Size = new System.Drawing.Size(60, 60);
      this.btnDongY.TabIndex = 117;
      this.btnDongY.UseVisualStyleBackColor = true;
      this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
      // 
      // btnThemAnh
      // 
      this.btnThemAnh.BackgroundImage = global::GUI.Properties.Resources.AddImage;
      this.btnThemAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnThemAnh.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnThemAnh.FlatAppearance.BorderSize = 0;
      this.btnThemAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnThemAnh.Location = new System.Drawing.Point(95, 125);
      this.btnThemAnh.Name = "btnThemAnh";
      this.btnThemAnh.Size = new System.Drawing.Size(28, 23);
      this.btnThemAnh.TabIndex = 84;
      this.btnThemAnh.UseVisualStyleBackColor = true;
      this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
      // 
      // picAnhDaiDien
      // 
      this.picAnhDaiDien.BackColor = System.Drawing.Color.White;
      this.picAnhDaiDien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.picAnhDaiDien.Location = new System.Drawing.Point(36, 58);
      this.picAnhDaiDien.Name = "picAnhDaiDien";
      this.picAnhDaiDien.Size = new System.Drawing.Size(88, 91);
      this.picAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.picAnhDaiDien.TabIndex = 83;
      this.picAnhDaiDien.TabStop = false;
      // 
      // urcThemNhanVien
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.MintCream;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.chbKichHoatTK);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.dtpNgayVaoLam);
      this.Controls.Add(this.btnDongY);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtMatKhau);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtMaNhanVien);
      this.Controls.Add(this.cboChucVu);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.dtpNgaySinh);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.txtSoDienThoai);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtDiaChi);
      this.Controls.Add(this.rdbNam);
      this.Controls.Add(this.rdbNu);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.lblHoTen);
      this.Controls.Add(this.txtHoTen);
      this.Controls.Add(this.btnThemAnh);
      this.Controls.Add(this.picAnhDaiDien);
      this.Controls.Add(this.panel1);
      this.Name = "urcThemNhanVien";
      this.Size = new System.Drawing.Size(573, 384);
      this.Load += new System.EventHandler(this.urcThemNhanVien_Load);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.urcThemNhanVien_MouseDown);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.urcThemNhanVien_MouseMove);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemAnh;
        private System.Windows.Forms.PictureBox picAnhDaiDien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Button btnDongCuaSo;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.CheckBox chbKichHoatTK;
    }
}
