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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dgvDSTheKH = new System.Windows.Forms.DataGridView();
      this.grbDSTheKH = new System.Windows.Forms.GroupBox();
      this.txtTimKiemTheKH = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnMoThe = new System.Windows.Forms.Button();
      this.btnXoaThe = new System.Windows.Forms.Button();
      this.colMaThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colLoaiThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNgayDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDonViGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDSTheKH)).BeginInit();
      this.grbDSTheKH.SuspendLayout();
      this.SuspendLayout();
      // 
      // dgvDSTheKH
      // 
      this.dgvDSTheKH.AllowUserToAddRows = false;
      this.dgvDSTheKH.AllowUserToDeleteRows = false;
      this.dgvDSTheKH.BackgroundColor = System.Drawing.Color.White;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
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
      this.dgvDSTheKH.EnableHeadersVisualStyles = false;
      this.dgvDSTheKH.Location = new System.Drawing.Point(6, 108);
      this.dgvDSTheKH.MultiSelect = false;
      this.dgvDSTheKH.Name = "dgvDSTheKH";
      this.dgvDSTheKH.ReadOnly = true;
      this.dgvDSTheKH.RowHeadersVisible = false;
      this.dgvDSTheKH.RowTemplate.Height = 40;
      this.dgvDSTheKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvDSTheKH.Size = new System.Drawing.Size(888, 394);
      this.dgvDSTheKH.TabIndex = 0;
      this.dgvDSTheKH.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDSTheKH_CellFormatting);
      this.dgvDSTheKH.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDSTheKH_DataBindingComplete);
      this.dgvDSTheKH.SelectionChanged += new System.EventHandler(this.dgvDSTheKH_SelectionChanged);
      this.dgvDSTheKH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDSTheKH_KeyUp);
      // 
      // grbDSTheKH
      // 
      this.grbDSTheKH.BackColor = System.Drawing.Color.MintCream;
      this.grbDSTheKH.Controls.Add(this.txtTimKiemTheKH);
      this.grbDSTheKH.Controls.Add(this.label1);
      this.grbDSTheKH.Controls.Add(this.btnMoThe);
      this.grbDSTheKH.Controls.Add(this.btnXoaThe);
      this.grbDSTheKH.Controls.Add(this.dgvDSTheKH);
      this.grbDSTheKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.grbDSTheKH.Location = new System.Drawing.Point(14, 19);
      this.grbDSTheKH.Name = "grbDSTheKH";
      this.grbDSTheKH.Size = new System.Drawing.Size(900, 508);
      this.grbDSTheKH.TabIndex = 1;
      this.grbDSTheKH.TabStop = false;
      this.grbDSTheKH.Text = "Danh sách thẻ khách hàng";
      // 
      // txtTimKiemTheKH
      // 
      this.txtTimKiemTheKH.Location = new System.Drawing.Point(225, 47);
      this.txtTimKiemTheKH.Name = "txtTimKiemTheKH";
      this.txtTimKiemTheKH.Size = new System.Drawing.Size(310, 23);
      this.txtTimKiemTheKH.TabIndex = 83;
      this.txtTimKiemTheKH.TextChanged += new System.EventHandler(this.txtTimKiemTheKH_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 50);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(203, 17);
      this.label1.TabIndex = 82;
      this.label1.Text = "Tìm kiếm theo mã hoặc tên";
      // 
      // btnMoThe
      // 
      this.btnMoThe.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnMoThe.FlatAppearance.BorderSize = 0;
      this.btnMoThe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMoThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnMoThe.ForeColor = System.Drawing.Color.Green;
      this.btnMoThe.Image = global::GUI.Properties.Resources.UnLockIOS10_35px;
      this.btnMoThe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnMoThe.Location = new System.Drawing.Point(560, 33);
      this.btnMoThe.Name = "btnMoThe";
      this.btnMoThe.Size = new System.Drawing.Size(153, 49);
      this.btnMoThe.TabIndex = 81;
      this.btnMoThe.Text = "  Mở thẻ";
      this.btnMoThe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnMoThe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnMoThe.UseVisualStyleBackColor = true;
      this.btnMoThe.Click += new System.EventHandler(this.btnMoThe_Click);
      // 
      // btnXoaThe
      // 
      this.btnXoaThe.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnXoaThe.FlatAppearance.BorderSize = 0;
      this.btnXoaThe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnXoaThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnXoaThe.ForeColor = System.Drawing.Color.Green;
      this.btnXoaThe.Image = global::GUI.Properties.Resources.LockIOS10_35px;
      this.btnXoaThe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnXoaThe.Location = new System.Drawing.Point(719, 33);
      this.btnXoaThe.Name = "btnXoaThe";
      this.btnXoaThe.Size = new System.Drawing.Size(153, 46);
      this.btnXoaThe.TabIndex = 80;
      this.btnXoaThe.Text = "  Khóa thẻ";
      this.btnXoaThe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnXoaThe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnXoaThe.UseVisualStyleBackColor = true;
      this.btnXoaThe.Click += new System.EventHandler(this.btnXoaThe_Click);
      // 
      // colMaThe
      // 
      this.colMaThe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colMaThe.DataPropertyName = "MaThe";
      this.colMaThe.HeaderText = "Mã Thẻ";
      this.colMaThe.Name = "colMaThe";
      this.colMaThe.ReadOnly = true;
      this.colMaThe.Width = 87;
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
      this.colLoaiThe.Width = 97;
      // 
      // colNgayDangKy
      // 
      this.colNgayDangKy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colNgayDangKy.DataPropertyName = "NgayDangKy";
      dataGridViewCellStyle2.Format = "d";
      dataGridViewCellStyle2.NullValue = null;
      this.colNgayDangKy.DefaultCellStyle = dataGridViewCellStyle2;
      this.colNgayDangKy.HeaderText = "Ngày Đăng Ký";
      this.colNgayDangKy.Name = "colNgayDangKy";
      this.colNgayDangKy.ReadOnly = true;
      this.colNgayDangKy.Width = 108;
      // 
      // colGiamGia
      // 
      this.colGiamGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colGiamGia.DataPropertyName = "GiamGia";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle3.Format = "N1";
      dataGridViewCellStyle3.NullValue = null;
      this.colGiamGia.DefaultCellStyle = dataGridViewCellStyle3;
      this.colGiamGia.HeaderText = "Giảm Giá";
      this.colGiamGia.Name = "colGiamGia";
      this.colGiamGia.ReadOnly = true;
      this.colGiamGia.Width = 92;
      // 
      // colDonViGiamGia
      // 
      this.colDonViGiamGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colDonViGiamGia.DataPropertyName = "DonViGiamGia";
      this.colDonViGiamGia.HeaderText = "Đơn Vị Giảm Giá";
      this.colDonViGiamGia.Name = "colDonViGiamGia";
      this.colDonViGiamGia.ReadOnly = true;
      this.colDonViGiamGia.Width = 117;
      // 
      // colTrangThai
      // 
      this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colTrangThai.DataPropertyName = "TrangThai";
      this.colTrangThai.HeaderText = "Trạng Thái";
      this.colTrangThai.Name = "colTrangThai";
      this.colTrangThai.ReadOnly = true;
      this.colTrangThai.Visible = false;
      this.colTrangThai.Width = 104;
      // 
      // urcDanhSachTheKhachHang
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.MintCream;
      this.Controls.Add(this.grbDSTheKH);
      this.Name = "urcDanhSachTheKhachHang";
      this.Size = new System.Drawing.Size(930, 530);
      this.Load += new System.EventHandler(this.urcDanhSachTheKhachHang_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDSTheKH)).EndInit();
      this.grbDSTheKH.ResumeLayout(false);
      this.grbDSTheKH.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSTheKH;
        private System.Windows.Forms.GroupBox grbDSTheKH;
        private System.Windows.Forms.Button btnXoaThe;
        private System.Windows.Forms.Button btnMoThe;
        private System.Windows.Forms.TextBox txtTimKiemTheKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonViGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
