namespace GUI
{
  partial class urcThemKhachHang
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
      this.btnDongCuaSo = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.txtMaKhachHang = new System.Windows.Forms.TextBox();
      this.lblHoTen = new System.Windows.Forms.Label();
      this.txtHoTen = new System.Windows.Forms.TextBox();
      this.rdbNam = new System.Windows.Forms.RadioButton();
      this.rdbNu = new System.Windows.Forms.RadioButton();
      this.label9 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
      this.label11 = new System.Windows.Forms.Label();
      this.txtSoDienThoai = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtDiaChi = new System.Windows.Forms.TextBox();
      this.btnThem = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnDongCuaSo
      // 
      this.btnDongCuaSo.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnDongCuaSo.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnDongCuaSo.FlatAppearance.BorderSize = 0;
      this.btnDongCuaSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDongCuaSo.Image = global::GUI.Properties.Resources.white_close2;
      this.btnDongCuaSo.Location = new System.Drawing.Point(376, 0);
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
      this.label1.Location = new System.Drawing.Point(-1, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(424, 40);
      this.label1.TabIndex = 0;
      this.label1.Text = "THÊM KHÁCH HÀNG";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
      this.panel1.Controls.Add(this.btnDongCuaSo);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(423, 40);
      this.panel1.TabIndex = 127;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label3.Location = new System.Drawing.Point(41, 132);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(118, 17);
      this.label3.TabIndex = 129;
      this.label3.Text = "Mã khách hàng";
      // 
      // txtMaKhachHang
      // 
      this.txtMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtMaKhachHang.Location = new System.Drawing.Point(174, 129);
      this.txtMaKhachHang.Name = "txtMaKhachHang";
      this.txtMaKhachHang.ReadOnly = true;
      this.txtMaKhachHang.Size = new System.Drawing.Size(201, 23);
      this.txtMaKhachHang.TabIndex = 128;
      // 
      // lblHoTen
      // 
      this.lblHoTen.AutoSize = true;
      this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.lblHoTen.Location = new System.Drawing.Point(41, 161);
      this.lblHoTen.Name = "lblHoTen";
      this.lblHoTen.Size = new System.Drawing.Size(56, 17);
      this.lblHoTen.TabIndex = 131;
      this.lblHoTen.Text = "Họ tên";
      // 
      // txtHoTen
      // 
      this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtHoTen.Location = new System.Drawing.Point(174, 158);
      this.txtHoTen.MaxLength = 50;
      this.txtHoTen.Name = "txtHoTen";
      this.txtHoTen.Size = new System.Drawing.Size(201, 23);
      this.txtHoTen.TabIndex = 130;
      this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
      // 
      // rdbNam
      // 
      this.rdbNam.AutoSize = true;
      this.rdbNam.Checked = true;
      this.rdbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.rdbNam.Location = new System.Drawing.Point(174, 187);
      this.rdbNam.Name = "rdbNam";
      this.rdbNam.Size = new System.Drawing.Size(58, 21);
      this.rdbNam.TabIndex = 133;
      this.rdbNam.TabStop = true;
      this.rdbNam.Text = "Nam";
      this.rdbNam.UseVisualStyleBackColor = true;
      // 
      // rdbNu
      // 
      this.rdbNu.AutoSize = true;
      this.rdbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.rdbNu.Location = new System.Drawing.Point(238, 187);
      this.rdbNu.Name = "rdbNu";
      this.rdbNu.Size = new System.Drawing.Size(46, 21);
      this.rdbNu.TabIndex = 134;
      this.rdbNu.Text = "Nữ";
      this.rdbNu.UseVisualStyleBackColor = true;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label9.Location = new System.Drawing.Point(41, 189);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(69, 17);
      this.label9.TabIndex = 132;
      this.label9.Text = "Giới tính";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label8.Location = new System.Drawing.Point(41, 219);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(80, 17);
      this.label8.TabIndex = 136;
      this.label8.Text = "Ngày sinh";
      // 
      // dtpNgaySinh
      // 
      this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpNgaySinh.Location = new System.Drawing.Point(174, 214);
      this.dtpNgaySinh.Name = "dtpNgaySinh";
      this.dtpNgaySinh.Size = new System.Drawing.Size(201, 23);
      this.dtpNgaySinh.TabIndex = 135;
      this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label11.Location = new System.Drawing.Point(41, 246);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(82, 17);
      this.label11.TabIndex = 138;
      this.label11.Text = "Điện thoại";
      // 
      // txtSoDienThoai
      // 
      this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtSoDienThoai.Location = new System.Drawing.Point(174, 243);
      this.txtSoDienThoai.MaxLength = 13;
      this.txtSoDienThoai.Name = "txtSoDienThoai";
      this.txtSoDienThoai.ShortcutsEnabled = false;
      this.txtSoDienThoai.Size = new System.Drawing.Size(201, 23);
      this.txtSoDienThoai.TabIndex = 137;
      this.txtSoDienThoai.TextChanged += new System.EventHandler(this.txtSoDienThoai_TextChanged);
      this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label5.Location = new System.Drawing.Point(41, 275);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(58, 17);
      this.label5.TabIndex = 140;
      this.label5.Text = "Địa chỉ";
      // 
      // txtDiaChi
      // 
      this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtDiaChi.Location = new System.Drawing.Point(174, 272);
      this.txtDiaChi.MaxLength = 250;
      this.txtDiaChi.Name = "txtDiaChi";
      this.txtDiaChi.Size = new System.Drawing.Size(201, 23);
      this.txtDiaChi.TabIndex = 139;
      this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
      // 
      // btnThem
      // 
      this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnThem.FlatAppearance.BorderSize = 0;
      this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnThem.Image = global::GUI.Properties.Resources.Ok_50px;
      this.btnThem.Location = new System.Drawing.Point(315, 63);
      this.btnThem.Name = "btnThem";
      this.btnThem.Size = new System.Drawing.Size(60, 60);
      this.btnThem.TabIndex = 142;
      this.btnThem.UseVisualStyleBackColor = true;
      this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
      // 
      // urcThemKhachHang
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btnThem);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtDiaChi);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.txtSoDienThoai);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.dtpNgaySinh);
      this.Controls.Add(this.rdbNam);
      this.Controls.Add(this.rdbNu);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.lblHoTen);
      this.Controls.Add(this.txtHoTen);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtMaKhachHang);
      this.Controls.Add(this.panel1);
      this.Name = "urcThemKhachHang";
      this.Size = new System.Drawing.Size(423, 338);
      this.Load += new System.EventHandler(this.urcThemKhachHang_Load);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.urcThemKhachHang_MouseDown);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.urcThemKhachHang_MouseMove);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnDongCuaSo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtMaKhachHang;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.RadioButton rdbNam;
    private System.Windows.Forms.RadioButton rdbNu;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox txtSoDienThoai;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtDiaChi;
    private System.Windows.Forms.Button btnThem;

  }
}
