namespace GUI
{
  partial class urcXemLichLamViec
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnTimKiem = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.dtpTo = new System.Windows.Forms.DateTimePicker();
      this.dgvLichLamViec = new System.Windows.Forms.DataGridView();
      this.dtpFrom = new System.Windows.Forms.DateTimePicker();
      this.txtTimKiem = new System.Windows.Forms.TextBox();
      this.lblMaNV = new System.Windows.Forms.Label();
      this.colMaBanGhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.btnTimKiem);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.dtpTo);
      this.groupBox1.Controls.Add(this.dgvLichLamViec);
      this.groupBox1.Controls.Add(this.dtpFrom);
      this.groupBox1.Controls.Add(this.txtTimKiem);
      this.groupBox1.Controls.Add(this.lblMaNV);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.groupBox1.Location = new System.Drawing.Point(23, 20);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(886, 491);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Xem lịch làm việc";
      // 
      // btnTimKiem
      // 
      this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnTimKiem.ForeColor = System.Drawing.Color.Green;
      this.btnTimKiem.Image = global::GUI.Properties.Resources.icons8_Search_35px;
      this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnTimKiem.Location = new System.Drawing.Point(649, 49);
      this.btnTimKiem.Name = "btnTimKiem";
      this.btnTimKiem.Size = new System.Drawing.Size(152, 54);
      this.btnTimKiem.TabIndex = 69;
      this.btnTimKiem.Text = "Xem";
      this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnTimKiem.UseVisualStyleBackColor = true;
      this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label2.Location = new System.Drawing.Point(404, 82);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(71, 17);
      this.label2.TabIndex = 16;
      this.label2.Text = "Tới ngày";
      // 
      // dtpTo
      // 
      this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpTo.Location = new System.Drawing.Point(492, 78);
      this.dtpTo.Name = "dtpTo";
      this.dtpTo.Size = new System.Drawing.Size(137, 23);
      this.dtpTo.TabIndex = 15;
      // 
      // dgvLichLamViec
      // 
      this.dgvLichLamViec.AllowUserToAddRows = false;
      this.dgvLichLamViec.AllowUserToDeleteRows = false;
      this.dgvLichLamViec.BackgroundColor = System.Drawing.Color.White;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvLichLamViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.dgvLichLamViec.ColumnHeadersHeight = 40;
      this.dgvLichLamViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBanGhi,
            this.colMaNV,
            this.colHoTen,
            this.colNgayLam,
            this.colCa,
            this.colTrangThai});
      this.dgvLichLamViec.EnableHeadersVisualStyles = false;
      this.dgvLichLamViec.Location = new System.Drawing.Point(7, 151);
      this.dgvLichLamViec.Name = "dgvLichLamViec";
      this.dgvLichLamViec.ReadOnly = true;
      this.dgvLichLamViec.RowHeadersVisible = false;
      this.dgvLichLamViec.RowTemplate.Height = 35;
      this.dgvLichLamViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvLichLamViec.Size = new System.Drawing.Size(871, 334);
      this.dgvLichLamViec.TabIndex = 14;
      this.dgvLichLamViec.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLichLamViec_CellFormatting);
      // 
      // dtpFrom
      // 
      this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFrom.Location = new System.Drawing.Point(236, 78);
      this.dtpFrom.Name = "dtpFrom";
      this.dtpFrom.Size = new System.Drawing.Size(137, 23);
      this.dtpFrom.TabIndex = 12;
      // 
      // txtTimKiem
      // 
      this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtTimKiem.Location = new System.Drawing.Point(236, 49);
      this.txtTimKiem.Name = "txtTimKiem";
      this.txtTimKiem.Size = new System.Drawing.Size(393, 23);
      this.txtTimKiem.TabIndex = 10;
      // 
      // lblMaNV
      // 
      this.lblMaNV.AutoSize = true;
      this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.lblMaNV.Location = new System.Drawing.Point(69, 52);
      this.lblMaNV.Name = "lblMaNV";
      this.lblMaNV.Size = new System.Drawing.Size(148, 17);
      this.lblMaNV.TabIndex = 9;
      this.lblMaNV.Text = "Nhập mã nhân viên";
      // 
      // colMaBanGhi
      // 
      this.colMaBanGhi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colMaBanGhi.DataPropertyName = "MaBanGhi";
      this.colMaBanGhi.HeaderText = "Mã bản ghi";
      this.colMaBanGhi.Name = "colMaBanGhi";
      this.colMaBanGhi.ReadOnly = true;
      this.colMaBanGhi.Visible = false;
      this.colMaBanGhi.Width = 104;
      // 
      // colMaNV
      // 
      this.colMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colMaNV.DataPropertyName = "MaNhanVien";
      this.colMaNV.HeaderText = "Mã NV";
      this.colMaNV.Name = "colMaNV";
      this.colMaNV.ReadOnly = true;
      this.colMaNV.Width = 55;
      // 
      // colHoTen
      // 
      this.colHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colHoTen.DataPropertyName = "MaNhanVien";
      this.colHoTen.HeaderText = "Họ tên";
      this.colHoTen.Name = "colHoTen";
      this.colHoTen.ReadOnly = true;
      // 
      // colNgayLam
      // 
      this.colNgayLam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colNgayLam.DataPropertyName = "NgayLamViec";
      this.colNgayLam.HeaderText = "Ngày làm";
      this.colNgayLam.Name = "colNgayLam";
      this.colNgayLam.ReadOnly = true;
      this.colNgayLam.Width = 92;
      // 
      // colCa
      // 
      this.colCa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colCa.DataPropertyName = "MaCaLamViec";
      this.colCa.HeaderText = "Ca";
      this.colCa.Name = "colCa";
      this.colCa.ReadOnly = true;
      this.colCa.Width = 52;
      // 
      // colTrangThai
      // 
      this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colTrangThai.DataPropertyName = "TrangThai";
      this.colTrangThai.HeaderText = "Trạng thái";
      this.colTrangThai.Name = "colTrangThai";
      this.colTrangThai.ReadOnly = true;
      this.colTrangThai.Width = 99;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label1.Location = new System.Drawing.Point(69, 83);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 17);
      this.label1.TabIndex = 70;
      this.label1.Text = "Từ ngày";
      // 
      // urcXemLichLamViec
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.MintCream;
      this.Controls.Add(this.groupBox1);
      this.Name = "urcXemLichLamViec";
      this.Size = new System.Drawing.Size(930, 530);
      this.Load += new System.EventHandler(this.urcXemLichLamViec_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker dtpTo;
    private System.Windows.Forms.DataGridView dgvLichLamViec;
    private System.Windows.Forms.DateTimePicker dtpFrom;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.Label lblMaNV;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaBanGhi;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
    private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLam;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCa;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    private System.Windows.Forms.Label label1;


  }
}
