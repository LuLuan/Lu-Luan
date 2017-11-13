namespace GUI
{
    partial class urcXemLichSuBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.colMaMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnhMonAn = new System.Windows.Forms.DataGridViewImageColumn();
            this.colTenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKichThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSSP
            // 
            this.dgvDSSP.AllowUserToAddRows = false;
            this.dgvDSSP.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDSSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSSP.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSSP.ColumnHeadersHeight = 37;
            this.dgvDSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMonAn,
            this.colAnhMonAn,
            this.colTenMonAn,
            this.colGiaBan,
            this.colTenKichThuoc,
            this.colDonViTinh,
            this.colTenLoaiMonAn});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSSP.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDSSP.EnableHeadersVisualStyles = false;
            this.dgvDSSP.Location = new System.Drawing.Point(3, 175);
            this.dgvDSSP.MultiSelect = false;
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.ReadOnly = true;
            this.dgvDSSP.RowHeadersVisible = false;
            this.dgvDSSP.RowTemplate.Height = 35;
            this.dgvDSSP.RowTemplate.ReadOnly = true;
            this.dgvDSSP.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSP.Size = new System.Drawing.Size(924, 392);
            this.dgvDSSP.TabIndex = 1;
            // 
            // colMaMonAn
            // 
            this.colMaMonAn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMaMonAn.DataPropertyName = "MaMonAn";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaMonAn.DefaultCellStyle = dataGridViewCellStyle3;
            this.colMaMonAn.HeaderText = "Mã Món Ăn";
            this.colMaMonAn.Name = "colMaMonAn";
            this.colMaMonAn.ReadOnly = true;
            this.colMaMonAn.Width = 113;
            // 
            // colAnhMonAn
            // 
            this.colAnhMonAn.DataPropertyName = "AnhMonAn";
            this.colAnhMonAn.HeaderText = "Ảnh ";
            this.colAnhMonAn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colAnhMonAn.Name = "colAnhMonAn";
            this.colAnhMonAn.ReadOnly = true;
            this.colAnhMonAn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAnhMonAn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTenMonAn
            // 
            this.colTenMonAn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenMonAn.DataPropertyName = "TenMonAn";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTenMonAn.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTenMonAn.HeaderText = "Tên Món Ăn";
            this.colTenMonAn.Name = "colTenMonAn";
            this.colTenMonAn.ReadOnly = true;
            // 
            // colGiaBan
            // 
            this.colGiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colGiaBan.DefaultCellStyle = dataGridViewCellStyle5;
            this.colGiaBan.HeaderText = "Giá Bán";
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.ReadOnly = true;
            this.colGiaBan.Width = 91;
            // 
            // colTenKichThuoc
            // 
            this.colTenKichThuoc.DataPropertyName = "MaKichThuoc";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTenKichThuoc.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTenKichThuoc.HeaderText = "Kích Thước";
            this.colTenKichThuoc.Name = "colTenKichThuoc";
            this.colTenKichThuoc.ReadOnly = true;
            this.colTenKichThuoc.Width = 114;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.DataPropertyName = "MaDonViTinh";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDonViTinh.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDonViTinh.HeaderText = "Đơn vị";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.ReadOnly = true;
            this.colDonViTinh.Width = 79;
            // 
            // colTenLoaiMonAn
            // 
            this.colTenLoaiMonAn.DataPropertyName = "MaLoaiMon";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTenLoaiMonAn.DefaultCellStyle = dataGridViewCellStyle8;
            this.colTenLoaiMonAn.HeaderText = "Tên Loại";
            this.colTenLoaiMonAn.Name = "colTenLoaiMonAn";
            this.colTenLoaiMonAn.ReadOnly = true;
            this.colTenLoaiMonAn.Width = 97;
            // 
            // urcXemLichSuBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.dgvDSSP);
            this.Name = "urcXemLichSuBan";
            this.Size = new System.Drawing.Size(930, 570);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMonAn;
        private System.Windows.Forms.DataGridViewImageColumn colAnhMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKichThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiMonAn;
    }
}
