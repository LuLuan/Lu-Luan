namespace GUI
{
  partial class urcChiTietBanPhanCong
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.dgvBanPhanCong = new System.Windows.Forms.DataGridView();
      this.colMaBanPhanCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colThoiGianBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colThoiGianKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNhanVienTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rdbNghiKhongPhep = new System.Windows.Forms.RadioButton();
      this.rdbNghiCoPhep = new System.Windows.Forms.RadioButton();
      this.rdbDiTre = new System.Windows.Forms.RadioButton();
      this.rdbDiLam = new System.Windows.Forms.RadioButton();
      this.listviewCaChieu = new System.Windows.Forms.ListView();
      this.listviewCaSang = new System.Windows.Forms.ListView();
      this.lblCaChieu = new System.Windows.Forms.Label();
      this.lblCaSang = new System.Windows.Forms.Label();
      this.rbdLuu = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvBanPhanCong)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.dgvBanPhanCong);
      this.groupBox1.Controls.Add(this.lblCaChieu);
      this.groupBox1.Controls.Add(this.lblCaSang);
      this.groupBox1.Controls.Add(this.rbdLuu);
      this.groupBox1.Controls.Add(this.rdbNghiKhongPhep);
      this.groupBox1.Controls.Add(this.rdbNghiCoPhep);
      this.groupBox1.Controls.Add(this.rdbDiTre);
      this.groupBox1.Controls.Add(this.rdbDiLam);
      this.groupBox1.Controls.Add(this.listviewCaChieu);
      this.groupBox1.Controls.Add(this.listviewCaSang);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.groupBox1.Location = new System.Drawing.Point(15, 23);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(900, 487);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Chấm công";
      // 
      // dgvBanPhanCong
      // 
      this.dgvBanPhanCong.AllowUserToAddRows = false;
      this.dgvBanPhanCong.AllowUserToDeleteRows = false;
      this.dgvBanPhanCong.ColumnHeadersHeight = 40;
      this.dgvBanPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvBanPhanCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBanPhanCong,
            this.colThoiGianBatDau,
            this.colThoiGianKetThuc,
            this.colNhanVienTao,
            this.colTrangThai});
      this.dgvBanPhanCong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.dgvBanPhanCong.Location = new System.Drawing.Point(16, 22);
      this.dgvBanPhanCong.MultiSelect = false;
      this.dgvBanPhanCong.Name = "dgvBanPhanCong";
      this.dgvBanPhanCong.ReadOnly = true;
      this.dgvBanPhanCong.RowHeadersWidth = 40;
      this.dgvBanPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvBanPhanCong.Size = new System.Drawing.Size(868, 183);
      this.dgvBanPhanCong.TabIndex = 12;
      // 
      // colMaBanPhanCong
      // 
      this.colMaBanPhanCong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colMaBanPhanCong.HeaderText = "Mã BPC";
      this.colMaBanPhanCong.Name = "colMaBanPhanCong";
      this.colMaBanPhanCong.ReadOnly = true;
      this.colMaBanPhanCong.Width = 82;
      // 
      // colThoiGianBatDau
      // 
      this.colThoiGianBatDau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colThoiGianBatDau.HeaderText = "Thời Gian Bắt Đầu";
      this.colThoiGianBatDau.Name = "colThoiGianBatDau";
      this.colThoiGianBatDau.ReadOnly = true;
      // 
      // colThoiGianKetThuc
      // 
      this.colThoiGianKetThuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colThoiGianKetThuc.HeaderText = "Thời Gian Kết Thúc";
      this.colThoiGianKetThuc.Name = "colThoiGianKetThuc";
      this.colThoiGianKetThuc.ReadOnly = true;
      // 
      // colNhanVienTao
      // 
      this.colNhanVienTao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colNhanVienTao.HeaderText = "Nhân Viên Tạo BPC";
      this.colNhanVienTao.Name = "colNhanVienTao";
      this.colNhanVienTao.ReadOnly = true;
      // 
      // colTrangThai
      // 
      this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colTrangThai.HeaderText = "Trạng Thái";
      this.colTrangThai.Name = "colTrangThai";
      this.colTrangThai.ReadOnly = true;
      this.colTrangThai.Width = 104;
      // 
      // rdbNghiKhongPhep
      // 
      this.rdbNghiKhongPhep.AutoSize = true;
      this.rdbNghiKhongPhep.Location = new System.Drawing.Point(292, 445);
      this.rdbNghiKhongPhep.Name = "rdbNghiKhongPhep";
      this.rdbNghiKhongPhep.Size = new System.Drawing.Size(149, 21);
      this.rdbNghiKhongPhep.TabIndex = 8;
      this.rdbNghiKhongPhep.TabStop = true;
      this.rdbNghiKhongPhep.Text = "Nghỉ không phép";
      this.rdbNghiKhongPhep.UseVisualStyleBackColor = true;
      // 
      // rdbNghiCoPhep
      // 
      this.rdbNghiCoPhep.AutoSize = true;
      this.rdbNghiCoPhep.Location = new System.Drawing.Point(164, 445);
      this.rdbNghiCoPhep.Name = "rdbNghiCoPhep";
      this.rdbNghiCoPhep.Size = new System.Drawing.Size(122, 21);
      this.rdbNghiCoPhep.TabIndex = 7;
      this.rdbNghiCoPhep.TabStop = true;
      this.rdbNghiCoPhep.Text = "Nghỉ có phép";
      this.rdbNghiCoPhep.UseVisualStyleBackColor = true;
      // 
      // rdbDiTre
      // 
      this.rdbDiTre.AutoSize = true;
      this.rdbDiTre.Location = new System.Drawing.Point(92, 445);
      this.rdbDiTre.Name = "rdbDiTre";
      this.rdbDiTre.Size = new System.Drawing.Size(66, 21);
      this.rdbDiTre.TabIndex = 6;
      this.rdbDiTre.TabStop = true;
      this.rdbDiTre.Text = "Đi trễ";
      this.rdbDiTre.UseVisualStyleBackColor = true;
      // 
      // rdbDiLam
      // 
      this.rdbDiLam.AutoSize = true;
      this.rdbDiLam.Location = new System.Drawing.Point(15, 445);
      this.rdbDiLam.Name = "rdbDiLam";
      this.rdbDiLam.Size = new System.Drawing.Size(71, 21);
      this.rdbDiLam.TabIndex = 5;
      this.rdbDiLam.TabStop = true;
      this.rdbDiLam.Text = "Đi làm";
      this.rdbDiLam.UseVisualStyleBackColor = true;
      // 
      // listviewCaChieu
      // 
      this.listviewCaChieu.Location = new System.Drawing.Point(455, 250);
      this.listviewCaChieu.Name = "listviewCaChieu";
      this.listviewCaChieu.Size = new System.Drawing.Size(429, 173);
      this.listviewCaChieu.TabIndex = 4;
      this.listviewCaChieu.UseCompatibleStateImageBehavior = false;
      // 
      // listviewCaSang
      // 
      this.listviewCaSang.Location = new System.Drawing.Point(16, 250);
      this.listviewCaSang.Name = "listviewCaSang";
      this.listviewCaSang.Size = new System.Drawing.Size(429, 173);
      this.listviewCaSang.TabIndex = 3;
      this.listviewCaSang.UseCompatibleStateImageBehavior = false;
      // 
      // lblCaChieu
      // 
   //   this.lblCaChieu.Image = global::GUI.Properties.Resources.moon_30px;
      this.lblCaChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lblCaChieu.Location = new System.Drawing.Point(452, 208);
      this.lblCaChieu.Name = "lblCaChieu";
      this.lblCaChieu.Size = new System.Drawing.Size(105, 39);
      this.lblCaChieu.TabIndex = 11;
      this.lblCaChieu.Text = "Ca Chiều";
      this.lblCaChieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblCaSang
      // 
    //  this.lblCaSang.Image = global::GUI.Properties.Resources.sun2_30px;
      this.lblCaSang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lblCaSang.Location = new System.Drawing.Point(12, 208);
      this.lblCaSang.Name = "lblCaSang";
      this.lblCaSang.Size = new System.Drawing.Size(105, 39);
      this.lblCaSang.TabIndex = 10;
      this.lblCaSang.Text = "Ca Sáng";
      this.lblCaSang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // rbdLuu
      // 
      this.rbdLuu.FlatAppearance.BorderSize = 0;
      this.rbdLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.rbdLuu.Image = global::GUI.Properties.Resources.icons8_Save_35px;
      this.rbdLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.rbdLuu.Location = new System.Drawing.Point(455, 429);
      this.rbdLuu.Name = "rbdLuu";
      this.rbdLuu.Size = new System.Drawing.Size(98, 52);
      this.rbdLuu.TabIndex = 9;
      this.rbdLuu.Text = "Lưu";
      this.rbdLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.rbdLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.rbdLuu.UseVisualStyleBackColor = true;
      // 
      // urcChiTietBanPhanCong
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupBox1);
      this.Name = "urcChiTietBanPhanCong";
      this.Size = new System.Drawing.Size(930, 530);
      this.Load += new System.EventHandler(this.urcChiTietBanPhanCong_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvBanPhanCong)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView dgvBanPhanCong;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaBanPhanCong;
    private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianBatDau;
    private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianKetThuc;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNhanVienTao;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    private System.Windows.Forms.Label lblCaChieu;
    private System.Windows.Forms.Label lblCaSang;
    private System.Windows.Forms.Button rbdLuu;
    private System.Windows.Forms.RadioButton rdbNghiKhongPhep;
    private System.Windows.Forms.RadioButton rdbNghiCoPhep;
    private System.Windows.Forms.RadioButton rdbDiTre;
    private System.Windows.Forms.RadioButton rdbDiLam;
    private System.Windows.Forms.ListView listviewCaChieu;
    private System.Windows.Forms.ListView listviewCaSang;
  }
}
