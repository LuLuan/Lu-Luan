namespace GUI
{
    partial class frmChiTietSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvThanhPhanMonAn = new System.Windows.Forms.DataGridView();
            this.picAnhMonAn = new System.Windows.Forms.PictureBox();
            this.colTenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaMonAn = new System.Windows.Forms.TextBox();
            this.lbTenMonAn = new System.Windows.Forms.Label();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhPhanMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThanhPhanMonAn
            // 
            this.dgvThanhPhanMonAn.AllowUserToAddRows = false;
            this.dgvThanhPhanMonAn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThanhPhanMonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvThanhPhanMonAn.ColumnHeadersHeight = 35;
            this.dgvThanhPhanMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenNguyenLieu});
            this.dgvThanhPhanMonAn.EnableHeadersVisualStyles = false;
            this.dgvThanhPhanMonAn.Location = new System.Drawing.Point(352, 57);
            this.dgvThanhPhanMonAn.MultiSelect = false;
            this.dgvThanhPhanMonAn.Name = "dgvThanhPhanMonAn";
            this.dgvThanhPhanMonAn.ReadOnly = true;
            this.dgvThanhPhanMonAn.RowHeadersVisible = false;
            this.dgvThanhPhanMonAn.RowHeadersWidth = 30;
            this.dgvThanhPhanMonAn.RowTemplate.Height = 35;
            this.dgvThanhPhanMonAn.RowTemplate.ReadOnly = true;
            this.dgvThanhPhanMonAn.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThanhPhanMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvThanhPhanMonAn.Size = new System.Drawing.Size(320, 243);
            this.dgvThanhPhanMonAn.TabIndex = 30;
            this.dgvThanhPhanMonAn.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvThanhPhanMonAn_CellFormatting);
            // 
            // picAnhMonAn
            // 
            this.picAnhMonAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAnhMonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhMonAn.Enabled = false;
            this.picAnhMonAn.Location = new System.Drawing.Point(12, 57);
            this.picAnhMonAn.Name = "picAnhMonAn";
            this.picAnhMonAn.Size = new System.Drawing.Size(302, 243);
            this.picAnhMonAn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhMonAn.TabIndex = 31;
            this.picAnhMonAn.TabStop = false;
            // 
            // colTenNguyenLieu
            // 
            this.colTenNguyenLieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenNguyenLieu.DataPropertyName = "MaNguyenLieu";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTenNguyenLieu.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTenNguyenLieu.HeaderText = "Nguyên Liệu";
            this.colTenNguyenLieu.Name = "colTenNguyenLieu";
            this.colTenNguyenLieu.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Mã Món";
            // 
            // txtMaMonAn
            // 
            this.txtMaMonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaMonAn.Enabled = false;
            this.txtMaMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaMonAn.ForeColor = System.Drawing.Color.Black;
            this.txtMaMonAn.Location = new System.Drawing.Point(102, 12);
            this.txtMaMonAn.Multiline = true;
            this.txtMaMonAn.Name = "txtMaMonAn";
            this.txtMaMonAn.Size = new System.Drawing.Size(212, 27);
            this.txtMaMonAn.TabIndex = 43;
            // 
            // lbTenMonAn
            // 
            this.lbTenMonAn.AutoSize = true;
            this.lbTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenMonAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTenMonAn.Location = new System.Drawing.Point(397, 22);
            this.lbTenMonAn.Name = "lbTenMonAn";
            this.lbTenMonAn.Size = new System.Drawing.Size(36, 17);
            this.lbTenMonAn.TabIndex = 40;
            this.lbTenMonAn.Text = "Tên";
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenMonAn.Enabled = false;
            this.txtTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenMonAn.ForeColor = System.Drawing.Color.Black;
            this.txtTenMonAn.Location = new System.Drawing.Point(460, 12);
            this.txtTenMonAn.Multiline = true;
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(212, 27);
            this.txtTenMonAn.TabIndex = 41;
            // 
            // frmChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(688, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaMonAn);
            this.Controls.Add(this.lbTenMonAn);
            this.Controls.Add(this.txtTenMonAn);
            this.Controls.Add(this.picAnhMonAn);
            this.Controls.Add(this.dgvThanhPhanMonAn);
            this.Name = "frmChiTietSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChiTietSanPham";
            this.Load += new System.EventHandler(this.frmChiTietSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhPhanMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThanhPhanMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNguyenLieu;
        private System.Windows.Forms.PictureBox picAnhMonAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaMonAn;
        private System.Windows.Forms.Label lbTenMonAn;
        private System.Windows.Forms.TextBox txtTenMonAn;
    }
}