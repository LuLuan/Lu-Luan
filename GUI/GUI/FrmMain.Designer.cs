namespace GUI
{
    partial class FrmMain
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnThoatUngDung = new System.Windows.Forms.PictureBox();
            this.btnClickToLogin = new System.Windows.Forms.Button();
            this.pnlMiniMenu = new System.Windows.Forms.Panel();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.pnlThongTinTop = new System.Windows.Forms.Panel();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.picAnhNhanVien = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemMnMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMnSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMnLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlChuaMenuDong = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoatUngDung)).BeginInit();
            this.pnlMiniMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.pnlThongTinTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNhanVien)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Black;
            this.pnlMenu.Controls.Add(this.btnThoatUngDung);
            this.pnlMenu.Controls.Add(this.btnClickToLogin);
            this.pnlMenu.Controls.Add(this.pnlMiniMenu);
            this.pnlMenu.Controls.Add(this.pnlThongTinTop);
            this.pnlMenu.Controls.Add(this.pnlChuaMenuDong);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(970, 570);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnThoatUngDung
            // 
            this.btnThoatUngDung.BackgroundImage = global::GUI.Properties.Resources.Delete_50pxtrongtrongrong;
            this.btnThoatUngDung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoatUngDung.Location = new System.Drawing.Point(3, 76);
            this.btnThoatUngDung.Name = "btnThoatUngDung";
            this.btnThoatUngDung.Size = new System.Drawing.Size(37, 37);
            this.btnThoatUngDung.TabIndex = 5;
            this.btnThoatUngDung.TabStop = false;
            this.btnThoatUngDung.Visible = false;
            this.btnThoatUngDung.Click += new System.EventHandler(this.btnThoatUngDung_Click);
            // 
            // btnClickToLogin
            // 
            this.btnClickToLogin.BackColor = System.Drawing.Color.Black;
            this.btnClickToLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnClickToLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnClickToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClickToLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClickToLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClickToLogin.Image = global::GUI.Properties.Resources.Click;
            this.btnClickToLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClickToLogin.Location = new System.Drawing.Point(151, 198);
            this.btnClickToLogin.Name = "btnClickToLogin";
            this.btnClickToLogin.Size = new System.Drawing.Size(691, 120);
            this.btnClickToLogin.TabIndex = 1;
            this.btnClickToLogin.Text = "Nhấn để đăng nhập";
            this.btnClickToLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClickToLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClickToLogin.UseVisualStyleBackColor = false;
            this.btnClickToLogin.Click += new System.EventHandler(this.btnClickToLogin_Click);
            this.btnClickToLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnClickToLogin_KeyUp);
            // 
            // pnlMiniMenu
            // 
            this.pnlMiniMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMiniMenu.Controls.Add(this.picHome);
            this.pnlMiniMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMiniMenu.Name = "pnlMiniMenu";
            this.pnlMiniMenu.Size = new System.Drawing.Size(74, 74);
            this.pnlMiniMenu.TabIndex = 4;
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.Color.DarkMagenta;
            this.picHome.BackgroundImage = global::GUI.Properties.Resources.Home_96px;
            this.picHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picHome.Location = new System.Drawing.Point(1, 0);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(74, 74);
            this.picHome.TabIndex = 1;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // pnlThongTinTop
            // 
            this.pnlThongTinTop.BackColor = System.Drawing.Color.BlueViolet;
            this.pnlThongTinTop.Controls.Add(this.lbTenNhanVien);
            this.pnlThongTinTop.Controls.Add(this.picAnhNhanVien);
            this.pnlThongTinTop.Controls.Add(this.menuStrip1);
            this.pnlThongTinTop.Location = new System.Drawing.Point(75, 0);
            this.pnlThongTinTop.Name = "pnlThongTinTop";
            this.pnlThongTinTop.Size = new System.Drawing.Size(895, 74);
            this.pnlThongTinTop.TabIndex = 3;
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenNhanVien.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lbTenNhanVien.Location = new System.Drawing.Point(656, 45);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(168, 25);
            this.lbTenNhanVien.TabIndex = 3;
            this.lbTenNhanVien.Text = "Nguyễn Văn ABC";
            // 
            // picAnhNhanVien
            // 
            this.picAnhNhanVien.BackColor = System.Drawing.Color.BlueViolet;
            this.picAnhNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAnhNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhNhanVien.Location = new System.Drawing.Point(591, 11);
            this.picAnhNhanVien.Name = "picAnhNhanVien";
            this.picAnhNhanVien.Size = new System.Drawing.Size(59, 59);
            this.picAnhNhanVien.TabIndex = 2;
            this.picAnhNhanVien.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMnMinimize,
            this.itemMnSetting,
            this.itemMnClose});
            this.menuStrip1.Location = new System.Drawing.Point(834, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(60, 20);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemMnMinimize
            // 
            this.itemMnMinimize.AutoSize = false;
            this.itemMnMinimize.BackgroundImage = global::GUI.Properties.Resources.Subtract_50px;
            this.itemMnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.itemMnMinimize.Name = "itemMnMinimize";
            this.itemMnMinimize.Padding = new System.Windows.Forms.Padding(0);
            this.itemMnMinimize.Size = new System.Drawing.Size(20, 20);
            this.itemMnMinimize.Click += new System.EventHandler(this.itemMnMinimize_Click);
            // 
            // itemMnSetting
            // 
            this.itemMnSetting.AutoSize = false;
            this.itemMnSetting.BackgroundImage = global::GUI.Properties.Resources.Settings_32pxW;
            this.itemMnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.itemMnSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMnLogOut});
            this.itemMnSetting.Name = "itemMnSetting";
            this.itemMnSetting.Padding = new System.Windows.Forms.Padding(0);
            this.itemMnSetting.Size = new System.Drawing.Size(20, 20);
            // 
            // itemMnLogOut
            // 
            this.itemMnLogOut.Name = "itemMnLogOut";
            this.itemMnLogOut.Size = new System.Drawing.Size(105, 22);
            this.itemMnLogOut.Text = "Thoát";
            this.itemMnLogOut.Click += new System.EventHandler(this.itemMnLogOut_Click);
            // 
            // itemMnClose
            // 
            this.itemMnClose.AutoSize = false;
            this.itemMnClose.BackgroundImage = global::GUI.Properties.Resources.Delete_50pxtrongtrongrong;
            this.itemMnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.itemMnClose.Name = "itemMnClose";
            this.itemMnClose.Size = new System.Drawing.Size(20, 20);
            this.itemMnClose.Click += new System.EventHandler(this.itemMnClose_Click);
            // 
            // pnlChuaMenuDong
            // 
            this.pnlChuaMenuDong.AutoScroll = true;
            this.pnlChuaMenuDong.BackColor = System.Drawing.Color.White;
            this.pnlChuaMenuDong.Location = new System.Drawing.Point(909, 76);
            this.pnlChuaMenuDong.Name = "pnlChuaMenuDong";
            this.pnlChuaMenuDong.Size = new System.Drawing.Size(60, 494);
            this.pnlChuaMenuDong.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(970, 570);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnThoatUngDung)).EndInit();
            this.pnlMiniMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.pnlThongTinTop.ResumeLayout(false);
            this.pnlThongTinTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNhanVien)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Panel pnlThongTinTop;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.PictureBox picAnhNhanVien;
        private System.Windows.Forms.Panel pnlMiniMenu;
        private System.Windows.Forms.Button btnClickToLogin;
        private System.Windows.Forms.Panel pnlChuaMenuDong;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemMnMinimize;
        private System.Windows.Forms.ToolStripMenuItem itemMnSetting;
        private System.Windows.Forms.ToolStripMenuItem itemMnLogOut;
        private System.Windows.Forms.ToolStripMenuItem itemMnClose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox btnThoatUngDung;
    }
}

