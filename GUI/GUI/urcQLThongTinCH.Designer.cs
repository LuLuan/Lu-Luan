namespace GUI
{
    partial class urcQLThongTinCH
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
      this.pnlMenu = new System.Windows.Forms.Panel();
      this.btnHome = new System.Windows.Forms.Button();
      this.btnMoMenu = new System.Windows.Forms.Button();
      this.pnlTieuDe = new System.Windows.Forms.Panel();
      this.lblTieuDe = new System.Windows.Forms.Label();
      this.timerMenu = new System.Windows.Forms.Timer(this.components);
      this.pnlContainer = new System.Windows.Forms.Panel();
      this.pnlMenu.SuspendLayout();
      this.pnlTieuDe.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlMenu
      // 
      this.pnlMenu.BackColor = System.Drawing.Color.Black;
      this.pnlMenu.Controls.Add(this.btnHome);
      this.pnlMenu.Controls.Add(this.btnMoMenu);
      this.pnlMenu.Location = new System.Drawing.Point(930, 0);
      this.pnlMenu.Name = "pnlMenu";
      this.pnlMenu.Size = new System.Drawing.Size(40, 570);
      this.pnlMenu.TabIndex = 0;
      // 
      // btnHome
      // 
      this.btnHome.BackgroundImage = global::GUI.Properties.Resources.Home_96px;
      this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnHome.FlatAppearance.BorderSize = 0;
      this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnHome.Location = new System.Drawing.Point(0, 0);
      this.btnHome.Name = "btnHome";
      this.btnHome.Size = new System.Drawing.Size(40, 40);
      this.btnHome.TabIndex = 6;
      this.btnHome.UseVisualStyleBackColor = true;
      this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
      // 
      // btnMoMenu
      // 
      this.btnMoMenu.BackgroundImage = global::GUI.Properties.Resources.more_20px;
      this.btnMoMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnMoMenu.FlatAppearance.BorderSize = 0;
      this.btnMoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMoMenu.Location = new System.Drawing.Point(10, 50);
      this.btnMoMenu.Name = "btnMoMenu";
      this.btnMoMenu.Size = new System.Drawing.Size(20, 20);
      this.btnMoMenu.TabIndex = 5;
      this.btnMoMenu.UseVisualStyleBackColor = true;
      this.btnMoMenu.Click += new System.EventHandler(this.btnMoMenu_Click);
      // 
      // pnlTieuDe
      // 
      this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
      this.pnlTieuDe.Controls.Add(this.lblTieuDe);
      this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
      this.pnlTieuDe.Name = "pnlTieuDe";
      this.pnlTieuDe.Size = new System.Drawing.Size(930, 40);
      this.pnlTieuDe.TabIndex = 1;
      // 
      // lblTieuDe
      // 
      this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.lblTieuDe.ForeColor = System.Drawing.Color.White;
      this.lblTieuDe.Location = new System.Drawing.Point(125, 0);
      this.lblTieuDe.Name = "lblTieuDe";
      this.lblTieuDe.Size = new System.Drawing.Size(663, 40);
      this.lblTieuDe.TabIndex = 0;
      this.lblTieuDe.Text = "QUẢN LÝ THÔNG TIN CỬA HÀNG";
      this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // timerMenu
      // 
      this.timerMenu.Interval = 1;
      this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
      // 
      // pnlContainer
      // 
      this.pnlContainer.BackColor = System.Drawing.Color.MintCream;
      this.pnlContainer.Location = new System.Drawing.Point(0, 40);
      this.pnlContainer.Name = "pnlContainer";
      this.pnlContainer.Size = new System.Drawing.Size(930, 530);
      this.pnlContainer.TabIndex = 2;
      // 
      // urcQLThongTinCH
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.pnlMenu);
      this.Controls.Add(this.pnlContainer);
      this.Controls.Add(this.pnlTieuDe);
      this.Name = "urcQLThongTinCH";
      this.Size = new System.Drawing.Size(970, 570);
      this.Load += new System.EventHandler(this.urcQLNhanVien_Load);
      this.pnlMenu.ResumeLayout(false);
      this.pnlTieuDe.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnMoMenu;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnHome;
        //private urcDSNhanVien urcDSNhanVien;
    }
}
