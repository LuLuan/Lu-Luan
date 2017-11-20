namespace GUI
{
    partial class urcDanhSachKhachHang
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
      this.grbDSKhachHang = new System.Windows.Forms.GroupBox();
      this.rdbTrangThaiCoSan_TK = new System.Windows.Forms.RadioButton();
      this.rdbTrangThaiDaXoa_TK = new System.Windows.Forms.RadioButton();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.txtHoTen_TK = new System.Windows.Forms.TextBox();
      this.dgvDSKH = new System.Windows.Forms.DataGridView();
      this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.grbTTKhachHang = new System.Windows.Forms.GroupBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.rdbTrangThaiCoSan = new System.Windows.Forms.RadioButton();
      this.rdbNu = new System.Windows.Forms.RadioButton();
      this.rdbNam = new System.Windows.Forms.RadioButton();
      this.btnCapNhat = new System.Windows.Forms.Button();
      this.btnHuyThaoTac = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtDiaChi = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtMaKH = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.txtSoDienThoai = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.txtHoTen = new System.Windows.Forms.TextBox();
      this.grbDSKhachHang.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).BeginInit();
      this.grbTTKhachHang.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // grbDSKhachHang
      // 
      this.grbDSKhachHang.Controls.Add(this.rdbTrangThaiCoSan_TK);
      this.grbDSKhachHang.Controls.Add(this.rdbTrangThaiDaXoa_TK);
      this.grbDSKhachHang.Controls.Add(this.label8);
      this.grbDSKhachHang.Controls.Add(this.label7);
      this.grbDSKhachHang.Controls.Add(this.txtHoTen_TK);
      this.grbDSKhachHang.Controls.Add(this.dgvDSKH);
      this.grbDSKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.grbDSKhachHang.Location = new System.Drawing.Point(15, 188);
      this.grbDSKhachHang.Name = "grbDSKhachHang";
      this.grbDSKhachHang.Size = new System.Drawing.Size(900, 339);
      this.grbDSKhachHang.TabIndex = 1;
      this.grbDSKhachHang.TabStop = false;
      this.grbDSKhachHang.Text = "Danh sách khách hàng";
      // 
      // rdbTrangThaiCoSan_TK
      // 
      this.rdbTrangThaiCoSan_TK.AutoSize = true;
      this.rdbTrangThaiCoSan_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.rdbTrangThaiCoSan_TK.Location = new System.Drawing.Point(421, 36);
      this.rdbTrangThaiCoSan_TK.Name = "rdbTrangThaiCoSan_TK";
      this.rdbTrangThaiCoSan_TK.Size = new System.Drawing.Size(76, 21);
      this.rdbTrangThaiCoSan_TK.TabIndex = 90;
      this.rdbTrangThaiCoSan_TK.TabStop = true;
      this.rdbTrangThaiCoSan_TK.Text = "Có sẵn";
      this.rdbTrangThaiCoSan_TK.UseVisualStyleBackColor = true;
      this.rdbTrangThaiCoSan_TK.Visible = false;
      this.rdbTrangThaiCoSan_TK.CheckedChanged += new System.EventHandler(this.rdbTrangThaiCoSan_TK_CheckedChanged);
      // 
      // rdbTrangThaiDaXoa_TK
      // 
      this.rdbTrangThaiDaXoa_TK.AutoSize = true;
      this.rdbTrangThaiDaXoa_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.rdbTrangThaiDaXoa_TK.Location = new System.Drawing.Point(503, 36);
      this.rdbTrangThaiDaXoa_TK.Name = "rdbTrangThaiDaXoa_TK";
      this.rdbTrangThaiDaXoa_TK.Size = new System.Drawing.Size(76, 21);
      this.rdbTrangThaiDaXoa_TK.TabIndex = 91;
      this.rdbTrangThaiDaXoa_TK.TabStop = true;
      this.rdbTrangThaiDaXoa_TK.Text = "Đã xóa";
      this.rdbTrangThaiDaXoa_TK.UseVisualStyleBackColor = true;
      this.rdbTrangThaiDaXoa_TK.Visible = false;
      this.rdbTrangThaiDaXoa_TK.CheckedChanged += new System.EventHandler(this.rdbTrangThaiDaXoa_TK_CheckedChanged);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label8.Location = new System.Drawing.Point(322, 38);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(83, 17);
      this.label8.TabIndex = 89;
      this.label8.Text = "Trạng thái";
      this.label8.Visible = false;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label7.Location = new System.Drawing.Point(71, 38);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(56, 17);
      this.label7.TabIndex = 71;
      this.label7.Text = "Họ tên";
      // 
      // txtHoTen_TK
      // 
      this.txtHoTen_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtHoTen_TK.Location = new System.Drawing.Point(150, 35);
      this.txtHoTen_TK.Name = "txtHoTen_TK";
      this.txtHoTen_TK.Size = new System.Drawing.Size(150, 23);
      this.txtHoTen_TK.TabIndex = 70;
      this.txtHoTen_TK.TextChanged += new System.EventHandler(this.txtHoTen_TK_TextChanged);
      // 
      // dgvDSKH
      // 
      this.dgvDSKH.AllowUserToAddRows = false;
      this.dgvDSKH.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvDSKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvDSKH.ColumnHeadersHeight = 40;
      this.dgvDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvDSKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKH,
            this.colTenKH,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colDiaChi,
            this.colEmail,
            this.colSDT,
            this.colTrangThai});
      this.dgvDSKH.EnableHeadersVisualStyles = false;
      this.dgvDSKH.Location = new System.Drawing.Point(6, 68);
      this.dgvDSKH.MultiSelect = false;
      this.dgvDSKH.Name = "dgvDSKH";
      this.dgvDSKH.ReadOnly = true;
      this.dgvDSKH.RowHeadersVisible = false;
      this.dgvDSKH.RowHeadersWidth = 50;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvDSKH.RowsDefaultCellStyle = dataGridViewCellStyle2;
      this.dgvDSKH.RowTemplate.Height = 40;
      this.dgvDSKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvDSKH.Size = new System.Drawing.Size(888, 265);
      this.dgvDSKH.TabIndex = 0;
      this.dgvDSKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKH_CellClick);
      this.dgvDSKH.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDSKH_CellFormatting);
      this.dgvDSKH.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDSKH_DataBindingComplete);
      this.dgvDSKH.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDSKH_RowPostPaint);
      this.dgvDSKH.SelectionChanged += new System.EventHandler(this.dgvDSKH_SelectionChanged);
      this.dgvDSKH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDSKH_KeyUp);
      // 
      // colMaKH
      // 
      this.colMaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colMaKH.DataPropertyName = "MaKhachHang";
      this.colMaKH.HeaderText = "Mã KH";
      this.colMaKH.Name = "colMaKH";
      this.colMaKH.ReadOnly = true;
      this.colMaKH.Width = 80;
      // 
      // colTenKH
      // 
      this.colTenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colTenKH.DataPropertyName = "TenKhachHang";
      this.colTenKH.HeaderText = "Tên KH";
      this.colTenKH.Name = "colTenKH";
      this.colTenKH.ReadOnly = true;
      // 
      // colNgaySinh
      // 
      this.colNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colNgaySinh.DataPropertyName = "NgaySinh";
      this.colNgaySinh.HeaderText = "Ngày sinh";
      this.colNgaySinh.Name = "colNgaySinh";
      this.colNgaySinh.ReadOnly = true;
      this.colNgaySinh.Width = 105;
      // 
      // colGioiTinh
      // 
      this.colGioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colGioiTinh.DataPropertyName = "GioiTinh";
      this.colGioiTinh.HeaderText = "Giới Tính";
      this.colGioiTinh.Name = "colGioiTinh";
      this.colGioiTinh.ReadOnly = true;
      this.colGioiTinh.Width = 99;
      // 
      // colDiaChi
      // 
      this.colDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colDiaChi.DataPropertyName = "DiaChi";
      this.colDiaChi.HeaderText = "Địa Chỉ";
      this.colDiaChi.Name = "colDiaChi";
      this.colDiaChi.ReadOnly = true;
      // 
      // colEmail
      // 
      this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colEmail.DataPropertyName = "Email";
      this.colEmail.HeaderText = "Email";
      this.colEmail.Name = "colEmail";
      this.colEmail.ReadOnly = true;
      this.colEmail.Visible = false;
      this.colEmail.Width = 72;
      // 
      // colSDT
      // 
      this.colSDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colSDT.DataPropertyName = "SoDienThoai";
      this.colSDT.HeaderText = "Điện  Thoại";
      this.colSDT.Name = "colSDT";
      this.colSDT.ReadOnly = true;
      this.colSDT.Width = 117;
      // 
      // colTrangThai
      // 
      this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colTrangThai.DataPropertyName = "TrangThai";
      this.colTrangThai.HeaderText = "Trạng Thái";
      this.colTrangThai.Name = "colTrangThai";
      this.colTrangThai.ReadOnly = true;
      this.colTrangThai.Visible = false;
      this.colTrangThai.Width = 113;
      // 
      // grbTTKhachHang
      // 
      this.grbTTKhachHang.Controls.Add(this.panel1);
      this.grbTTKhachHang.Controls.Add(this.rdbNu);
      this.grbTTKhachHang.Controls.Add(this.rdbNam);
      this.grbTTKhachHang.Controls.Add(this.btnCapNhat);
      this.grbTTKhachHang.Controls.Add(this.btnHuyThaoTac);
      this.grbTTKhachHang.Controls.Add(this.label4);
      this.grbTTKhachHang.Controls.Add(this.label5);
      this.grbTTKhachHang.Controls.Add(this.txtDiaChi);
      this.grbTTKhachHang.Controls.Add(this.label1);
      this.grbTTKhachHang.Controls.Add(this.txtMaKH);
      this.grbTTKhachHang.Controls.Add(this.label11);
      this.grbTTKhachHang.Controls.Add(this.txtSoDienThoai);
      this.grbTTKhachHang.Controls.Add(this.label9);
      this.grbTTKhachHang.Controls.Add(this.label6);
      this.grbTTKhachHang.Controls.Add(this.dtpNgaySinh);
      this.grbTTKhachHang.Controls.Add(this.label2);
      this.grbTTKhachHang.Controls.Add(this.txtHoTen);
      this.grbTTKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.grbTTKhachHang.Location = new System.Drawing.Point(15, 0);
      this.grbTTKhachHang.Name = "grbTTKhachHang";
      this.grbTTKhachHang.Size = new System.Drawing.Size(900, 182);
      this.grbTTKhachHang.TabIndex = 0;
      this.grbTTKhachHang.TabStop = false;
      this.grbTTKhachHang.Text = "Thông tin khách hàng";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.rdbTrangThaiCoSan);
      this.panel1.Location = new System.Drawing.Point(499, 105);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(158, 18);
      this.panel1.TabIndex = 96;
      // 
      // rdbTrangThaiCoSan
      // 
      this.rdbTrangThaiCoSan.AutoSize = true;
      this.rdbTrangThaiCoSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.rdbTrangThaiCoSan.Location = new System.Drawing.Point(0, -1);
      this.rdbTrangThaiCoSan.Name = "rdbTrangThaiCoSan";
      this.rdbTrangThaiCoSan.Size = new System.Drawing.Size(76, 21);
      this.rdbTrangThaiCoSan.TabIndex = 86;
      this.rdbTrangThaiCoSan.TabStop = true;
      this.rdbTrangThaiCoSan.Text = "Có sẵn";
      this.rdbTrangThaiCoSan.UseVisualStyleBackColor = true;
      // 
      // rdbNu
      // 
      this.rdbNu.AutoSize = true;
      this.rdbNu.Location = new System.Drawing.Point(281, 76);
      this.rdbNu.Name = "rdbNu";
      this.rdbNu.Size = new System.Drawing.Size(46, 21);
      this.rdbNu.TabIndex = 93;
      this.rdbNu.TabStop = true;
      this.rdbNu.Text = "Nữ";
      this.rdbNu.UseVisualStyleBackColor = true;
      // 
      // rdbNam
      // 
      this.rdbNam.AutoSize = true;
      this.rdbNam.Location = new System.Drawing.Point(217, 76);
      this.rdbNam.Name = "rdbNam";
      this.rdbNam.Size = new System.Drawing.Size(58, 21);
      this.rdbNam.TabIndex = 92;
      this.rdbNam.TabStop = true;
      this.rdbNam.Text = "Nam";
      this.rdbNam.UseVisualStyleBackColor = true;
      // 
      // btnCapNhat
      // 
      this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnCapNhat.FlatAppearance.BorderSize = 0;
      this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnCapNhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
      this.btnCapNhat.Image = global::GUI.Properties.Resources.Save;
      this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnCapNhat.Location = new System.Drawing.Point(688, 44);
      this.btnCapNhat.Name = "btnCapNhat";
      this.btnCapNhat.Size = new System.Drawing.Size(155, 37);
      this.btnCapNhat.TabIndex = 90;
      this.btnCapNhat.Text = "  Cập nhật";
      this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnCapNhat.UseVisualStyleBackColor = true;
      this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
      // 
      // btnHuyThaoTac
      // 
      this.btnHuyThaoTac.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnHuyThaoTac.FlatAppearance.BorderSize = 0;
      this.btnHuyThaoTac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnHuyThaoTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnHuyThaoTac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
      this.btnHuyThaoTac.Image = global::GUI.Properties.Resources.Cleaner;
      this.btnHuyThaoTac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnHuyThaoTac.Location = new System.Drawing.Point(689, 87);
      this.btnHuyThaoTac.Name = "btnHuyThaoTac";
      this.btnHuyThaoTac.Size = new System.Drawing.Size(154, 37);
      this.btnHuyThaoTac.TabIndex = 89;
      this.btnHuyThaoTac.Text = "  Hủy thao tác";
      this.btnHuyThaoTac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnHuyThaoTac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnHuyThaoTac.UseVisualStyleBackColor = true;
      this.btnHuyThaoTac.Click += new System.EventHandler(this.btnHuyThaoTac_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label4.Location = new System.Drawing.Point(401, 106);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(83, 17);
      this.label4.TabIndex = 85;
      this.label4.Text = "Trạng thái";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label5.Location = new System.Drawing.Point(82, 132);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(58, 17);
      this.label5.TabIndex = 84;
      this.label5.Text = "Địa chỉ";
      // 
      // txtDiaChi
      // 
      this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtDiaChi.Location = new System.Drawing.Point(217, 129);
      this.txtDiaChi.MaxLength = 250;
      this.txtDiaChi.Name = "txtDiaChi";
      this.txtDiaChi.Size = new System.Drawing.Size(440, 23);
      this.txtDiaChi.TabIndex = 83;
      this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label1.Location = new System.Drawing.Point(82, 50);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(118, 17);
      this.label1.TabIndex = 80;
      this.label1.Text = "Mã khách hàng";
      // 
      // txtMaKH
      // 
      this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtMaKH.Location = new System.Drawing.Point(217, 47);
      this.txtMaKH.Name = "txtMaKH";
      this.txtMaKH.ReadOnly = true;
      this.txtMaKH.Size = new System.Drawing.Size(156, 23);
      this.txtMaKH.TabIndex = 79;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label11.Location = new System.Drawing.Point(82, 103);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(82, 17);
      this.label11.TabIndex = 76;
      this.label11.Text = "Điện thoại";
      // 
      // txtSoDienThoai
      // 
      this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtSoDienThoai.Location = new System.Drawing.Point(217, 100);
      this.txtSoDienThoai.MaxLength = 13;
      this.txtSoDienThoai.Name = "txtSoDienThoai";
      this.txtSoDienThoai.ShortcutsEnabled = false;
      this.txtSoDienThoai.Size = new System.Drawing.Size(156, 23);
      this.txtSoDienThoai.TabIndex = 75;
      this.txtSoDienThoai.TextChanged += new System.EventHandler(this.txtSoDienThoai_TextChanged);
      this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label9.Location = new System.Drawing.Point(82, 78);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(69, 17);
      this.label9.TabIndex = 72;
      this.label9.Text = "Giới tính";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label6.Location = new System.Drawing.Point(401, 78);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(80, 17);
      this.label6.TabIndex = 71;
      this.label6.Text = "Ngày sinh";
      // 
      // dtpNgaySinh
      // 
      this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpNgaySinh.Location = new System.Drawing.Point(499, 76);
      this.dtpNgaySinh.Name = "dtpNgaySinh";
      this.dtpNgaySinh.Size = new System.Drawing.Size(156, 23);
      this.dtpNgaySinh.TabIndex = 70;
      this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label2.Location = new System.Drawing.Point(401, 50);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 17);
      this.label2.TabIndex = 69;
      this.label2.Text = "Họ tên";
      // 
      // txtHoTen
      // 
      this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtHoTen.Location = new System.Drawing.Point(499, 44);
      this.txtHoTen.MaxLength = 50;
      this.txtHoTen.Name = "txtHoTen";
      this.txtHoTen.Size = new System.Drawing.Size(156, 23);
      this.txtHoTen.TabIndex = 68;
      this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
      // 
      // urcDanhSachKhachHang
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.MintCream;
      this.Controls.Add(this.grbDSKhachHang);
      this.Controls.Add(this.grbTTKhachHang);
      this.Name = "urcDanhSachKhachHang";
      this.Size = new System.Drawing.Size(930, 530);
      this.Load += new System.EventHandler(this.urcDanhSachKhachHang_Load);
      this.grbDSKhachHang.ResumeLayout(false);
      this.grbDSKhachHang.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).EndInit();
      this.grbTTKhachHang.ResumeLayout(false);
      this.grbTTKhachHang.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTKhachHang;
        private System.Windows.Forms.GroupBox grbDSKhachHang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDSKH;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnHuyThaoTac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHoTen_TK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbTrangThaiCoSan;
        private System.Windows.Forms.RadioButton rdbTrangThaiCoSan_TK;
        private System.Windows.Forms.RadioButton rdbTrangThaiDaXoa_TK;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
