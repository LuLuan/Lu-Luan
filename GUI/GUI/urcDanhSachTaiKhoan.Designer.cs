namespace GUI
{
    partial class urcDanhSachTaiKhoan
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dgvDSTK = new System.Windows.Forms.DataGridView();
      this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colMaDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colMaKhanCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colQuyenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.grbDSTaiKhoan = new System.Windows.Forms.GroupBox();
      this.txtHoTen_TK = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.grbTTTaiKhoan = new System.Windows.Forms.GroupBox();
      this.btnCapNhat = new System.Windows.Forms.Button();
      this.btnHuyThaoTac = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
      this.label5 = new System.Windows.Forms.Label();
      this.cboTrangThai = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.cboQuyenDangNhap = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtMaKhanCap = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtMatKhau = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtMaDangNhap = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).BeginInit();
      this.grbDSTaiKhoan.SuspendLayout();
      this.grbTTTaiKhoan.SuspendLayout();
      this.SuspendLayout();
      // 
      // dgvDSTK
      // 
      this.dgvDSTK.AllowUserToAddRows = false;
      this.dgvDSTK.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvDSTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvDSTK.ColumnHeadersHeight = 50;
      this.dgvDSTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHoTen,
            this.colMaDangNhap,
            this.colMatKhau,
            this.colMaKhanCap,
            this.colQuyenDangNhap,
            this.colNgayTao,
            this.colTrangThai});
      this.dgvDSTK.Location = new System.Drawing.Point(6, 88);
      this.dgvDSTK.MultiSelect = false;
      this.dgvDSTK.Name = "dgvDSTK";
      this.dgvDSTK.ReadOnly = true;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvDSTK.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.dgvDSTK.RowHeadersVisible = false;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.dgvDSTK.RowsDefaultCellStyle = dataGridViewCellStyle3;
      this.dgvDSTK.RowTemplate.Height = 40;
      this.dgvDSTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvDSTK.Size = new System.Drawing.Size(888, 265);
      this.dgvDSTK.TabIndex = 0;
      this.dgvDSTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTK_CellClick);
      this.dgvDSTK.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDSTK_CellFormatting);
      this.dgvDSTK.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDSTK_DataBindingComplete);
      this.dgvDSTK.SelectionChanged += new System.EventHandler(this.dgvDSTK_SelectionChanged);
      // 
      // colHoTen
      // 
      this.colHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colHoTen.DataPropertyName = "MaDangNhap";
      this.colHoTen.HeaderText = "Họ Tên";
      this.colHoTen.Name = "colHoTen";
      this.colHoTen.ReadOnly = true;
      // 
      // colMaDangNhap
      // 
      this.colMaDangNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colMaDangNhap.DataPropertyName = "MaDangNhap";
      this.colMaDangNhap.HeaderText = "Mã Đăng Nhập";
      this.colMaDangNhap.Name = "colMaDangNhap";
      this.colMaDangNhap.ReadOnly = true;
      this.colMaDangNhap.Width = 128;
      // 
      // colMatKhau
      // 
      this.colMatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colMatKhau.DataPropertyName = "MatKhau";
      this.colMatKhau.HeaderText = "Mật Khẩu";
      this.colMatKhau.Name = "colMatKhau";
      this.colMatKhau.ReadOnly = true;
      this.colMatKhau.Width = 93;
      // 
      // colMaKhanCap
      // 
      this.colMaKhanCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colMaKhanCap.DataPropertyName = "MaKhanCap";
      this.colMaKhanCap.HeaderText = "Mã Khẩn Cấp";
      this.colMaKhanCap.Name = "colMaKhanCap";
      this.colMaKhanCap.ReadOnly = true;
      this.colMaKhanCap.Width = 118;
      // 
      // colQuyenDangNhap
      // 
      this.colQuyenDangNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colQuyenDangNhap.DataPropertyName = "MaQuyenDangNhap";
      this.colQuyenDangNhap.HeaderText = "Quyền Đăng Nhập";
      this.colQuyenDangNhap.Name = "colQuyenDangNhap";
      this.colQuyenDangNhap.ReadOnly = true;
      this.colQuyenDangNhap.Width = 117;
      // 
      // colNgayTao
      // 
      this.colNgayTao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colNgayTao.DataPropertyName = "NgayTao";
      this.colNgayTao.HeaderText = "Ngày Tạo";
      this.colNgayTao.Name = "colNgayTao";
      this.colNgayTao.ReadOnly = true;
      this.colNgayTao.Width = 95;
      // 
      // colTrangThai
      // 
      this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colTrangThai.DataPropertyName = "TrangThai";
      this.colTrangThai.HeaderText = "Trạng Thái";
      this.colTrangThai.Name = "colTrangThai";
      this.colTrangThai.ReadOnly = true;
      this.colTrangThai.Width = 104;
      // 
      // grbDSTaiKhoan
      // 
      this.grbDSTaiKhoan.Controls.Add(this.txtHoTen_TK);
      this.grbDSTaiKhoan.Controls.Add(this.label7);
      this.grbDSTaiKhoan.Controls.Add(this.dgvDSTK);
      this.grbDSTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.grbDSTaiKhoan.Location = new System.Drawing.Point(15, 168);
      this.grbDSTaiKhoan.Name = "grbDSTaiKhoan";
      this.grbDSTaiKhoan.Size = new System.Drawing.Size(900, 359);
      this.grbDSTaiKhoan.TabIndex = 3;
      this.grbDSTaiKhoan.TabStop = false;
      this.grbDSTaiKhoan.Text = "Danh sách nhân viên";
      // 
      // txtHoTen_TK
      // 
      this.txtHoTen_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtHoTen_TK.Location = new System.Drawing.Point(204, 48);
      this.txtHoTen_TK.Name = "txtHoTen_TK";
      this.txtHoTen_TK.Size = new System.Drawing.Size(183, 23);
      this.txtHoTen_TK.TabIndex = 4;
      this.txtHoTen_TK.TextChanged += new System.EventHandler(this.txtHoTen_TK_TextChanged);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(27, 51);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(160, 17);
      this.label7.TabIndex = 3;
      this.label7.Text = "Tìm kiếm theo họ tên";
      // 
      // grbTTTaiKhoan
      // 
      this.grbTTTaiKhoan.Controls.Add(this.btnCapNhat);
      this.grbTTTaiKhoan.Controls.Add(this.btnHuyThaoTac);
      this.grbTTTaiKhoan.Controls.Add(this.label6);
      this.grbTTTaiKhoan.Controls.Add(this.dtpNgayDangKy);
      this.grbTTTaiKhoan.Controls.Add(this.label5);
      this.grbTTTaiKhoan.Controls.Add(this.cboTrangThai);
      this.grbTTTaiKhoan.Controls.Add(this.label4);
      this.grbTTTaiKhoan.Controls.Add(this.cboQuyenDangNhap);
      this.grbTTTaiKhoan.Controls.Add(this.label3);
      this.grbTTTaiKhoan.Controls.Add(this.txtMaKhanCap);
      this.grbTTTaiKhoan.Controls.Add(this.label2);
      this.grbTTTaiKhoan.Controls.Add(this.txtMatKhau);
      this.grbTTTaiKhoan.Controls.Add(this.label1);
      this.grbTTTaiKhoan.Controls.Add(this.txtMaDangNhap);
      this.grbTTTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.grbTTTaiKhoan.Location = new System.Drawing.Point(15, 0);
      this.grbTTTaiKhoan.Name = "grbTTTaiKhoan";
      this.grbTTTaiKhoan.Size = new System.Drawing.Size(900, 162);
      this.grbTTTaiKhoan.TabIndex = 4;
      this.grbTTTaiKhoan.TabStop = false;
      this.grbTTTaiKhoan.Text = "Thông tin tài khoản";
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
      this.btnCapNhat.Location = new System.Drawing.Point(704, 38);
      this.btnCapNhat.Name = "btnCapNhat";
      this.btnCapNhat.Size = new System.Drawing.Size(153, 37);
      this.btnCapNhat.TabIndex = 65;
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
      this.btnHuyThaoTac.Location = new System.Drawing.Point(704, 82);
      this.btnHuyThaoTac.Name = "btnHuyThaoTac";
      this.btnHuyThaoTac.Size = new System.Drawing.Size(153, 37);
      this.btnHuyThaoTac.TabIndex = 64;
      this.btnHuyThaoTac.Text = "  Hủy thao tác";
      this.btnHuyThaoTac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnHuyThaoTac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnHuyThaoTac.UseVisualStyleBackColor = true;
      this.btnHuyThaoTac.Click += new System.EventHandler(this.btnHuyThaoTac_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(401, 101);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(73, 17);
      this.label6.TabIndex = 11;
      this.label6.Text = "Ngày tạo";
      // 
      // dtpNgayDangKy
      // 
      this.dtpNgayDangKy.Enabled = false;
      this.dtpNgayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpNgayDangKy.Location = new System.Drawing.Point(506, 96);
      this.dtpNgayDangKy.Name = "dtpNgayDangKy";
      this.dtpNgayDangKy.Size = new System.Drawing.Size(180, 23);
      this.dtpNgayDangKy.TabIndex = 10;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(47, 101);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(83, 17);
      this.label5.TabIndex = 9;
      this.label5.Text = "Trạng thái";
      // 
      // cboTrangThai
      // 
      this.cboTrangThai.FormattingEnabled = true;
      this.cboTrangThai.Location = new System.Drawing.Point(194, 98);
      this.cboTrangThai.Name = "cboTrangThai";
      this.cboTrangThai.Size = new System.Drawing.Size(180, 24);
      this.cboTrangThai.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(47, 70);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(137, 17);
      this.label4.TabIndex = 7;
      this.label4.Text = "Quyền đăng nhập";
      // 
      // cboQuyenDangNhap
      // 
      this.cboQuyenDangNhap.FormattingEnabled = true;
      this.cboQuyenDangNhap.Location = new System.Drawing.Point(194, 67);
      this.cboQuyenDangNhap.Name = "cboQuyenDangNhap";
      this.cboQuyenDangNhap.Size = new System.Drawing.Size(180, 24);
      this.cboQuyenDangNhap.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(401, 70);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(100, 17);
      this.label3.TabIndex = 5;
      this.label3.Text = "Mã khẩn cấp";
      // 
      // txtMaKhanCap
      // 
      this.txtMaKhanCap.Location = new System.Drawing.Point(506, 67);
      this.txtMaKhanCap.MaxLength = 6;
      this.txtMaKhanCap.Name = "txtMaKhanCap";
      this.txtMaKhanCap.Size = new System.Drawing.Size(180, 23);
      this.txtMaKhanCap.TabIndex = 4;
      this.txtMaKhanCap.TextChanged += new System.EventHandler(this.txtMaKhanCap_TextChanged);
      this.txtMaKhanCap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKhanCap_KeyPress);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(401, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(74, 17);
      this.label2.TabIndex = 3;
      this.label2.Text = "Mật khẩu";
      // 
      // txtMatKhau
      // 
      this.txtMatKhau.Location = new System.Drawing.Point(506, 38);
      this.txtMatKhau.MaxLength = 20;
      this.txtMatKhau.Name = "txtMatKhau";
      this.txtMatKhau.Size = new System.Drawing.Size(180, 23);
      this.txtMatKhau.TabIndex = 2;
      this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(47, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(111, 17);
      this.label1.TabIndex = 1;
      this.label1.Text = "Mã đăng nhập";
      // 
      // txtMaDangNhap
      // 
      this.txtMaDangNhap.Location = new System.Drawing.Point(194, 38);
      this.txtMaDangNhap.MaxLength = 6;
      this.txtMaDangNhap.Name = "txtMaDangNhap";
      this.txtMaDangNhap.ReadOnly = true;
      this.txtMaDangNhap.Size = new System.Drawing.Size(180, 23);
      this.txtMaDangNhap.TabIndex = 0;
      // 
      // urcDanhSachTaiKhoan
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.MintCream;
      this.Controls.Add(this.grbTTTaiKhoan);
      this.Controls.Add(this.grbDSTaiKhoan);
      this.Name = "urcDanhSachTaiKhoan";
      this.Size = new System.Drawing.Size(930, 530);
      this.Load += new System.EventHandler(this.urcDanhSachTaiKhoan_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).EndInit();
      this.grbDSTaiKhoan.ResumeLayout(false);
      this.grbDSTaiKhoan.PerformLayout();
      this.grbTTTaiKhoan.ResumeLayout(false);
      this.grbTTTaiKhoan.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhanCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuyenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.GroupBox grbDSTaiKhoan;
        private System.Windows.Forms.GroupBox grbTTTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKhanCap;
        private System.Windows.Forms.ComboBox cboQuyenDangNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnHuyThaoTac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHoTen_TK;
        private System.Windows.Forms.ComboBox cboTrangThai;
    }
}
