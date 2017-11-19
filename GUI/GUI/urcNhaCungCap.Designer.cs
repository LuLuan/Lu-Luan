namespace GUI
{
    partial class urcNhaCungCap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSoDienThoaiNCC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChiNCC = new System.Windows.Forms.TextBox();
            this.lbTenMonAn = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.dgvDSNhaCungCap = new System.Windows.Forms.DataGridView();
            this.grbDSNL = new System.Windows.Forms.GroupBox();
            this.grbThongTinNCC = new System.Windows.Forms.GroupBox();
            this.colMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienTHoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.btnHuyBoChinhSua = new System.Windows.Forms.Button();
            this.btnHuyBoThemMoi = new System.Windows.Forms.Button();
            this.btnChinhSuaNCC = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThemMoiNCC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhaCungCap)).BeginInit();
            this.grbDSNL.SuspendLayout();
            this.grbThongTinNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(15, 29);
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
            this.txtTimKiem.Location = new System.Drawing.Point(189, 27);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(406, 36);
            this.txtTimKiem.TabIndex = 69;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(601, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 37);
            this.comboBox1.TabIndex = 70;
            // 
            // txtSoDienThoaiNCC
            // 
            this.txtSoDienThoaiNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoDienThoaiNCC.Enabled = false;
            this.txtSoDienThoaiNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoDienThoaiNCC.Location = new System.Drawing.Point(342, 154);
            this.txtSoDienThoaiNCC.Multiline = true;
            this.txtSoDienThoaiNCC.Name = "txtSoDienThoaiNCC";
            this.txtSoDienThoaiNCC.Size = new System.Drawing.Size(253, 27);
            this.txtSoDienThoaiNCC.TabIndex = 18;
            this.txtSoDienThoaiNCC.TextChanged += new System.EventHandler(this.txtSoDienThoaiNCC_TextChanged);
            this.txtSoDienThoaiNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoaiNCC_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.label6.Location = new System.Drawing.Point(186, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(186, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Địa chỉ";
            // 
            // txtDiaChiNCC
            // 
            this.txtDiaChiNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChiNCC.Enabled = false;
            this.txtDiaChiNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChiNCC.Location = new System.Drawing.Point(342, 121);
            this.txtDiaChiNCC.Multiline = true;
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.Size = new System.Drawing.Size(253, 27);
            this.txtDiaChiNCC.TabIndex = 10;
            // 
            // lbTenMonAn
            // 
            this.lbTenMonAn.AutoSize = true;
            this.lbTenMonAn.Enabled = false;
            this.lbTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenMonAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lbTenMonAn.Location = new System.Drawing.Point(186, 94);
            this.lbTenMonAn.Name = "lbTenMonAn";
            this.lbTenMonAn.Size = new System.Drawing.Size(139, 17);
            this.lbTenMonAn.TabIndex = 2;
            this.lbTenMonAn.Text = "Tên nhà cung cấp";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNCC.Enabled = false;
            this.txtTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNCC.Location = new System.Drawing.Point(342, 88);
            this.txtTenNCC.Multiline = true;
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(253, 27);
            this.txtTenNCC.TabIndex = 5;
            // 
            // dgvDSNhaCungCap
            // 
            this.dgvDSNhaCungCap.AllowUserToAddRows = false;
            this.dgvDSNhaCungCap.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDSNhaCungCap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDSNhaCungCap.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSNhaCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDSNhaCungCap.ColumnHeadersHeight = 37;
            this.dgvDSNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNCC,
            this.colTenNCC,
            this.colDiaChiNCC,
            this.colSoDienTHoai});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSNhaCungCap.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDSNhaCungCap.EnableHeadersVisualStyles = false;
            this.dgvDSNhaCungCap.Location = new System.Drawing.Point(6, 19);
            this.dgvDSNhaCungCap.MultiSelect = false;
            this.dgvDSNhaCungCap.Name = "dgvDSNhaCungCap";
            this.dgvDSNhaCungCap.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSNhaCungCap.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDSNhaCungCap.RowHeadersVisible = false;
            this.dgvDSNhaCungCap.RowTemplate.Height = 35;
            this.dgvDSNhaCungCap.RowTemplate.ReadOnly = true;
            this.dgvDSNhaCungCap.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSNhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNhaCungCap.Size = new System.Drawing.Size(886, 249);
            this.dgvDSNhaCungCap.TabIndex = 0;
            // 
            // grbDSNL
            // 
            this.grbDSNL.Controls.Add(this.dgvDSNhaCungCap);
            this.grbDSNL.Location = new System.Drawing.Point(22, 252);
            this.grbDSNL.Name = "grbDSNL";
            this.grbDSNL.Size = new System.Drawing.Size(898, 274);
            this.grbDSNL.TabIndex = 54;
            this.grbDSNL.TabStop = false;
            this.grbDSNL.Text = "Danh sách nhà cung cấp";
            // 
            // grbThongTinNCC
            // 
            this.grbThongTinNCC.Controls.Add(this.btnHuyBoChinhSua);
            this.grbThongTinNCC.Controls.Add(this.btnHuyBoThemMoi);
            this.grbThongTinNCC.Controls.Add(this.label1);
            this.grbThongTinNCC.Controls.Add(this.txtTimKiem);
            this.grbThongTinNCC.Controls.Add(this.comboBox1);
            this.grbThongTinNCC.Controls.Add(this.btnChinhSuaNCC);
            this.grbThongTinNCC.Controls.Add(this.btnLuu);
            this.grbThongTinNCC.Controls.Add(this.btnThemMoiNCC);
            this.grbThongTinNCC.Controls.Add(this.txtSoDienThoaiNCC);
            this.grbThongTinNCC.Controls.Add(this.label6);
            this.grbThongTinNCC.Controls.Add(this.label2);
            this.grbThongTinNCC.Controls.Add(this.txtDiaChiNCC);
            this.grbThongTinNCC.Controls.Add(this.lbTenMonAn);
            this.grbThongTinNCC.Controls.Add(this.txtTenNCC);
            this.grbThongTinNCC.Location = new System.Drawing.Point(22, 24);
            this.grbThongTinNCC.Name = "grbThongTinNCC";
            this.grbThongTinNCC.Size = new System.Drawing.Size(898, 225);
            this.grbThongTinNCC.TabIndex = 55;
            this.grbThongTinNCC.TabStop = false;
            // 
            // colMaNCC
            // 
            this.colMaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMaNCC.DataPropertyName = "MaNhaCungCap";
            this.colMaNCC.HeaderText = "Mã NCC";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.ReadOnly = true;
            this.colMaNCC.Width = 90;
            // 
            // colTenNCC
            // 
            this.colTenNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenNCC.DataPropertyName = "TenNhaCungCap";
            this.colTenNCC.HeaderText = "Tên NCC";
            this.colTenNCC.Name = "colTenNCC";
            this.colTenNCC.ReadOnly = true;
            // 
            // colDiaChiNCC
            // 
            this.colDiaChiNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDiaChiNCC.DataPropertyName = "DiaChi";
            this.colDiaChiNCC.HeaderText = "Địa chỉ";
            this.colDiaChiNCC.Name = "colDiaChiNCC";
            this.colDiaChiNCC.ReadOnly = true;
            this.colDiaChiNCC.Width = 83;
            // 
            // colSoDienTHoai
            // 
            this.colSoDienTHoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSoDienTHoai.DataPropertyName = "SoDienThoai";
            this.colSoDienTHoai.HeaderText = "Số điện thoại";
            this.colSoDienTHoai.Name = "colSoDienTHoai";
            this.colSoDienTHoai.ReadOnly = true;
            this.colSoDienTHoai.Width = 129;
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
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // btnHuyBoChinhSua
            // 
            this.btnHuyBoChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyBoChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBoChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyBoChinhSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnHuyBoChinhSua.Image = global::GUI.Properties.Resources.icons8_Cancel_35px_2;
            this.btnHuyBoChinhSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyBoChinhSua.Location = new System.Drawing.Point(726, 117);
            this.btnHuyBoChinhSua.Name = "btnHuyBoChinhSua";
            this.btnHuyBoChinhSua.Size = new System.Drawing.Size(152, 45);
            this.btnHuyBoChinhSua.TabIndex = 75;
            this.btnHuyBoChinhSua.Text = "   Hủy bỏ";
            this.btnHuyBoChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBoChinhSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyBoChinhSua.UseVisualStyleBackColor = true;
            this.btnHuyBoChinhSua.Visible = false;
            this.btnHuyBoChinhSua.Click += new System.EventHandler(this.btnHuyBoChinhSua_Click);
            // 
            // btnHuyBoThemMoi
            // 
            this.btnHuyBoThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyBoThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBoThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyBoThemMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnHuyBoThemMoi.Image = global::GUI.Properties.Resources.icons8_Cancel_35px_2;
            this.btnHuyBoThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyBoThemMoi.Location = new System.Drawing.Point(726, 66);
            this.btnHuyBoThemMoi.Name = "btnHuyBoThemMoi";
            this.btnHuyBoThemMoi.Size = new System.Drawing.Size(152, 45);
            this.btnHuyBoThemMoi.TabIndex = 73;
            this.btnHuyBoThemMoi.Text = "   Hủy bỏ";
            this.btnHuyBoThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBoThemMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyBoThemMoi.UseVisualStyleBackColor = true;
            this.btnHuyBoThemMoi.Visible = false;
            this.btnHuyBoThemMoi.Click += new System.EventHandler(this.btnHuyBoThemMoi_Click);
            // 
            // btnChinhSuaNCC
            // 
            this.btnChinhSuaNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSuaNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSuaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChinhSuaNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnChinhSuaNCC.Image = global::GUI.Properties.Resources.icons8_Edit_File_35px_1;
            this.btnChinhSuaNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChinhSuaNCC.Location = new System.Drawing.Point(726, 117);
            this.btnChinhSuaNCC.Name = "btnChinhSuaNCC";
            this.btnChinhSuaNCC.Size = new System.Drawing.Size(152, 45);
            this.btnChinhSuaNCC.TabIndex = 72;
            this.btnChinhSuaNCC.Text = "  Chỉnh sửa";
            this.btnChinhSuaNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChinhSuaNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChinhSuaNCC.UseVisualStyleBackColor = true;
            this.btnChinhSuaNCC.Click += new System.EventHandler(this.btnChinhSuaNCC_Click);
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
            this.btnLuu.Location = new System.Drawing.Point(726, 169);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(152, 45);
            this.btnLuu.TabIndex = 68;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemMoiNCC
            // 
            this.btnThemMoiNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMoiNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoiNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemMoiNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThemMoiNCC.Image = global::GUI.Properties.Resources.icons8_Add_35px;
            this.btnThemMoiNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMoiNCC.Location = new System.Drawing.Point(726, 66);
            this.btnThemMoiNCC.Name = "btnThemMoiNCC";
            this.btnThemMoiNCC.Size = new System.Drawing.Size(152, 45);
            this.btnThemMoiNCC.TabIndex = 67;
            this.btnThemMoiNCC.Text = "   Thêm Mới";
            this.btnThemMoiNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoiNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemMoiNCC.UseVisualStyleBackColor = true;
            this.btnThemMoiNCC.Click += new System.EventHandler(this.btnThemMoiNCC_Click);
            // 
            // urcNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.grbDSNL);
            this.Controls.Add(this.grbThongTinNCC);
            this.Name = "urcNhaCungCap";
            this.Size = new System.Drawing.Size(930, 530);
            this.Load += new System.EventHandler(this.urcNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhaCungCap)).EndInit();
            this.grbDSNL.ResumeLayout(false);
            this.grbThongTinNCC.ResumeLayout(false);
            this.grbThongTinNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHuyBoChinhSua;
        private System.Windows.Forms.Button btnHuyBoThemMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnChinhSuaNCC;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThemMoiNCC;
        private System.Windows.Forms.TextBox txtSoDienThoaiNCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChiNCC;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lbTenMonAn;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.DataGridView dgvDSNhaCungCap;
        private System.Windows.Forms.GroupBox grbDSNL;
        private System.Windows.Forms.GroupBox grbThongTinNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienTHoai;
    }
}
