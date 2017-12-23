namespace GUI
{
  partial class urcDanhSachPhanCong
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
      this.components = new System.ComponentModel.Container();
      this.listviewNhanVien = new System.Windows.Forms.ListView();
      this.colTenNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colMaNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colSoDienThoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colTrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.largeImageList = new System.Windows.Forms.ImageList(this.components);
      this.smallImageList = new System.Windows.Forms.ImageList(this.components);
      this.cboKhungNhin = new System.Windows.Forms.ComboBox();
      this.txtTimKiem = new System.Windows.Forms.TextBox();
      this.grbDSNhanVienCoThePhanCong = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.grbDanhSachNVDuocChon = new System.Windows.Forms.GroupBox();
      this.btnCapNhat = new System.Windows.Forms.Button();
      this.btnLamMoi = new System.Windows.Forms.Button();
      this.btnThemBPC = new System.Windows.Forms.Button();
      this.label9 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
      this.listviewDanhSachChon = new System.Windows.Forms.ListView();
      this.grbDSNhanVienCoThePhanCong.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.grbDanhSachNVDuocChon.SuspendLayout();
      this.SuspendLayout();
      // 
      // listviewNhanVien
      // 
      this.listviewNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.listviewNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenNhanVien,
            this.colMaNhanVien,
            this.colGioiTinh,
            this.colSoDienThoai,
            this.colTrangThai});
      this.listviewNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.listviewNhanVien.FullRowSelect = true;
      this.listviewNhanVien.LargeImageList = this.largeImageList;
      this.listviewNhanVien.Location = new System.Drawing.Point(5, 52);
      this.listviewNhanVien.MultiSelect = false;
      this.listviewNhanVien.Name = "listviewNhanVien";
      this.listviewNhanVien.Size = new System.Drawing.Size(321, 389);
      this.listviewNhanVien.SmallImageList = this.smallImageList;
      this.listviewNhanVien.TabIndex = 0;
      this.listviewNhanVien.UseCompatibleStateImageBehavior = false;
      this.listviewNhanVien.DoubleClick += new System.EventHandler(this.listviewNhanVien_DoubleClick);
      // 
      // colTenNhanVien
      // 
      this.colTenNhanVien.Text = "Họ Tên";
      this.colTenNhanVien.Width = 110;
      // 
      // colMaNhanVien
      // 
      this.colMaNhanVien.Text = "Mã";
      this.colMaNhanVien.Width = 54;
      // 
      // colGioiTinh
      // 
      this.colGioiTinh.Text = "Giới Tính";
      this.colGioiTinh.Width = 66;
      // 
      // colSoDienThoai
      // 
      this.colSoDienThoai.Text = "Số Điện Thoại";
      this.colSoDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.colSoDienThoai.Width = 113;
      // 
      // colTrangThai
      // 
      this.colTrangThai.Text = "Trạng Thái";
      this.colTrangThai.Width = 84;
      // 
      // largeImageList
      // 
      this.largeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
      this.largeImageList.ImageSize = new System.Drawing.Size(50, 60);
      this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // smallImageList
      // 
      this.smallImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
      this.smallImageList.ImageSize = new System.Drawing.Size(30, 35);
      this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // cboKhungNhin
      // 
      this.cboKhungNhin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboKhungNhin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.cboKhungNhin.FormattingEnabled = true;
      this.cboKhungNhin.Items.AddRange(new object[] {
            "Large Icon",
            "Detail",
            "Tile"});
      this.cboKhungNhin.Location = new System.Drawing.Point(5, 22);
      this.cboKhungNhin.Name = "cboKhungNhin";
      this.cboKhungNhin.Size = new System.Drawing.Size(321, 24);
      this.cboKhungNhin.TabIndex = 1;
      this.cboKhungNhin.SelectedIndexChanged += new System.EventHandler(this.cboKhungNhin_SelectedIndexChanged);
      // 
      // txtTimKiem
      // 
      this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtTimKiem.ForeColor = System.Drawing.Color.DimGray;
      this.txtTimKiem.Location = new System.Drawing.Point(6, 19);
      this.txtTimKiem.Name = "txtTimKiem";
      this.txtTimKiem.Size = new System.Drawing.Size(321, 23);
      this.txtTimKiem.TabIndex = 2;
      this.txtTimKiem.Text = "Nhập mã hoặc tên nhân viên để tìm kiếm";
      this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
      // 
      // grbDSNhanVienCoThePhanCong
      // 
      this.grbDSNhanVienCoThePhanCong.Controls.Add(this.listviewNhanVien);
      this.grbDSNhanVienCoThePhanCong.Controls.Add(this.cboKhungNhin);
      this.grbDSNhanVienCoThePhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.grbDSNhanVienCoThePhanCong.Location = new System.Drawing.Point(14, 71);
      this.grbDSNhanVienCoThePhanCong.Name = "grbDSNhanVienCoThePhanCong";
      this.grbDSNhanVienCoThePhanCong.Size = new System.Drawing.Size(330, 447);
      this.grbDSNhanVienCoThePhanCong.TabIndex = 3;
      this.grbDSNhanVienCoThePhanCong.TabStop = false;
      this.grbDSNhanVienCoThePhanCong.Text = "Danh sách nhân viên";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtTimKiem);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.groupBox2.Location = new System.Drawing.Point(13, 16);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(331, 49);
      this.groupBox2.TabIndex = 4;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Tìm kiếm nhân viên";
      // 
      // grbDanhSachNVDuocChon
      // 
      this.grbDanhSachNVDuocChon.Controls.Add(this.btnCapNhat);
      this.grbDanhSachNVDuocChon.Controls.Add(this.btnLamMoi);
      this.grbDanhSachNVDuocChon.Controls.Add(this.btnThemBPC);
      this.grbDanhSachNVDuocChon.Controls.Add(this.label9);
      this.grbDanhSachNVDuocChon.Controls.Add(this.label8);
      this.grbDanhSachNVDuocChon.Controls.Add(this.label12);
      this.grbDanhSachNVDuocChon.Controls.Add(this.label10);
      this.grbDanhSachNVDuocChon.Controls.Add(this.dtpNgayBatDau);
      this.grbDanhSachNVDuocChon.Controls.Add(this.listviewDanhSachChon);
      this.grbDanhSachNVDuocChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.grbDanhSachNVDuocChon.Location = new System.Drawing.Point(367, 16);
      this.grbDanhSachNVDuocChon.Name = "grbDanhSachNVDuocChon";
      this.grbDanhSachNVDuocChon.Size = new System.Drawing.Size(546, 330);
      this.grbDanhSachNVDuocChon.TabIndex = 5;
      this.grbDanhSachNVDuocChon.TabStop = false;
      this.grbDanhSachNVDuocChon.Text = "Phân công";
      // 
      // btnCapNhat
      // 
      this.btnCapNhat.Location = new System.Drawing.Point(445, 74);
      this.btnCapNhat.Name = "btnCapNhat";
      this.btnCapNhat.Size = new System.Drawing.Size(95, 40);
      this.btnCapNhat.TabIndex = 21;
      this.btnCapNhat.Text = "Cập nhật";
      this.btnCapNhat.UseVisualStyleBackColor = true;
      // 
      // btnLamMoi
      // 
      this.btnLamMoi.Location = new System.Drawing.Point(445, 126);
      this.btnLamMoi.Name = "btnLamMoi";
      this.btnLamMoi.Size = new System.Drawing.Size(95, 40);
      this.btnLamMoi.TabIndex = 20;
      this.btnLamMoi.Text = "Làm mới";
      this.btnLamMoi.UseVisualStyleBackColor = true;
      this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
      // 
      // btnThemBPC
      // 
      this.btnThemBPC.Location = new System.Drawing.Point(445, 22);
      this.btnThemBPC.Name = "btnThemBPC";
      this.btnThemBPC.Size = new System.Drawing.Size(95, 40);
      this.btnThemBPC.TabIndex = 19;
      this.btnThemBPC.Text = "Thêm";
      this.btnThemBPC.UseVisualStyleBackColor = true;
      this.btnThemBPC.Click += new System.EventHandler(this.btnThemBPC_Click);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(6, 272);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(49, 17);
      this.label9.TabIndex = 17;
      this.label9.Text = "Chiều";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(6, 227);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(45, 17);
      this.label8.TabIndex = 17;
      this.label8.Text = "Sáng";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(120, 177);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(105, 17);
      this.label12.TabIndex = 17;
      this.label12.Text = "Ngày bắt đầu";
      this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(6, 201);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(69, 17);
      this.label10.TabIndex = 17;
      this.label10.Text = "Ca/Ngày";
      this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dtpNgayBatDau
      // 
      this.dtpNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpNgayBatDau.Location = new System.Drawing.Point(238, 172);
      this.dtpNgayBatDau.Name = "dtpNgayBatDau";
      this.dtpNgayBatDau.Size = new System.Drawing.Size(201, 21);
      this.dtpNgayBatDau.TabIndex = 0;
      this.dtpNgayBatDau.ValueChanged += new System.EventHandler(this.dtpNgayBatDauLamTheoPhanCong_ValueChanged);
      // 
      // listviewDanhSachChon
      // 
      this.listviewDanhSachChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.listviewDanhSachChon.LargeImageList = this.largeImageList;
      this.listviewDanhSachChon.Location = new System.Drawing.Point(6, 22);
      this.listviewDanhSachChon.Name = "listviewDanhSachChon";
      this.listviewDanhSachChon.Size = new System.Drawing.Size(433, 144);
      this.listviewDanhSachChon.SmallImageList = this.smallImageList;
      this.listviewDanhSachChon.TabIndex = 0;
      this.listviewDanhSachChon.UseCompatibleStateImageBehavior = false;
      this.listviewDanhSachChon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listviewDanhSachChon_MouseDoubleClick);
      // 
      // urcDanhSachPhanCong
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.MintCream;
      this.Controls.Add(this.grbDanhSachNVDuocChon);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.grbDSNhanVienCoThePhanCong);
      this.Name = "urcDanhSachPhanCong";
      this.Size = new System.Drawing.Size(930, 530);
      this.Load += new System.EventHandler(this.urcDanhSachPhanCong_Load);
      this.grbDSNhanVienCoThePhanCong.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.grbDanhSachNVDuocChon.ResumeLayout(false);
      this.grbDanhSachNVDuocChon.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListView listviewNhanVien;
    private System.Windows.Forms.ColumnHeader colTenNhanVien;
    private System.Windows.Forms.ColumnHeader colMaNhanVien;
    private System.Windows.Forms.ColumnHeader colGioiTinh;
    private System.Windows.Forms.ColumnHeader colSoDienThoai;
    private System.Windows.Forms.ColumnHeader colTrangThai;
    private System.Windows.Forms.ImageList largeImageList;
    private System.Windows.Forms.ImageList smallImageList;
    private System.Windows.Forms.ComboBox cboKhungNhin;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.GroupBox grbDSNhanVienCoThePhanCong;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox grbDanhSachNVDuocChon;
    private System.Windows.Forms.ListView listviewDanhSachChon;
    private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.Button btnThemBPC;
    private System.Windows.Forms.Button btnCapNhat;

  }
}
