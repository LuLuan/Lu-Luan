﻿namespace GUI
{
    partial class urcBanHang
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Mã Món Ăn");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Mã Loại Món Ăn");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Đơn Vị Tính");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlright = new System.Windows.Forms.Panel();
            this.grbThongTinThemMonAnVaoHoaDon = new System.Windows.Forms.GroupBox();
            this.picAnhMonAn = new System.Windows.Forms.PictureBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbKichThuocMonAn = new System.Windows.Forms.ComboBox();
            this.txtThemSanPham = new System.Windows.Forms.Button();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbViewStyle = new System.Windows.Forms.GroupBox();
            this.rdbTile = new System.Windows.Forms.RadioButton();
            this.rdbDetails = new System.Windows.Forms.RadioButton();
            this.rdbLargeIcon = new System.Windows.Forms.RadioButton();
            this.lbTimNL = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lswThucUong = new System.Windows.Forms.ListView();
            this.colMaMonAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaLoaiMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonViTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilsLon = new System.Windows.Forms.ImageList(this.components);
            this.ilsNho = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbChuNangThanhToan = new System.Windows.Forms.GroupBox();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnTraSP = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.colMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTongTienHide = new System.Windows.Forms.Label();
            this.pnlright.SuspendLayout();
            this.grbThongTinThemMonAnVaoHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhMonAn)).BeginInit();
            this.grbViewStyle.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbChuNangThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlright
            // 
            this.pnlright.BackColor = System.Drawing.Color.MintCream;
            this.pnlright.Controls.Add(this.lblTongTienHide);
            this.pnlright.Controls.Add(this.grbThongTinThemMonAnVaoHoaDon);
            this.pnlright.Controls.Add(this.grbViewStyle);
            this.pnlright.Controls.Add(this.lbTimNL);
            this.pnlright.Controls.Add(this.txtTimKiem);
            this.pnlright.Controls.Add(this.tabControl1);
            this.pnlright.Location = new System.Drawing.Point(274, 0);
            this.pnlright.Name = "pnlright";
            this.pnlright.Size = new System.Drawing.Size(654, 530);
            this.pnlright.TabIndex = 1;
            this.pnlright.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // grbThongTinThemMonAnVaoHoaDon
            // 
            this.grbThongTinThemMonAnVaoHoaDon.Controls.Add(this.picAnhMonAn);
            this.grbThongTinThemMonAnVaoHoaDon.Controls.Add(this.txtGia);
            this.grbThongTinThemMonAnVaoHoaDon.Controls.Add(this.label4);
            this.grbThongTinThemMonAnVaoHoaDon.Controls.Add(this.txtSoLuong);
            this.grbThongTinThemMonAnVaoHoaDon.Controls.Add(this.label3);
            this.grbThongTinThemMonAnVaoHoaDon.Controls.Add(this.label2);
            this.grbThongTinThemMonAnVaoHoaDon.Controls.Add(this.cbbKichThuocMonAn);
            this.grbThongTinThemMonAnVaoHoaDon.Controls.Add(this.txtThemSanPham);
            this.grbThongTinThemMonAnVaoHoaDon.Controls.Add(this.txtTenMon);
            this.grbThongTinThemMonAnVaoHoaDon.Controls.Add(this.label1);
            this.grbThongTinThemMonAnVaoHoaDon.Location = new System.Drawing.Point(7, 67);
            this.grbThongTinThemMonAnVaoHoaDon.Name = "grbThongTinThemMonAnVaoHoaDon";
            this.grbThongTinThemMonAnVaoHoaDon.Size = new System.Drawing.Size(642, 100);
            this.grbThongTinThemMonAnVaoHoaDon.TabIndex = 54;
            this.grbThongTinThemMonAnVaoHoaDon.TabStop = false;
            // 
            // picAnhMonAn
            // 
            this.picAnhMonAn.Location = new System.Drawing.Point(2, 8);
            this.picAnhMonAn.Name = "picAnhMonAn";
            this.picAnhMonAn.Size = new System.Drawing.Size(89, 89);
            this.picAnhMonAn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhMonAn.TabIndex = 72;
            this.picAnhMonAn.TabStop = false;
            // 
            // txtGia
            // 
            this.txtGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGia.Enabled = false;
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGia.Location = new System.Drawing.Point(146, 57);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(207, 30);
            this.txtGia.TabIndex = 71;
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(90, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 70;
            this.label4.Text = "Giá";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLuong.Location = new System.Drawing.Point(463, 19);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(72, 30);
            this.txtSoLuong.TabIndex = 69;
            this.txtSoLuong.Text = "1";
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(359, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 68;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(359, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 67;
            this.label2.Text = "Kích Cỡ";
            // 
            // cbbKichThuocMonAn
            // 
            this.cbbKichThuocMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKichThuocMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbKichThuocMonAn.FormattingEnabled = true;
            this.cbbKichThuocMonAn.Location = new System.Drawing.Point(463, 58);
            this.cbbKichThuocMonAn.Name = "cbbKichThuocMonAn";
            this.cbbKichThuocMonAn.Size = new System.Drawing.Size(72, 33);
            this.cbbKichThuocMonAn.TabIndex = 66;
            this.cbbKichThuocMonAn.SelectionChangeCommitted += new System.EventHandler(this.cbbKichThuocMonAn_SelectionChangeCommitted);
            // 
            // txtThemSanPham
            // 
            this.txtThemSanPham.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtThemSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtThemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtThemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThemSanPham.Location = new System.Drawing.Point(551, 19);
            this.txtThemSanPham.Name = "txtThemSanPham";
            this.txtThemSanPham.Size = new System.Drawing.Size(85, 68);
            this.txtThemSanPham.TabIndex = 65;
            this.txtThemSanPham.Text = "Thêm";
            this.txtThemSanPham.UseVisualStyleBackColor = false;
            this.txtThemSanPham.Click += new System.EventHandler(this.txtThemSanPham_Click);
            // 
            // txtTenMon
            // 
            this.txtTenMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenMon.Enabled = false;
            this.txtTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenMon.Location = new System.Drawing.Point(146, 19);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(207, 30);
            this.txtTenMon.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(90, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "Tên";
            // 
            // grbViewStyle
            // 
            this.grbViewStyle.Controls.Add(this.rdbTile);
            this.grbViewStyle.Controls.Add(this.rdbDetails);
            this.grbViewStyle.Controls.Add(this.rdbLargeIcon);
            this.grbViewStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbViewStyle.ForeColor = System.Drawing.Color.Maroon;
            this.grbViewStyle.Location = new System.Drawing.Point(411, 172);
            this.grbViewStyle.Name = "grbViewStyle";
            this.grbViewStyle.Size = new System.Drawing.Size(236, 67);
            this.grbViewStyle.TabIndex = 53;
            this.grbViewStyle.TabStop = false;
            this.grbViewStyle.Text = "Kiểu  nhìn";
            // 
            // rdbTile
            // 
            this.rdbTile.AutoSize = true;
            this.rdbTile.Location = new System.Drawing.Point(16, 37);
            this.rdbTile.Name = "rdbTile";
            this.rdbTile.Size = new System.Drawing.Size(104, 24);
            this.rdbTile.TabIndex = 10;
            this.rdbTile.Text = "Danh sách";
            this.rdbTile.UseVisualStyleBackColor = true;
            this.rdbTile.CheckedChanged += new System.EventHandler(this.rdbTile_CheckedChanged);
            // 
            // rdbDetails
            // 
            this.rdbDetails.AutoSize = true;
            this.rdbDetails.Location = new System.Drawing.Point(123, 16);
            this.rdbDetails.Name = "rdbDetails";
            this.rdbDetails.Size = new System.Drawing.Size(76, 24);
            this.rdbDetails.TabIndex = 8;
            this.rdbDetails.Text = "Chi tiết";
            this.rdbDetails.UseVisualStyleBackColor = true;
            this.rdbDetails.CheckedChanged += new System.EventHandler(this.rdbDetails_CheckedChanged);
            // 
            // rdbLargeIcon
            // 
            this.rdbLargeIcon.AutoSize = true;
            this.rdbLargeIcon.Checked = true;
            this.rdbLargeIcon.Location = new System.Drawing.Point(16, 16);
            this.rdbLargeIcon.Name = "rdbLargeIcon";
            this.rdbLargeIcon.Size = new System.Drawing.Size(57, 24);
            this.rdbLargeIcon.TabIndex = 7;
            this.rdbLargeIcon.TabStop = true;
            this.rdbLargeIcon.Text = "Lưới";
            this.rdbLargeIcon.UseVisualStyleBackColor = true;
            this.rdbLargeIcon.CheckedChanged += new System.EventHandler(this.rdbLargeIcon_CheckedChanged);
            // 
            // lbTimNL
            // 
            this.lbTimNL.AutoSize = true;
            this.lbTimNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTimNL.ForeColor = System.Drawing.Color.Black;
            this.lbTimNL.Location = new System.Drawing.Point(104, 23);
            this.lbTimNL.Name = "lbTimNL";
            this.lbTimNL.Size = new System.Drawing.Size(72, 29);
            this.lbTimNL.TabIndex = 52;
            this.lbTimNL.Text = "Tìm :";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Blue;
            this.txtTimKiem.Location = new System.Drawing.Point(212, 21);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(288, 40);
            this.txtTimKiem.TabIndex = 51;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.ImageList = this.ilsNho;
            this.tabControl1.ItemSize = new System.Drawing.Size(130, 70);
            this.tabControl1.Location = new System.Drawing.Point(7, 173);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 354);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lswThucUong);
            this.tabPage1.ForeColor = System.Drawing.Color.Green;
            this.tabPage1.Location = new System.Drawing.Point(4, 74);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "THỨC UỐNG";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lswThucUong
            // 
            this.lswThucUong.BackColor = System.Drawing.Color.White;
            this.lswThucUong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lswThucUong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaMonAn,
            this.colMaLoaiMon,
            this.colDonViTinh});
            this.lswThucUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lswThucUong.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lswThucUong.LargeImageList = this.ilsLon;
            this.lswThucUong.Location = new System.Drawing.Point(-4, -2);
            this.lswThucUong.MultiSelect = false;
            this.lswThucUong.Name = "lswThucUong";
            this.lswThucUong.Size = new System.Drawing.Size(642, 280);
            this.lswThucUong.SmallImageList = this.ilsNho;
            this.lswThucUong.TabIndex = 0;
            this.lswThucUong.UseCompatibleStateImageBehavior = false;
            this.lswThucUong.SelectedIndexChanged += new System.EventHandler(this.lswThucUong_SelectedIndexChanged);
            // 
            // colMaMonAn
            // 
            this.colMaMonAn.Text = "Mã Món Ăn";
            this.colMaMonAn.Width = 150;
            // 
            // colMaLoaiMon
            // 
            this.colMaLoaiMon.Text = "Mã Loại Món";
            this.colMaLoaiMon.Width = 150;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.Text = "Đơn Vị Tính";
            this.colDonViTinh.Width = 150;
            // 
            // ilsLon
            // 
            this.ilsLon.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilsLon.ImageSize = new System.Drawing.Size(80, 110);
            this.ilsLon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilsNho
            // 
            this.ilsNho.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.ilsNho.ImageSize = new System.Drawing.Size(32, 48);
            this.ilsNho.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 74);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TOPPING";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 74);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(636, 276);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MÓN ĂN";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.grbChuNangThanhToan);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.lblTongTien);
            this.panel1.Controls.Add(this.dgvGioHang);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 530);
            this.panel1.TabIndex = 2;
            // 
            // grbChuNangThanhToan
            // 
            this.grbChuNangThanhToan.Controls.Add(this.btnHuyBo);
            this.grbChuNangThanhToan.Controls.Add(this.btnTraSP);
            this.grbChuNangThanhToan.Controls.Add(this.btnThanhToan);
            this.grbChuNangThanhToan.Location = new System.Drawing.Point(1, 391);
            this.grbChuNangThanhToan.Name = "grbChuNangThanhToan";
            this.grbChuNangThanhToan.Size = new System.Drawing.Size(278, 140);
            this.grbChuNangThanhToan.TabIndex = 76;
            this.grbChuNangThanhToan.TabStop = false;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.Color.White;
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyBo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHuyBo.Image = global::GUI.Properties.Resources.icons8_Clear_Shopping_Cart_25px;
            this.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyBo.Location = new System.Drawing.Point(6, 97);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(265, 38);
            this.btnHuyBo.TabIndex = 78;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click_1);
            // 
            // btnTraSP
            // 
            this.btnTraSP.BackColor = System.Drawing.Color.White;
            this.btnTraSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTraSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTraSP.Image = global::GUI.Properties.Resources.icons8_Return_Purchase_25px_1;
            this.btnTraSP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTraSP.Location = new System.Drawing.Point(6, 53);
            this.btnTraSP.Name = "btnTraSP";
            this.btnTraSP.Size = new System.Drawing.Size(265, 38);
            this.btnTraSP.TabIndex = 77;
            this.btnTraSP.Text = "Trả sản phẩm";
            this.btnTraSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraSP.UseVisualStyleBackColor = false;
            this.btnTraSP.Click += new System.EventHandler(this.btnTraSP_Click_1);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.White;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThanhToan.Image = global::GUI.Properties.Resources.icons8_Paycheque_25px;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.Location = new System.Drawing.Point(6, 10);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(265, 38);
            this.btnThanhToan.TabIndex = 76;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click_1);
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.Location = new System.Drawing.Point(117, 361);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(155, 30);
            this.txtTongTien.TabIndex = 72;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Black;
            this.lblTongTien.Location = new System.Drawing.Point(3, 366);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(110, 25);
            this.lblTongTien.TabIndex = 55;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowDrop = true;
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGioHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMon,
            this.colTenMon,
            this.colSL,
            this.colGia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGioHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGioHang.EnableHeadersVisualStyles = false;
            this.dgvGioHang.Location = new System.Drawing.Point(3, 3);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersVisible = false;
            this.dgvGioHang.RowHeadersWidth = 60;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGioHang.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(274, 355);
            this.dgvGioHang.TabIndex = 7;
            // 
            // colMaMon
            // 
            this.colMaMon.DataPropertyName = "colMaMon";
            this.colMaMon.HeaderText = "Mã Món";
            this.colMaMon.Name = "colMaMon";
            this.colMaMon.Width = 50;
            // 
            // colTenMon
            // 
            this.colTenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenMon.DataPropertyName = "colTenMon";
            this.colTenMon.HeaderText = "Tên Món";
            this.colTenMon.Name = "colTenMon";
            // 
            // colSL
            // 
            this.colSL.DataPropertyName = "colSL";
            this.colSL.HeaderText = "SL";
            this.colSL.Name = "colSL";
            this.colSL.Width = 35;
            // 
            // colGia
            // 
            this.colGia.DataPropertyName = "colGia";
            this.colGia.HeaderText = "Giá";
            this.colGia.Name = "colGia";
            this.colGia.Width = 50;
            // 
            // lblTongTienHide
            // 
            this.lblTongTienHide.AutoSize = true;
            this.lblTongTienHide.ForeColor = System.Drawing.Color.MintCream;
            this.lblTongTienHide.Location = new System.Drawing.Point(11, 3);
            this.lblTongTienHide.Name = "lblTongTienHide";
            this.lblTongTienHide.Size = new System.Drawing.Size(0, 13);
            this.lblTongTienHide.TabIndex = 55;
            // 
            // urcBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlright);
            this.Name = "urcBanHang";
            this.Size = new System.Drawing.Size(930, 530);
            this.Load += new System.EventHandler(this.urcBanHang_Load);
            this.pnlright.ResumeLayout(false);
            this.pnlright.PerformLayout();
            this.grbThongTinThemMonAnVaoHoaDon.ResumeLayout(false);
            this.grbThongTinThemMonAnVaoHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhMonAn)).EndInit();
            this.grbViewStyle.ResumeLayout(false);
            this.grbViewStyle.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbChuNangThanhToan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlright;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbTimNL;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ListView lswThucUong;
        private System.Windows.Forms.ImageList ilsNho;
        private System.Windows.Forms.ImageList ilsLon;
        private System.Windows.Forms.GroupBox grbViewStyle;
        private System.Windows.Forms.RadioButton rdbTile;
        private System.Windows.Forms.RadioButton rdbDetails;
        private System.Windows.Forms.RadioButton rdbLargeIcon;
        private System.Windows.Forms.ColumnHeader colMaMonAn;
        private System.Windows.Forms.ColumnHeader colMaLoaiMon;
        private System.Windows.Forms.ColumnHeader colDonViTinh;
        private System.Windows.Forms.GroupBox grbThongTinThemMonAnVaoHoaDon;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbKichThuocMonAn;
        private System.Windows.Forms.Button txtThemSanPham;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.PictureBox picAnhMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.GroupBox grbChuNangThanhToan;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnTraSP;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTongTienHide;
    }
}