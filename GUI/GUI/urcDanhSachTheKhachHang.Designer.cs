namespace GUI
{
    partial class urcDanhSachTheKhachHang
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
      this.dgvDSTheKH = new System.Windows.Forms.DataGridView();
      this.colMaThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colLoaiThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNgayDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDonViGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.grbDSTheKH = new System.Windows.Forms.GroupBox();
      this.label5 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.grbTTTheKH = new System.Windows.Forms.GroupBox();
      this.txtLoaiThe = new System.Windows.Forms.TextBox();
      this.btnCapNhat = new System.Windows.Forms.Button();
      this.btnHuyThaoTac = new System.Windows.Forms.Button();
      this.rdbTrangThaiMo = new System.Windows.Forms.RadioButton();
      this.rdbTrangThaiDong = new System.Windows.Forms.RadioButton();
      this.label9 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtTenKH = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtMaTheKH = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDSTheKH)).BeginInit();
      this.grbDSTheKH.SuspendLayout();
      this.grbTTTheKH.SuspendLayout();
      this.SuspendLayout();
      // 
      // dgvDSTheKH
      // 
      this.dgvDSTheKH.AllowUserToAddRows = false;
      this.dgvDSTheKH.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvDSTheKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvDSTheKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDSTheKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaThe,
            this.colTenKH,
            this.colLoaiThe,
            this.colNgayDangKy,
            this.colGiamGia,
            this.colDonViGiamGia,
            this.colTrangThai});
      this.dgvDSTheKH.Location = new System.Drawing.Point(6, 58);
      this.dgvDSTheKH.MultiSelect = false;
      this.dgvDSTheKH.Name = "dgvDSTheKH";
      this.dgvDSTheKH.ReadOnly = true;
      this.dgvDSTheKH.RowHeadersVisible = false;
      this.dgvDSTheKH.RowTemplate.Height = 40;
      this.dgvDSTheKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvDSTheKH.Size = new System.Drawing.Size(888, 315);
      this.dgvDSTheKH.TabIndex = 0;
      this.dgvDSTheKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTheKH_CellClick);
      this.dgvDSTheKH.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDSTheKH_CellFormatting);
      this.dgvDSTheKH.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDSTheKH_DataBindingComplete);
      this.dgvDSTheKH.SelectionChanged += new System.EventHandler(this.dgvDSTheKH_SelectionChanged);
      this.dgvDSTheKH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDSTheKH_KeyUp);
      // 
      // colMaThe
      // 
      this.colMaThe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colMaThe.DataPropertyName = "MaThe";
      this.colMaThe.HeaderText = "Mã Thẻ";
      this.colMaThe.Name = "colMaThe";
      this.colMaThe.ReadOnly = true;
      this.colMaThe.Width = 80;
      // 
      // colTenKH
      // 
      this.colTenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colTenKH.DataPropertyName = "MaKhachHang";
      this.colTenKH.HeaderText = "Tên KH";
      this.colTenKH.Name = "colTenKH";
      this.colTenKH.ReadOnly = true;
      // 
      // colLoaiThe
      // 
      this.colLoaiThe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colLoaiThe.DataPropertyName = "MaLoaiThe";
      this.colLoaiThe.HeaderText = "Loại Thẻ";
      this.colLoaiThe.Name = "colLoaiThe";
      this.colLoaiThe.ReadOnly = true;
      this.colLoaiThe.Width = 64;
      // 
      // colNgayDangKy
      // 
      this.colNgayDangKy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colNgayDangKy.DataPropertyName = "NgayDangKy";
      this.colNgayDangKy.HeaderText = "Ngày Đăng Ký";
      this.colNgayDangKy.Name = "colNgayDangKy";
      this.colNgayDangKy.ReadOnly = true;
      this.colNgayDangKy.Width = 108;
      // 
      // colGiamGia
      // 
      this.colGiamGia.DataPropertyName = "GiamGia";
      dataGridViewCellStyle2.Format = "N1";
      dataGridViewCellStyle2.NullValue = null;
      this.colGiamGia.DefaultCellStyle = dataGridViewCellStyle2;
      this.colGiamGia.HeaderText = "Giảm Giá";
      this.colGiamGia.Name = "colGiamGia";
      this.colGiamGia.ReadOnly = true;
      // 
      // colDonViGiamGia
      // 
      this.colDonViGiamGia.DataPropertyName = "DonViGiamGia";
      this.colDonViGiamGia.HeaderText = "Đơn Vị Giảm Giá";
      this.colDonViGiamGia.Name = "colDonViGiamGia";
      this.colDonViGiamGia.ReadOnly = true;
      // 
      // colTrangThai
      // 
      this.colTrangThai.DataPropertyName = "TrangThai";
      this.colTrangThai.HeaderText = "Trạng Thái";
      this.colTrangThai.Name = "colTrangThai";
      this.colTrangThai.ReadOnly = true;
      // 
      // grbDSTheKH
      // 
      this.grbDSTheKH.BackColor = System.Drawing.Color.MintCream;
      this.grbDSTheKH.Controls.Add(this.label5);
      this.grbDSTheKH.Controls.Add(this.textBox3);
      this.grbDSTheKH.Controls.Add(this.label3);
      this.grbDSTheKH.Controls.Add(this.textBox2);
      this.grbDSTheKH.Controls.Add(this.dgvDSTheKH);
      this.grbDSTheKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.grbDSTheKH.Location = new System.Drawing.Point(14, 148);
      this.grbDSTheKH.Name = "grbDSTheKH";
      this.grbDSTheKH.Size = new System.Drawing.Size(900, 379);
      this.grbDSTheKH.TabIndex = 1;
      this.grbDSTheKH.TabStop = false;
      this.grbDSTheKH.Text = "Danh sách thẻ khách hàng";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(270, 32);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(125, 17);
      this.label5.TabIndex = 74;
      this.label5.Text = "Tên khách hàng";
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(401, 29);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(171, 23);
      this.textBox3.TabIndex = 73;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(26, 32);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(57, 17);
      this.label3.TabIndex = 5;
      this.label3.Text = "Mã thẻ";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(89, 29);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(147, 23);
      this.textBox2.TabIndex = 4;
      // 
      // grbTTTheKH
      // 
      this.grbTTTheKH.BackColor = System.Drawing.Color.MintCream;
      this.grbTTTheKH.Controls.Add(this.txtLoaiThe);
      this.grbTTTheKH.Controls.Add(this.btnCapNhat);
      this.grbTTTheKH.Controls.Add(this.btnHuyThaoTac);
      this.grbTTTheKH.Controls.Add(this.rdbTrangThaiMo);
      this.grbTTTheKH.Controls.Add(this.rdbTrangThaiDong);
      this.grbTTTheKH.Controls.Add(this.label9);
      this.grbTTTheKH.Controls.Add(this.label2);
      this.grbTTTheKH.Controls.Add(this.txtTenKH);
      this.grbTTTheKH.Controls.Add(this.label4);
      this.grbTTTheKH.Controls.Add(this.label1);
      this.grbTTTheKH.Controls.Add(this.txtMaTheKH);
      this.grbTTTheKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.grbTTTheKH.Location = new System.Drawing.Point(14, 3);
      this.grbTTTheKH.Name = "grbTTTheKH";
      this.grbTTTheKH.Size = new System.Drawing.Size(900, 139);
      this.grbTTTheKH.TabIndex = 2;
      this.grbTTTheKH.TabStop = false;
      this.grbTTTheKH.Text = "Thông tin thẻ khách hàng";
      // 
      // txtLoaiThe
      // 
      this.txtLoaiThe.Location = new System.Drawing.Point(495, 34);
      this.txtLoaiThe.Name = "txtLoaiThe";
      this.txtLoaiThe.ReadOnly = true;
      this.txtLoaiThe.Size = new System.Drawing.Size(180, 23);
      this.txtLoaiThe.TabIndex = 80;
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
      this.btnCapNhat.Location = new System.Drawing.Point(702, 33);
      this.btnCapNhat.Name = "btnCapNhat";
      this.btnCapNhat.Size = new System.Drawing.Size(153, 37);
      this.btnCapNhat.TabIndex = 79;
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
      this.btnHuyThaoTac.Location = new System.Drawing.Point(702, 76);
      this.btnHuyThaoTac.Name = "btnHuyThaoTac";
      this.btnHuyThaoTac.Size = new System.Drawing.Size(154, 37);
      this.btnHuyThaoTac.TabIndex = 78;
      this.btnHuyThaoTac.Text = "  Hủy thao tác";
      this.btnHuyThaoTac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnHuyThaoTac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnHuyThaoTac.UseVisualStyleBackColor = true;
      this.btnHuyThaoTac.Click += new System.EventHandler(this.btnHuyThaoTac_Click);
      // 
      // rdbTrangThaiMo
      // 
      this.rdbTrangThaiMo.AutoSize = true;
      this.rdbTrangThaiMo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.rdbTrangThaiMo.Location = new System.Drawing.Point(495, 63);
      this.rdbTrangThaiMo.Name = "rdbTrangThaiMo";
      this.rdbTrangThaiMo.Size = new System.Drawing.Size(47, 21);
      this.rdbTrangThaiMo.TabIndex = 76;
      this.rdbTrangThaiMo.TabStop = true;
      this.rdbTrangThaiMo.Text = "Mở";
      this.rdbTrangThaiMo.UseVisualStyleBackColor = true;
      // 
      // rdbTrangThaiDong
      // 
      this.rdbTrangThaiDong.AutoSize = true;
      this.rdbTrangThaiDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.rdbTrangThaiDong.Location = new System.Drawing.Point(548, 63);
      this.rdbTrangThaiDong.Name = "rdbTrangThaiDong";
      this.rdbTrangThaiDong.Size = new System.Drawing.Size(63, 21);
      this.rdbTrangThaiDong.TabIndex = 77;
      this.rdbTrangThaiDong.TabStop = true;
      this.rdbTrangThaiDong.Text = "Khóa";
      this.rdbTrangThaiDong.UseVisualStyleBackColor = true;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label9.Location = new System.Drawing.Point(398, 65);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(83, 17);
      this.label9.TabIndex = 75;
      this.label9.Text = "Trạng thái";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(51, 65);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(125, 17);
      this.label2.TabIndex = 72;
      this.label2.Text = "Tên khách hàng";
      // 
      // txtTenKH
      // 
      this.txtTenKH.Location = new System.Drawing.Point(188, 62);
      this.txtTenKH.Name = "txtTenKH";
      this.txtTenKH.Size = new System.Drawing.Size(180, 23);
      this.txtTenKH.TabIndex = 71;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(398, 36);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(67, 17);
      this.label4.TabIndex = 9;
      this.label4.Text = "Loại thẻ";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(51, 36);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 17);
      this.label1.TabIndex = 3;
      this.label1.Text = "Mã thẻ";
      // 
      // txtMaTheKH
      // 
      this.txtMaTheKH.Location = new System.Drawing.Point(188, 33);
      this.txtMaTheKH.MaxLength = 10;
      this.txtMaTheKH.Name = "txtMaTheKH";
      this.txtMaTheKH.ReadOnly = true;
      this.txtMaTheKH.Size = new System.Drawing.Size(180, 23);
      this.txtMaTheKH.TabIndex = 2;
      // 
      // urcDanhSachTheKhachHang
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.MintCream;
      this.Controls.Add(this.grbTTTheKH);
      this.Controls.Add(this.grbDSTheKH);
      this.Name = "urcDanhSachTheKhachHang";
      this.Size = new System.Drawing.Size(930, 530);
      this.Load += new System.EventHandler(this.urcDanhSachTheKhachHang_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDSTheKH)).EndInit();
      this.grbDSTheKH.ResumeLayout(false);
      this.grbDSTheKH.PerformLayout();
      this.grbTTTheKH.ResumeLayout(false);
      this.grbTTTheKH.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSTheKH;
        private System.Windows.Forms.GroupBox grbDSTheKH;
        private System.Windows.Forms.GroupBox grbTTTheKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaTheKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbTrangThaiMo;
        private System.Windows.Forms.RadioButton rdbTrangThaiDong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnHuyThaoTac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtLoaiThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonViGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
