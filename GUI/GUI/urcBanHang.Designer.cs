namespace GUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTimNL = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lswThucUong = new System.Windows.Forms.ListView();
            this.ilsLon = new System.Windows.Forms.ImageList(this.components);
            this.ilsNho = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grbViewStyle = new System.Windows.Forms.GroupBox();
            this.rdbList = new System.Windows.Forms.RadioButton();
            this.rdbTile = new System.Windows.Forms.RadioButton();
            this.rdbSmallIcon = new System.Windows.Forms.RadioButton();
            this.rdbDetails = new System.Windows.Forms.RadioButton();
            this.rdbLargeIcon = new System.Windows.Forms.RadioButton();
            this.colMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grbViewStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 530);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(141, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 48);
            this.button4.TabIndex = 6;
            this.button4.Text = "Trả sản phẩm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(-1, 389);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 48);
            this.button5.TabIndex = 5;
            this.button5.Text = "Thanh toán";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(69, 389);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 48);
            this.button6.TabIndex = 4;
            this.button6.Text = "Xuất hóa đơn";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 443);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 64);
            this.button3.TabIndex = 3;
            this.button3.Text = "Hủy bỏ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-1, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 64);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMon,
            this.colTenMon,
            this.colSoLuong,
            this.colDonGia});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(190, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.grbViewStyle);
            this.panel2.Controls.Add(this.lbTimNL);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(196, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 530);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbTimNL
            // 
            this.lbTimNL.AutoSize = true;
            this.lbTimNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTimNL.ForeColor = System.Drawing.Color.Black;
            this.lbTimNL.Location = new System.Drawing.Point(53, 31);
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
            this.txtTimKiem.Location = new System.Drawing.Point(164, 25);
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
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 50);
            this.tabControl1.Location = new System.Drawing.Point(3, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 437);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lswThucUong);
            this.tabPage1.ForeColor = System.Drawing.Color.Green;
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(720, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "THỨC UỐNG";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lswThucUong
            // 
            this.lswThucUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lswThucUong.LargeImageList = this.ilsLon;
            this.lswThucUong.Location = new System.Drawing.Point(-4, 0);
            this.lswThucUong.MultiSelect = false;
            this.lswThucUong.Name = "lswThucUong";
            this.lswThucUong.Size = new System.Drawing.Size(724, 380);
            this.lswThucUong.SmallImageList = this.ilsNho;
            this.lswThucUong.TabIndex = 0;
            this.lswThucUong.UseCompatibleStateImageBehavior = false;
            // 
            // ilsLon
            // 
            this.ilsLon.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilsLon.ImageSize = new System.Drawing.Size(70, 70);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(628, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TOPPING";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 54);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(628, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MÓN ĂN";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grbViewStyle
            // 
            this.grbViewStyle.Controls.Add(this.rdbList);
            this.grbViewStyle.Controls.Add(this.rdbTile);
            this.grbViewStyle.Controls.Add(this.rdbSmallIcon);
            this.grbViewStyle.Controls.Add(this.rdbDetails);
            this.grbViewStyle.Controls.Add(this.rdbLargeIcon);
            this.grbViewStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbViewStyle.ForeColor = System.Drawing.Color.Maroon;
            this.grbViewStyle.Location = new System.Drawing.Point(612, 3);
            this.grbViewStyle.Name = "grbViewStyle";
            this.grbViewStyle.Size = new System.Drawing.Size(119, 138);
            this.grbViewStyle.TabIndex = 53;
            this.grbViewStyle.TabStop = false;
            this.grbViewStyle.Text = "View Style";
            // 
            // rdbList
            // 
            this.rdbList.AutoSize = true;
            this.rdbList.Location = new System.Drawing.Point(17, 88);
            this.rdbList.Name = "rdbList";
            this.rdbList.Size = new System.Drawing.Size(52, 24);
            this.rdbList.TabIndex = 11;
            this.rdbList.TabStop = true;
            this.rdbList.Text = "List";
            this.rdbList.UseVisualStyleBackColor = true;
            this.rdbList.CheckedChanged += new System.EventHandler(this.rdbList_CheckedChanged);
            // 
            // rdbTile
            // 
            this.rdbTile.AutoSize = true;
            this.rdbTile.Location = new System.Drawing.Point(17, 106);
            this.rdbTile.Name = "rdbTile";
            this.rdbTile.Size = new System.Drawing.Size(51, 24);
            this.rdbTile.TabIndex = 10;
            this.rdbTile.TabStop = true;
            this.rdbTile.Text = "Tile";
            this.rdbTile.UseVisualStyleBackColor = true;
            this.rdbTile.CheckedChanged += new System.EventHandler(this.rdbTile_CheckedChanged);
            // 
            // rdbSmallIcon
            // 
            this.rdbSmallIcon.AutoSize = true;
            this.rdbSmallIcon.Location = new System.Drawing.Point(17, 69);
            this.rdbSmallIcon.Name = "rdbSmallIcon";
            this.rdbSmallIcon.Size = new System.Drawing.Size(99, 24);
            this.rdbSmallIcon.TabIndex = 9;
            this.rdbSmallIcon.TabStop = true;
            this.rdbSmallIcon.Text = "Small icon";
            this.rdbSmallIcon.UseVisualStyleBackColor = true;
            this.rdbSmallIcon.CheckedChanged += new System.EventHandler(this.rdbSmallIcon_CheckedChanged);
            // 
            // rdbDetails
            // 
            this.rdbDetails.AutoSize = true;
            this.rdbDetails.Location = new System.Drawing.Point(17, 47);
            this.rdbDetails.Name = "rdbDetails";
            this.rdbDetails.Size = new System.Drawing.Size(76, 24);
            this.rdbDetails.TabIndex = 8;
            this.rdbDetails.TabStop = true;
            this.rdbDetails.Text = "Details";
            this.rdbDetails.UseVisualStyleBackColor = true;
            this.rdbDetails.CheckedChanged += new System.EventHandler(this.rdbDetails_CheckedChanged);
            // 
            // rdbLargeIcon
            // 
            this.rdbLargeIcon.AutoSize = true;
            this.rdbLargeIcon.Location = new System.Drawing.Point(17, 25);
            this.rdbLargeIcon.Name = "rdbLargeIcon";
            this.rdbLargeIcon.Size = new System.Drawing.Size(101, 24);
            this.rdbLargeIcon.TabIndex = 7;
            this.rdbLargeIcon.TabStop = true;
            this.rdbLargeIcon.Text = "Large icon";
            this.rdbLargeIcon.UseVisualStyleBackColor = true;
            this.rdbLargeIcon.CheckedChanged += new System.EventHandler(this.rdbLargeIcon_CheckedChanged);
            // 
            // colMaMon
            // 
            this.colMaMon.HeaderText = "Mã Món";
            this.colMaMon.Name = "colMaMon";
            this.colMaMon.Width = 30;
            // 
            // colTenMon
            // 
            this.colTenMon.HeaderText = "Tên Món";
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.Width = 77;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "SL";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 30;
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn Giá";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Width = 50;
            // 
            // urcBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "urcBanHang";
            this.Size = new System.Drawing.Size(930, 530);
            this.Load += new System.EventHandler(this.urcBanHang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grbViewStyle.ResumeLayout(false);
            this.grbViewStyle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbTimNL;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ListView lswThucUong;
        private System.Windows.Forms.ImageList ilsNho;
        private System.Windows.Forms.ImageList ilsLon;
        private System.Windows.Forms.GroupBox grbViewStyle;
        private System.Windows.Forms.RadioButton rdbList;
        private System.Windows.Forms.RadioButton rdbTile;
        private System.Windows.Forms.RadioButton rdbSmallIcon;
        private System.Windows.Forms.RadioButton rdbDetails;
        private System.Windows.Forms.RadioButton rdbLargeIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
    }
}
