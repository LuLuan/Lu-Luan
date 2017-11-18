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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.grbChamCong = new System.Windows.Forms.GroupBox();
      this.btnLuuThayDoi = new System.Windows.Forms.Button();
      this.btnHuyThaoTac = new System.Windows.Forms.Button();
      this.dgvDSNVCaChieu = new System.Windows.Forms.DataGridView();
      this.dgvDSNVCaSang = new System.Windows.Forms.DataGridView();
      this.dtpNgayLam = new System.Windows.Forms.DateTimePicker();
      this.lblCaChieu = new System.Windows.Forms.Label();
      this.lblCaSang = new System.Windows.Forms.Label();
      this.rdbNghiKhongPhep = new System.Windows.Forms.RadioButton();
      this.rdbNghiCoPhep = new System.Windows.Forms.RadioButton();
      this.rdbDiTre = new System.Windows.Forms.RadioButton();
      this.rdbDiLam = new System.Windows.Forms.RadioButton();
      this.colMaBanGhiSang = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colMaNVSang = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colHoTenSang = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNgayLamSang = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colCaLamSang = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colCoMatSang = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNghiCoPhepSang = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTrangThaiSang = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colMaBanGhiChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colMaNVChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colHoTenChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNgayLamChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colCaLamChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colCoMatChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNghiCoPhepChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTrangThaiChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rdbChuaChapCong = new System.Windows.Forms.RadioButton();
      this.grbChamCong.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDSNVCaChieu)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDSNVCaSang)).BeginInit();
      this.SuspendLayout();
      // 
      // grbChamCong
      // 
      this.grbChamCong.Controls.Add(this.rdbChuaChapCong);
      this.grbChamCong.Controls.Add(this.btnLuuThayDoi);
      this.grbChamCong.Controls.Add(this.btnHuyThaoTac);
      this.grbChamCong.Controls.Add(this.dgvDSNVCaChieu);
      this.grbChamCong.Controls.Add(this.dgvDSNVCaSang);
      this.grbChamCong.Controls.Add(this.dtpNgayLam);
      this.grbChamCong.Controls.Add(this.lblCaChieu);
      this.grbChamCong.Controls.Add(this.lblCaSang);
      this.grbChamCong.Controls.Add(this.rdbNghiKhongPhep);
      this.grbChamCong.Controls.Add(this.rdbNghiCoPhep);
      this.grbChamCong.Controls.Add(this.rdbDiTre);
      this.grbChamCong.Controls.Add(this.rdbDiLam);
      this.grbChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.grbChamCong.Location = new System.Drawing.Point(15, 23);
      this.grbChamCong.Name = "grbChamCong";
      this.grbChamCong.Size = new System.Drawing.Size(900, 487);
      this.grbChamCong.TabIndex = 4;
      this.grbChamCong.TabStop = false;
      this.grbChamCong.Text = "Chấm công";
      // 
      // btnLuuThayDoi
      // 
      this.btnLuuThayDoi.ForeColor = System.Drawing.Color.Black;
      this.btnLuuThayDoi.Location = new System.Drawing.Point(455, 397);
      this.btnLuuThayDoi.Name = "btnLuuThayDoi";
      this.btnLuuThayDoi.Size = new System.Drawing.Size(120, 44);
      this.btnLuuThayDoi.TabIndex = 16;
      this.btnLuuThayDoi.Text = "Lưu";
      this.btnLuuThayDoi.UseVisualStyleBackColor = true;
      this.btnLuuThayDoi.Click += new System.EventHandler(this.btnLuuThayDoi_Click);
      // 
      // btnHuyThaoTac
      // 
      this.btnHuyThaoTac.ForeColor = System.Drawing.Color.Black;
      this.btnHuyThaoTac.Location = new System.Drawing.Point(581, 397);
      this.btnHuyThaoTac.Name = "btnHuyThaoTac";
      this.btnHuyThaoTac.Size = new System.Drawing.Size(171, 44);
      this.btnHuyThaoTac.TabIndex = 15;
      this.btnHuyThaoTac.Text = "Hủy thao tác";
      this.btnHuyThaoTac.UseVisualStyleBackColor = true;
      this.btnHuyThaoTac.Click += new System.EventHandler(this.btnHuyThaoTac_Click);
      // 
      // dgvDSNVCaChieu
      // 
      this.dgvDSNVCaChieu.AllowUserToAddRows = false;
      this.dgvDSNVCaChieu.AllowUserToDeleteRows = false;
      this.dgvDSNVCaChieu.ColumnHeadersHeight = 40;
      this.dgvDSNVCaChieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBanGhiChieu,
            this.colMaNVChieu,
            this.colHoTenChieu,
            this.colNgayLamChieu,
            this.colCaLamChieu,
            this.colCoMatChieu,
            this.colNghiCoPhepChieu,
            this.colTrangThaiChieu});
      this.dgvDSNVCaChieu.Location = new System.Drawing.Point(455, 149);
      this.dgvDSNVCaChieu.MultiSelect = false;
      this.dgvDSNVCaChieu.Name = "dgvDSNVCaChieu";
      this.dgvDSNVCaChieu.ReadOnly = true;
      this.dgvDSNVCaChieu.RowHeadersWidth = 35;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvDSNVCaChieu.RowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvDSNVCaChieu.RowTemplate.Height = 35;
      this.dgvDSNVCaChieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvDSNVCaChieu.Size = new System.Drawing.Size(425, 242);
      this.dgvDSNVCaChieu.TabIndex = 14;
      //this.dgvDSNVCaChieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNVCaChieu_CellContentClick);
      this.dgvDSNVCaChieu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDSNVCaChieu_CellFormatting);
      this.dgvDSNVCaChieu.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDSNVCaChieu_DataBindingComplete);
      this.dgvDSNVCaChieu.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDSNVCaChieu_RowPostPaint);
      this.dgvDSNVCaChieu.SelectionChanged += new System.EventHandler(this.dgvDSNVCaChieu_SelectionChanged);
      // 
      // dgvDSNVCaSang
      // 
      this.dgvDSNVCaSang.AllowUserToAddRows = false;
      this.dgvDSNVCaSang.AllowUserToDeleteRows = false;
      this.dgvDSNVCaSang.ColumnHeadersHeight = 40;
      this.dgvDSNVCaSang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBanGhiSang,
            this.colMaNVSang,
            this.colHoTenSang,
            this.colNgayLamSang,
            this.colCaLamSang,
            this.colCoMatSang,
            this.colNghiCoPhepSang,
            this.colTrangThaiSang});
      this.dgvDSNVCaSang.Location = new System.Drawing.Point(16, 149);
      this.dgvDSNVCaSang.MultiSelect = false;
      this.dgvDSNVCaSang.Name = "dgvDSNVCaSang";
      this.dgvDSNVCaSang.ReadOnly = true;
      this.dgvDSNVCaSang.RowHeadersWidth = 35;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvDSNVCaSang.RowsDefaultCellStyle = dataGridViewCellStyle2;
      this.dgvDSNVCaSang.RowTemplate.Height = 35;
      this.dgvDSNVCaSang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvDSNVCaSang.Size = new System.Drawing.Size(425, 242);
      this.dgvDSNVCaSang.TabIndex = 13;
      //this.dgvDSNVCaSang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNVCaSang_CellContentClick);
      this.dgvDSNVCaSang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDSNVCaSang_CellFormatting);
      this.dgvDSNVCaSang.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDSNVCaSang_DataBindingComplete);
      this.dgvDSNVCaSang.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDSNVCaSang_RowPostPaint);
      this.dgvDSNVCaSang.SelectionChanged += new System.EventHandler(this.dgvDSNVCaSang_SelectionChanged);
      // 
      // dtpNgayLam
      // 
      this.dtpNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpNgayLam.Location = new System.Drawing.Point(15, 45);
      this.dtpNgayLam.Name = "dtpNgayLam";
      this.dtpNgayLam.Size = new System.Drawing.Size(426, 23);
      this.dtpNgayLam.TabIndex = 12;
      this.dtpNgayLam.ValueChanged += new System.EventHandler(this.dtpNgayLam_ValueChanged);
      // 
      // lblCaChieu
      // 
      this.lblCaChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lblCaChieu.Location = new System.Drawing.Point(452, 94);
      this.lblCaChieu.Name = "lblCaChieu";
      this.lblCaChieu.Size = new System.Drawing.Size(105, 39);
      this.lblCaChieu.TabIndex = 11;
      this.lblCaChieu.Text = "Ca Chiều";
      this.lblCaChieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblCaSang
      // 
      this.lblCaSang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lblCaSang.Location = new System.Drawing.Point(13, 94);
      this.lblCaSang.Name = "lblCaSang";
      this.lblCaSang.Size = new System.Drawing.Size(105, 39);
      this.lblCaSang.TabIndex = 10;
      this.lblCaSang.Text = "Ca Sáng";
      this.lblCaSang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // rdbNghiKhongPhep
      // 
      this.rdbNghiKhongPhep.AutoSize = true;
      this.rdbNghiKhongPhep.ForeColor = System.Drawing.Color.Black;
      this.rdbNghiKhongPhep.Location = new System.Drawing.Point(120, 440);
      this.rdbNghiKhongPhep.Name = "rdbNghiKhongPhep";
      this.rdbNghiKhongPhep.Size = new System.Drawing.Size(149, 21);
      this.rdbNghiKhongPhep.TabIndex = 8;
      this.rdbNghiKhongPhep.TabStop = true;
      this.rdbNghiKhongPhep.Text = "Nghỉ không phép";
      this.rdbNghiKhongPhep.UseVisualStyleBackColor = true;
      this.rdbNghiKhongPhep.CheckedChanged += new System.EventHandler(this.rdbNghiKhongPhep_CheckedChanged);
      this.rdbNghiKhongPhep.EnabledChanged += new System.EventHandler(this.rdbNghiKhongPhep_EnabledChanged);
      // 
      // rdbNghiCoPhep
      // 
      this.rdbNghiCoPhep.AutoSize = true;
      this.rdbNghiCoPhep.ForeColor = System.Drawing.Color.Black;
      this.rdbNghiCoPhep.Location = new System.Drawing.Point(120, 413);
      this.rdbNghiCoPhep.Name = "rdbNghiCoPhep";
      this.rdbNghiCoPhep.Size = new System.Drawing.Size(122, 21);
      this.rdbNghiCoPhep.TabIndex = 7;
      this.rdbNghiCoPhep.TabStop = true;
      this.rdbNghiCoPhep.Text = "Nghỉ có phép";
      this.rdbNghiCoPhep.UseVisualStyleBackColor = true;
      this.rdbNghiCoPhep.CheckedChanged += new System.EventHandler(this.rdbNghiCoPhep_CheckedChanged);
      this.rdbNghiCoPhep.EnabledChanged += new System.EventHandler(this.rdbNghiCoPhep_EnabledChanged);
      // 
      // rdbDiTre
      // 
      this.rdbDiTre.AutoSize = true;
      this.rdbDiTre.ForeColor = System.Drawing.Color.Black;
      this.rdbDiTre.Location = new System.Drawing.Point(15, 440);
      this.rdbDiTre.Name = "rdbDiTre";
      this.rdbDiTre.Size = new System.Drawing.Size(66, 21);
      this.rdbDiTre.TabIndex = 6;
      this.rdbDiTre.TabStop = true;
      this.rdbDiTre.Text = "Đi trễ";
      this.rdbDiTre.UseVisualStyleBackColor = true;
      this.rdbDiTre.CheckedChanged += new System.EventHandler(this.rdbDiTre_CheckedChanged);
      this.rdbDiTre.EnabledChanged += new System.EventHandler(this.rdbDiTre_EnabledChanged);
      // 
      // rdbDiLam
      // 
      this.rdbDiLam.AutoSize = true;
      this.rdbDiLam.ForeColor = System.Drawing.Color.Black;
      this.rdbDiLam.Location = new System.Drawing.Point(15, 413);
      this.rdbDiLam.Name = "rdbDiLam";
      this.rdbDiLam.Size = new System.Drawing.Size(71, 21);
      this.rdbDiLam.TabIndex = 5;
      this.rdbDiLam.TabStop = true;
      this.rdbDiLam.Text = "Đi làm";
      this.rdbDiLam.UseVisualStyleBackColor = true;
      this.rdbDiLam.CheckedChanged += new System.EventHandler(this.rdbDiLam_CheckedChanged);
      this.rdbDiLam.EnabledChanged += new System.EventHandler(this.rdbDiLam_EnabledChanged);
      // 
      // colMaBanGhiSang
      // 
      this.colMaBanGhiSang.DataPropertyName = "MaBanGhi";
      this.colMaBanGhiSang.HeaderText = "Mã Bản Ghi";
      this.colMaBanGhiSang.Name = "colMaBanGhiSang";
      this.colMaBanGhiSang.ReadOnly = true;
      this.colMaBanGhiSang.Visible = false;
      // 
      // colMaNVSang
      // 
      this.colMaNVSang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colMaNVSang.DataPropertyName = "MaNhanVien";
      this.colMaNVSang.HeaderText = "Mã NV";
      this.colMaNVSang.Name = "colMaNVSang";
      this.colMaNVSang.ReadOnly = true;
      this.colMaNVSang.Width = 55;
      // 
      // colHoTenSang
      // 
      this.colHoTenSang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colHoTenSang.DataPropertyName = "MaNhanVien";
      this.colHoTenSang.HeaderText = "Họ Tên";
      this.colHoTenSang.Name = "colHoTenSang";
      this.colHoTenSang.ReadOnly = true;
      // 
      // colNgayLamSang
      // 
      this.colNgayLamSang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colNgayLamSang.DataPropertyName = "NgayLamViec";
      this.colNgayLamSang.HeaderText = "Ngày Làm";
      this.colNgayLamSang.Name = "colNgayLamSang";
      this.colNgayLamSang.ReadOnly = true;
      this.colNgayLamSang.Width = 96;
      // 
      // colCaLamSang
      // 
      this.colCaLamSang.DataPropertyName = "MaCaLamViec";
      this.colCaLamSang.HeaderText = "Ca Làm";
      this.colCaLamSang.Name = "colCaLamSang";
      this.colCaLamSang.ReadOnly = true;
      this.colCaLamSang.Visible = false;
      // 
      // colCoMatSang
      // 
      this.colCoMatSang.DataPropertyName = "CoMat";
      this.colCoMatSang.HeaderText = "Có Mặt";
      this.colCoMatSang.Name = "colCoMatSang";
      this.colCoMatSang.ReadOnly = true;
      this.colCoMatSang.Visible = false;
      // 
      // colNghiCoPhepSang
      // 
      this.colNghiCoPhepSang.DataPropertyName = "NghiCoPhep";
      this.colNghiCoPhepSang.HeaderText = "Nghỉ Có Phép";
      this.colNghiCoPhepSang.Name = "colNghiCoPhepSang";
      this.colNghiCoPhepSang.ReadOnly = true;
      this.colNghiCoPhepSang.Visible = false;
      // 
      // colTrangThaiSang
      // 
      this.colTrangThaiSang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colTrangThaiSang.DataPropertyName = "TrangThai";
      this.colTrangThaiSang.HeaderText = "Trạng Thái";
      this.colTrangThaiSang.Name = "colTrangThaiSang";
      this.colTrangThaiSang.ReadOnly = true;
      this.colTrangThaiSang.Width = 104;
      // 
      // colMaBanGhiChieu
      // 
      this.colMaBanGhiChieu.DataPropertyName = "MaBanGhi";
      this.colMaBanGhiChieu.HeaderText = "Mã Bản Ghi";
      this.colMaBanGhiChieu.Name = "colMaBanGhiChieu";
      this.colMaBanGhiChieu.ReadOnly = true;
      this.colMaBanGhiChieu.Visible = false;
      // 
      // colMaNVChieu
      // 
      this.colMaNVChieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colMaNVChieu.DataPropertyName = "MaNhanVien";
      this.colMaNVChieu.HeaderText = "Mã NV";
      this.colMaNVChieu.Name = "colMaNVChieu";
      this.colMaNVChieu.ReadOnly = true;
      this.colMaNVChieu.Width = 55;
      // 
      // colHoTenChieu
      // 
      this.colHoTenChieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colHoTenChieu.DataPropertyName = "MaNhanVien";
      this.colHoTenChieu.HeaderText = "Họ Tên";
      this.colHoTenChieu.Name = "colHoTenChieu";
      this.colHoTenChieu.ReadOnly = true;
      // 
      // colNgayLamChieu
      // 
      this.colNgayLamChieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colNgayLamChieu.DataPropertyName = "NgayLamViec";
      this.colNgayLamChieu.HeaderText = "Ngày Làm";
      this.colNgayLamChieu.Name = "colNgayLamChieu";
      this.colNgayLamChieu.ReadOnly = true;
      this.colNgayLamChieu.Width = 96;
      // 
      // colCaLamChieu
      // 
      this.colCaLamChieu.DataPropertyName = "MaCaLamViec";
      this.colCaLamChieu.HeaderText = "Ca Làm";
      this.colCaLamChieu.Name = "colCaLamChieu";
      this.colCaLamChieu.ReadOnly = true;
      this.colCaLamChieu.Visible = false;
      // 
      // colCoMatChieu
      // 
      this.colCoMatChieu.DataPropertyName = "CoMat";
      this.colCoMatChieu.HeaderText = "Có Mặt";
      this.colCoMatChieu.Name = "colCoMatChieu";
      this.colCoMatChieu.ReadOnly = true;
      this.colCoMatChieu.Visible = false;
      // 
      // colNghiCoPhepChieu
      // 
      this.colNghiCoPhepChieu.DataPropertyName = "NghiCoPhep";
      this.colNghiCoPhepChieu.HeaderText = "Nghỉ Có Phép";
      this.colNghiCoPhepChieu.Name = "colNghiCoPhepChieu";
      this.colNghiCoPhepChieu.ReadOnly = true;
      this.colNghiCoPhepChieu.Visible = false;
      // 
      // colTrangThaiChieu
      // 
      this.colTrangThaiChieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colTrangThaiChieu.DataPropertyName = "TrangThai";
      this.colTrangThaiChieu.HeaderText = "Trạng Thái";
      this.colTrangThaiChieu.Name = "colTrangThaiChieu";
      this.colTrangThaiChieu.ReadOnly = true;
      this.colTrangThaiChieu.Width = 104;
      // 
      // rdbChuaChapCong
      // 
      this.rdbChuaChapCong.AutoSize = true;
      this.rdbChuaChapCong.Location = new System.Drawing.Point(295, 413);
      this.rdbChuaChapCong.Name = "rdbChuaChapCong";
      this.rdbChuaChapCong.Size = new System.Drawing.Size(146, 21);
      this.rdbChuaChapCong.TabIndex = 17;
      this.rdbChuaChapCong.TabStop = true;
      this.rdbChuaChapCong.Text = "Chưa chấm công";
      this.rdbChuaChapCong.UseVisualStyleBackColor = true;
      // 
      // urcChiTietBanPhanCong
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.grbChamCong);
      this.Name = "urcChiTietBanPhanCong";
      this.Size = new System.Drawing.Size(930, 530);
      this.Load += new System.EventHandler(this.urcChiTietBanPhanCong_Load);
      this.grbChamCong.ResumeLayout(false);
      this.grbChamCong.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDSNVCaChieu)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDSNVCaSang)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox grbChamCong;
    private System.Windows.Forms.Label lblCaChieu;
    private System.Windows.Forms.Label lblCaSang;
    private System.Windows.Forms.RadioButton rdbNghiKhongPhep;
    private System.Windows.Forms.RadioButton rdbNghiCoPhep;
    private System.Windows.Forms.RadioButton rdbDiTre;
    private System.Windows.Forms.RadioButton rdbDiLam;
    private System.Windows.Forms.DateTimePicker dtpNgayLam;
    private System.Windows.Forms.DataGridView dgvDSNVCaSang;
    private System.Windows.Forms.DataGridView dgvDSNVCaChieu;
    private System.Windows.Forms.Button btnHuyThaoTac;
    private System.Windows.Forms.Button btnLuuThayDoi;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaBanGhiChieu;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaNVChieu;
    private System.Windows.Forms.DataGridViewTextBoxColumn colHoTenChieu;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLamChieu;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCaLamChieu;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCoMatChieu;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNghiCoPhepChieu;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThaiChieu;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaBanGhiSang;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaNVSang;
    private System.Windows.Forms.DataGridViewTextBoxColumn colHoTenSang;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLamSang;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCaLamSang;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCoMatSang;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNghiCoPhepSang;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThaiSang;
    private System.Windows.Forms.RadioButton rdbChuaChapCong;
  }
}
