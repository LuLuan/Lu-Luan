namespace GUI
{
    partial class urcDanhSachLoaiNguyenLieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvDSLoaiNguyenLieu = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDSLoaiNL = new System.Windows.Forms.GroupBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuyBoChinhSua = new System.Windows.Forms.Button();
            this.btnHuyBoThemMoi = new System.Windows.Forms.Button();
            this.btnChinhSuaLoaiNL = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThemLoaiNL = new System.Windows.Forms.Button();
            this.lbTenLoaiNL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDVTinhNL = new System.Windows.Forms.ComboBox();
            this.txtTenLoaiNL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiNguyenLieu)).BeginInit();
            this.grbDSLoaiNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 68;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Blue;
            this.txtTimKiem.Location = new System.Drawing.Point(158, 19);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(299, 36);
            this.txtTimKiem.TabIndex = 69;
            // 
            // dgvDSLoaiNguyenLieu
            // 
            this.dgvDSLoaiNguyenLieu.AllowUserToAddRows = false;
            this.dgvDSLoaiNguyenLieu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDSLoaiNguyenLieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDSLoaiNguyenLieu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSLoaiNguyenLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDSLoaiNguyenLieu.ColumnHeadersHeight = 37;
            this.dgvDSLoaiNguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.colTenLoaiNguyenLieu,
            this.colTrangThai});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSLoaiNguyenLieu.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDSLoaiNguyenLieu.EnableHeadersVisualStyles = false;
            this.dgvDSLoaiNguyenLieu.Location = new System.Drawing.Point(25, 61);
            this.dgvDSLoaiNguyenLieu.MultiSelect = false;
            this.dgvDSLoaiNguyenLieu.Name = "dgvDSLoaiNguyenLieu";
            this.dgvDSLoaiNguyenLieu.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSLoaiNguyenLieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDSLoaiNguyenLieu.RowHeadersVisible = false;
            this.dgvDSLoaiNguyenLieu.RowTemplate.Height = 35;
            this.dgvDSLoaiNguyenLieu.RowTemplate.ReadOnly = true;
            this.dgvDSLoaiNguyenLieu.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSLoaiNguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSLoaiNguyenLieu.Size = new System.Drawing.Size(432, 383);
            this.dgvDSLoaiNguyenLieu.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "MaLoaiNguyenLieu";
            this.Column6.HeaderText = "Mã loại NL";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 110;
            // 
            // colTenLoaiNguyenLieu
            // 
            this.colTenLoaiNguyenLieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenLoaiNguyenLieu.DataPropertyName = "TenLoaiNguyenLieu";
            this.colTenLoaiNguyenLieu.HeaderText = "Tên loại NL";
            this.colTenLoaiNguyenLieu.Name = "colTenLoaiNguyenLieu";
            this.colTenLoaiNguyenLieu.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Width = 108;
            // 
            // grbDSLoaiNL
            // 
            this.grbDSLoaiNL.Controls.Add(this.label1);
            this.grbDSLoaiNL.Controls.Add(this.txtTimKiem);
            this.grbDSLoaiNL.Controls.Add(this.dgvDSLoaiNguyenLieu);
            this.grbDSLoaiNL.Location = new System.Drawing.Point(10, 33);
            this.grbDSLoaiNL.Name = "grbDSLoaiNL";
            this.grbDSLoaiNL.Size = new System.Drawing.Size(476, 481);
            this.grbDSLoaiNL.TabIndex = 54;
            this.grbDSLoaiNL.TabStop = false;
            this.grbDSLoaiNL.Text = "Danh sách  nguyên liệu";
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = global::GUI.Properties.Resources.icons8_Close_Window_25px_3;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picExit.Location = new System.Drawing.Point(10, 5);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(22, 22);
            this.picExit.TabIndex = 56;
            this.picExit.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenLoaiNL);
            this.groupBox1.Controls.Add(this.cbbDVTinhNL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnHuyBoChinhSua);
            this.groupBox1.Controls.Add(this.btnHuyBoThemMoi);
            this.groupBox1.Controls.Add(this.btnChinhSuaLoaiNL);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnThemLoaiNL);
            this.groupBox1.Controls.Add(this.lbTenLoaiNL);
            this.groupBox1.Location = new System.Drawing.Point(504, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 481);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            // 
            // btnHuyBoChinhSua
            // 
            this.btnHuyBoChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyBoChinhSua.Enabled = false;
            this.btnHuyBoChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBoChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyBoChinhSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnHuyBoChinhSua.Image = global::GUI.Properties.Resources.icons8_Cancel_35px_2;
            this.btnHuyBoChinhSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyBoChinhSua.Location = new System.Drawing.Point(237, 177);
            this.btnHuyBoChinhSua.Name = "btnHuyBoChinhSua";
            this.btnHuyBoChinhSua.Size = new System.Drawing.Size(152, 45);
            this.btnHuyBoChinhSua.TabIndex = 87;
            this.btnHuyBoChinhSua.Text = "   Hủy bỏ";
            this.btnHuyBoChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBoChinhSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyBoChinhSua.UseVisualStyleBackColor = true;
            this.btnHuyBoChinhSua.Visible = false;
            this.btnHuyBoChinhSua.Click += new System.EventHandler(this.btnHuyBoChinhSua_Click_1);
            // 
            // btnHuyBoThemMoi
            // 
            this.btnHuyBoThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyBoThemMoi.Enabled = false;
            this.btnHuyBoThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBoThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyBoThemMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnHuyBoThemMoi.Image = global::GUI.Properties.Resources.icons8_Cancel_35px_2;
            this.btnHuyBoThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyBoThemMoi.Location = new System.Drawing.Point(237, 126);
            this.btnHuyBoThemMoi.Name = "btnHuyBoThemMoi";
            this.btnHuyBoThemMoi.Size = new System.Drawing.Size(152, 45);
            this.btnHuyBoThemMoi.TabIndex = 86;
            this.btnHuyBoThemMoi.Text = "   Hủy bỏ";
            this.btnHuyBoThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBoThemMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyBoThemMoi.UseVisualStyleBackColor = true;
            this.btnHuyBoThemMoi.Visible = false;
            this.btnHuyBoThemMoi.Click += new System.EventHandler(this.btnHuyBoThemMoi_Click_1);
            // 
            // btnChinhSuaLoaiNL
            // 
            this.btnChinhSuaLoaiNL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSuaLoaiNL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSuaLoaiNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChinhSuaLoaiNL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnChinhSuaLoaiNL.Image = global::GUI.Properties.Resources.icons8_Edit_File_35px_1;
            this.btnChinhSuaLoaiNL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChinhSuaLoaiNL.Location = new System.Drawing.Point(237, 177);
            this.btnChinhSuaLoaiNL.Name = "btnChinhSuaLoaiNL";
            this.btnChinhSuaLoaiNL.Size = new System.Drawing.Size(152, 45);
            this.btnChinhSuaLoaiNL.TabIndex = 85;
            this.btnChinhSuaLoaiNL.Text = "  Chỉnh sửa";
            this.btnChinhSuaLoaiNL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChinhSuaLoaiNL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChinhSuaLoaiNL.UseVisualStyleBackColor = true;
            this.btnChinhSuaLoaiNL.Click += new System.EventHandler(this.btnChinhSuaLoaiNL_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.Color.Green;
            this.btnLuu.Image = global::GUI.Properties.Resources.icons8_Save_35px;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.Location = new System.Drawing.Point(237, 228);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(152, 45);
            this.btnLuu.TabIndex = 84;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnThemLoaiNL
            // 
            this.btnThemLoaiNL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemLoaiNL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLoaiNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemLoaiNL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThemLoaiNL.Image = global::GUI.Properties.Resources.icons8_Add_35px;
            this.btnThemLoaiNL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemLoaiNL.Location = new System.Drawing.Point(237, 126);
            this.btnThemLoaiNL.Name = "btnThemLoaiNL";
            this.btnThemLoaiNL.Size = new System.Drawing.Size(152, 45);
            this.btnThemLoaiNL.TabIndex = 83;
            this.btnThemLoaiNL.Text = "   Thêm Mới";
            this.btnThemLoaiNL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLoaiNL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemLoaiNL.UseVisualStyleBackColor = true;
            this.btnThemLoaiNL.Click += new System.EventHandler(this.btnThemLoaiNL_Click_1);
            // 
            // lbTenLoaiNL
            // 
            this.lbTenLoaiNL.AutoSize = true;
            this.lbTenLoaiNL.Enabled = false;
            this.lbTenLoaiNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenLoaiNL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lbTenLoaiNL.Location = new System.Drawing.Point(18, 41);
            this.lbTenLoaiNL.Name = "lbTenLoaiNL";
            this.lbTenLoaiNL.Size = new System.Drawing.Size(92, 17);
            this.lbTenLoaiNL.TabIndex = 81;
            this.lbTenLoaiNL.Text = "Tên loại NL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 88;
            this.label2.Text = "Trạng thái";
            // 
            // cbbDVTinhNL
            // 
            this.cbbDVTinhNL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDVTinhNL.Enabled = false;
            this.cbbDVTinhNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbDVTinhNL.FormattingEnabled = true;
            this.cbbDVTinhNL.Location = new System.Drawing.Point(116, 65);
            this.cbbDVTinhNL.Name = "cbbDVTinhNL";
            this.cbbDVTinhNL.Size = new System.Drawing.Size(273, 28);
            this.cbbDVTinhNL.TabIndex = 89;
            // 
            // txtTenLoaiNL
            // 
            this.txtTenLoaiNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenLoaiNL.Enabled = false;
            this.txtTenLoaiNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenLoaiNL.Location = new System.Drawing.Point(116, 31);
            this.txtTenLoaiNL.Name = "txtTenLoaiNL";
            this.txtTenLoaiNL.Size = new System.Drawing.Size(273, 27);
            this.txtTenLoaiNL.TabIndex = 90;
            // 
            // urcDanhSachLoaiNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.grbDSLoaiNL);
            this.Name = "urcDanhSachLoaiNguyenLieu";
            this.Size = new System.Drawing.Size(930, 530);
            this.Load += new System.EventHandler(this.urcDanhSachLoaiNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiNguyenLieu)).EndInit();
            this.grbDSLoaiNL.ResumeLayout(false);
            this.grbDSLoaiNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.DataGridView dgvDSLoaiNguyenLieu;
        private System.Windows.Forms.GroupBox grbDSLoaiNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHuyBoChinhSua;
        private System.Windows.Forms.Button btnHuyBoThemMoi;
        private System.Windows.Forms.Button btnChinhSuaLoaiNL;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThemLoaiNL;
        private System.Windows.Forms.Label lbTenLoaiNL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbDVTinhNL;
        private System.Windows.Forms.TextBox txtTenLoaiNL;
    }
}
