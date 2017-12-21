namespace GUI
{
  partial class frmDoiMatKhau
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
      this.label3 = new System.Windows.Forms.Label();
      this.txtMatKhauMoi2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtMatKhauHienTai = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnDongCuaSo = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtMaDangNhap = new System.Windows.Forms.TextBox();
      this.btnDongY = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label3.Location = new System.Drawing.Point(36, 245);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(169, 17);
      this.label3.TabIndex = 128;
      this.label3.Text = "Nhập lại mật khẩu mới";
      // 
      // txtMatKhauMoi2
      // 
      this.txtMatKhauMoi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtMatKhauMoi2.Location = new System.Drawing.Point(228, 242);
      this.txtMatKhauMoi2.MaxLength = 20;
      this.txtMatKhauMoi2.Name = "txtMatKhauMoi2";
      this.txtMatKhauMoi2.Size = new System.Drawing.Size(201, 23);
      this.txtMatKhauMoi2.TabIndex = 3;
      this.txtMatKhauMoi2.UseSystemPasswordChar = true;
      this.txtMatKhauMoi2.TextChanged += new System.EventHandler(this.txtMatKhauMoi2_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label1.Location = new System.Drawing.Point(36, 205);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(104, 17);
      this.label1.TabIndex = 126;
      this.label1.Text = "Mật khẩu mới";
      // 
      // txtMatKhauMoi
      // 
      this.txtMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtMatKhauMoi.Location = new System.Drawing.Point(228, 202);
      this.txtMatKhauMoi.MaxLength = 20;
      this.txtMatKhauMoi.Name = "txtMatKhauMoi";
      this.txtMatKhauMoi.Size = new System.Drawing.Size(201, 23);
      this.txtMatKhauMoi.TabIndex = 2;
      this.txtMatKhauMoi.UseSystemPasswordChar = true;
      this.txtMatKhauMoi.TextChanged += new System.EventHandler(this.txtMatKhauMoi_TextChanged);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label7.Location = new System.Drawing.Point(36, 165);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(133, 17);
      this.label7.TabIndex = 124;
      this.label7.Text = "Mật khẩu hiện tại";
      // 
      // txtMatKhauHienTai
      // 
      this.txtMatKhauHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtMatKhauHienTai.Location = new System.Drawing.Point(228, 162);
      this.txtMatKhauHienTai.MaxLength = 20;
      this.txtMatKhauHienTai.Name = "txtMatKhauHienTai";
      this.txtMatKhauHienTai.Size = new System.Drawing.Size(201, 23);
      this.txtMatKhauHienTai.TabIndex = 1;
      this.txtMatKhauHienTai.UseSystemPasswordChar = true;
      this.txtMatKhauHienTai.TextChanged += new System.EventHandler(this.txtMatKhauHienTai_TextChanged);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
      this.panel1.Controls.Add(this.btnDongCuaSo);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(470, 40);
      this.panel1.TabIndex = 129;
      // 
      // btnDongCuaSo
      // 
      this.btnDongCuaSo.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnDongCuaSo.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnDongCuaSo.FlatAppearance.BorderSize = 0;
      this.btnDongCuaSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDongCuaSo.Image = global::GUI.Properties.Resources.white_close2;
      this.btnDongCuaSo.Location = new System.Drawing.Point(423, 0);
      this.btnDongCuaSo.Name = "btnDongCuaSo";
      this.btnDongCuaSo.Size = new System.Drawing.Size(47, 40);
      this.btnDongCuaSo.TabIndex = 5;
      this.btnDongCuaSo.UseVisualStyleBackColor = true;
      this.btnDongCuaSo.Click += new System.EventHandler(this.btnDongCuaSo_Click);
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(470, 40);
      this.label2.TabIndex = 0;
      this.label2.Text = "ĐỔI MẬT KHẨU";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label4.Location = new System.Drawing.Point(36, 125);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(111, 17);
      this.label4.TabIndex = 131;
      this.label4.Text = "Mã đăng nhập";
      // 
      // txtMaDangNhap
      // 
      this.txtMaDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtMaDangNhap.Location = new System.Drawing.Point(228, 122);
      this.txtMaDangNhap.MaxLength = 6;
      this.txtMaDangNhap.Name = "txtMaDangNhap";
      this.txtMaDangNhap.Size = new System.Drawing.Size(201, 23);
      this.txtMaDangNhap.TabIndex = 0;
      this.txtMaDangNhap.TextChanged += new System.EventHandler(this.txtMaDangNhap_TextChanged);
      // 
      // btnDongY
      // 
      this.btnDongY.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnDongY.FlatAppearance.BorderSize = 0;
      this.btnDongY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnDongY.Image = global::GUI.Properties.Resources.Ok_50px;
      this.btnDongY.Location = new System.Drawing.Point(369, 56);
      this.btnDongY.Name = "btnDongY";
      this.btnDongY.Size = new System.Drawing.Size(60, 60);
      this.btnDongY.TabIndex = 4;
      this.btnDongY.UseVisualStyleBackColor = true;
      this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
      // 
      // frmDoiMatKhau
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(470, 306);
      this.Controls.Add(this.btnDongY);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtMaDangNhap);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtMatKhauMoi2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtMatKhauMoi);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtMatKhauHienTai);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmDoiMatKhau";
      this.Text = "frmDoiMatKhau";
      this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDoiMatKhau_MouseDown);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDoiMatKhau_MouseMove);
      this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmDoiMatKhau_MouseUp);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtMatKhauMoi2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtMatKhauMoi;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtMatKhauHienTai;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnDongCuaSo;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtMaDangNhap;
    private System.Windows.Forms.Button btnDongY;
  }
}